﻿using NUnit.Framework;
using QualitasDigitalSeleniumCSharp.Extensions;
using QualitasDigitalSeleniumCSharp.PageObjects;
using QualitasDigitalSeleniumCSharp.src.TestData;
using QualitasDigitalSeleniumCSharp.WrapperFactory;
using System;
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
        public void HomePageLoad()
        {
            BrowserFactory.GoToPage(HomePage.Url);
            BrowserFactory.WaitForPageLoad(10);
            Assert.IsFalse(Page.Home.LogoImage.Displayed, "homePage.LogoImage.Displayed");
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
            Assert.AreEqual(HomePageTestData.PrimarySectionTitle, Page.Home.PrimarySectionTitle.GetInnertext());
            Assert.AreEqual(HomePageTestData.PrimarySectionImageSrc, Page.Home.PrimarySectionImage.GetSrc());
            Assert.AreEqual(HomePageTestData.PrimarySectionBodyText, Page.Home.PrimarySectionBodyText.GetInnertext());
            Assert.AreEqual(HomePageTestData.PrimarySectionScheduleButtonLink, Page.Home.PrimarySectionScheduleButton.GetHref());

            //Validate Our Services section
            Assert.AreEqual(HomePageTestData.OurServicesSectionTitle, Page.Home.OurServicesSectionTitle.GetInnertext());
            Assert.AreEqual(HomePageTestData.OurServicesSectionBodyText, Page.Home.OurServicesSectionBodyText.GetInnertext());
            Assert.AreEqual(HomePageTestData.OurServicesSectionLink, Page.Home.OurServicesSectionLink.GetHref());

            //Validate Our Commitment section
            Assert.AreEqual(HomePageTestData.OurCommitmentSectionTitle, Page.Home.OurCommitmentSectionTitle.GetInnertext());
            Assert.AreEqual(HomePageTestData.OurCommitmentSectionBodyText, Page.Home.OurCommitmentSectionBodyText.GetInnertext());
            Assert.AreEqual(HomePageTestData.OurCommitmentSectionLink, Page.Home.OurCommitmentSectionLink.GetHref());

            //Validate Monthly Articles section
            Assert.AreEqual(HomePageTestData.MonthlyArticlesSectionTitle, Page.Home.MonthlyArticlesSectionTitle.GetInnertext());
            Assert.AreEqual(HomePageTestData.MonthlyArticlesSectionBodyText, Page.Home.MonthlyArticlesSectionBodyText.GetInnertext());
            Assert.AreEqual(HomePageTestData.MonthlyArticlesSectionLink, Page.Home.MonthlyArticlesSectionLink.GetHref());

            //Validate secondary section
            Assert.AreEqual(HomePageTestData.SecondarySectionTitle, Page.Home.SecondarySectionTitle.GetInnertext());
            Assert.AreEqual(HomePageTestData.SecondarySectionImageSrc, Page.Home.SecondarySectionImage.GetSrc());
            Assert.AreEqual(HomePageTestData.SecondarySectionBodyText, Page.Home.SecondarySectionBodyText.GetInnertext().Replace("\r", "").Replace("\n", ""));
            Assert.AreEqual(HomePageTestData.SecondarySectionAboutUsButtonLink, Page.Home.SecondarySectionAboutUsButton.GetHref());

            //Validate mid page title
            Assert.AreEqual(HomePageTestData.MidPageTitle, Page.Home.MidPageTitle.GetInnertext());

            //Validate tertiary section
            Assert.AreEqual(HomePageTestData.TertiarySectionTitle, Page.Home.TertiarySectionTitle.GetInnertext());
            Assert.AreEqual(HomePageTestData.TertiarySectionImageSrc, Page.Home.TertiarySectionImage.GetSrc());
            Assert.AreEqual(HomePageTestData.TertiarySectionBodyText, Page.Home.TertiarySectionBodyText.GetInnertext());
            Assert.AreEqual(HomePageTestData.TertiarySectionClientTestimonialsButtonLink, Page.Home.TertiarySectionClientTestimonialsButton.GetHref());

            //Validate footer
            Assert.AreEqual(HomePageTestData.FooterTitle, Page.Home.FooterTitle.GetInnertext());
            Assert.AreEqual(HomePageTestData.FooterScheduleButtonLink, Page.Home.FooterScheduleButton.GetHref());

            //Verify footer expected link texts
            List<string> expectedLinkTexts = new List<string>
            {
                "Our Commitment",
                "Terms + Conditions"
            };

            List<string> actualLinkTexts = Page.Home.GetLinkTexts(Page.Home.FooterLinksCollection);
            Assert.AreEqual(expectedLinkTexts, actualLinkTexts);

            //Verify footer expected link urls
            List<string> expectedPageUrls = new List<string>
            {
                "https://www.qualitasdigital.com/our-commitment",
                "https://www.qualitasdigital.com/terms-conditions"
            };

            List<string> actualPageUrls = Page.Home.GetLinkUrls(Page.Home.FooterLinksCollection);
            Assert.AreEqual(expectedPageUrls, actualPageUrls);
        }

        #endregion Tests
    }
}
