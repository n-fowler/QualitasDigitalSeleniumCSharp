using OpenQA.Selenium;
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
        public IWebElement LogoImage => driver.FindElement(By.ClassName("logo-image"));

        /// <summary>
        /// Navigation section expansion toggle open
        /// </summary>
        public IWebElement NavToggle => driver.FindElement(By.Id("navToggle"));

        /// <summary>
        /// Navigation section side tray
        /// </summary>
        public IWebElement NavTray => driver.FindElement(By.Id("sideTrayWrapper"));

        /// <summary>
        /// Navigation section parent
        /// </summary>
        public IWebElement NavSection => NavTray.FindElement(By.Id("mainNavigation"));

        /// <summary>
        /// Navigation section link collection
        /// </summary>
        public List<IWebElement> NavCollection => NavSection.FindElements(By.ClassName("nav-link--collection")).ToList();

        /// <summary>
        /// Navigation section body text
        /// </summary>
        public IWebElement NavBodyText => driver.FindElement(By.Id("block-5aa025203dc65c6e55e9"));

        /// <summary>
        /// Navigation section schedule button
        /// </summary>
        public IWebElement NavScheduleButton => driver.FindElement(By.Id("block-d013aff45daaf1868f5b"));

        /// <summary>
        /// Home Page search button
        /// </summary>
        public IWebElement SearchButton => driver.FindElement(By.ClassName("header-search"));

        /// <summary>
        /// Home Page search text box
        /// </summary>
        public IWebElement SearchTextBox => driver.FindElement(By.ClassName("header-search-form-input"));

        /// <summary>
        /// Home Page search result text
        /// </summary>
        public IWebElement SearchResultText => driver.FindElement(By.ClassName("sqs-search-page-notice"));

        /// <summary>
        /// Primary section title text
        /// </summary>
        public IWebElement PrimarySectionTitle => driver.FindElement(By.XPath("//*[@id='block-a50c2484babd68ea94ea']/div/h1"));

        /// <summary>
        /// Primary section Image
        /// </summary>
        public IWebElement PrimarySectionImage => driver.FindElements(By.CssSelector("div[id^='yui_3_17_2_1'][id$='68']")).First().FindElement(By.TagName("img"));

        /// <summary>
        /// Primary section body text
        /// </summary>
        public IWebElement PrimarySectionBodyText => driver.FindElement(By.XPath("//*[@id='block-f99a4c371dd091271df7']/div/p"));

        /// <summary>
        /// Primary section schedule a free consultation button
        /// </summary>
        public IWebElement PrimarySectionScheduleButton => driver.FindElements(By.CssSelector("div[id^='yui_3_17_2_1'][id$='134']")).First().FindElement(By.TagName("a"));

        /// <summary>
        /// Our services section title
        /// </summary>
        public IWebElement OurServicesSectionTitle => driver.FindElement(By.XPath("//*[@id='block-9b7a80e3167ce3d3995a']/div/h2"));

        /// <summary>
        /// Our services section body text
        /// </summary>
        public IWebElement OurServicesSectionBodyText => driver.FindElement(By.XPath("//*[@id='block-9b7a80e3167ce3d3995a']/div/p[1]"));

        /// <summary>
        /// Our services section link
        /// </summary>
        public IWebElement OurServicesSectionLink => driver.FindElement(By.XPath("//*[@id='block-9b7a80e3167ce3d3995a']/div/p[2]/a"));

        /// <summary>
        /// Our commitment section title
        /// </summary>
        public IWebElement OurCommitmentSectionTitle => driver.FindElement(By.XPath("//*[@id='block-2429c8770ce968f657a8']/div/h2"));

        /// <summary>
        /// Our commitment section body text
        /// </summary>
        public IWebElement OurCommitmentSectionBodyText => driver.FindElement(By.XPath("//*[@id='block-2429c8770ce968f657a8']/div/p[1]"));

        /// <summary>
        /// Our commitment section link
        /// </summary>
        public IWebElement OurCommitmentSectionLink => driver.FindElement(By.XPath("//*[@id='block-2429c8770ce968f657a8']/div/p[2]/a"));        

        /// <summary>
        /// Monthly articles section title
        /// </summary>
        public IWebElement MonthlyArticlesSectionTitle => driver.FindElement(By.XPath("//*[@id='block-5c47022b53cd95d3d039']/div/h2"));

        /// <summary>
        /// Monthly articles section body text
        /// </summary>
        public IWebElement MonthlyArticlesSectionBodyText => driver.FindElement(By.XPath("//*[@id='block-5c47022b53cd95d3d039']/div/p[1]"));

        /// <summary>
        /// Monthly articles section link
        /// </summary>
        public IWebElement MonthlyArticlesSectionLink => driver.FindElement(By.XPath("//*[@id='block-5c47022b53cd95d3d039']/div/p[2]/a"));

        /// <summary>
        /// Secondary section
        /// </summary>
        public IWebElement SecondarySection => driver.FindElement(By.Id("block-98c1d846f408c7fae1f8"));

        /// <summary>
        /// Secondary section title
        /// </summary>
        public IWebElement SecondarySectionTitle => SecondarySection.FindElement(By.ClassName("image-title-wrapper"));

        /// <summary>
        /// Secondary section image
        /// </summary>
        public IWebElement SecondarySectionImage => SecondarySection.FindElements(By.CssSelector("div[id^='yui_3_17_2_1'][id$='89']")).First().FindElement(By.TagName("img"));

        /// <summary>
        /// Secondary section body text
        /// </summary>
        public IWebElement SecondarySectionBodyText => SecondarySection.FindElement(By.ClassName("image-subtitle-wrapper"));

        /// <summary>
        /// Secondary section about us button
        /// </summary>
        public IWebElement SecondarySectionAboutUsButton => SecondarySection.FindElement(By.ClassName("image-button-wrapper")).FindElement(By.TagName("div")).FindElement(By.TagName("div")).FindElement(By.TagName("a"));

        /// <summary>
        /// Mid page title
        /// </summary>
        public IWebElement MidPageTitle => driver.FindElement(By.Id("block-036c44c036644d931bc6")).FindElement(By.TagName("div")).FindElement(By.TagName("h1"));

        /// <summary>
        /// Tertiary section
        /// </summary>
        public IWebElement TertiarySection => driver.FindElement(By.Id("block-6863d26509d4596a922e"));

        /// <summary>
        /// Tertiary section title
        /// </summary>
        public IWebElement TertiarySectionTitle => TertiarySection.FindElement(By.ClassName("image-title-wrapper"));

        /// <summary>
        /// Tertiary section image
        /// </summary>
        public IWebElement TertiarySectionImage => TertiarySection.FindElements(By.CssSelector("div[id^='yui_3_17_2_1'][id$='107']")).First().FindElement(By.TagName("img"));

        /// <summary>
        /// Tertiary section body text
        /// </summary>
        public IWebElement TertiarySectionBodyText => TertiarySection.FindElement(By.ClassName("image-subtitle-wrapper"));

        /// <summary>
        /// Tertiary section client testimonials button
        /// </summary>
        public IWebElement TertiarySectionClientTestimonialsButton => TertiarySection.FindElement(By.ClassName("image-button-wrapper")).FindElement(By.TagName("div")).FindElement(By.TagName("div")).FindElement(By.TagName("a"));

        /// <summary>
        /// Footer title
        /// </summary>
        public IWebElement FooterTitle => driver.FindElement(By.Id("block-5694a211d5b58deead3e")).FindElement(By.TagName("div")).FindElement(By.TagName("h1"));

        /// <summary>
        /// Footer schedule button
        /// </summary>
        public IWebElement FooterScheduleButton => driver.FindElements(By.CssSelector("div[id^='yui_3_17_2_1'][id$='141']")).First().FindElement(By.TagName("a"));

        /// <summary>
        /// Footer section navigation
        /// </summary>
        public IWebElement FooterNav => driver.FindElement(By.Id("footerNavWrapper"));

        /// <summary>
        /// Footer links section
        /// </summary>
        public IWebElement FooterLinksSection => FooterNav.FindElement(By.Id("mainNavigation"));

        /// <summary>
        /// Footer links collection
        /// </summary>
        public List<IWebElement> FooterLinksCollection => FooterLinksSection.FindElements(By.ClassName("nav-link--collection")).ToList();

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
                string text = webElement.FindElement(By.TagName("a")).FindElement(By.TagName("span")).GetAttribute("innerText");

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
                string text = webElement.FindElement(By.TagName("a")).GetAttribute("href");

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
