using OpenQA.Selenium;
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
        public IWebElement LogoImage => driver.FindElement(By.ClassName("logo-image"));

        /// <summary>
        /// Highlighted Review Content element
        /// </summary>
        public IWebElement HighlightedReviewContent => driver.FindElement(By.XPath("//*[@id='block-af6af313004c75816482']/div/figure/blockquote"));

        /// <summary>
        /// Highlighted Review Author element
        /// </summary>
        public IWebElement HighlightedReviewAuthor => driver.FindElement(By.XPath("//*[@id='block-af6af313004c75816482']/div/figure/figcaption"));

        /// <summary>
        /// MidPage Title element
        /// </summary>
        public IWebElement MidPageTitle => driver.FindElement(By.XPath("//*[@id='block-797e974aa3c773f59547']/div/h1"));

        /// <summary>
        /// Review One Content element
        /// </summary>
        public IWebElement ReviewOneContent => driver.FindElement(By.XPath("//*[@id='block-3f00d4aac80b3b685ab4']/div/p"));

        /// <summary>
        /// Review One Author element
        /// </summary>
        public IWebElement ReviewOneAuthor => driver.FindElement(By.XPath("//*[@id='block-3f00d4aac80b3b685ab4']/div/h3"));

        /// <summary>
        /// Review Two Content element
        /// </summary>
        public IWebElement ReviewTwoContent => driver.FindElement(By.XPath("//*[@id='block-d4ed1102416f802aa412']/div/p"));

        /// <summary>
        /// Review Two Author element
        /// </summary>
        public IWebElement ReviewTwoAuthor => driver.FindElement(By.XPath("//*[@id='block-d4ed1102416f802aa412']/div/h3"));

        /// <summary>
        /// Review Three Content element
        /// </summary>
        public IWebElement ReviewThreeContent => driver.FindElement(By.XPath("//*[@id='block-21f65fd856a855645486']/div/p"));

        /// <summary>
        /// Review Three Author element
        /// </summary>
        public IWebElement ReviewThreeAuthor => driver.FindElement(By.XPath("//*[@id='block-21f65fd856a855645486']/div/h3"));

        /// <summary>
        /// Review Four Content element
        /// </summary>
        public IWebElement ReviewFourContent => driver.FindElement(By.XPath("//*[@id='block-4e70a0e5d8b1842d6a94']/div/p"));

        /// <summary>
        /// Review Four Author element
        /// </summary>
        public IWebElement ReviewFourAuthor => driver.FindElement(By.XPath("//*[@id='block-4e70a0e5d8b1842d6a94']/div/h3"));

        /// <summary>
        /// Review Five Content element
        /// </summary>
        public IWebElement ReviewFiveContent => driver.FindElement(By.XPath("//*[@id='block-3b57590e10d83c5450ee']/div/p"));

        /// <summary>
        /// Review Five Author element
        /// </summary>
        public IWebElement ReviewFiveAuthor => driver.FindElement(By.XPath("//*[@id='block-3b57590e10d83c5450ee']/div/h3"));

        #endregion Elements
    }
}
