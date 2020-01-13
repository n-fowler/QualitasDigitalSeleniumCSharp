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
            Assert.AreEqual(PricingAndServicesPageTestData.PricingAndServicesTitle, Page.PricingAndServices.HeaderTitle.GetInnertext());

            //Validate left subsection
            Assert.AreEqual(PricingAndServicesPageTestData.PricingAndServicesSubtitle, Page.PricingAndServices.Subtitle.GetInnertext());
            Assert.AreEqual(PricingAndServicesPageTestData.OurCommitmentLink, Page.PricingAndServices.OurCommitmentLink.GetHref());

            //Validate middle subsection
            Assert.AreEqual(PricingAndServicesPageTestData.AdditionalTestCoverageTitle, Page.PricingAndServices.AdditionalTestCoverageTitle.GetInnertext());
            Assert.AreEqual(PricingAndServicesPageTestData.AdditionalTestCoverageBodyText, Page.PricingAndServices.AdditionalTestCoverageBodyText.GetInnertext());
            Assert.AreEqual(PricingAndServicesPageTestData.FrameworkUpdatesTitle, Page.PricingAndServices.FrameworkUpdatesTitle.GetInnertext());
            Assert.AreEqual(PricingAndServicesPageTestData.FrameworkUpdatesUpgradesBodyText, Page.PricingAndServices.FrameworkUpdatesUpgradesBodyText.GetInnertext());
            Assert.AreEqual(PricingAndServicesPageTestData.FrameworkUpdatesCustomTailoredBodyText, Page.PricingAndServices.FrameworkUpdatesCustomTailoredBodyText.GetInnertext());
            Assert.AreEqual(PricingAndServicesPageTestData.ProcessAutomationTitle, Page.PricingAndServices.ProcessAutomationTitle.GetInnertext());
            Assert.AreEqual(PricingAndServicesPageTestData.ProcessAutomationBodyText, Page.PricingAndServices.ProcessAutomationBodyText.GetInnertext());
            Assert.AreEqual(PricingAndServicesPageTestData.DashboardsTitle, Page.PricingAndServices.DashboardsTitle.GetInnertext());
            Assert.AreEqual(PricingAndServicesPageTestData.DashboardsOnPremiseBodyText, Page.PricingAndServices.DashboardsOnPremiseBodyText.GetInnertext());
            Assert.AreEqual(PricingAndServicesPageTestData.DashboardsSaasBodyText, Page.PricingAndServices.DashboardsSaasBodyText.GetInnertext());
            Assert.AreEqual(PricingAndServicesPageTestData.DashboardsDisclaimerBodyText, Page.PricingAndServices.DashboardsDisclaimerBodyText.GetInnertext());

            //Validate right subsection
            Assert.AreEqual(PricingAndServicesPageTestData.TrainingTitle, Page.PricingAndServices.TrainingTitle.GetInnertext());
            Assert.AreEqual(PricingAndServicesPageTestData.TrainingBodyText, Page.PricingAndServices.TrainingBodyText.GetInnertext());
            Assert.AreEqual(PricingAndServicesPageTestData.CoachingTitle, Page.PricingAndServices.CoachingTitle.GetInnertext());
            Assert.AreEqual(PricingAndServicesPageTestData.CoachingBodyText, Page.PricingAndServices.CoachingBodyText.GetInnertext());
            Assert.AreEqual(PricingAndServicesPageTestData.RoadmapsTitle, Page.PricingAndServices.RoadmapsTitle.GetInnertext());
            Assert.AreEqual(PricingAndServicesPageTestData.RoadmapsBodyText, Page.PricingAndServices.RoadmapsBodyText.GetInnertext());
            Assert.AreEqual(PricingAndServicesPageTestData.TrustedAdvisorTitle, Page.PricingAndServices.TrustedAdvisorTitle.GetInnertext());
            Assert.AreEqual(PricingAndServicesPageTestData.TrustedAdvisorBodyText, Page.PricingAndServices.TrustedAdvisorBodyText.GetInnertext());
            Assert.AreEqual(PricingAndServicesPageTestData.TechnicalCoFounderTitle, Page.PricingAndServices.TechnicalCoFounderTitle.GetInnertext());
            Assert.AreEqual(PricingAndServicesPageTestData.TechnicalCoFounderBodyText, Page.PricingAndServices.TechnicalCoFounderBodyText.GetInnertext());
        }

        #endregion Tests
    }
}
