using OpenQA.Selenium;
using QualitasDigitalSeleniumCSharp.Extensions;
using QualitasDigitalSeleniumCSharp.WrapperFactory;
using System.Collections.Generic;
using System.Linq;

namespace QualitasDigitalSeleniumCSharp.PageObjects
{
    /// <summary>
    /// The HomePage Page Object
    /// </summary>
    public class HomePage
    {
        private IWebDriver driver = BrowserFactory.Driver;

        /// <summary>
        /// The HomePage Url
        /// </summary>
        public const string Url = "http://www.qualitasdigital.com";

        #region Elements

        /// <summary>
        /// The Logo Image element
        /// </summary>
        public IWebElement LogoImage => driver.FindElementByClassName("logo-image");

        /// <summary>
        /// Navigation section expansion toggle open
        /// </summary>
        public IWebElement NavToggle => driver.FindElementById("navToggle");

        /// <summary>
        /// Navigation section parent
        /// </summary>
        public IWebElement NavSection => driver.FindElementById("mainNavigation");

        /// <summary>
        /// Navigation section link collection
        /// </summary>
        public List<IWebElement> NavCollection => NavSection.FindElementsByClassName("nav-link--collection").ToList();

        /// <summary>
        /// Navigation section body text
        /// </summary>
        public IWebElement NavBodyText => driver.FindElementById("block-5aa025203dc65c6e55e9");

        /// <summary>
        /// Navigation section schedule button
        /// </summary>
        public IWebElement NavScheduleButton => driver.FindElementById("block-d013aff45daaf1868f5b");

        #endregion Elements

        #region Methods

        /// <summary>
        /// Navigation section get link text
        /// </summary>
        /// <returns></returns>
        public List<string> GetLinkTexts()
        {
            List<string> navLinkTexts = new List<string>();

            foreach (IWebElement webElement in NavCollection)
            {
                string text = webElement.FindElementByTagName("a").FindElementByTagName("span").GetAttribute("innerText");

                if (!string.IsNullOrEmpty(text))
                {
                    navLinkTexts.Add(text);
                }
            }

            return navLinkTexts;
        }

        #endregion Methods
    }
}
