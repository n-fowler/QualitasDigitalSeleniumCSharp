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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="webDriver"></param>
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

        /// <summary>
        /// 
        /// </summary>
        public static void CloseAllDrivers()
        {
            foreach (string key in Drivers.Keys)
            {
                Drivers[key].Close();
                Drivers[key].Quit();
            }
        }

        /// <summary>
        /// 
        /// </summary>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        public static void GoToPage(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string GetPageTitle()
        {
            return driver.Title;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string GetPageUrl()
        {
            return driver.Url;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string GetPageSource()
        {
            return driver.PageSource;
        }

        #endregion Basic Browser Operations

        #region Advanced Browser Operations

        /// <summary>
        /// 
        /// </summary>
        public static void AcceptPopup()
        {
            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();
        }

        /// <summary>
        /// 
        /// </summary>
        public static void DismissPopup()
        {
            IAlert alert = driver.SwitchTo().Alert();
            alert.Dismiss();
        }

        /// <summary>
        /// 
        /// </summary>
        public static void SwitchToFirstTab()
        {
            ReadOnlyCollection<string> windowHandles = driver.WindowHandles;
            string firstTab = windowHandles.First();
            driver.SwitchTo().Window(firstTab);
        }

        /// <summary>
        /// 
        /// </summary>
        public static void SwitchToLastTab()
        {
            ReadOnlyCollection<string> windowHandles = driver.WindowHandles;
            string lastTab = windowHandles.Last();
            driver.SwitchTo().Window(lastTab);
        }

        /// <summary>
        /// 
        /// </summary>
        public static void SwitchToNextTab()
        {
            ReadOnlyCollection<string> windowHandles = driver.WindowHandles;
            int currentIndex = windowHandles.IndexOf(driver.CurrentWindowHandle);

            if (currentIndex < windowHandles.Count - 1)
            {
                driver.SwitchTo().Window(windowHandles[currentIndex + 1]);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static void SwitchToPreviousTab()
        {
            ReadOnlyCollection<string> windowHandles = driver.WindowHandles;
            int currentIndex = windowHandles.IndexOf(driver.CurrentWindowHandle);

            if (currentIndex > 0)
            {
                driver.SwitchTo().Window(windowHandles[currentIndex - 1]);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static void GoBack()
        {
            driver.Navigate().Back();
        }

        /// <summary>
        /// 
        /// </summary>
        public static void GoForward()
        {
            driver.Navigate().Forward();
        }

        /// <summary>
        /// 
        /// </summary>
        public static void Refresh()
        {
            driver.Navigate().Refresh();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="link"></param>
        public static void FocusLink(string link)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].focus();", link);
        }

        /// <summary>
        /// 
        /// </summary>
        public static void MaximizeWindow()
        {
            driver.Manage().Window.Maximize();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void AddCookie(string key, string value)
        {
            Cookie cookie = new Cookie("key", "value");
            driver.Manage().Cookies.AddCookie(cookie);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static ReadOnlyCollection<Cookie> GetCookies()
        {
            return driver.Manage().Cookies.AllCookies;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        public static void DeleteCookie(string name)
        {
            driver.Manage().Cookies.DeleteCookieNamed(name);
        }

        /// <summary>
        /// 
        /// </summary>
        public static void DeleteCookies()
        {
            driver.Manage().Cookies.DeleteAllCookies();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        public static void TakeScreenshot(string path)
        {
            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            screenshot.SaveAsFile(path, ScreenshotImageFormat.Png);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="timeout"></param>
        public static void WaitForPageLoad(int timeout = 30)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
            wait.Until((x) =>
            {
                return ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete");
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        public static void SwitchToFrameByIndex(int index)
        {
            driver.SwitchTo().Frame(index);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        public static void SwitchToFrameByName(string name)
        {
            driver.SwitchTo().Frame(name);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="element"></param>
        public static void SwitchToFrameByElement(IWebElement element)
        {
            driver.SwitchTo().Frame(element);
        }

        /// <summary>
        /// 
        /// </summary>
        public static void SwitchToDefaultFrame()
        {
            driver.SwitchTo().DefaultContent();
        }

        #endregion Advanced Browser Operations

        #region Advanced Browser Configurations

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userName"></param>
        public static void UseFirefoxProfile(string userName)
        {
            FirefoxProfileManager profileManager = new FirefoxProfileManager();
            FirefoxProfile profile = profileManager.GetProfile(userName);
            FirefoxOptions options = new FirefoxOptions { Profile = profile };
            driver = new FirefoxDriver(options);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="networkProxyType"></param>
        /// <param name="networkProxyHttp"></param>
        /// <param name="networkProxyHttpPort"></param>
        public static void SetFirefoxHttpProxy(int networkProxyType = 1, string networkProxyHttp = "myproxy.com", int networkProxyHttpPort = 3239)
        {
            FirefoxProfile profile = new FirefoxProfile();
            profile.SetPreference("network.proxy.type", networkProxyType);
            profile.SetPreference("network.proxy.http", networkProxyHttp);
            profile.SetPreference("network.proxy.http_port", networkProxyHttpPort);
            FirefoxOptions options = new FirefoxOptions { Profile = profile };
            driver = new FirefoxDriver(options);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="proxyKind"></param>
        /// <param name="isAutoDetect"></param>
        /// <param name="httpProxy"></param>
        /// <param name="sslProxy"></param>
        public static void SetChromeHttpProxy(ProxyKind proxyKind = ProxyKind.Manual, bool isAutoDetect = false, string httpProxy = "", string sslProxy = "127.0.0.1:3239")
        {
            ChromeOptions options = new ChromeOptions();
            Proxy proxy = new Proxy
            {
                Kind = proxyKind,
                IsAutoDetect = isAutoDetect,
                HttpProxy = httpProxy,
                SslProxy = sslProxy
            };
            options.Proxy = proxy;
            options.AddArgument("ignore-certificate-errors");
            driver = new ChromeDriver(options);
        }

        /// <summary>
        /// 
        /// </summary>
        public static void AcceptAllCertificatesFirefox()
        {
            FirefoxProfile profile = new FirefoxProfile
            {
                AcceptUntrustedCertificates = true,
                AssumeUntrustedCertificateIssuer = false
            };
            FirefoxOptions options = new FirefoxOptions { Profile = profile };
            driver = new FirefoxDriver(options);
        }

        /// <summary>
        /// 
        /// </summary>
        public static void AcceptAllCertificatesChrome()
        {
            ChromeOptions options = new ChromeOptions { AcceptInsecureCertificates = true };
            driver = new ChromeDriver(options);
        }

        /// <summary>
        /// 
        /// </summary>
        public static void SetChromeOptions()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userName"></param>
        public static void DisableJavascriptFirefox(string userName)
        {
            FirefoxProfileManager profileManager = new FirefoxProfileManager();
            FirefoxProfile profile = profileManager.GetProfile(userName);
            profile.SetPreference("javascript.enabled", false);
            FirefoxOptions options = new FirefoxOptions { Profile = profile };
            driver = new FirefoxDriver(options);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="timeout"></param>
        public static void SetDefaultPageLoadTimeout(int timeout)
        {
            driver.Manage().Timeouts().PageLoad = new TimeSpan(timeout);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pluginPath"></param>
        public static void StartFirefoxWithPlugins(string pluginPath = @"C:extensionsLocationextension.xpi")
        {
            FirefoxProfile profile = new FirefoxProfile();
            profile.AddExtension(pluginPath);
            FirefoxOptions options = new FirefoxOptions { Profile = profile };
            driver = new FirefoxDriver(options);
        }

        /// <summary>
        /// 
        /// </summary>
        public static void StartChromeUnpacked()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        public static void StartChromePacked()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="downloadFolderPath"></param>
        /// <param name="browserDownloadFolderList"></param>
        /// <param name="browserDownloadManagerAlertOnExeOpen"></param>
        public static void ChangeDefaultSaveLocation(string downloadFolderPath = @"c:temp", int browserDownloadFolderList = 2, bool browserDownloadManagerAlertOnExeOpen = false)
        {
            FirefoxProfile profile = new FirefoxProfile();
            profile.SetPreference("browser.download.folderList", browserDownloadFolderList);
            profile.SetPreference("browser.download.dir", downloadFolderPath);
            profile.SetPreference("browser.download.manager.alertOnEXEOpen", browserDownloadManagerAlertOnExeOpen);
            profile.SetPreference("browser.helperApps.neverAsk.saveToDisk",
                @"application/msword, application/binary, application/ris, text/csv, image/png, application/pdf,
            text / html, text / plain, application / zip, application / x - zip, application / x - zip - compressed, application / download,
            application / octet - stream");
            FirefoxOptions options = new FirefoxOptions { Profile = profile };
            driver = new FirefoxDriver(options);
        }

        #endregion Advanced Browser Configurations
    }
}
