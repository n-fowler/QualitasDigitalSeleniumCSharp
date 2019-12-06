using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Opera;
using OpenQA.Selenium.Safari;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
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

        public static void GoToPage(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public static string GetPageTitle()
        {
            return driver.Title;
        }

        public static string GetPageUrl()
        {
            return driver.Url;
        }

        public static string GetPageSource()
        {
            return driver.PageSource;
        }

        #endregion Basic Browser Operations

        #region Advanced Browser Operations

        public static void AcceptPopup()
        {
            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();
        }

        public static void DismissPopup()
        {
            IAlert alert = driver.SwitchTo().Alert();
            alert.Dismiss();
        }

        public static void SwitchToFirstTab()
        {
            ReadOnlyCollection<string> windowHandles = driver.WindowHandles;
            string firstTab = windowHandles.First();
            driver.SwitchTo().Window(firstTab);
        }

        public static void SwitchToLastTab()
        {
            ReadOnlyCollection<string> windowHandles = driver.WindowHandles;
            string lastTab = windowHandles.Last();
            driver.SwitchTo().Window(lastTab);
        }

        public static void SwitchToNextTab()
        {
            ReadOnlyCollection<string> windowHandles = driver.WindowHandles;
            int currentIndex = windowHandles.IndexOf(driver.CurrentWindowHandle);

            if (currentIndex < windowHandles.Count - 1)
            {
                driver.SwitchTo().Window(windowHandles[currentIndex + 1]);
            }
        }

        public static void SwitchToPreviousTab()
        {
            ReadOnlyCollection<string> windowHandles = driver.WindowHandles;
            int currentIndex = windowHandles.IndexOf(driver.CurrentWindowHandle);

            if (currentIndex > 0)
            {
                driver.SwitchTo().Window(windowHandles[currentIndex - 1]);
            }
        }

        public static void GoBack()
        {
            driver.Navigate().Back();
        }

        public static void GoForward()
        {
            driver.Navigate().Forward();
        }

        public static void Refresh()
        {
            driver.Navigate().Refresh();
        }

        public static void FocusLink(string link)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].focus();", link);
        }

        public static void MaximizeWindow()
        {
            driver.Manage().Window.Maximize();
        }

        public static void AddCookie(string key, string value)
        {
            Cookie cookie = new Cookie("key", "value");
            driver.Manage().Cookies.AddCookie(cookie);
        }

        public static ReadOnlyCollection<Cookie> GetCookies()
        {
            return driver.Manage().Cookies.AllCookies;
        }

        public static void DeleteCookie(string name)
        {
            driver.Manage().Cookies.DeleteCookieNamed(name);
        }

        public static void DeleteCookies()
        {
            driver.Manage().Cookies.DeleteAllCookies();
        }

        public static void TakeScreenshot(string path)
        {
            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            screenshot.SaveAsFile(path, ScreenshotImageFormat.Png);
        }

        public static void WaitForPageLoad(int timeout = 30)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
            wait.Until((x) =>
            {
                return ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete");
            });
        }

        public static void SwitchToFrameByIndex(int index)
        {
            driver.SwitchTo().Frame(index);
        }

        public static void SwitchToFrameByName(string name)
        {
            driver.SwitchTo().Frame(name);
        }

        public static void SwitchToFrameByElement(IWebElement element)
        {
            driver.SwitchTo().Frame(element);
        }

        public static void SwitchToDefaultFrame()
        {
            driver.SwitchTo().DefaultContent();
        }

        #endregion Advanced Browser Operations

        #region Advanced Browser Configurations
        #endregion Advanced Browser Configurations
    }
}
