﻿using OpenQA.Selenium;
using QualitasDigitalSeleniumCSharp.Extensions;
using QualitasDigitalSeleniumCSharp.src.LocalConfiguration;
using QualitasDigitalSeleniumCSharp.WrapperFactory;
using System.Collections.Generic;
using System.Linq;

namespace QualitasDigitalSeleniumCSharp.PageObjects
{
    /// <summary>
    /// The HomePage Page Object
    /// </summary>
    public class HomePage
    {
        private IWebDriver driver = BrowserFactory.Driver;

        /// <summary>
        /// The HomePage Url
        /// </summary>
        public const string Url = "https://www.qualitasdigital.com";

        #region Elements

        /// <summary>
        /// The Logo Image element
        /// </summary>
        public IWebElement LogoImage => driver.FindElementByClassName("logo-image");

        /// <summary>
        /// Navigation section expansion toggle open
        /// </summary>
        public IWebElement NavToggle => driver.FindElementById("navToggle");

        /// <summary>
        /// Navigation section side tray
        /// </summary>
        public IWebElement NavTray => driver.FindElementById("sideTrayWrapper");

        /// <summary>
        /// Navigation section parent
        /// </summary>
        public IWebElement NavSection => NavTray.FindElementById("mainNavigation");

        /// <summary>
        /// Navigation section link collection
        /// </summary>
        public List<IWebElement> NavCollection => NavSection.FindElementsByClassName("nav-link--collection").ToList();

        /// <summary>
        /// Navigation section body text
        /// </summary>
        public IWebElement NavBodyText => driver.FindElementById("block-5aa025203dc65c6e55e9");

        /// <summary>
        /// Navigation section schedule button
        /// </summary>
        public IWebElement NavScheduleButton => driver.FindElementById("block-d013aff45daaf1868f5b");

        /// <summary>
        /// Home Page search button
        /// </summary>
        public IWebElement SearchButton => driver.FindElementByClassName("header-search");

        /// <summary>
        /// Home Page search text box
        /// </summary>
        public IWebElement SearchTextBox => driver.FindElementByClassName("header-search-form-input");

        /// <summary>
        /// Home Page search result text
        /// </summary>
        public IWebElement SearchResultText => driver.FindElementByClassName("sqs-search-page-notice");

        /// <summary>
        /// Primary section title text
        /// </summary>
        public IWebElement PrimarySectionTitle => driver.FindElementById("block-a50c2484babd68ea94ea").FindElementByTagName("div").FindElementByTagName("h1");

        /// <summary>
        /// Primary section Image
        /// </summary>
        public IWebElement PrimarySectionImage => driver.GetElementsWithTagAndAttributeStartAndEndingWithValues("div", "id", Configuration.SitePrefix, "66").First().FindElementByTagName("img");

        /// <summary>
        /// Primary section body text
        /// </summary>
        public IWebElement PrimarySectionBodyText => driver.FindElementById("block-f99a4c371dd091271df7").FindElementByTagName("div").FindElementByTagName("p");

        /// <summary>
        /// Primary section schedule a free consultation button
        /// </summary>
        public IWebElement PrimarySectionScheduleButton => driver.GetElementsWithTagAndAttributeStartAndEndingWithValues("div", "id", Configuration.SitePrefix, "132").First().FindElementByTagName("a");

        /// <summary>
        /// Our services section
        /// </summary>
        public IWebElement OurServicesSection => driver.FindElementById("block-9b7a80e3167ce3d3995a");

        /// <summary>
        /// Our services section title
        /// </summary>
        public IWebElement OurServicesSectionTitle => OurServicesSection.FindElementByTagName("div").FindElementByTagName("h2");

        /// <summary>
        /// Our services section body text
        /// </summary>
        public IWebElement OurServicesSectionBodyText => OurServicesSection.FindElementByTagName("div").FindElementsByTagName("p").ToList()[0];

        /// <summary>
        /// Our services section link
        /// </summary>
        public IWebElement OurServicesSectionLink => OurServicesSection.FindElementByTagName("div").FindElementsByTagName("p").ToList()[1].FindElementByTagName("a");

        /// <summary>
        /// Our commitment section
        /// </summary>
        public IWebElement OurCommitmentSection => driver.FindElementById("block-2429c8770ce968f657a8");

        /// <summary>
        /// Our commitment section title
        /// </summary>
        public IWebElement OurCommitmentSectionTitle => OurCommitmentSection.FindElementByTagName("div").FindElementByTagName("h2");

        /// <summary>
        /// Our commitment section body text
        /// </summary>
        public IWebElement OurCommitmentSectionBodyText => OurCommitmentSection.FindElementByTagName("div").FindElementsByTagName("p").ToList()[0];

        /// <summary>
        /// Our commitment section link
        /// </summary>
        public IWebElement OurCommitmentSectionLink => OurCommitmentSection.FindElementByTagName("div").FindElementsByTagName("p").ToList()[1].FindElementByTagName("a");

        /// <summary>
        /// Monthly articles section
        /// </summary>
        public IWebElement MonthlyArticlesSection => driver.FindElementById("block-5c47022b53cd95d3d039");

