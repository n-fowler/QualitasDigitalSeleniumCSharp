using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Opera;
using OpenQA.Selenium.Safari;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace QualitasDigitalSeleniumCSharp.WrapperFactory
{
    public static class BrowserFactory
    {
        private static readonly IDictionary<string, IWebDriver> Drivers = new Dictionary<string, IWebDriver>();
        private static IWebDriver driver;

        public static IWebDriver Driver
        {
            get
            {
                if (driver == null)
                {
                    throw new NullReferenceException("The WebDriver browser instance was not initialized. You should first call the method InitBrowser.");
                }
                return driver;
            }
            private set => driver = value;
        }

        public static void InitBrowser(WebDriver webDriver)
        {
            if (driver != null) return;

            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            switch (webDriver)
            {
                case WebDriver.Chrome:
                    Driver = new ChromeDriver(path);
                    Drivers.Add("Chrome", Driver);
                    break;
                case WebDriver.Firefox:
                    Driver = new FirefoxDriver(path);
                    Drivers.Add("Firefox", Driver);
                    break;
                case WebDriver.InternetExplorer:
                    Driver = new InternetExplorerDriver(path);
                    Drivers.Add("InternetExplorer", Driver);
                    break;
                case WebDriver.Edge:
                    Driver = new EdgeDriver(path);
                    Drivers.Add("Edge", Driver);
                    break;
                case WebDriver.Opera:
                    Driver = new OperaDriver(path);
                    Drivers.Add("Opera", Driver);
                    break;
                case WebDriver.Safari:
                    Driver = new SafariDriver(path);
                    Drivers.Add("Safari", Driver);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(webDriver), webDriver, null);
            }
        }

        public static void GoTo(string url)
        {
            Driver.Url = url;
        }

        public static void CloseAllDrivers()
        {
            foreach (string key in Drivers.Keys)
            {
                Drivers[key].Close();
                Drivers[key].Quit();
            }
        }

        public enum WebDriver
        {
            Chrome,
            Firefox,
            InternetExplorer,
            Edge,
            Opera,
            Safari
        }

        #region Basic Browser Operations
        #endregion Basic Browser Operations

        #region Advanced Browser Operations
        #endregion Advanced Browser Operations

        #region Advanced Browser Configurations
        #endregion Advanced Browser Configurations
    }
}
