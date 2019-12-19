using HtmlAgilityPack;
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
            HtmlDocument testResultReport = new HtmlDocument();
            testResultReport.LoadHtml(ReadResource("TestResultReport"));

            testResultReport.GetElementbyId("TestStepsTable").RemoveAllChildren();
            for (int i = 0; i < TestStepLog.TestSteps.Count; i++)
            {
                string testStepRow = $@"
                <tr>
                    <td>{i + 1}</td>
                    <td>{TestStepLog.TestSteps[i]}</td>
                    <td>Step Result Placeholder</td>
                    <td>Pass</td>
                </tr>";
                HtmlNode htmlNode = HtmlNode.CreateNode(testStepRow);
                testResultReport.GetElementbyId("TestStepsTable").AppendChild(htmlNode);
            }

            HtmlDocument eventLogViewer = new HtmlDocument();
            eventLogViewer.LoadHtml(ReadResource("EventLogViewer"));
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
    }
}
