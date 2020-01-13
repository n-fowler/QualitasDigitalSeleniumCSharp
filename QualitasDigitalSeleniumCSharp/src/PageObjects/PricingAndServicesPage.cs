using OpenQA.Selenium;
using QualitasDigitalSeleniumCSharp.Extensions;
using QualitasDigitalSeleniumCSharp.WrapperFactory;
using System.Linq;

namespace QualitasDigitalSeleniumCSharp.PageObjects
{
    /// <summary>
    /// The PricingAndServices Page Object
    /// </summary>
    public class PricingAndServicesPage
    {
        private IWebDriver driver = BrowserFactory.Driver;

        /// <summary>
        /// The Pricing and Services Url
        /// </summary>
        public const string Url = "https://www.qualitasdigital.com/pricing-services";

        #region Elements

        /// <summary>
        /// The Logo Image element
        /// </summary>
        public IWebElement LogoImage => driver.FindElementByClassName("logo-image");

        /// <summary>
        /// The Header section element
        /// </summary>
        public IWebElement HeaderSection => driver.FindElementById("block-19f417ec60a63ba7c692");

        /// <summary>
        /// The Header Title element
        /// </summary>
        public IWebElement HeaderTitle => HeaderSection.FindElementByTagName("div").FindElementByTagName("h1");

        /// <summary>
        /// The Left Section element
        /// </summary>
        public IWebElement LeftSection => driver.FindElementById("block-82a19843bee36801ceff");

        /// <summary>
        /// The Left Subtitle element
        /// </summary>
        public IWebElement Subtitle => LeftSection.FindElementByTagName("div").FindElementByTagName("h2");

        /// <summary>
        /// The Our Commitment Link element
        /// </summary>
        public IWebElement OurCommitmentLink => LeftSection.FindElementByTagName("div").FindElementsByTagName("p").ToList()[0].FindElementsByTagName("a").ToList()[0];

        /// <summary>
        /// The Center Section element
        /// </summary>
        public IWebElement CenterSection => driver.FindElementById("block-54c775ec01e945af9697");

        /// <summary>
        /// The Additional Test Coverage Title element
        /// </summary>
        public IWebElement AdditionalTestCoverageTitle => CenterSection.FindElementByTagName("div").FindElementsByTagName("h2").ToList()[0];

        /// <summary>
        /// The Additional Test Coverage Body Text element
        /// </summary>
        public IWebElement AdditionalTestCoverageBodyText => CenterSection.FindElementByTagName("div").FindElementsByTagName("p").ToList()[0];

        /// <summary>
        /// The Framework Updates Title element
        /// </summary>
        public IWebElement FrameworkUpdatesTitle => CenterSection.FindElementByTagName("div").FindElementsByTagName("h2").ToList()[1];

        /// <summary>
        /// The Framework Updates Upgrades Body Text element
        /// </summary>
        public IWebElement FrameworkUpdatesUpgradesBodyText => CenterSection.FindElementByTagName("div").FindElementsByTagName("p").ToList()[1];

        /// <summary>
        /// The Framework Updates Custom Tailored Body Text element
        /// </summary>
        public IWebElement FrameworkUpdatesCustomTailoredBodyText => CenterSection.FindElementByTagName("div").FindElementsByTagName("p").ToList()[2];

        /// <summary>
        /// The Process Automation Title element
        /// </summary>
        public IWebElement ProcessAutomationTitle => CenterSection.FindElementByTagName("div").FindElementsByTagName("h2").ToList()[2];

        /// <summary>
        /// The Process Automation Body Text element
        /// </summary>
        public IWebElement ProcessAutomationBodyText => CenterSection.FindElementByTagName("div").FindElementsByTagName("p").ToList()[3];

        /// <summary>
        /// The Dashboards Title element
        /// </summary>
        public IWebElement DashboardsTitle => CenterSection.FindElementByTagName("div").FindElementsByTagName("h2").ToList()[3];

        /// <summary>
        /// The Dashboards On Premise Body Text element
        /// </summary>
        public IWebElement DashboardsOnPremiseBodyText => CenterSection.FindElementByTagName("div").FindElementsByTagName("p").ToList()[4];

        /// <summary>
        /// The Dashboards Saas Body Text element
        /// </summary>
        public IWebElement DashboardsSaasBodyText => CenterSection.FindElementByTagName("div").FindElementsByTagName("p").ToList()[5];

        /// <summary>
        /// The Dashboards Disclaimer Body Text element
        /// </summary>
        public IWebElement DashboardsDisclaimerBodyText => CenterSection.FindElementByTagName("div").FindElementsByTagName("p").ToList()[6];

        /// <summary>
        /// The Right Section element
        /// </summary>
        public IWebElement RightSection => driver.FindElementById("block-beb271dbce1faba38f10");

        /// <summary>
        /// The Training Title element
        /// </summary>
        public IWebElement TrainingTitle => RightSection.FindElementByTagName("div").FindElementsByTagName("h2").ToList()[0];

        /// <summary>
        /// The Training Body Text element
        /// </summary>
        public IWebElement TrainingBodyText => RightSection.FindElementByTagName("div").FindElementsByTagName("p").ToList()[0];

        /// <summary>
        /// The Coaching Title element
        /// </summary>
        public IWebElement CoachingTitle => RightSection.FindElementByTagName("div").FindElementsByTagName("h2").ToList()[1];

        /// <summary>
        /// The Coaching Body Text element
        /// </summary>
        public IWebElement CoachingBodyText => RightSection.FindElementByTagName("div").FindElementsByTagName("p").ToList()[1];

        /// <summary>
        /// The Roadmaps Title element
        /// </summary>
        public IWebElement RoadmapsTitle => RightSection.FindElementByTagName("div").FindElementsByTagName("h2").ToList()[2];

        /// <summary>
        /// The Roadmaps Body Text element
        /// </summary>
        public IWebElement RoadmapsBodyText => RightSection.FindElementByTagName("div").FindElementsByTagName("p").ToList()[2];

        /// <summary>
        /// The Trusted Advisor Title element
        /// </summary>
        public IWebElement TrustedAdvisorTitle => RightSection.FindElementByTagName("div").FindElementsByTagName("h2").ToList()[3];

        /// <summary>
        /// The Trusted Advisor Body Text element
        /// </summary>
        public IWebElement TrustedAdvisorBodyText => RightSection.FindElementByTagName("div").FindElementsByTagName("p").ToList()[3];

        /// <summary>
        /// The Technical CoFounder title element
        /// </summary>
        public IWebElement TechnicalCoFounderTitle => RightSection.FindElementByTagName("div").FindElementsByTagName("h2").ToList()[4];

        /// <summary>
        /// The Technical CoFounder Body Text element
        /// </summary>
        public IWebElement TechnicalCoFounderBodyText => RightSection.FindElementByTagName("div").FindElementsByTagName("p").ToList()[4];

        #endregion Elements
    }
}
