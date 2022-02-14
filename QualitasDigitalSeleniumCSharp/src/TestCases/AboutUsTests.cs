using NUnit.Framework;
using QualitasDigitalSeleniumCSharp.Extensions;
using QualitasDigitalSeleniumCSharp.PageObjects;
using QualitasDigitalSeleniumCSharp.src.TestData;
using QualitasDigitalSeleniumCSharp.WrapperFactory;
using System;

namespace QualitasDigitalSeleniumCSharp.TestCases
{
    /// <summary>
    /// AboutUs Tests
    /// </summary>
    public class AboutUsTests
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
            BrowserFactory.InitBrowserHeadless(webDriverEnum);
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
        public void AboutUsLoad()
        {
            BrowserFactory.GoToPage(AboutUsPage.Url);
            BrowserFactory.WaitForPageLoad(10);
            Assert.IsTrue(Page.AboutUs.LogoImage.Displayed, "Page.AboutUs.LogoImage.Displayed");
        }

        /// <summary></summary>
        [Test]
        public void AboutUsContent()
        {
            BrowserFactory.GoToPage(AboutUsPage.Url);
            BrowserFactory.WaitForPageLoad(10);

            //Validate About Us Section
            Assert.AreEqual(AboutUsPageTestData.HeaderTitle, Page.AboutUs.HeaderTitle.GetInnertext());
            Assert.AreEqual(AboutUsPageTestData.AboutUsTitle, Page.AboutUs.Title.GetInnertext());
            StringAssert.Contains(AboutUsPageTestData.AboutUsImageSrc, Page.AboutUs.Image.GetSrc());
            Assert.AreEqual(AboutUsPageTestData.AboutUsBodyText, Page.AboutUs.BodyText.GetInnertext());
            Assert.AreEqual(AboutUsPageTestData.OurServicesLink, Page.AboutUs.OurServicesLink.GetHref());
            Assert.AreEqual(AboutUsPageTestData.ScheduleConsultationLink, Page.AboutUs.ScheduleConsultationLink.GetHref());
        }

        #endregion Tests
    }
}
