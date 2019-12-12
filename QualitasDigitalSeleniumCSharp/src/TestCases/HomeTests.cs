using NUnit.Framework;
using QualitasDigitalSeleniumCSharp.Extensions;
using QualitasDigitalSeleniumCSharp.PageObjects;
using QualitasDigitalSeleniumCSharp.WrapperFactory;
using System.Collections.Generic;

namespace QualitasDigitalSeleniumCSharp.TestCases
{
    /// <summary>
    /// HomePage Tests
    /// </summary>
    [TestFixture]
    public class HomeTests
    {
        #region Fields

        private BrowserFactory.WebDriver webDriverEnum = BrowserFactory.WebDriver.Chrome;

        #endregion Fields

        #region Shared

        /// <summary>
        /// The test setup method
        /// </summary>
        [OneTimeSetUp]
        public void SetUp()
        {
            BrowserFactory.InitBrowser(webDriverEnum);
        }

        /// <summary>
        /// The test tear down method
        /// </summary>
        [OneTimeTearDown]
        public void TearDown()
        {
            BrowserFactory.CloseAllDrivers();
        }

        #endregion Shared

        #region Tests

        /// <summary></summary>
        [Test]
        public void HomePageLoad()
        {
            BrowserFactory.GoToPage(HomePage.Url);
            BrowserFactory.WaitForPageLoad(10);
            Assert.IsTrue(Page.Home.LogoImage.Displayed, "homePage.LogoImage.Displayed");
        }

        /// <summary></summary>
        [Test]
        public void HomePageNavigation()
        {
            BrowserFactory.GoToPage(HomePage.Url);

            //Open navigation
            Page.Home.NavToggle.ClickWithJavascriptById();

            //Verify all expected link texts
            List<string> expectedLinkTexts = new List<string>
            {
                "Home",
                "About Us",
                "Pricing + Services",
                "FAQ",
                "News + Notes",
                "Testimonials",
                "Schedule Consultation",
                "Contact Us"
            };

            List<string> actualLinkTexts = Page.Home.GetLinkTexts(Page.Home.NavCollection);
            Assert.AreEqual(expectedLinkTexts, actualLinkTexts);

            //Verify all expected link urls
            List<string> expectedPageUrls = new List<string>
            {
                "https://www.qualitasdigital.com/",
                "https://www.qualitasdigital.com/about-us",
                "https://www.qualitasdigital.com/pricing-services",
                "https://www.qualitasdigital.com/faq",
                "https://www.qualitasdigital.com/news-notes-qualitas",
                "https://www.qualitasdigital.com/testimonials",
                "https://www.qualitasdigital.com/schedule-consultation",
                "https://www.qualitasdigital.com/contact-us"
            };

            List<string> actualPageUrls = Page.Home.GetLinkUrls(Page.Home.NavCollection);
            Assert.AreEqual(expectedPageUrls, actualPageUrls);

            //Verify navigation body text
            const string expectedNavigationBodyText = @"Qualitas Digital brings Software Quality Automation within reach. Our solutions help you bridge the gap between where you are and where you want to be. We help you create Quality Automation programs that scale without the high overhead of a purely manual approach.  Take advantage of a free consultation today.";
            Assert.AreEqual(expectedNavigationBodyText, Page.Home.NavBodyText.GetInnertext());

            //Verify navigation schedule button
            Assert.IsTrue(Page.Home.NavScheduleButton.IsDisplayed(), "Page.Home.NavScheduleButton.IsDisplayed()");
        }

        /// <summary></summary>
        [Test]
        public void HomePageSearch()
        {
            BrowserFactory.GoToPage(HomePage.Url);

            //Open search
            Page.Home.SearchButton.ClickWhenReady();

            //Validate placeholder text of "Search"
            Assert.AreEqual("Search", Page.Home.SearchTextBox.GetAttribute("placeholder"));

            //enter abc
            Page.Home.SearchTextBox.EnterText("abc");

            //Hit enter
            Page.Home.SearchTextBox.SubmitElement();

            //Verify the page update
            Assert.AreEqual("https://www.qualitasdigital.com/search?q=abc", BrowserFactory.GetPageUrl());

            //Verify result of "Your search did not match any documents."
            Assert.AreEqual("Your search did not match any documents.", Page.Home.SearchResultText.GetInnertext());
        }

        /// <summary></summary>
        [Test]
        public void HomePageContent()
        {
            BrowserFactory.GoToPage(HomePage.Url);

            //Validate primary section
            Assert.AreEqual("Putting the Quality in Software Quality Automation", Page.Home.PrimarySectionTitle.GetInnertext());
            Assert.AreEqual("", Page.Home.PrimarySectionImage.GetInnertext());
            Assert.AreEqual("", Page.Home.PrimarySectionBodyText.GetInnertext());
            Assert.AreEqual("", Page.Home.PrimarySectionScheduleButton.GetHref());

            //Validate Our Services section
            Assert.AreEqual("", Page.Home.OurServicesSectionTitle.GetInnertext());
            Assert.AreEqual("", Page.Home.OurServicesSectionBodyText.GetInnertext());
            Assert.AreEqual("", Page.Home.OurServicesSectionLink.GetHref());

            //Validate Our Commitment section
            Assert.AreEqual("", Page.Home.OurCommitmentSectionTitle.GetInnertext());
            Assert.AreEqual("", Page.Home.OurCommitmentSectionBodyText.GetInnertext());
            Assert.AreEqual("", Page.Home.OurCommitmentSectionLink.GetHref());

            //Validate Monthly Articles section
            Assert.AreEqual("", Page.Home.MonthlyArticlesSectionTitle.GetInnertext());
            Assert.AreEqual("", Page.Home.MonthlyArticlesSectionBodyText.GetInnertext());
            Assert.AreEqual("", Page.Home.MonthlyArticlesSectionLink.GetHref());

            //Validate secondary section
            Assert.AreEqual("", Page.Home.SecondarySectionTitle.GetInnertext());
            Assert.AreEqual("", Page.Home.SecondarySectionImage.GetInnertext());
            Assert.AreEqual("", Page.Home.SecondarySectionBodyText.GetInnertext());
            Assert.AreEqual("", Page.Home.SecondarySectionAboutUsButton.GetHref());

            //Validate mid page title
            Assert.AreEqual("", Page.Home.MidPageTitle.GetInnertext());

            //Validate tertiary section
            Assert.AreEqual("", Page.Home.TertiarySectionTitle.GetInnertext());
            Assert.AreEqual("", Page.Home.TertiarySectionImage.GetInnertext());
            Assert.AreEqual("", Page.Home.TertiarySectionBodyText.GetInnertext());
            Assert.AreEqual("", Page.Home.TertiarySectionClientTestimonialsButton.GetHref());

            //Validate footer
            Assert.AreEqual("", Page.Home.FooterTitle.GetInnertext());
            Assert.AreEqual("", Page.Home.FooterScheduleButton.GetInnertext());
            Assert.AreEqual("", Page.Home.GetLinkTexts(Page.Home.FooterLinksCollection));
            Assert.AreEqual("", Page.Home.GetLinkUrls(Page.Home.FooterLinksCollection));
        }

        #endregion Tests
    }
}
