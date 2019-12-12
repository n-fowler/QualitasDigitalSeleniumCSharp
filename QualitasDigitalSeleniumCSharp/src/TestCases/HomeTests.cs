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

        private void SetUp()
        {
            BrowserFactory.InitBrowser(webDriverEnum);
            BrowserFactory.GoToPage(HomePage.Url);
        }

        private void TearDown()
        {
            BrowserFactory.CloseAllDrivers();
        }

        #endregion Shared

        #region Tests

        /// <summary></summary>
        [TestCase()]
        public void HomePageLoad()
        {
            try
            {
                SetUp();
                BrowserFactory.WaitForPageLoad(10);
                Assert.IsTrue(Page.Home.LogoImage.Displayed, "homePage.LogoImage.Displayed");
            }
            finally
            {
                TearDown();
            }
        }

        /// <summary></summary>
        [TestCase()]
        public void HomePageNavigation()
        {
            try
            {
                SetUp();

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

                List<string> actualLinkTexts = Page.Home.GetLinkTexts();
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

                List<string> actualPageUrls = Page.Home.GetLinkUrls();
                Assert.AreEqual(expectedPageUrls, actualPageUrls);

                //Verify navigation body text
                const string expectedNavigationBodyText = @"Qualitas Digital brings Software Quality Automation within reach. Our solutions help you bridge the gap between where you are and where you want to be. We help you create Quality Automation programs that scale without the high overhead of a purely manual approach.  Take advantage of a free consultation today.";
                Assert.AreEqual(expectedNavigationBodyText, Page.Home.NavBodyText.GetInnertext());

                //Verify navigation schedule button
                Assert.IsTrue(Page.Home.NavScheduleButton.IsDisplayed(), "Page.Home.NavScheduleButton.IsDisplayed()");
            }
            finally
            {
                TearDown();
            }
        }

        /// <summary></summary>
        [TestCase()]
        public void HomePageSearch()
        {
            try
            {
                SetUp();

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
            finally
            {
                TearDown();
            }
        }

        /// <summary></summary>
        [TestCase()]
        public void HomePageContent()
        {
            try
            {
                SetUp();
            }
            finally
            {
                TearDown();
            }
        }

        /// <summary></summary>
        [TestCase()]
        public void HomePageLinks()
        {
            try
            {
                SetUp();
            }
            finally
            {
                TearDown();
            }
        }

        #endregion Tests
    }
}
