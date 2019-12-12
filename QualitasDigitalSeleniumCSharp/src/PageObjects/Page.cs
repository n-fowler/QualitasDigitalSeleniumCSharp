namespace QualitasDigitalSeleniumCSharp.PageObjects
{
    /// <summary>
    /// A generic page object implementation
    /// </summary>
    public static class Page
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            return page;
        }

        /// <summary>
        /// HomePage
        /// </summary>
        public static HomePage Home => GetPage<HomePage>();
    }
}
