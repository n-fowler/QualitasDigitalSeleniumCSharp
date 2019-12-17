using System.Collections.Generic;

namespace QualitasDigitalSeleniumCSharp.Extensions
{
    /// <summary>
    /// 
    /// </summary>
    public class Logging
    {
        /// <summary>
        /// 
        /// </summary>
        public void GetFailureScreenshot()
        {
            //take the screenshot

            //Save it so that it can be displayed
        }

        /// <summary>
        /// 
        /// </summary>
        public void GetFailureReason()
        {
            //Set the failure reason for the report
        }

        /// <summary>
        /// 
        /// </summary>
        public void GetEventLoggingContent()
        {
            //Set the event logging content for the report
            //it should be organized in sections that can be collapsed
        }

        /// <summary>
        /// Get the test steps from the test run
        /// </summary>
        public List<TestStepLog> GetTestStepContent()
        {
            //Set the test steps for the report
            return null;
        }

        /// <summary>
        /// Generate the test run report
        /// </summary>
        public void GenerateHtmlReport()
        {

        }
    }
}
