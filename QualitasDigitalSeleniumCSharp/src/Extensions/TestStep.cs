﻿using System;

namespace QualitasDigitalSeleniumCSharp.Extensions
{
    /// <summary>
    /// 
    /// </summary>
    public class TestStep
    {
        /// <summary>
        /// 
        /// </summary>
        public string StepDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string StepResult { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool StepStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public TimeSpan Time { get; set; }
    }
}
