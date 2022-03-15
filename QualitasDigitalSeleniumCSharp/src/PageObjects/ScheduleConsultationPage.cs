using OpenQA.Selenium;
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
        public IWebElement LogoImage => driver.FindElement(By.ClassName("logo-image"));

        /// <summary>
        /// Header Content element
        /// </summary>
        public IWebElement HeaderContent => driver.FindElement(By.XPath("//*[@id='block-540803d1406a17b6338b']/div/h1"));

        /// <summary>
        /// Left Content element
        /// </summary>
        public IWebElement LeftContent => driver.FindElement(By.XPath("//*[@id='block-6bcc55f9ff3b7b21fdea']/div/h2/em"));

        /// <summary>
        /// Our Commitment Link element
        /// </summary>
        public IWebElement OurCommitmentLink => driver.FindElement(By.XPath("//*[@id='block-6bcc55f9ff3b7b21fdea']/div/p/a[1]"));

        /// <summary>
        /// Faq Link element
        /// </summary>
        public IWebElement FaqLink => driver.FindElement(By.XPath("//*[@id='block-6bcc55f9ff3b7b21fdea']/div/p/a[2]"));

        /// <summary>
        /// Terms And Conditions Link element
        /// </summary>
        public IWebElement TermsAndConditionsLink => driver.FindElement(By.XPath("//*[@id='block-6bcc55f9ff3b7b21fdea']/div/p/a[3]"));

        /// <summary>
        /// Schedule Consultation Button element
        /// </summary>
        public IWebElement ScheduleConsultationButton => driver.FindElements(By.CssSelector("div[id^='yui_3_17_2_1'][id$='77']")).First();

        /// <summary>
        /// Schedule Consultation Button Link element
        /// </summary>
        public IWebElement ScheduleConsultationButtonLink => ScheduleConsultationButton.FindElement(By.TagName("a"));

        #endregion Elements
    }
}
