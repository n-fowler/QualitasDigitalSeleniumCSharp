using OpenQA.Selenium;
using QualitasDigitalSeleniumCSharp.src.Extensions;
using System;
using System.Collections.Generic;

namespace QualitasDigitalSeleniumCSharp.Extensions
{
    /// <summary>
    /// a log entry for a test step
    /// </summary>
    public static class TestStepLog
    {
        public static List<TestStep> TestSteps { get; set; }

        private static TimeSpan _lastStepExecuted { get; set; }



        public static void GenerateTestStep(IWebElement element, TimeSpan time)
        {
            TestStep testStep = new TestStep();


        }
    }
}
