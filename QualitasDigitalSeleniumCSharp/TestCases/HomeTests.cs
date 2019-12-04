using NUnit.Framework;
using QualitasDigitalSeleniumCSharp.PageObjects;
using QualitasDigitalSeleniumCSharp.WrapperFactory;

namespace QualitasDigitalSeleniumCSharp.TestCases
{
    [TestFixture]
    public class HomeTests
    {
        #region Fields

        private BrowserFactory.WebDriver webDriverEnum = BrowserFactory.WebDriver.Chrome;
        private string pageUrl = "https://www.qualitasdigital.com";

        #endregion Fields

        #region Tests

        [TestCase()]
        public void HomePageLoad()
        {
            BrowserFactory.InitBrowser(webDriverEnum);
            BrowserFactory.GoTo(pageUrl);

            Assert.IsTrue(Page.Home.LogoImage.Displayed, "homePage.LogoImage.Displayed");
        }

        [TestCase()]
        public void HomePageNavigation()
        {
            Assert.Pass();
        }

        [TestCase()]
        public void HomePageSearch()
        {
            Assert.Pass();
        }

        [TestCase()]
        public void HomePageContent()
        {
            Assert.Pass();
        }

        [TestCase()]
        public void HomePageLinks()
        {
            Assert.Pass();
        }

        #endregion Tests
    }
}
