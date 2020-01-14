using NUnit.Framework;
using QualitasDigitalSeleniumCSharp.Extensions;
using QualitasDigitalSeleniumCSharp.PageObjects;
using QualitasDigitalSeleniumCSharp.src.TestData;
using QualitasDigitalSeleniumCSharp.WrapperFactory;
using System;

namespace QualitasDigitalSeleniumCSharp.TestCases
{
    /// <summary>
    /// Schedule Consultation Tests
    /// </summary>
    public class ScheduleConsultationTests
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
        public void ScheduleConsultationLoad()
        {
            BrowserFactory.GoToPage(ScheduleConsultationPage.Url);
            BrowserFactory.WaitForPageLoad(10);
            Assert.IsTrue(Page.ScheduleConsultation.LogoImage.Displayed, "Page.ScheduleConsultation.LogoImage.Displayed");
        }

        /// <summary></summary>
        [Test]
        public void ScheduleConsultationContent()
        {
            BrowserFactory.GoToPage(ScheduleConsultationPage.Url);
            BrowserFactory.WaitForPageLoad(10);

            //Validate Title
            Assert.AreEqual(ScheduleConsultationPageData.HeaderContent, Page.ScheduleConsultation.HeaderContent.GetInnertext());

            //Validate left section
            Assert.AreEqual(ScheduleConsultationPageData.LeftContent, Page.ScheduleConsultation.LeftContent.GetInnertext());
            Assert.AreEqual(ScheduleConsultationPageData.OurCommitmentLink, Page.ScheduleConsultation.OurCommitmentLink.GetHref());
            Assert.AreEqual(ScheduleConsultationPageData.FaqLink, Page.ScheduleConsultation.FaqLink.GetHref());
            Assert.AreEqual(ScheduleConsultationPageData.TermsAndConditionsLink, Page.ScheduleConsultation.TermsAndConditionsLink.GetHref());

            //Validate right section
            Assert.AreEqual(ScheduleConsultationPageData.ScheduleConsultationButtonLink, Page.ScheduleConsultation.ScheduleConsultationButtonLink.GetHref());
        }

        //Due to the lack of test environments, there aren't any tests for scheduling the consultation on calendly, and their tests cover that anyway.

        #endregion Tests
    }
}
