using OpenQA.Selenium;
using System;
using System.Collections.Generic;

namespace QualitasDigitalSeleniumCSharp.Extensions
{
    /// <summary>
    /// a log entry for a test step
    /// </summary>
    public static class TestStepLog
    {
        /// <summary>
        /// 
        /// </summary>
        public static List<TestStep> TestSteps { get; set; }

        private static TimeSpan _lastStepExecuted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="element"></param>
        /// <param name="time"></param>
        public static void GenerateTestStep(IWebElement element, TimeSpan time)
        {
            TestStep testStep = new TestStep();


        }
    }
}
