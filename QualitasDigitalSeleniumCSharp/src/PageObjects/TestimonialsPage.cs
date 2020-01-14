using OpenQA.Selenium;
using QualitasDigitalSeleniumCSharp.Extensions;
using QualitasDigitalSeleniumCSharp.WrapperFactory;

namespace QualitasDigitalSeleniumCSharp.PageObjects
{
    /// <summary>
    /// The Testimonials Page Object
    /// </summary>
    public class TestimonialsPage
    {
        private IWebDriver driver = BrowserFactory.Driver;

        /// <summary>
        /// The Pricing and Services Url
        /// </summary>
        public const string Url = "https://www.qualitasdigital.com/testimonials";

        #region Elements

        /// <summary>
        /// The Logo Image element
        /// </summary>
        public IWebElement LogoImage => driver.FindElementByClassName("logo-image");

        /// <summary>
        /// Highlighted Review Section element
        /// </summary>
        public IWebElement HighlightedReviewSection => driver.FindElementById("block-af6af313004c75816482");

        /// <summary>
        /// Highlighted Review Content element
        /// </summary>
        public IWebElement HighlightedReviewContent => HighlightedReviewSection.FindElementByTagName("div").FindElementByTagName("figure").FindElementByTagName("blockquote");

        /// <summary>
        /// Highlighted Review Author element
        /// </summary>
        public IWebElement HighlightedReviewAuthor => HighlightedReviewSection.FindElementByTagName("div").FindElementByTagName("figure").FindElementByTagName("figcaption");

        /// <summary>
        /// MidPage Title Section element
        /// </summary>
        public IWebElement MidPageTitleSection => driver.FindElementById("block-797e974aa3c773f59547");

        /// <summary>
        /// MidPage Title element
        /// </summary>
        public IWebElement MidPageTitle => MidPageTitleSection.FindElementByTagName("div").FindElementByTagName("h1");

        /// <summary>
        /// Review One Section element
        /// </summary>
        public IWebElement ReviewOneSection => driver.FindElementById("block-3f00d4aac80b3b685ab4");

        /// <summary>
        /// Review One Content element
        /// </summary>
        public IWebElement ReviewOneContent => ReviewOneSection.FindElementByTagName("div").FindElementByTagName("p");

        /// <summary>
        /// Review One Author element
        /// </summary>
        public IWebElement ReviewOneAuthor => ReviewOneSection.FindElementByTagName("div").FindElementByTagName("h3");

        /// <summary>
        /// Review Two Section element
        /// </summary>
        public IWebElement ReviewTwoSection => driver.FindElementById("block-d4ed1102416f802aa412");

        /// <summary>
        /// Review Two Content element
        /// </summary>
        public IWebElement ReviewTwoContent => ReviewTwoSection.FindElementByTagName("div").FindElementByTagName("p");

        /// <summary>
        /// Review Two Author element
        /// </summary>
        public IWebElement ReviewTwoAuthor => ReviewTwoSection.FindElementByTagName("div").FindElementByTagName("h3");

        /// <summary>
        /// Review Three Section element
        /// </summary>
        public IWebElement ReviewThreeSection => driver.FindElementById("block-21f65fd856a855645486");

        /// <summary>
        /// Review Three Content element
        /// </summary>
        public IWebElement ReviewThreeContent => ReviewThreeSection.FindElementByTagName("div").FindElementByTagName("p");

        /// <summary>
        /// Review Three Author element
        /// </summary>
        public IWebElement ReviewThreeAuthor => ReviewThreeSection.FindElementByTagName("div").FindElementByTagName("h3");

        /// <summary>
        /// Review Four Section element
        /// </summary>
        public IWebElement ReviewFourSection => driver.FindElementById("block-4e70a0e5d8b1842d6a94");

        /// <summary>
        /// Review Four Content element
        /// </summary>
        public IWebElement ReviewFourContent => ReviewFourSection.FindElementByTagName("div").FindElementByTagName("p");

        /// <summary>
        /// Review Four Author element
        /// </summary>
        public IWebElement ReviewFourAuthor => ReviewFourSection.FindElementByTagName("div").FindElementByTagName("h3");

        /// <summary>
        /// Review Five Section element
        /// </summary>
        public IWebElement ReviewFiveSection => driver.FindElementById("block-3b57590e10d83c5450ee");

        /// <summary>
        /// Review Five Content element
        /// </summary>
        public IWebElement ReviewFiveContent => ReviewFiveSection.FindElementByTagName("div").FindElementByTagName("p");

        /// <summary>
        /// Review Five Author element
        /// </summary>
        public IWebElement ReviewFiveAuthor => ReviewFiveSection.FindElementByTagName("div").FindElementByTagName("h3");

        #endregion Elements
    }
}
