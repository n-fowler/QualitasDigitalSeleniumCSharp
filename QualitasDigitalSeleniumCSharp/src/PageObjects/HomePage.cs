using OpenQA.Selenium;
using QualitasDigitalSeleniumCSharp.WrapperFactory;
using System.Collections.Generic;

namespace QualitasDigitalSeleniumCSharp.PageObjects
{
    public class HomePage
    {
        private IWebDriver driver = BrowserFactory.Driver;
        public string url = "http://www.qualitasdigital.com";

        #region Elements

        public IWebElement LogoImage => driver.FindElement(By.ClassName("logo-image"));

        /// <summary>
        /// Navigation Section
        /// </summary>
        public IWebElement NavToggleOpen => driver.FindElement(By.ClassName("nav-toggle-label-icon"));

        public IWebElement NavToggleClose => driver.FindElement(By.Id("navCloseToggle"));

        public IReadOnlyCollection<IWebElement> NavCollection => driver.FindElements(By.ClassName("nav-link--collection"));

        public IWebElement NavBodyText => driver.FindElement(By.Id("block-5aa025203dc65c6e55e9"));

        public IWebElement NavScheduleButton => driver.FindElement(By.Id("block-d013aff45daaf1868f5b"));

        #endregion Elements

        #region Methods

        public List<string> GetLinkTexts()
        {
            List<string> navLinkTexts = new List<string>();

            foreach (IWebElement webElement in NavCollection)
            {

            }

            return navLinkTexts;
        }

        #endregion Methods
    }
}
