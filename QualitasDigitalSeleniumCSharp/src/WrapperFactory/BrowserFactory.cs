﻿using OpenQA.Selenium;
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
        /// Initializes the driver based on the supplied WebDriver enum
        /// </summary>
        /// <param name="webDriver">The Browser enum</param>
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
        /// Close all active drivers for the session
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
        /// Set the Browser to be used for the WebDriver
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
        /// Go to page by URL
        /// </summary>
        /// <param name="url"></param>
        public static void GoToPage(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        /// <summary>
        /// Gets the title of the current page
        /// </summary>
        /// <returns></returns>
        public static string GetPageTitle()
        {
            return driver.Title;
        }

        /// <summary>
        /// Gets the url of the current page
        /// </summary>
        /// <returns></returns>
        public static string GetPageUrl()
        {
            return driver.Url;
        }

        /// <summary>
        /// Gets the source code of the current page
        /// </summary>
        /// <returns></returns>
        public static string GetPageSource()
        {
            return driver.PageSource;
        }

        #endregion Basic Browser Operations

        #region Advanced Browser Operations

        /// <summary>
        /// Accepts the current popup
        /// </summary>
        public static void AcceptPopup()
        {
            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();
        }

        /// <summary>
        /// Dismisses the current popup
        /// </summary>
        public static void DismissPopup()
        {
            IAlert alert = driver.SwitchTo().Alert();
            alert.Dismiss();
        }

        /// <summary>
        /// Switches to the first browser tab
        /// </summary>
        public static void SwitchToFirstTab()
        {
            ReadOnlyCollection<string> windowHandles = driver.WindowHandles;
            string firstTab = windowHandles.First();
            driver.SwitchTo().Window(firstTab);
        }

        /// <summary>
        /// Switches to the last browser tab
        /// </summary>
        public static void SwitchToLastTab()
        {
            ReadOnlyCollection<string> windowHandles = driver.WindowHandles;
            string lastTab = windowHandles.Last();
            driver.SwitchTo().Window(lastTab);
        }

        /// <summary>
        /// Switches to the next browser tab unless you're already at the end
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
        /// Switches to the previous browser tab unless you're already at the beginning
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
        /// Uses the browser back button
        /// </summary>
        public static void GoBack()
        {
            driver.Navigate().Back();
        }

        /// <summary>
        /// Uses the browser forward button
        /// </summary>
        public static void GoForward()
        {
            driver.Navigate().Forward();
        }

        /// <summary>
        /// Uses the browser refresh button
        /// </summary>
        public static void Refresh()
        {
            driver.Navigate().Refresh();
        }

        /// <summary>
        /// Scrolls to a hyperlink and focuses it
        /// </summary>
        /// <param name="link">The hyperlink</param>
        public static void FocusLink(string link)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].focus();", link);
        }

        /// <summary>
        /// Maximizes the browser window
        /// </summary>
        public static void MaximizeWindow()
        {
            driver.Manage().Window.Maximize();
        }

        /// <summary>
        /// Adds a cookie key and value to the driver
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void AddCookie(string key, string value)
        {
            Cookie cookie = new Cookie("key", "value");
            driver.Manage().Cookies.AddCookie(cookie);
        }

        /// <summary>
        /// Gets all cookies
        /// </summary>
        /// <returns>ReadOnlyCollection of type Cookie</returns>
        public static ReadOnlyCollection<Cookie> GetCookies()
        {
            return driver.Manage().Cookies.AllCookies;
        }

        /// <summary>
        /// Deletes a cookie by name
        /// </summary>
        /// <param name="name">The name of the cookie</param>
        public static void DeleteCookie(string name)
        {
            driver.Manage().Cookies.DeleteCookieNamed(name);
        }

        /// <summary>
        /// Deletes all cookies
        /// </summary>
        public static void DeleteCookies()
        {
            driver.Manage().Cookies.DeleteAllCookies();
        }

        /// <summary>
        /// Takes a screenshot and saves it at the supplied path
        /// </summary>
        /// <param name="path">The path to save the image at</param>
        public static void TakeScreenshot(string path)
        {
            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            screenshot.SaveAsFile(path, ScreenshotImageFormat.Png);
        }

        /// <summary>
        /// Waits for the page to load using document ready state and the supplied timeout
        /// </summary>
        /// <param name="timeout">The number of seconds to wait</param>
        public static void WaitForPageLoad(int timeout = 30)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
            wait.Until((x) => ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete"));
        }

        /// <summary>
        /// Switches to an iframe by index
        /// </summary>
        /// <param name="index">the index of the iframe</param>
        public static void SwitchToFrameByIndex(int index)
        {
            driver.SwitchTo().Frame(index);
        }

        /// <summary>
        /// Switches to an iframe by its name
        /// </summary>
        /// <param name="name">the name of the iframe</param>
        public static void SwitchToFrameByName(string name)
        {
            driver.SwitchTo().Frame(name);
        }

        /// <summary>
        /// Switches to an iframe by element
        /// </summary>
        /// <param name="element">the element for the iframe</param>
        public static void SwitchToFrameByElement(IWebElement element)
        {
            driver.SwitchTo().Frame(element);
        }

        /// <summary>
        /// Switches to the default iframe
        /// </summary>
        public static void SwitchToDefaultFrame()
        {
            driver.SwitchTo().DefaultContent();
        }

        #endregion Advanced Browser Operations

        #region Advanced Browser Configurations

        /// <summary>
        /// Sets the firefox profile by username
        /// </summary>
        /// <param name="userName">the username to use</param>
        public static void UseFirefoxProfile(string userName)
        {
            FirefoxProfileManager profileManager = new FirefoxProfileManager();
            FirefoxProfile profile = profileManager.GetProfile(userName);
            FirefoxOptions options = new FirefoxOptions { Profile = profile };
            driver = new FirefoxDriver(options);
        }

        /// <summary>
        /// Create a firefox profile and set the network proxy settings
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
        /// Create a chrome options and set the network proxy settings
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
        /// Accept all certificates for firefox
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
        /// Accept all certificates for chrome
        /// </summary>
        public static void AcceptAllCertificatesChrome()
        {
            ChromeOptions options = new ChromeOptions { AcceptInsecureCertificates = true };
            driver = new ChromeDriver(options);
        }

        /// <summary>
        /// Set Chrome options, currently not implemented
        /// </summary>
        public static void SetChromeOptions()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Disables javascript for Firefox within options
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
        /// Set the default page load timeout for the driver
        /// </summary>
        /// <param name="timeout"></param>
        public static void SetDefaultPageLoadTimeout(int timeout)
        {
            driver.Manage().Timeouts().PageLoad = new TimeSpan(timeout);
        }

        /// <summary>
        /// start firefox with plugins at the specified path
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
        /// Start chrome unpacked, currently not implemented
        /// </summary>
        public static void StartChromeUnpacked()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Start chrome packed, currently not implemented
        /// </summary>
        public static void StartChromePacked()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Set the default download save location for firefox
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