using NUnit.Framework;
using QualitasDigitalSeleniumCSharp.PageObjects;
using QualitasDigitalSeleniumCSharp.src.TestCases;
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
    public class HomeTests : BaseTest
    {

        #region Tests

        /// <summary></summary>
        [Test]
        public void HomePageLoad()
        {
            BrowserFactory.GoToPage(HomePage.Url);
            BrowserFactory.WaitForPageLoad(10);
            Assert.IsTrue(Page.Home.LogoImage.Displayed, "Page.Home.LogoImage.Displayed");
        }

        /// <summary></summary>
        [Test]
        public void HomePageNavigation()
        {
            BrowserFactory.GoToPage(HomePage.Url);
            BrowserFactory.WaitForPageLoad(10);

            //Open navigation
            Page.Home.NavToggle.Click();

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
            Assert.AreEqual(expectedNavigationBodyText, Page.Home.NavBodyText.GetAttribute("innerText"));

            //Verify navigation schedule button
            Assert.IsTrue(Page.Home.NavScheduleButton.Displayed, "Page.Home.NavScheduleButton.Displayed");
        }

        /// <summary></summary>
        [Test]
        public void HomePageSearch()
        {
            BrowserFactory.GoToPage(HomePage.Url);
            BrowserFactory.WaitForPageLoad(10);

            //Open search
            Page.Home.SearchButton.Click();

            //Validate placeholder text of "Search"
            Assert.AreEqual("Search", Page.Home.SearchTextBox.GetAttribute("placeholder"));

            //enter abc
            Page.Home.SearchTextBox.SendKeys("abc");

            //Hit enter
            Page.Home.SearchTextBox.Submit();

            //Verify the page update
            Assert.AreEqual("https://www.qualitasdigital.com/search?q=abc", BrowserFactory.GetPageUrl());

            //Verify result of "Your search did not match any documents."
            Assert.AreEqual("Your search did not match any documents.", Page.Home.SearchResultText.GetAttribute("innerText"));
        }

        /// <summary></summary>
        [Test]
        public void HomePageContent()
        {
            BrowserFactory.GoToPage(HomePage.Url);
            BrowserFactory.WaitForPageLoad(10);

            //Validate primary section
            Assert.AreEqual(HomePageTestData.PrimarySectionTitle, Page.Home.PrimarySectionTitle.GetAttribute("innerText"));
            StringAssert.Contains(HomePageTestData.PrimarySectionImageSrc, Page.Home.PrimarySectionImage.GetAttribute("src"));
            Assert.AreEqual(HomePageTestData.PrimarySectionBodyText, Page.Home.PrimarySectionBodyText.GetAttribute("innerText"));
            Assert.AreEqual(HomePageTestData.PrimarySectionScheduleButtonLink, Page.Home.PrimarySectionScheduleButton.GetAttribute("href"));

            //Validate Our Services section
            Assert.AreEqual(HomePageTestData.OurServicesSectionTitle, Page.Home.OurServicesSectionTitle.GetAttribute("innerText"));
            Assert.AreEqual(HomePageTestData.OurServicesSectionBodyText, Page.Home.OurServicesSectionBodyText.GetAttribute("innerText"));
            Assert.AreEqual(HomePageTestData.OurServicesSectionLink, Page.Home.OurServicesSectionLink.GetAttribute("href"));

            //Validate Our Commitment section
            Assert.AreEqual(HomePageTestData.OurCommitmentSectionTitle, Page.Home.OurCommitmentSectionTitle.GetAttribute("innerText"));
            Assert.AreEqual(HomePageTestData.OurCommitmentSectionBodyText, Page.Home.OurCommitmentSectionBodyText.GetAttribute("innerText"));
            Assert.AreEqual(HomePageTestData.OurCommitmentSectionLink, Page.Home.OurCommitmentSectionLink.GetAttribute("href"));

            //Validate Monthly Articles section
            Assert.AreEqual(HomePageTestData.MonthlyArticlesSectionTitle, Page.Home.MonthlyArticlesSectionTitle.GetAttribute("innerText"));
            Assert.AreEqual(HomePageTestData.MonthlyArticlesSectionBodyText, Page.Home.MonthlyArticlesSectionBodyText.GetAttribute("innerText"));
            Assert.AreEqual(HomePageTestData.MonthlyArticlesSectionLink, Page.Home.MonthlyArticlesSectionLink.GetAttribute("href"));

            //Validate secondary section
            Assert.AreEqual(HomePageTestData.SecondarySectionTitle, Page.Home.SecondarySectionTitle.GetAttribute("innerText"));
            StringAssert.Contains(HomePageTestData.SecondarySectionImageSrc, Page.Home.SecondarySectionImage.GetAttribute("src"));
            Assert.AreEqual(HomePageTestData.SecondarySectionBodyText, Page.Home.SecondarySectionBodyText.GetAttribute("innerText").Replace("\r", "").Replace("\n", ""));
            Assert.AreEqual(HomePageTestData.SecondarySectionAboutUsButtonLink, Page.Home.SecondarySectionAboutUsButton.GetAttribute("href"));

            //Validate mid page title
            Assert.AreEqual(HomePageTestData.MidPageTitle, Page.Home.MidPageTitle.GetAttribute("innerText"));

            //Validate tertiary section
            Assert.AreEqual(HomePageTestData.TertiarySectionTitle, Page.Home.TertiarySectionTitle.GetAttribute("innerText"));
            StringAssert.Contains(HomePageTestData.TertiarySectionImageSrc, Page.Home.TertiarySectionImage.GetAttribute("src"));
            Assert.AreEqual(HomePageTestData.TertiarySectionBodyText, Page.Home.TertiarySectionBodyText.GetAttribute("innerText"));
            Assert.AreEqual(HomePageTestData.TertiarySectionClientTestimonialsButtonLink, Page.Home.TertiarySectionClientTestimonialsButton.GetAttribute("href"));

            //Validate footer
            Assert.AreEqual(HomePageTestData.FooterTitle, Page.Home.FooterTitle.GetAttribute("innerText"));
            Assert.AreEqual(HomePageTestData.FooterScheduleButtonLink, Page.Home.FooterScheduleButton.GetAttribute("href"));

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
