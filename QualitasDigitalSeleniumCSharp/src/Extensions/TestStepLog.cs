namespace QualitasDigitalSeleniumCSharp.Extensions
{
    /// <summary>
    /// 
    /// </summary>
    public class TestStepLog
    {
        private string Step { get; set; }
        private int Time { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="step"></param>
        /// <param name="time"></param>
        public TestStepLog(string step, int time)
        {
            Step = step;
            Time = time;
        }
    }
}
