using OpenQA.Selenium;
using QualitasDigitalSeleniumCSharp.WrapperFactory;
using System.Collections.Generic;
using System.Linq;

namespace QualitasDigitalSeleniumCSharp.PageObjects
{
    /// <summary>
    /// The AboutUs Page Object
    /// </summary>
    public class AboutUsPage
    {
        private IWebDriver driver = BrowserFactory.Driver;

        /// <summary>
        /// The AboutUs Url
        /// </summary>
        public const string Url = "https://www.qualitasdigital.com/about-us";

        #region Elements

        /// <summary>
        /// The Logo Image element
        /// </summary>
        public IWebElement LogoImage => driver.FindElement(By.ClassName("logo-image"));

        /// <summary>
        /// The About Us Header section
        /// </summary>
        public IWebElement HeaderSection => driver.FindElement(By.Id("block-8d07de855042f0a5360c"));

        /// <summary>
        /// The About Us Header Title element
        /// </summary>
        public IWebElement HeaderTitle => driver.FindElement(By.XPath("//*[@id='block-8d07de855042f0a5360c']/div/h1"));

        /// <summary>
        /// The About Us SubSection Title element
        /// </summary>
        public IWebElement Title => driver.FindElement(By.XPath("//*[@id='block-54dfc3255ea4a1352072']/div/h2"));

        /// <summary>
        /// The About Us Sidebar element
        /// </summary>
        public List<IWebElement> Sidebar => driver.FindElements(By.XPath("//*[@id='block-54dfc3255ea4a1352072']/div/p")).ToList();

        /// <summary>
        /// The About Us Body element
        /// </summary>
        public IWebElement BodyText => Sidebar[0];

        /// <summary>
        /// The SideBar Links element
        /// </summary>
        public List<IWebElement> SidebarLinks => Sidebar[1].FindElements(By.TagName("a")).ToList();

        /// <summary>
        /// The About Us Our Services Link element
        /// </summary>
        public IWebElement OurServicesLink => SidebarLinks[0];

        /// <summary>
        /// The About Us Schedule Consultation Link element
        /// </summary>
        public IWebElement ScheduleConsultationLink => SidebarLinks[1];

        /// <summary>
        /// The About Us Image Subsection
        /// </summary>
        public IWebElement AboutUsImageSection => driver.FindElement(By.Id("block-5347679b4da120838be3"));

        /// <summary>
        /// The About Us Image element
        /// </summary>
        public IWebElement Image => AboutUsImageSection.FindElements(By.CssSelector("div[id^='yui_3_17_2_1'][id$='68']")).First().FindElement(By.TagName("img"));
        #endregion Elements
    }
}
