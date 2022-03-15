using OpenQA.Selenium;
using QualitasDigitalSeleniumCSharp.WrapperFactory;
using System.Collections.Generic;
using System.Linq;

namespace QualitasDigitalSeleniumCSharp.PageObjects
{
    /// <summary>
    /// The ContactUs Page Object
    /// </summary>
    public class ContactUsPage
    {
        private IWebDriver driver = BrowserFactory.Driver;

        /// <summary>
        /// The Pricing and Services Url
        /// </summary>
        public const string Url = "https://www.qualitasdigital.com/contact-us";

        #region Elements

        /// <summary>
        /// The Logo Image element
        /// </summary>
        public IWebElement LogoImage => driver.FindElement(By.ClassName("logo-image"));

        /// <summary>
        /// Header Content element
        /// </summary>
        public IWebElement HeaderContent => driver.FindElement(By.XPath("//*[@id='block-66e658da5d8a61ea0d14']/div/h1"));

        /// <summary>
        /// Sidebar Content element
        /// </summary>
        public IWebElement SidebarContent => driver.FindElement(By.XPath("//*[@id='block-ef19513355911ef99e33']/div/h2"));

        /// <summary>
        /// Sidebar Links element
        /// </summary>
        public List<IWebElement> SidebarLinks => driver.FindElements(By.XPath("//*[@id='block-ef19513355911ef99e33']/div/p/a")).ToList();

        /// <summary>
        /// Our Commitment Link element
        /// </summary>
        public IWebElement OurCommitmentLink => SidebarLinks[0];

        /// <summary>
        /// Faq Link element
        /// </summary>
        public IWebElement FaqLink => SidebarLinks[1];

        /// <summary>
        /// Terms And Conditions Link element
        /// </summary>
        public IWebElement TermsAndConditionsLink => SidebarLinks[2];

        /// <summary>
        /// Form Section element
        /// </summary>
        public IWebElement FormSection => driver.FindElement(By.Id("block-1d7f70b9528dd074da0a"));

        /// <summary>
        /// First Name Field element
        /// </summary>
        public IWebElement FirstNameField => FormSection.FindElement(By.Name("fname"));

        /// <summary>
        /// Last Name Field element
        /// </summary>
        public IWebElement LastNameField => FormSection.FindElement(By.Name("lname"));

        /// <summary>
        /// Email Field element
        /// </summary>
        public IWebElement EmailField => FormSection.FindElement(By.Name("email"));

        /// <summary>
        /// Checkbox Section element
        /// </summary>
        public IWebElement CheckboxSection => FormSection.FindElements(By.CssSelector("fieldset[id^='checkbox-yui_3_17_2_1'][id$='22390']")).First();

        /// <summary>
        /// Additional Message Text Area element
        /// </summary>
        public IWebElement AdditionalMessageTextArea => FormSection.FindElements(By.CssSelector("textarea[id^='textarea-yui_3_17_2_1'][id$='67663-field']")).First();

        /// <summary>
        /// Submit Button element
        /// </summary>
        public IWebElement SubmitButton => FormSection.FindElement(By.ClassName("form-button-wrapper")).FindElement(By.TagName("input"));

        #endregion Elements
    }
}
