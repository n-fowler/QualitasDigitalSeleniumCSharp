using NUnit.Framework;
using OpenQA.Selenium;
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

                List<string> expectedPageUrls = new List<string>
                {
                    "https://qualitasdigital.com",
                    "https://www.qualitasdigital.com/about-us",
                    "https://www.qualitasdigital.com/pricing-services",
                    "https://www.qualitasdigital.com/faq",
                    "https://www.qualitasdigital.com/news-notes-qualitas",
                    "https://www.qualitasdigital.com/testimonials",
                    "https://www.qualitasdigital.com/schedule-consultation",
                    "https://www.qualitasdigital.com/contact-us"
                };

                List<string> actualPageUrls = new List<string>();

                //Click all links and validate navigation
                foreach (IWebElement webElement in Page.Home.NavCollection)
                {
                    //Click the nav link
                    webElement.ClickWhenReady();

                    //Store the updated page url
                    actualPageUrls.Add(BrowserFactory.GetPageUrl());

                    //Open the navigation
                    Page.Home.NavToggle.ClickWithJavascriptById();
                }

                Assert.AreEqual(expectedPageUrls, actualPageUrls);
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