        /// <summary>
        /// Monthly articles section title
        /// </summary>
        public IWebElement MonthlyArticlesSectionTitle => MonthlyArticlesSection.FindElementByTagName("div").FindElementByTagName("h2");

        /// <summary>
        /// Monthly articles section body text
        /// </summary>
        public IWebElement MonthlyArticlesSectionBodyText => MonthlyArticlesSection.FindElementByTagName("div").FindElementsByTagName("p").ToList()[0];

        /// <summary>
        /// Monthly articles section link
        /// </summary>
        public IWebElement MonthlyArticlesSectionLink => MonthlyArticlesSection.FindElementByTagName("div").FindElementsByTagName("p").ToList()[1].FindElementByTagName("a");

        /// <summary>
        /// Secondary section
        /// </summary>
        public IWebElement SecondarySection => driver.FindElementById("block-98c1d846f408c7fae1f8");

        /// <summary>
        /// Secondary section title
        /// </summary>
        public IWebElement SecondarySectionTitle => SecondarySection.FindElementByClassName("image-title-wrapper");

        /// <summary>
        /// Secondary section image
        /// </summary>
        public IWebElement SecondarySectionImage => SecondarySection.GetElementsWithTagAndAttributeStartAndEndingWithValues("div", "id", Configuration.SitePrefix, "87").First().FindElementByTagName("img");

        /// <summary>
        /// Secondary section body text
        /// </summary>
        public IWebElement SecondarySectionBodyText => SecondarySection.FindElementByClassName("image-subtitle-wrapper");

        /// <summary>
        /// Secondary section about us button
        /// </summary>
        public IWebElement SecondarySectionAboutUsButton => SecondarySection.FindElementByClassName("image-button-wrapper").FindElementByTagName("div").FindElementByTagName("div").FindElementByTagName("a");

        /// <summary>
        /// Mid page title
        /// </summary>
        public IWebElement MidPageTitle => driver.FindElementById("block-036c44c036644d931bc6").FindElementByTagName("div").FindElementByTagName("h1");

        /// <summary>
        /// Tertiary section
        /// </summary>
        public IWebElement TertiarySection => driver.FindElementById("block-6863d26509d4596a922e");

        /// <summary>
        /// Tertiary section title
        /// </summary>
        public IWebElement TertiarySectionTitle => TertiarySection.FindElementByClassName("image-title-wrapper");

        /// <summary>
        /// Tertiary section image
        /// </summary>
        public IWebElement TertiarySectionImage => TertiarySection.GetElementsWithTagAndAttributeStartAndEndingWithValues("div", "id", Configuration.SitePrefix, "105").First().FindElementByTagName("img");

        /// <summary>
        /// Tertiary section body text
        /// </summary>
        public IWebElement TertiarySectionBodyText => TertiarySection.FindElementByClassName("image-subtitle-wrapper");

        /// <summary>
        /// Tertiary section client testimonials button
        /// </summary>
        public IWebElement TertiarySectionClientTestimonialsButton => TertiarySection.FindElementByClassName("image-button-wrapper").FindElementByTagName("div").FindElementByTagName("div").FindElementByTagName("a");

        /// <summary>
        /// Footer title
        /// </summary>
        public IWebElement FooterTitle => driver.FindElementById("block-5694a211d5b58deead3e").FindElementByTagName("div").FindElementByTagName("h1");

        /// <summary>
        /// Footer schedule button
        /// </summary>
        public IWebElement FooterScheduleButton => driver.GetElementsWithTagAndAttributeStartAndEndingWithValues("div", "id", Configuration.SitePrefix, "139").First().FindElementByTagName("a");

        /// <summary>
        /// Footer section navigation
        /// </summary>
        public IWebElement FooterNav => driver.FindElementById("footerNavWrapper");

        /// <summary>
        /// Footer links section
        /// </summary>
        public IWebElement FooterLinksSection => FooterNav.FindElementById("mainNavigation");

        /// <summary>
        /// Footer links collection
        /// </summary>
        public List<IWebElement> FooterLinksCollection => FooterLinksSection.FindElementsByClassName("nav-link--collection").ToList();

        #endregion Elements

        #region Methods

        /// <summary>
        /// Navigation section get link text
        /// </summary>
        /// <returns></returns>
        public List<string> GetLinkTexts(List<IWebElement> linkElements)
        {
            List<string> navLinkTexts = new List<string>();

            foreach (IWebElement webElement in linkElements)
            {
                string text = webElement.FindElementByTagName("a").FindElementByTagName("span").GetInnertext();

                if (!string.IsNullOrEmpty(text))
                {
                    navLinkTexts.Add(text);
                }
            }

            return navLinkTexts;
        }

        /// <summary>
        /// Navigation Section get link urls
        /// </summary>
        /// <returns></returns>
        public List<string> GetLinkUrls(List<IWebElement> linkElements)
        {
            List<string> navLinkUrls = new List<string>();

            foreach (IWebElement webElement in linkElements)
            {
                string text = webElement.FindElementByTagName("a").GetHref();

                if (!string.IsNullOrEmpty(text))
                {
                    navLinkUrls.Add(text);
                }
            }

            return navLinkUrls;
        }

        #endregion Methods
    }
}
