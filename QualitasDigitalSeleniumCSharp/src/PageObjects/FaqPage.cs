using OpenQA.Selenium;
using QualitasDigitalSeleniumCSharp.Extensions;
using QualitasDigitalSeleniumCSharp.WrapperFactory;
using System.Linq;

namespace QualitasDigitalSeleniumCSharp.PageObjects
{
    /// <summary>
    /// The Faq Page Object
    /// </summary>
    public class FaqPage
    {
        private IWebDriver driver = BrowserFactory.Driver;

        /// <summary>
        /// Faq Url
        /// </summary>
        public const string Url = "https://www.qualitasdigital.com/faq";

        #region Elements

        /// <summary>
        /// The Logo Image element
        /// </summary>
        public IWebElement LogoImage => driver.FindElementByClassName("logo-image");

        /// <summary>
        /// The Header section element
        /// </summary>
        public IWebElement HeaderSection => driver.FindElementById("block-0872d1f64aa73dc210a0");

        /// <summary>
        /// The Header Title element
        /// </summary>
        public IWebElement HeaderTitle => HeaderSection.FindElementByTagName("div").FindElementByTagName("h1");

        /// <summary>
        /// The Left Section element
        /// </summary>
        public IWebElement LeftSection => driver.FindElementById("block-5a5c2d60498a7ac2f90c");

        /// <summary>
        /// The Left Subtitle element
        /// </summary>
        public IWebElement Subtitle => LeftSection.FindElementByTagName("div").FindElementByTagName("h2");

        /// <summary>
        /// The Our Commitment Link element
        /// </summary>
        public IWebElement ContactUsLink => LeftSection.FindElementByTagName("div").FindElementsByTagName("p").ToList()[0].FindElementsByTagName("a").ToList()[0];

        /// <summary>
        /// The Center Section element
        /// </summary>
        public IWebElement CenterSection => driver.FindElementById("block-07ad9bb3be93b9c67b17");

        /// <summary>
        /// The Title One element
        /// </summary>
        public IWebElement TitleOne => CenterSection.FindElementByTagName("div").FindElementsByTagName("h3").ToList()[0];

        /// <summary>
        /// The Body Text One element
        /// </summary>
        public IWebElement BodyTextOne => CenterSection.FindElementByTagName("div").FindElementsByTagName("p").ToList()[0];

        /// <summary>
        /// The Title One element
        /// </summary>
        public IWebElement TitleTwo => CenterSection.FindElementByTagName("div").FindElementsByTagName("h3").ToList()[1];

        /// <summary>
        /// The Body Text One element
        /// </summary>
        public IWebElement BodyTextTwo => CenterSection.FindElementByTagName("div").FindElementsByTagName("p").ToList()[1];

        /// <summary>
        /// The Title One element
        /// </summary>
        public IWebElement TitleThree => CenterSection.FindElementByTagName("div").FindElementsByTagName("h3").ToList()[2];

        /// <summary>
        /// The Body Text One element
        /// </summary>
        public IWebElement BodyTextThree => CenterSection.FindElementByTagName("div").FindElementsByTagName("p").ToList()[2];

        /// <summary>
        /// The Title One element
        /// </summary>
        public IWebElement TitleFour => CenterSection.FindElementByTagName("div").FindElementsByTagName("h3").ToList()[3];

        /// <summary>
        /// The Body Text One element
        /// </summary>
        public IWebElement BodyTextFour => CenterSection.FindElementByTagName("div").FindElementsByTagName("p").ToList()[3];

        /// <summary>
        /// The Title One element
        /// </summary>
        public IWebElement TitleFive => CenterSection.FindElementByTagName("div").FindElementsByTagName("h3").ToList()[4];

        /// <summary>
        /// The Body Text One element
        /// </summary>
        public IWebElement BodyTextFive => CenterSection.FindElementByTagName("div").FindElementsByTagName("p").ToList()[4];

        /// <summary>
        /// The Title One element
        /// </summary>
        public IWebElement TitleSix => CenterSection.FindElementByTagName("div").FindElementsByTagName("h3").ToList()[5];

