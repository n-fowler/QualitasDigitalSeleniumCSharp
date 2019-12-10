namespace QualitasDigitalSeleniumCSharp.PageObjects
{
    public static class Page
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            return page;
        }

        public static HomePage Home => GetPage<HomePage>();
    }
}
