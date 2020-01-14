using OpenQA.Selenium;
using QualitasDigitalSeleniumCSharp.Extensions;
using QualitasDigitalSeleniumCSharp.src.LocalConfiguration;
using QualitasDigitalSeleniumCSharp.WrapperFactory;
using System.Linq;

namespace QualitasDigitalSeleniumCSharp.PageObjects
{
    /// <summary>
    /// The ScheduleConsultation Page Object
    /// </summary>
    public class ScheduleConsultationPage
    {
        private IWebDriver driver = BrowserFactory.Driver;

        /// <summary>
        /// The Pricing and Services Url
        /// </summary>
        public const string Url = "https://www.qualitasdigital.com/schedule-consultation";

        #region Elements

        /// <summary>
        /// The Logo Image element
        /// </summary>
        public IWebElement LogoImage => driver.FindElementByClassName("logo-image");

        /// <summary>
        /// Header Section element
        /// </summary>
        public IWebElement HeaderSection => driver.FindElementById("block-540803d1406a17b6338b");

        /// <summary>
        /// Header Content element
        /// </summary>
        public IWebElement HeaderContent => HeaderSection.FindElementByTagName("div").FindElementByTagName("h1");

        /// <summary>
        /// Left Section element
        /// </summary>
        public IWebElement LeftSection => driver.FindElementById("block-6bcc55f9ff3b7b21fdea");

        /// <summary>
        /// Left Content element
        /// </summary>
        public IWebElement LeftContent => LeftSection.FindElementByTagName("div").FindElementByTagName("h2");

        /// <summary>
        /// Our Commitment Link element
        /// </summary>
        public IWebElement OurCommitmentLink => LeftSection.FindElementByTagName("div").FindElementByTagName("p").FindElementsByTagName("a").ToList()[0];

        /// <summary>
        /// Faq Link element
        /// </summary>
        public IWebElement FaqLink => LeftSection.FindElementByTagName("div").FindElementByTagName("p").FindElementsByTagName("a").ToList()[1];

        /// <summary>
        /// Terms And Conditions Link element
        /// </summary>
        public IWebElement TermsAndConditionsLink => LeftSection.FindElementByTagName("div").FindElementByTagName("p").FindElementsByTagName("a").ToList()[2];

        /// <summary>
        /// Schedule Consultation Button element
        /// </summary>
        public IWebElement ScheduleConsultationButton => driver.GetElementsWithTagAndAttributeStartAndEndingWithValues("div", "id", Configuration.SitePrefix, "68").First();

        /// <summary>
        /// Schedule Consultation Button Link element
        /// </summary>
        public IWebElement ScheduleConsultationButtonLink => ScheduleConsultationButton.FindElementByTagName("a");

        #endregion Elements
    }
}
