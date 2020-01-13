using NUnit.Framework;
using QualitasDigitalSeleniumCSharp.Extensions;
using QualitasDigitalSeleniumCSharp.PageObjects;
using QualitasDigitalSeleniumCSharp.src.TestData;
using QualitasDigitalSeleniumCSharp.WrapperFactory;
using System;

namespace QualitasDigitalSeleniumCSharp.TestCases
{
    /// <summary>
    /// PricingAndServices Tests
    /// </summary>
    public class PricingAndServicesTests
    {
        #region Fields

        private BrowserFactory.WebDriver webDriverEnum = BrowserFactory.WebDriver.Chrome;

        #endregion Fields

        #region Shared

        /// <summary>
        /// The one time test setup method
        /// </summary>
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            BrowserFactory.InitBrowser(webDriverEnum);
        }

        /// <summary>
        /// The one time test tear down method
        /// </summary>
        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            BrowserFactory.CloseAllDrivers();
        }

        /// <summary>
        /// The individual test setup method
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            Logging.SetTestRunId();
            Logging.TestStartTime = DateTime.Now;
        }

        /// <summary>
        /// The individual test tear down method
        /// </summary>
        [TearDown]
        public void TearDown()
        {
            Logging.TestEndTime = DateTime.Now;
            BrowserFactory.ReportTestStatus(TestContext.CurrentContext);
        }

        #endregion Shared

        #region Tests

        /// <summary></summary>
        [Test]
        public void PricingAndServicesLoad()
        {
            BrowserFactory.GoToPage(PricingAndServicesPage.Url);
            BrowserFactory.WaitForPageLoad(10);
            Assert.IsTrue(Page.PricingAndServices.LogoImage.Displayed, "Page.PricingAndServices.LogoImage.Displayed");
        }

        /// <summary></summary>
        [Test]
        public void PricingAndServicesContent()
        {
            BrowserFactory.GoToPage(PricingAndServicesPage.Url);
            BrowserFactory.WaitForPageLoad(10);

            //Validate header
            Assert.AreEqual(PricingAndServicesPageTest.PricingAndServicesTitle, Page.PricingAndServices.HeaderTitle.GetInnertext());

            //Validate left subsection
            Assert.AreEqual(PricingAndServicesPageTest.PricingAndServicesSubtitle, Page.PricingAndServices.Subtitle.GetInnertext());
            Assert.AreEqual(PricingAndServicesPageTest.OurCommitmentLink, Page.PricingAndServices.OurCommitmentLink.GetHref());

            //Validate middle subsection
            Assert.AreEqual(PricingAndServicesPageTest.AdditionalTestCoverageTitle, Page.PricingAndServices.AdditionalTestCoverageTitle.GetInnertext());
            Assert.AreEqual(PricingAndServicesPageTest.AdditionalTestCoverageBodyText, Page.PricingAndServices.AdditionalTestCoverageBodyText.GetInnertext());
            Assert.AreEqual(PricingAndServicesPageTest.FrameworkUpdatesTitle, Page.PricingAndServices.FrameworkUpdatesTitle.GetInnertext());
            Assert.AreEqual(PricingAndServicesPageTest.FrameworkUpdatesUpgradesBodyText, Page.PricingAndServices.FrameworkUpdatesUpgradesBodyText.GetInnertext());
            Assert.AreEqual(PricingAndServicesPageTest.FrameworkUpdatesCustomTailoredBodyText, Page.PricingAndServices.FrameworkUpdatesCustomTailoredBodyText.GetInnertext());
            Assert.AreEqual(PricingAndServicesPageTest.ProcessAutomationTitle, Page.PricingAndServices.ProcessAutomationTitle.GetInnertext());
            Assert.AreEqual(PricingAndServicesPageTest.ProcessAutomationBodyText, Page.PricingAndServices.ProcessAutomationBodyText.GetInnertext());
            Assert.AreEqual(PricingAndServicesPageTest.DashboardsTitle, Page.PricingAndServices.DashboardsTitle.GetInnertext());
            Assert.AreEqual(PricingAndServicesPageTest.DashboardsOnPremiseBodyText, Page.PricingAndServices.DashboardsOnPremiseBodyText.GetInnertext());
            Assert.AreEqual(PricingAndServicesPageTest.DashboardsSaasBodyText, Page.PricingAndServices.DashboardsSaasBodyText.GetInnertext());
            Assert.AreEqual(PricingAndServicesPageTest.DashboardsDisclaimerBodyText, Page.PricingAndServices.DashboardsDisclaimerBodyText.GetInnertext());

            //Validate right subsection
            Assert.AreEqual(PricingAndServicesPageTest.TrainingTitle, Page.PricingAndServices.TrainingTitle.GetInnertext());
            Assert.AreEqual(PricingAndServicesPageTest.TrainingBodyText, Page.PricingAndServices.TrainingBodyText.GetInnertext());
            Assert.AreEqual(PricingAndServicesPageTest.CoachingTitle, Page.PricingAndServices.CoachingTitle.GetInnertext());
            Assert.AreEqual(PricingAndServicesPageTest.CoachingBodyText, Page.PricingAndServices.CoachingBodyText.GetInnertext());
            Assert.AreEqual(PricingAndServicesPageTest.RoadmapsTitle, Page.PricingAndServices.RoadmapsTitle.GetInnertext());
            Assert.AreEqual(PricingAndServicesPageTest.RoadmapsBodyText, Page.PricingAndServices.RoadmapsBodyText.GetInnertext());
            Assert.AreEqual(PricingAndServicesPageTest.TrustedAdvisorTitle, Page.PricingAndServices.TrustedAdvisorTitle.GetInnertext());
            Assert.AreEqual(PricingAndServicesPageTest.TrustedAdvisorBodyText, Page.PricingAndServices.TrustedAdvisorBodyText.GetInnertext());
            Assert.AreEqual(PricingAndServicesPageTest.TechnicalCoFounderTitle, Page.PricingAndServices.TechnicalCoFounderTitle.GetInnertext());
            Assert.AreEqual(PricingAndServicesPageTest.TechnicalCoFounderBodyText, Page.PricingAndServices.TechnicalCoFounderBodyText.GetInnertext());
        }

        #endregion Tests
    }
}