        /// <summary>
        /// The Body Text One element
        /// </summary>
        public IWebElement BodyTextSix => CenterSection.FindElementByTagName("div").FindElementsByTagName("p").ToList()[5];

        /// <summary>
        /// The Title One element
        /// </summary>
        public IWebElement TitleSeven => CenterSection.FindElementByTagName("div").FindElementsByTagName("h3").ToList()[6];

        /// <summary>
        /// The Body Text One element
        /// </summary>
        public IWebElement BodyTextSeven => CenterSection.FindElementByTagName("div").FindElementsByTagName("p").ToList()[6];

        /// <summary>
        /// The Right Section element
        /// </summary>
        public IWebElement RightSection => driver.FindElementById("block-156845d943225c44b8dd");

        /// <summary>
        /// The Title One element
        /// </summary>
        public IWebElement TitleEight => RightSection.FindElementByTagName("div").FindElementsByTagName("h3").ToList()[0];

        /// <summary>
        /// The Body Text One element
        /// </summary>
        public IWebElement BodyTextEight => RightSection.FindElementByTagName("div").FindElementsByTagName("p").ToList()[0];

        /// <summary>
        /// The Title One element
        /// </summary>
        public IWebElement TitleNine => RightSection.FindElementByTagName("div").FindElementsByTagName("h3").ToList()[1];

        /// <summary>
        /// The Body Text One element
        /// </summary>
        public IWebElement BodyTextNine => RightSection.FindElementByTagName("div").FindElementsByTagName("p").ToList()[1];

        /// <summary>
        /// The Title One element
        /// </summary>
        public IWebElement TitleTen => RightSection.FindElementByTagName("div").FindElementsByTagName("h3").ToList()[2];

        /// <summary>
        /// The Body Text One element
        /// </summary>
        public IWebElement BodyTextTen => RightSection.FindElementByTagName("div").FindElementsByTagName("p").ToList()[2];

        /// <summary>
        /// The Title One element
        /// </summary>
        public IWebElement TitleEleven => RightSection.FindElementByTagName("div").FindElementsByTagName("h3").ToList()[3];

        /// <summary>
        /// The Body Text One element
        /// </summary>
        public IWebElement BodyTextEleven => RightSection.FindElementByTagName("div").FindElementsByTagName("p").ToList()[3];

        /// <summary>
        /// The Title One element
        /// </summary>
        public IWebElement TitleTwelve => RightSection.FindElementByTagName("div").FindElementsByTagName("h3").ToList()[4];

        /// <summary>
        /// The Body Text One element
        /// </summary>
        public IWebElement BodyTextTwelve => RightSection.FindElementByTagName("div").FindElementsByTagName("p").ToList()[4];

        /// <summary>
        /// The Title One element
        /// </summary>
        public IWebElement TitleThirteen => RightSection.FindElementByTagName("div").FindElementsByTagName("h3").ToList()[5];

        /// <summary>
        /// The Body Text One element
        /// </summary>
        public IWebElement BodyTextThirteen => RightSection.FindElementByTagName("div").FindElementsByTagName("p").ToList()[5];

        /// <summary>
        /// The Title One element
        /// </summary>
        public IWebElement TitleFourteen => RightSection.FindElementByTagName("div").FindElementsByTagName("h3").ToList()[6];

        /// <summary>
        /// The Body Text One element
        /// </summary>
        public IWebElement BodyTextFourteen => RightSection.FindElementByTagName("div").FindElementsByTagName("p").ToList()[6];

        /// <summary>
        /// The Title One element
        /// </summary>
        public IWebElement TitleFifteen => RightSection.FindElementByTagName("div").FindElementsByTagName("h3").ToList()[7];

        /// <summary>
        /// The Body Text One element
        /// </summary>
        public IWebElement BodyTextFifteen => RightSection.FindElementByTagName("div").FindElementsByTagName("p").ToList()[7];

        #endregion Elements
    }
}
