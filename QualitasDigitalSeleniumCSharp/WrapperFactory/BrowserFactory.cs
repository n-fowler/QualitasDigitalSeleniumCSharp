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
            private set
            {
                driver = value;
            }
        }

        public static void InitBrowser(WebDriver webDriver)
        {
            if (Driver != null)
            {
                return;
            }

            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            switch (webDriver)
            {
                case WebDriver.Chrome:
                    driver = new ChromeDriver(path);
                    break;
                case WebDriver.Firefox:
                    driver = new FirefoxDriver(path);
                    break;
                case WebDriver.InternetExplorer:
                    driver = new InternetExplorerDriver(path);
                    break;
                case WebDriver.Edge:
                    driver = new EdgeDriver(path);
                    break;
                case WebDriver.Opera:
                    driver = new OperaDriver(path);
                    break;
                case WebDriver.Safari:
                    driver = new SafariDriver(path);
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
            Safari,
            RemoteWebDriver
        }
    }
}
