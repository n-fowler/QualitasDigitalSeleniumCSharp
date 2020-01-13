using OpenQA.Selenium;
using QualitasDigitalSeleniumCSharp.Extensions;
using QualitasDigitalSeleniumCSharp.src.LocalConfiguration;
using QualitasDigitalSeleniumCSharp.WrapperFactory;
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
        public IWebElement LogoImage => driver.FindElementByClassName("logo-image");

        /// <summary>
        /// The About Us Header section
        /// </summary>
        public IWebElement HeaderSection => driver.FindElementById("block-8d07de855042f0a5360c");

        /// <summary>
        /// The About Us Header Title element
        /// </summary>
        public IWebElement HeaderTitle => HeaderSection.FindElementByTagName("div").FindElementByTagName("h1");

        /// <summary>
        /// The About Us Text Subsection
        /// </summary>
        public IWebElement AboutUsTextSection => driver.FindElementById("block-54dfc3255ea4a1352072");

        /// <summary>
        /// The About Us SubSection Title element
        /// </summary>
        public IWebElement Title => AboutUsTextSection.FindElementByTagName("div").FindElementByTagName("h2");

        /// <summary>
        /// The About Us Body element
        /// </summary>
        public IWebElement BodyText => AboutUsTextSection.FindElementByTagName("div").FindElementsByTagName("p").ToList()[0];

        /// <summary>
        /// The About Us Our Services Link element
        /// </summary>
        public IWebElement OurServicesLink => AboutUsTextSection.FindElementByTagName("div").FindElementsByTagName("p").ToList()[1].FindElementsByTagName("a").ToList()[0];

        /// <summary>
        /// The About Us Schedule Consultation Link element
        /// </summary>
        public IWebElement ScheduleConsultationLink => AboutUsTextSection.FindElementByTagName("div").FindElementsByTagName("p").ToList()[1].FindElementsByTagName("a").ToList()[1];

        /// <summary>
        /// The About Us Image Subsection
        /// </summary>
        public IWebElement AboutUsImageSection => driver.FindElementById("block-5347679b4da120838be3");

        /// <summary>
        /// The About Us Image element
        /// </summary>
        public IWebElement Image => AboutUsImageSection.GetElementsWithTagAndAttributeStartAndEndingWithValues("div", "id", Configuration.SitePrefix, "59").First().FindElementByTagName("img");

        #endregion Elements
    }
}
