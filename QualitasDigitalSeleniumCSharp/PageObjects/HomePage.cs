using OpenQA.Selenium;
using QualitasDigitalSeleniumCSharp.WrapperFactory;

namespace QualitasDigitalSeleniumCSharp.PageObjects
{
    public class HomePage
    {
        private IWebDriver driver = BrowserFactory.Driver;
        public string url = "http://www.qualitasdigital.com";

        public IWebElement LogoImage => driver.FindElement(By.ClassName("logo-image"));
    }
}
