using QualitasDigitalSeleniumCSharp.src.TestData;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;

namespace QualitasDigitalSeleniumCSharp.Extensions
{
    /// <summary>
    /// Test Logging class for test run data, and failure details
    /// </summary>
    public static class Logging
    {
        /// <summary>
        /// 
        /// </summary>
        public static string FailureReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public static string FailureScreenshotPath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public static int TestRunId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public static DateTime TestStartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public static DateTime TestEndTime { get; set; }
        private static bool TestRunFailed { get; set; }
        private static List<EventLogEntry> InformationEventLogs { get; set; }
        private static List<EventLogEntry> WarningEventLogs { get; set; }
        private static List<EventLogEntry> ErrorEventLogs { get; set; }
        private static List<EventLogEntry> CriticalEventLogs { get; set; }

        /// <summary>
        /// Retrieves the failure screenshot path
        /// </summary>
        public static string GetFailureScreenshotPath()
        {
            return File.Exists(FailureScreenshotPath) ? FailureScreenshotPath : string.Empty;
        }

        /// <summary>
        /// Retrieves the event logs for the current test
        /// </summary>
        public static void PopulateEventLoggingContent()
        {
            InformationEventLogs = EventLogger.GetEventLog(EventType.Information, TestStartTime, TestEndTime);
            WarningEventLogs = EventLogger.GetEventLog(EventType.Warning, TestStartTime, TestEndTime);
            ErrorEventLogs = EventLogger.GetEventLog(EventType.Error, TestStartTime, TestEndTime);
            CriticalEventLogs = EventLogger.GetEventLog(EventType.Critical, TestStartTime, TestEndTime);
        }

        /// <summary>
        /// Generates the html report for the current test
        /// </summary>
        public static void GenerateHtmlReport()
        {
            string binPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string sourceTestResultPath = $"{binPath}\\src\\Web";
            string destinationTestResultPath = $"{Globals.TestResultsPath}\\{TestRunId}\\TestResult";

            //Copy Web folder from bin to test results folder
            DirectoryCopy(sourceTestResultPath, destinationTestResultPath, true);

            //Update the data in the javascript files
            string eventLogViewerJsPath = $"{destinationTestResultPath}\\js\\EventLogViewer.js";
            string testResultReportJsPath = $"{destinationTestResultPath}\\js\\TestResultReport.js";
            ReplaceFileContent(eventLogViewerJsPath, @"/*DataHere*/", GenerateJavascriptDataForEventLog());
            ReplaceFileContent(testResultReportJsPath, @"/*DataHere*/", GenerateJavascriptDataForTestResultReport(TestStepLog.TestSteps));

            //replace the test variable for test steps
            string originalTestStepsVariable = @"addDataToTbody(testStepsTableBody, testStepsDataTest);";
            string updatedTestStepsVariable = "addDataToTbody(testStepsTableBody, testStepsData);";
            ReplaceFileContent(testResultReportJsPath, originalTestStepsVariable, updatedTestStepsVariable);
        }

        /// <summary>
        /// Reports the test failure to the logging system
        /// </summary>
        /// <param name="failureReason"></param>
        public static void ReportTestFailure(string failureReason)
        {
            FailureReason = failureReason;
            FailureScreenshotPath = $"{Globals.TestResultsPath}\\{TestRunId}\\FailureScreenshot.png";
        }

        private static void ReplaceFileContent(string filePath, string originalContent, string replacementContent)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string input = reader.ReadToEnd();

                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    string output = input.Replace(originalContent, replacementContent);
                    writer.Write(output);
                    writer.Close();
                }

