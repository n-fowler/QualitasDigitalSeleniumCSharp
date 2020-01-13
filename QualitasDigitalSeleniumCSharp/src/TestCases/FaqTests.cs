using NUnit.Framework;
using QualitasDigitalSeleniumCSharp.Extensions;
using QualitasDigitalSeleniumCSharp.PageObjects;
using QualitasDigitalSeleniumCSharp.src.TestData;
using QualitasDigitalSeleniumCSharp.WrapperFactory;
using System;

namespace QualitasDigitalSeleniumCSharp.TestCases
{
    /// <summary>
    /// Faq Tests
    /// </summary>
    public class FaqTests
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
        public void FaqLoad()
        {
            BrowserFactory.GoToPage(FaqPage.Url);
            BrowserFactory.WaitForPageLoad(10);
            Assert.IsTrue(Page.Faq.LogoImage.Displayed, "Page.Faq.LogoImage.Displayed");
        }

        /// <summary></summary>
        [Test]
        public void FaqContent()
        {
            BrowserFactory.GoToPage(FaqPage.Url);
            BrowserFactory.WaitForPageLoad(10);

            //Validate header
            Assert.AreEqual(FaqPageTestData.FaqTitle, Page.Faq.HeaderTitle.GetInnertext());

            //Validate left subsection
            Assert.AreEqual(FaqPageTestData.FaqSubtitle, Page.Faq.Subtitle.GetInnertext());
            Assert.AreEqual(FaqPageTestData.ContactUsLink, Page.Faq.ContactUsLink.GetHref());

            //Validate middle subsection
            Assert.AreEqual(FaqPageTestData.TitleOne, Page.Faq.TitleOne.GetInnertext());
            Assert.AreEqual(FaqPageTestData.BodyOne, Page.Faq.BodyTextOne.GetInnertext());
            Assert.AreEqual(FaqPageTestData.TitleTwo, Page.Faq.TitleTwo.GetInnertext());
            Assert.AreEqual(FaqPageTestData.BodyTwo, Page.Faq.BodyTextTwo.GetInnertext());
            Assert.AreEqual(FaqPageTestData.TitleThree, Page.Faq.TitleThree.GetInnertext());
            Assert.AreEqual(FaqPageTestData.BodyThree, Page.Faq.BodyTextThree.GetInnertext());
            Assert.AreEqual(FaqPageTestData.TitleFour, Page.Faq.TitleFour.GetInnertext());
            Assert.AreEqual(FaqPageTestData.BodyFour, Page.Faq.BodyTextFour.GetInnertext());
            Assert.AreEqual(FaqPageTestData.TitleFive, Page.Faq.TitleFive.GetInnertext());
            Assert.AreEqual(FaqPageTestData.BodyFive, Page.Faq.BodyTextFive.GetInnertext());
            Assert.AreEqual(FaqPageTestData.TitleSix, Page.Faq.TitleSix.GetInnertext());
            Assert.AreEqual(FaqPageTestData.BodySix, Page.Faq.BodyTextSix.GetInnertext());
            Assert.AreEqual(FaqPageTestData.TitleSeven, Page.Faq.TitleSeven.GetInnertext());
            Assert.AreEqual(FaqPageTestData.BodySeven, Page.Faq.BodyTextSeven.GetInnertext());


            //Validate right subsection
            Assert.AreEqual(FaqPageTestData.TitleEight, Page.Faq.TitleEight.GetInnertext());
            Assert.AreEqual(FaqPageTestData.BodyEight, Page.Faq.BodyTextEight.GetInnertext());
            Assert.AreEqual(FaqPageTestData.TitleNine, Page.Faq.TitleNine.GetInnertext());
            Assert.AreEqual(FaqPageTestData.BodyNine, Page.Faq.BodyTextNine.GetInnertext());
            Assert.AreEqual(FaqPageTestData.TitleTen, Page.Faq.TitleTen.GetInnertext());
            Assert.AreEqual(FaqPageTestData.BodyTen, Page.Faq.BodyTextTen.GetInnertext());
            Assert.AreEqual(FaqPageTestData.TitleEleven, Page.Faq.TitleEleven.GetInnertext());
            Assert.AreEqual(FaqPageTestData.BodyEleven, Page.Faq.BodyTextEleven.GetInnertext());
            Assert.AreEqual(FaqPageTestData.TitleTwelve, Page.Faq.TitleTwelve.GetInnertext());
            Assert.AreEqual(FaqPageTestData.BodyTwelve, Page.Faq.BodyTextTwelve.GetInnertext());
            Assert.AreEqual(FaqPageTestData.TitleThirteen, Page.Faq.TitleThirteen.GetInnertext());
            Assert.AreEqual(FaqPageTestData.BodyThirteen, Page.Faq.BodyTextThirteen.GetInnertext());
            Assert.AreEqual(FaqPageTestData.TitleFourteen, Page.Faq.TitleFourteen.GetInnertext());
            Assert.AreEqual(FaqPageTestData.BodyFourteen, Page.Faq.BodyTextFourteen.GetInnertext());
            Assert.AreEqual(FaqPageTestData.TitleFifteen, Page.Faq.TitleFifteen.GetInnertext());
            Assert.AreEqual(FaqPageTestData.BodyFifteen, Page.Faq.BodyTextFifteen.GetInnertext());
        }

        #endregion Tests
    }
}