                reader.Close();
            }
        }

        private static string ReadResource(string name)
        {
            // Determine path
            Assembly assembly = Assembly.GetExecutingAssembly();
            string resourcePath = name;
            // Format: "{Namespace}.{Folder}.{filename}.{Extension}"
            resourcePath = assembly.GetManifestResourceNames()
                .Single(str => str.EndsWith(name));

            using (Stream stream = assembly.GetManifestResourceStream(resourcePath))
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }

        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();
            // If the destination directory doesn't exist, create it.
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destDirName, file.Name);
                file.CopyTo(temppath, false);
            }

            // If copying subdirectories, copy them and their contents to new location.
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                }
            }
        }

        private static string GenerateJavascriptDataForEventLog()
        {
            string eventLogData = GetEventLogData("Critical", CriticalEventLogs);
            eventLogData += GetEventLogData("Error", ErrorEventLogs);
            eventLogData += GetEventLogData("Warning", WarningEventLogs);
            eventLogData += GetEventLogData("Information", InformationEventLogs);

            string eventLogDetail = GetEventLogDetailData("Critical", CriticalEventLogs);
            eventLogDetail += GetEventLogDetailData("Error", ErrorEventLogs);
            eventLogDetail += GetEventLogDetailData("Warning", WarningEventLogs);
            eventLogDetail += GetEventLogDetailData("Information", InformationEventLogs);

            return eventLogData + eventLogDetail;
        }

        private static string GetEventLogData(string level, List<EventLogEntry> logEntries)
        {
            string eventLogData = string.Empty;

            eventLogData += $"var eventData{level} = [";

            for (int index = 0; index < logEntries.Count; index++)
            {
                string levelProp = "'Level': ";
                string dateAndTimeProp = "'DateAndTime': ";
                string sourceProp = "'Source': ";
                string taskCategoryProp = "'Task Category': ";
                string levelValue = "'" + level + "'";
                string dateAndTimeValue = "'" + logEntries[index].TimeGenerated.ToString("f") + "'";
                string sourceValue = "'" + logEntries[index].Source + "'";
                string taskCategoryValue = "'" + logEntries[index].Category + "'";

                eventLogData += "{";

                eventLogData += $"{levelProp}{levelValue}," +
                                $"{dateAndTimeProp}{dateAndTimeValue}," +
                                $"{sourceProp}{sourceValue}," +
                                $"{taskCategoryProp}{taskCategoryValue}";

                eventLogData += "}";

                if (index < logEntries.Count)
                {
                    eventLogData += ",";
                }
            }

            eventLogData += "];";

            return eventLogData;
        }

        private static string GetEventLogDetailData(string level, List<EventLogEntry> logEntries)
        {
            string detailLogData = string.Empty;

            detailLogData += $"var detailData{level} = [";

            for (int index = 0; index < logEntries.Count; index++)
            {
                string detailsProp = "'Details': ";
                string detailsValue = "'" + logEntries[index].Message + "'";

                detailLogData += "{";

                detailLogData += $"{detailsProp}{detailsValue}";

                detailLogData += "}";

                if (index < logEntries.Count)
                {
                    detailLogData += ",";
                }
            }

            detailLogData += "];";

            return detailLogData;
        }

        private static string GenerateJavascriptDataForTestResultReport(List<TestStep> testSteps)
        {
            string testStepsData = string.Empty;

            testStepsData += "var testStepsData = [";

            for (int index = 0; index < testSteps.Count; index++)
            {
                string stepNumberProp = "'Step Number': ";
                string stepDescriptionProp = "'Step Description': ";
                string stepResultProp = "'Step Result': ";
                string stepStatusProp = "'Step Status': ";
                string stepNumberValue = "'" + index + "'";
                string stepDescriptionValue = "'" + testSteps[index].StepDescription + "'";
                string stepResultValue = "'" + testSteps[index].StepResult + "'";
                string stepStatusValue = "'" + testSteps[index].StepStatus + "'";

                testStepsData += "{";

                testStepsData += $"{stepNumberProp}{stepNumberValue}," +
                                $"{stepDescriptionProp}{stepDescriptionValue}," +
                                $"{stepResultProp}{stepResultValue}," +
                                $"{stepStatusProp}{stepStatusValue}";

                testStepsData += "}";

                if (index < testSteps.Count)
                {
                    testStepsData += ",";
                }
            }

            testStepsData += "];";

            return testStepsData;
        }
    }
}
