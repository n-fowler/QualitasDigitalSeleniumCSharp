using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Support.UI;
using QualitasDigitalSeleniumCSharp.WrapperFactory;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QualitasDigitalSeleniumCSharp.Extensions
{
    /// <summary>
    /// Extends the functionality of the driver and web element classes
    /// </summary>
    public static class SeleniumExtensions
    {
        #region Find Element (IWebDriver)

        /// <summary>
        /// Uses the driver to find an element by class name
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <param name="className">The class name</param>
        /// <returns>Returns a selenium web element</returns>
        public static IWebElement FindElementByClassName(this IWebDriver driver, string className)
        {
            try
            {
                var element = driver.FindElement(By.ClassName(className));
                TestStepLog.GenerateTestStep($"Find Element By Class Name: {className}", "Element Found", "Success", BrowserFactory.Stopwatch.Elapsed);
                return element;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Find Element By Class Name: {className}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Uses the driver to find an element by css selector string
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <param name="cssSelector">The css selector string</param>
        /// <returns>Returns a selenium web element</returns>
        public static IWebElement FindElementByCssSelector(this IWebDriver driver, string cssSelector)
        {
            try
            {
                var element = driver.FindElement(By.CssSelector(cssSelector));
                TestStepLog.GenerateTestStep($"Find Element By Css Selector: {cssSelector}", "Element Found", "Success", BrowserFactory.Stopwatch.Elapsed);
                return element;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Find Element By Css Selector: {cssSelector}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Uses the driver to find an element by id
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <param name="id">The id</param>
        /// <returns>Returns a selenium web element</returns>
        public static IWebElement FindElementById(this IWebDriver driver, string id)
        {
            try
            {
                var element = driver.FindElement(By.Id(id));
                TestStepLog.GenerateTestStep($"Find Element By Id: {id}", "Element Found", "Success", BrowserFactory.Stopwatch.Elapsed);
                return element;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Find Element By Id: {id}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Uses the driver to find an element by link text
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <param name="linkText">The link text</param>
        /// <returns>Returns a selenium web element</returns>
        public static IWebElement FindElementByLinkText(this IWebDriver driver, string linkText)
        {
            try
            {
                var element = driver.FindElement(By.LinkText(linkText));
                TestStepLog.GenerateTestStep($"Find Element By Link Text: {linkText}", "Element Found", "Success", BrowserFactory.Stopwatch.Elapsed);
                return element;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Find Element By Link Text: {linkText}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Uses the driver to find an element by name
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <param name="name">The name</param>
        /// <returns>Returns a selenium web element</returns>
        public static IWebElement FindElementByName(this IWebDriver driver, string name)
        {
            try
            {
                var element = driver.FindElement(By.Name(name));
                TestStepLog.GenerateTestStep($"Find Element By Name: {name}", "Element Found", "Success", BrowserFactory.Stopwatch.Elapsed);
                return element;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Find Element By Name: {name}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Uses the driver to find an element containing the link text
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <param name="partialLinkText">The partial link text</param>
        /// <returns>Returns a selenium web element</returns>
        public static IWebElement FindElementByPartialLinkText(this IWebDriver driver, string partialLinkText)
        {
            try
            {
                var element = driver.FindElement(By.PartialLinkText(partialLinkText));
                TestStepLog.GenerateTestStep($"Find Element By Partial Link Text: {partialLinkText}", "Element Found", "Success", BrowserFactory.Stopwatch.Elapsed);
                return element;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Find Element By Partial Link Text: {partialLinkText}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Uses the driver to find an element by tag name
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <param name="tagName">The tag name</param>
        /// <returns>Returns a selenium web element</returns>
        public static IWebElement FindElementByTagName(this IWebDriver driver, string tagName)
        {
            try
            {
                var element = driver.FindElement(By.TagName(tagName));
                TestStepLog.GenerateTestStep($"Find Element By Tag Name: {tagName}", "Element Found", "Success", BrowserFactory.Stopwatch.Elapsed);
                return element;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Find Element By Tag Name: {tagName}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Uses the driver to find an element by xpath
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <param name="xPath">The xpath</param>
        /// <returns>Returns a selenium web element</returns>
        public static IWebElement FindElementByXPath(this IWebDriver driver, string xPath)
        {
            try
            {
                var element = driver.FindElement(By.XPath(xPath));
                TestStepLog.GenerateTestStep($"Find Element By XPath: {xPath}", "Element Found", "Success", BrowserFactory.Stopwatch.Elapsed);
                return element;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Find Element By XPath: {xPath}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        #endregion Find Element (IWebDriver)

        #region Find Element (IWebElement)

        /// <summary>
        /// Uses the driver to find an element by class name
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <param name="className">The class name</param>
        /// <returns>Returns a selenium web element</returns>
        public static IWebElement FindElementByClassName(this IWebElement webElement, string className)
        {
            try
            {
                var element = webElement.FindElement(By.ClassName(className));
                TestStepLog.GenerateTestStep($"Find Element By Class Name: {className}", "Element Found", "Success", BrowserFactory.Stopwatch.Elapsed);
                return element;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Find Element By Class Name: {className}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Uses the driver to find an element by css selector string
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <param name="cssSelector">The css selector string</param>
        /// <returns>Returns a selenium web element</returns>
        public static IWebElement FindElementByCssSelector(this IWebElement webElement, string cssSelector)
        {
            try
            {
                var element = webElement.FindElement(By.CssSelector(cssSelector));
                TestStepLog.GenerateTestStep($"Find Element By Css Selector: {cssSelector}", "Element Found", "Success", BrowserFactory.Stopwatch.Elapsed);
                return element;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Find Element By Css Selector: {cssSelector}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Uses the driver to find an element by id
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <param name="id">The id</param>
        /// <returns>Returns a selenium web element</returns>
        public static IWebElement FindElementById(this IWebElement webElement, string id)
        {
            try
            {
                var element = webElement.FindElement(By.Id(id));
                TestStepLog.GenerateTestStep($"Find Element By Id: {id}", "Element Found", "Success", BrowserFactory.Stopwatch.Elapsed);
                return element;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Find Element By Id: {id}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Uses the driver to find an element by link text
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <param name="linkText">The link text</param>
        /// <returns>Returns a selenium web element</returns>
        public static IWebElement FindElementByLinkText(this IWebElement webElement, string linkText)
        {
            try
            {
                var element = webElement.FindElement(By.LinkText(linkText));
                TestStepLog.GenerateTestStep($"Find Element By Link Text: {linkText}", "Element Found", "Success", BrowserFactory.Stopwatch.Elapsed);
                return element;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Find Element By Link Text: {linkText}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Uses the driver to find an element by name
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <param name="name">The name</param>
        /// <returns>Returns a selenium web element</returns>
        public static IWebElement FindElementByName(this IWebElement webElement, string name)
        {
            try
            {
                var element = webElement.FindElement(By.Name(name));
                TestStepLog.GenerateTestStep($"Find Element By Name: {name}", "Element Found", "Success", BrowserFactory.Stopwatch.Elapsed);
                return element;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Find Element By Name: {name}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Uses the driver to find an element containing the link text
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <param name="partialLinkText">The partial link text</param>
        /// <returns>Returns a selenium web element</returns>
        public static IWebElement FindElementByPartialLinkText(this IWebElement webElement, string partialLinkText)
        {
            try
            {
                var element = webElement.FindElement(By.PartialLinkText(partialLinkText));
                TestStepLog.GenerateTestStep($"Find Element By Partial Link Text: {partialLinkText}", "Element Found", "Success", BrowserFactory.Stopwatch.Elapsed);
                return element;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Find Element By Partial Link Text: {partialLinkText}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Uses the driver to find an element by tag name
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <param name="tagName">The tag name</param>
        /// <returns>Returns a selenium web element</returns>
        public static IWebElement FindElementByTagName(this IWebElement webElement, string tagName)
        {
            try
            {
                var element = webElement.FindElement(By.TagName(tagName));
                TestStepLog.GenerateTestStep($"Find Element By Tag Name: {tagName}", "Element Found", "Success", BrowserFactory.Stopwatch.Elapsed);
                return element;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Find Element By Tag Name: {tagName}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Uses the driver to find an element by xpath
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <param name="xPath">The xpath</param>
        /// <returns>Returns a selenium web element</returns>
        public static IWebElement FindElementByXPath(this IWebElement webElement, string xPath)
        {
            try
            {
                var element = webElement.FindElement(By.XPath(xPath));
                TestStepLog.GenerateTestStep($"Find Element By XPath: {xPath}", "Element Found", "Success", BrowserFactory.Stopwatch.Elapsed);
                return element;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Find Element By XPath: {xPath}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        #endregion Find Element (IWebDriver)

        #region Find Elements (IWebDriver)

        /// <summary>
        /// Uses the driver to find elements by the class name
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <param name="className">The class name</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> FindElementsByClassName(this IWebDriver driver, string className)
        {
            try
            {
                var element = driver.FindElements(By.ClassName(className));
                TestStepLog.GenerateTestStep($"Find Elements By Class Name: {className}", "Element Found", "Success", BrowserFactory.Stopwatch.Elapsed);
                return element;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Find Elements By Class Name: {className}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Uses the driver to find elements by the css selector string
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <param name="cssSelector">The css selector string</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> FindElementsByCssSelector(this IWebDriver driver, string cssSelector)
        {
            try
            {
                var element = driver.FindElements(By.CssSelector(cssSelector));
                TestStepLog.GenerateTestStep($"Find Elements By Css Selector: {cssSelector}", "Element Found", "Success", BrowserFactory.Stopwatch.Elapsed);
                return element;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Find Elements By Css Selector: {cssSelector}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Uses the driver to find elements by the id
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <param name="id">The id</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> FindElementsById(this IWebDriver driver, string id)
        {
            try
            {
                var element = driver.FindElements(By.Id(id));
                TestStepLog.GenerateTestStep($"Find Elements By Id: {id}", "Element Found", "Success", BrowserFactory.Stopwatch.Elapsed);
                return element;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Find Elements By Id: {id}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Uses the driver to find elements by the link text
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <param name="linkText">The link text</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> FindElementsByLinkText(this IWebDriver driver, string linkText)
        {
            try
            {
                var element = driver.FindElements(By.LinkText(linkText));
                TestStepLog.GenerateTestStep($"Find Elements By Link Text: {linkText}", "Element Found", "Success", BrowserFactory.Stopwatch.Elapsed);
                return element;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Find Elements By Link Text: {linkText}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Uses the driver to find elements by the name
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <param name="name">The name</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> FindElementsByName(this IWebDriver driver, string name)
        {
            try
            {
                var element = driver.FindElements(By.Name(name));
                TestStepLog.GenerateTestStep($"Find Elements By Name: {name}", "Element Found", "Success", BrowserFactory.Stopwatch.Elapsed);
                return element;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Find Elements By Name: {name}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Uses the driver to find elements containing the link text
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <param name="partialLinkText">The partial link text</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> FindElementsByPartialLinkText(this IWebDriver driver, string partialLinkText)
        {
            try
            {
                var element = driver.FindElements(By.PartialLinkText(partialLinkText));
                TestStepLog.GenerateTestStep($"Find Elements By Partial Link Text: {partialLinkText}", "Element Found", "Success", BrowserFactory.Stopwatch.Elapsed);
                return element;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Find Elements By Partial Link Text: {partialLinkText}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Uses the driver to find elements by the tag name
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <param name="tagName">The tag name</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> FindElementsByTagName(this IWebDriver driver, string tagName)
        {
            try
            {
                var element = driver.FindElements(By.TagName(tagName));
                TestStepLog.GenerateTestStep($"Find Elements By Tag Name: {tagName}", "Element Found", "Success", BrowserFactory.Stopwatch.Elapsed);
                return element;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Find Elements By Tag Name: {tagName}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Uses the driver to find elements by the xpath
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <param name="xPath">The xpath</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> FindElementsByXPath(this IWebDriver driver, string xPath)
        {
            try
            {
                var element = driver.FindElements(By.XPath(xPath));
                TestStepLog.GenerateTestStep($"Find Elements By XPath: {xPath}", "Element Found", "Success", BrowserFactory.Stopwatch.Elapsed);
                return element;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Find Elements By XPath: {xPath}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        #endregion Find Elements (IWebDriver)

        #region Find Elements (IWebElement)

        /// <summary>
        /// Uses the driver to find elements by the class name
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <param name="className">The class name</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> FindElementsByClassName(this IWebElement webElement, string className)
        {
            try
            {
                var element = webElement.FindElements(By.ClassName(className));
                TestStepLog.GenerateTestStep($"Find Elements By Class Name: {className}", "Element Found", "Success", BrowserFactory.Stopwatch.Elapsed);
                return element;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Find Elements By Class Name: {className}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Uses the driver to find elements by the css selector string
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <param name="cssSelector">The css selector string</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> FindElementsByCssSelector(this IWebElement webElement, string cssSelector)
        {
            try
            {
                var element = webElement.FindElements(By.CssSelector(cssSelector));
                TestStepLog.GenerateTestStep($"Find Elements By Css Selector: {cssSelector}", "Element Found", "Success", BrowserFactory.Stopwatch.Elapsed);
                return element;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Find Elements By Css Selector: {cssSelector}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Uses the driver to find elements by the id
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <param name="id">The id</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> FindElementsById(this IWebElement webElement, string id)
        {
            try
            {
                var element = webElement.FindElements(By.Id(id));
                TestStepLog.GenerateTestStep($"Find Elements By Id: {id}", "Element Found", "Success", BrowserFactory.Stopwatch.Elapsed);
                return element;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Find Elements By Id: {id}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Uses the driver to find elements by the link text
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <param name="linkText">The link text</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> FindElementsByLinkText(this IWebElement webElement, string linkText)
        {
            try
            {
                var element = webElement.FindElements(By.LinkText(linkText));
                TestStepLog.GenerateTestStep($"Find Elements By Link Text: {linkText}", "Element Found", "Success", BrowserFactory.Stopwatch.Elapsed);
                return element;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Find Elements By Link Text: {linkText}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Uses the driver to find elements by the name
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <param name="name">The name</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> FindElementsByName(this IWebElement webElement, string name)
        {
            try
            {
                var element = webElement.FindElements(By.Name(name));
                TestStepLog.GenerateTestStep($"Find Elements By Name: {name}", "Element Found", "Success", BrowserFactory.Stopwatch.Elapsed);
                return element;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Find Elements By Name: {name}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Uses the driver to find elements containing the link text
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <param name="partialLinkText">The partial link text</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> FindElementsByPartialLinkText(this IWebElement webElement, string partialLinkText)
        {
            try
            {
                var element = webElement.FindElements(By.PartialLinkText(partialLinkText));
                TestStepLog.GenerateTestStep($"Find Elements By Partial Link Text: {partialLinkText}", "Element Found", "Success", BrowserFactory.Stopwatch.Elapsed);
                return element;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Find Elements By Partial Link Text: {partialLinkText}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Uses the driver to find elements by the tag name
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <param name="tagName">The tag name</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> FindElementsByTagName(this IWebElement webElement, string tagName)
        {
            try
            {
                var element = webElement.FindElements(By.TagName(tagName));
                TestStepLog.GenerateTestStep($"Find Elements By Tag Name: {tagName}", "Element Found", "Success", BrowserFactory.Stopwatch.Elapsed);
                return element;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Find Elements By Tag Name: {tagName}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Uses the driver to find elements by the xpath
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <param name="xPath">The xpath</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> FindElementsByXPath(this IWebElement webElement, string xPath)
        {
            try
            {
                var element = webElement.FindElements(By.XPath(xPath));
                TestStepLog.GenerateTestStep($"Find Elements By XPath: {xPath}", "Element Found", "Success", BrowserFactory.Stopwatch.Elapsed);
                return element;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Find Elements By XPath: {xPath}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        #endregion Find Elements (IWebElement)

        #region Basic Element Operations (IWebElement)

        /// <summary>
        /// Clicks the web element.
        /// </summary>
        /// <param name="element">The web element</param>
        public static void ClickWhenReady(this IWebElement element)
        {
            try
            {
                element.Click();
                TestStepLog.GenerateTestStep("Click When Ready", "Element was Clicked", "Success", BrowserFactory.Stopwatch.Elapsed);
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep("Click When Ready", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Enters text into supported elements
        /// </summary>
        /// <param name="element">The web element</param>
        /// <param name="value">The value</param>
        public static void EnterText(this IWebElement element, string value)
        {
            try
            {
                element.SendKeys(value);
                TestStepLog.GenerateTestStep($"Enter Text: {value}", "Text was entered", "Success", BrowserFactory.Stopwatch.Elapsed);
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Enter Text: {value}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Clears the content of the element
        /// </summary>
        /// <param name="element">The web element</param>
        public static void ClearElement(this IWebElement element)
        {
            try
            {
                element.Clear();
                TestStepLog.GenerateTestStep("Clear Element", "Element was cleared", "Success", BrowserFactory.Stopwatch.Elapsed);
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep("Clear Element", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Performs a submit operation for the element
        /// </summary>
        /// <param name="element">The web element</param>
        public static void SubmitElement(this IWebElement element)
        {
            try
            {
                element.Submit();
                TestStepLog.GenerateTestStep("Submit Element", "Element was submitted", "Success", BrowserFactory.Stopwatch.Elapsed);
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep("Submit Element", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets the innertext of the element
        /// </summary>
        /// <param name="element">The web element</param>
        /// <returns>returns a string with innertext</returns>
        public static string GetInnertext(this IWebElement element)
        {
            try
            {
                var returnVal = element.GetAttribute("innerText");
                TestStepLog.GenerateTestStep("Get Innertext from the element", "Element Innertext retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return returnVal;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep("Get Innertext from the element", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets the href of the element
        /// </summary>
        /// <param name="element">The web element</param>
        /// <returns></returns>
        public static string GetHref(this IWebElement element)
        {
            try
            {
                var returnVal = element.GetAttribute("href");
                TestStepLog.GenerateTestStep("Get Href from the element", "Element Href retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return returnVal;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep("Get Href from the element", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets the src of the element
        /// </summary>
        /// <param name="element">The web element</param>
        /// <returns></returns>
        public static string GetSrc(this IWebElement element)
        {
            try
            {
                var returnVal = element.GetAttribute("src");
                TestStepLog.GenerateTestStep("Get Src from the element", "Element Src retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return returnVal;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep("Get Src from the element", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets the enabled state of the element
        /// </summary>
        /// <param name="element">The web element</param>
        /// <returns>returns a boolean for enabled state</returns>
        public static bool IsEnabled(this IWebElement element)
        {
            try
            {
                var returnVal = element.Enabled;
                TestStepLog.GenerateTestStep("Determine element enabled state", "Element enabled state retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return returnVal;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep("Determine element enabled state", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets the displayed state of the element
        /// </summary>
        /// <param name="element">The web element</param>
        /// <returns>returns a boolean for displayed state</returns>
        public static bool IsDisplayed(this IWebElement element)
        {
            try
            {
                var returnVal = element.Displayed;
                TestStepLog.GenerateTestStep("Determine element displayed state", "Element displayed state retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return returnVal;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep("Determine element displayed state", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets the selected state of the element
        /// </summary>
        /// <param name="element">The web element</param>
        /// <returns>returns a boolean for selected state</returns>
        public static bool IsSelected(this IWebElement element)
        {
            try
            {
                var returnVal = element.Selected;
                TestStepLog.GenerateTestStep("Determine element selected state", "Element selected state retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return returnVal;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep("Determine element selected state", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Selects an option from a Select Element by index
        /// </summary>
        /// <param name="element">The web element</param>
        /// <param name="index">The index</param>
        public static void SelectByIndex(this IWebElement element, int index)
        {
            try
            {
                new SelectElement(element).SelectByIndex(index);
                TestStepLog.GenerateTestStep($"Select By Index: {index}", "Element selected by Index", "Success", BrowserFactory.Stopwatch.Elapsed);
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Select By Index: {index}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Deselects an option from a Select Element by index
        /// </summary>
        /// <param name="element">The web element</param>
        /// <param name="index">The index</param>
        public static void DeselectByIndex(this IWebElement element, int index)
        {
            try
            {
                new SelectElement(element).DeselectByIndex(index);
                TestStepLog.GenerateTestStep($"Deselect By Index: {index}", "Element deselected by Index", "Success", BrowserFactory.Stopwatch.Elapsed);
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Deselect By Index: {index}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Selects an option from a Select Element by text
        /// </summary>
        /// <param name="element">The web element</param>
        /// <param name="text">The option text value</param>
        public static void SelectByText(this IWebElement element, string text)
        {
            try
            {
                new SelectElement(element).SelectByText(text);
                TestStepLog.GenerateTestStep($"Select By Text: {text}", "Element selected by Text", "Success", BrowserFactory.Stopwatch.Elapsed);
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Select By Text: {text}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Deselects an option from a Select Element by text
        /// </summary>
        /// <param name="element">The web element</param>
        /// <param name="text">The option text value</param>
        public static void DeselectByText(this IWebElement element, string text)
        {
            try
            {
                new SelectElement(element).DeselectByText(text);
                TestStepLog.GenerateTestStep($"Deselect By Text: {text}", "Element deselected by Text", "Success", BrowserFactory.Stopwatch.Elapsed);
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Deselect By Text: {text}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Selects an option from a Select Element by value
        /// </summary>
        /// <param name="element">The web element</param>
        /// <param name="value">The value</param>
        public static void SelectByValue(this IWebElement element, string value)
        {
            try
            {
                new SelectElement(element).SelectByValue(value);
                TestStepLog.GenerateTestStep($"Select By Value: {value}", "Element selected by Value", "Success", BrowserFactory.Stopwatch.Elapsed);
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Select By Value: {value}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Deslects an option from a Select Element by value
        /// </summary>
        /// <param name="element">The web element</param>
        /// <param name="value">The value</param>
        public static void DeselectByValue(this IWebElement element, string value)
        {
            try
            {
                new SelectElement(element).DeselectByValue(value);
                TestStepLog.GenerateTestStep($"Deselect By Value: {value}", "Element deselected by Value", "Success", BrowserFactory.Stopwatch.Elapsed);
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Deselect By Value: {value}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Deselects all options from a Select Element
        /// </summary>
        /// <param name="element">The web element</param>
        public static void DeselectAll(this IWebElement element)
        {
            try
            {
                new SelectElement(element).DeselectAll();
                TestStepLog.GenerateTestStep("Deselect all options from element", "Element deselected by Value", "Success", BrowserFactory.Stopwatch.Elapsed);
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep("Deselect all options from element", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets the currently selected option from a Select Element
        /// </summary>
        /// <param name="element">The web element</param>
        /// <returns>returns a Select web element</returns>
        public static IWebElement GetSelectedOption(this IWebElement element)
        {
            try
            {
                var returnVal = new SelectElement(element).SelectedOption;
                TestStepLog.GenerateTestStep("Get Selected Option", "Selected Option retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return returnVal;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep("Get Selected Option", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all currently selected options from a Select Element
        /// </summary>
        /// <param name="element">The web element</param>
        /// <returns>returns a list of Select web elements</returns>
        public static IList<IWebElement> GetAllSelectedOptions(this IWebElement element)
        {
            TestStepLog.GenerateTestStep("GetAllSelectedOptions executed", "", "", BrowserFactory.Stopwatch.Elapsed);
            return new SelectElement(element).AllSelectedOptions;
        }

        /// <summary>
        /// Gets the multiple select state of the Select Element
        /// </summary>
        /// <param name="element">The web element</param>
        /// <returns>returns a bool for the multiple select state</returns>
        public static bool IsMultipleSelect(this IWebElement element)
        {
            TestStepLog.GenerateTestStep("IsMultipleSelect executed", "", "", BrowserFactory.Stopwatch.Elapsed);
            return new SelectElement(element).IsMultiple;
        }

        #endregion Basic Element Operations (IWebElement)

        #region Advanced Element Operations (IWebElement)

        /// <summary>
        /// Drags and Drops an element to a position on the screen
        /// </summary>
        /// <param name="element">The web element</param>
        /// <param name="xPos">the x coordinate</param>
        /// <param name="yPos">the y coordinate</param>
        public static void DragAndDrop(this IWebElement element, int xPos, int yPos)
        {
            TestStepLog.GenerateTestStep($"DragAndDrop executed. xPos: {xPos}, yPos: {yPos}", "", "", BrowserFactory.Stopwatch.Elapsed);
            IWebDriver driver = ((IWrapsDriver)element).WrappedDriver;
            Actions move = new Actions(driver);
            move.DragAndDropToOffset(element, xPos, yPos).Perform();
        }

        /// <summary>
        /// Scrolls to a web element using javascript
        /// </summary>
        /// <param name="element">The web element</param>
        public static void ScrollTo(this IWebElement element)
        {
            TestStepLog.GenerateTestStep($"ScrollTo executed.  Element y coordinate: {element.Location.Y}", "", "", BrowserFactory.Stopwatch.Elapsed);
            string js = $"window.scroll(0, {element.Location.Y});";
            IWebDriver driver = ((IWrapsDriver)element).WrappedDriver;
            ((IJavaScriptExecutor)driver).ExecuteScript(js);
        }

        /// <summary>
        /// Clicks an element using javascript and the element id
        /// </summary>
        /// <param name="element">The web element</param>
        public static void ClickWithJavascriptById(this IWebElement element)
        {
            string js = $"document.getElementById('{element.GetAttribute("id")}').click();";
            TestStepLog.GenerateTestStep($"ClickWithJavascriptById executed.  Full script: {js}", "", "", BrowserFactory.Stopwatch.Elapsed);
            IWebDriver driver = ((IWrapsDriver)element).WrappedDriver;
            ((IJavaScriptExecutor)driver).ExecuteScript(js);
        }

        /// <summary>
        /// Wait for the visibility of an element
        /// </summary>
        /// <param name="element">The web element</param>
        /// <param name="cssSelector">The css selector string</param>
        /// <param name="timeLimit">the time limit in seconds</param>
        public static void WaitForVisibility(this IWebElement element, string cssSelector, int timeLimit = 30)
        {
            TestStepLog.GenerateTestStep($"WaitForVisibility: {cssSelector}", "", "", BrowserFactory.Stopwatch.Elapsed);
            IWebDriver driver = ((IWrapsDriver)element).WrappedDriver;
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeLimit));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.CssSelector(cssSelector)));
        }

        /// <summary>
        /// Wait for the visibility of an element
        /// </summary>
        /// <param name="element">The web element</param>
        /// <param name="timeLimit">the time limit in seconds</param>
        public static void WaitForClickable(this IWebElement element, int timeLimit = 30)
        {
            TestStepLog.GenerateTestStep("WaitForClickable executed", "", "", BrowserFactory.Stopwatch.Elapsed);
            IWebDriver driver = ((IWrapsDriver)element).WrappedDriver;
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeLimit));
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
        }

        /// <summary>
        /// Gets all Element properties, useful for logging
        /// </summary>
        /// <param name="element">The web element</param>
        /// <returns></returns>
        public static Dictionary<string, object> GetAllElementProperties(this IWebElement element)
        {
            TestStepLog.GenerateTestStep("GetAllElementProperties executed", "", "", BrowserFactory.Stopwatch.Elapsed);
            IWebDriver driver = ((IWrapsDriver)element).WrappedDriver;
            string js =
                "var items = {}; for (index = 0; index < arguments[0].attributes.length; ++index) { items[arguments[0].attributes[index].name] = arguments[0].attributes[index].value }; return items;";
            Dictionary<string, object> attributes = ((IJavaScriptExecutor)driver).ExecuteScript(js, element) as Dictionary<string, object>;
            return attributes;
        }

        /// <summary>
        /// Gets an element identifier for the test log test steps
        /// </summary>
        /// <param name="propertyDictionary">The property dictionary retrieved from GetAllElementProperties</param>
        /// <returns></returns>
        public static string GetElementIdentifierForTestLog(Dictionary<string, object> propertyDictionary)
        {
            if (propertyDictionary == null)
            {
                return "unknown value used.  Property dictionary is null";
            }
            if (propertyDictionary.ContainsKey("id"))
            {
                return $"id: {propertyDictionary["id"]}";
            }
            if (propertyDictionary.ContainsKey("class"))
            {
                return $"class: {propertyDictionary["class"]}";
            }
            if (propertyDictionary.ContainsKey("role"))
            {
                return $"role: {propertyDictionary["role"]}";
            }

            return $"unknown value: {propertyDictionary.First().Value as string}";
        }

        #endregion Advanced Element Operations (IWebElement)

        #region CSS Selectors (IWebDriver)

        /// <summary>
        /// Gets all elements by css selector
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetAllElements(this IWebDriver driver)
        {
            TestStepLog.GenerateTestStep("GetAllElements executed", "", "", BrowserFactory.Stopwatch.Elapsed);
            return driver.FindElementsByCssSelector("*");
        }

        /// <summary>
        /// Gets all elements by hierarchy using a css selector.  EX: div, p | div p | div > p | div + p | p ~ ul
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <param name="hierarchy">The hierarchy string</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsByTagHierarchy(this IWebDriver driver, string hierarchy)
        {
            TestStepLog.GenerateTestStep($"GetElementsByTagHierarchy: {hierarchy}", "", "", BrowserFactory.Stopwatch.Elapsed);
            return driver.FindElementsByCssSelector(hierarchy);
        }

        /// <summary>
        /// Gets all elements with a target attribute
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <param name="attribute">the target attribute</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithTargetAttribute(this IWebDriver driver, string attribute)
        {
            TestStepLog.GenerateTestStep($"GetElementsWithTargetAttribute: {attribute}", "", "", BrowserFactory.Stopwatch.Elapsed);
            return driver.FindElementsByCssSelector($"[{attribute}]");
        }

        /// <summary>
        /// Gets all elements with the blank target attribute
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithBlankTargetAttribute(this IWebDriver driver)
        {
            TestStepLog.GenerateTestStep("GetElementsWithBlankTargetAttribute executed", "", "", BrowserFactory.Stopwatch.Elapsed);
            return driver.FindElementsByCssSelector($"[target = _blank]");
        }

        /// <summary>
        /// Gets all elements with an attribute containing a specified value
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <param name="attribute">The attribute</param>
        /// <param name="value">The value</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithAttributeContainingValue(this IWebDriver driver, string attribute, string value)
        {
            TestStepLog.GenerateTestStep($"GetElementsWithAttributeContainingValue executed. attribute: {attribute}, value: {value}", "", "", BrowserFactory.Stopwatch.Elapsed);
            return driver.FindElementsByCssSelector($"[{attribute}~={value}]");
        }

        /// <summary>
        /// Gets all elements with an attribute starting with a specified value
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <param name="attribute">The attribute</param>
        /// <param name="value">The value</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithAttributeStartingWithValue(this IWebDriver driver, string attribute, string value)
        {
            TestStepLog.GenerateTestStep($"GetElementsWithAttributeStartingWithValue executed. attribute: {attribute}, value: {value}", "", "", BrowserFactory.Stopwatch.Elapsed);
            return driver.FindElementsByCssSelector($"[{attribute}|={value}]");
        }

        /// <summary>
        /// Gets all elements with a tag and attribute starting with a specified value
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <param name="tag">the tag</param>
        /// <param name="attribute">The attribute</param>
        /// <param name="value">The value</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithTagAndAttributeStartingWithValue(this IWebDriver driver, string tag, string attribute, string value)
        {
            TestStepLog.GenerateTestStep($"GetElementsWithTagAndAttributeStartingWithValue executed. tag: {tag}, attribute: {attribute}, value: {value}", "", "", BrowserFactory.Stopwatch.Elapsed);
            return driver.FindElementsByCssSelector($"{tag}[{attribute}^='{value}']");
        }

        /// <summary>
        /// Gets all elements with a tag and attribute ending with a specified value
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <param name="tag">The tag</param>
        /// <param name="attribute">The attribute</param>
        /// <param name="value">The value</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithTagAndAttributeEndingWithValue(this IWebDriver driver, string tag, string attribute, string value)
        {
            TestStepLog.GenerateTestStep($"GetElementsWithTagAndAttributeEndingWithValue executed. tag: {tag}, attribute: {attribute}, value: {value}", "", "", BrowserFactory.Stopwatch.Elapsed);
            return driver.FindElementsByCssSelector($"{tag}[{attribute}$='{value}']");
        }

        /// <summary>
        /// Gets all elements with a tag and attribute starting with one value and ending with a second value
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <param name="tag">The tag</param>
        /// <param name="attribute">The attribute</param>
        /// <param name="startsWith">The beginning of the value</param>
        /// <param name="endsWith">The end of the value</param>
        /// <returns></returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithTagAndAttributeStartAndEndingWithValues(this IWebDriver driver, string tag, string attribute, string startsWith, string endsWith)
        {
            TestStepLog.GenerateTestStep($"GetElementsWithTagAndAttributeStartAndEndingWithValues executed. tag: {tag}, attribute: {attribute}, startsWith: {startsWith}, endsWith: {endsWith}", "", "", BrowserFactory.Stopwatch.Elapsed);
            return driver.FindElementsByCssSelector($"{tag}[{attribute}^='{startsWith}'][{attribute}$='{endsWith}']");
        }

        /// <summary>
        /// Gets all elements with a tag and attribute containing a specified value
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <param name="tag">The tag</param>
        /// <param name="attribute">The attribute</param>
        /// <param name="value">The value</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithTagAndAttributeContainingValue(this IWebDriver driver, string tag, string attribute, string value)
        {
            TestStepLog.GenerateTestStep($"GetElementsWithTagAndAttributeContainingValue executed. tag: {tag}, attribute: {attribute}, value: {value}", "", "", BrowserFactory.Stopwatch.Elapsed);
            return driver.FindElementsByCssSelector($"{tag}[{attribute}*='{value}']");
        }

        /// <summary>
        /// Gets all elements that are active web links
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetActiveWebLink(this IWebDriver driver)
        {
            TestStepLog.GenerateTestStep("GetActiveWebLink executed", "", "", BrowserFactory.Stopwatch.Elapsed);
            return driver.FindElementsByCssSelector("a:active");
        }

        /// <summary>
        /// Gets all elements that have a checked state
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithCheckedState(this IWebDriver driver)
        {
            TestStepLog.GenerateTestStep("GetElementsWithCheckedState executed", "", "", BrowserFactory.Stopwatch.Elapsed);
            return driver.FindElementsByCssSelector("input:checked");
        }

        /// <summary>
        /// Gets all elements that have a default state
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithDefaultState(this IWebDriver driver)
        {
            TestStepLog.GenerateTestStep("GetElementsWithDefaultState executed", "", "", BrowserFactory.Stopwatch.Elapsed);
            return driver.FindElementsByCssSelector("input:default");
        }

        /// <summary>
        /// Gets all elements that have a disabled state
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithDisabledState(this IWebDriver driver)
        {
            TestStepLog.GenerateTestStep("GetElementsWithDisabledState executed", "", "", BrowserFactory.Stopwatch.Elapsed);
            return driver.FindElementsByCssSelector("input:disabled");
        }

        /// <summary>
        /// Gets all elements by tag that have no children
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <param name="tag">The tag</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsByTagAndNoChildren(this IWebDriver driver, string tag)
        {
            TestStepLog.GenerateTestStep($"GetElementsByTagAndNoChildren: {tag}", "", "", BrowserFactory.Stopwatch.Elapsed);
            return driver.FindElementsByCssSelector($"{tag}:empty");
        }

        /// <summary>
        /// Gets all elements with an enabled state
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithEnabledState(this IWebDriver driver)
        {
            TestStepLog.GenerateTestStep("GetElementsWithEnabledState executed", "", "", BrowserFactory.Stopwatch.Elapsed);
            return driver.FindElementsByCssSelector("input:enabled");
        }

        /// <summary>
        /// Gets all elements by tag that have a first child
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <param name="tag"></param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsByTagAndFirstChild(this IWebDriver driver, string tag)
        {
            TestStepLog.GenerateTestStep($"GetElementsByTagAndFirstChild: {tag}", "", "", BrowserFactory.Stopwatch.Elapsed);
            return driver.FindElementsByCssSelector($"{tag}:first-child");
        }

        /// <summary>
        /// Gets all elements by tag that have a first of type parent
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <param name="tag">The tag</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsByTagAndFirstTypeOfParent(this IWebDriver driver, string tag)
        {
            TestStepLog.GenerateTestStep($"GetElementsByTagAndFirstTypeOfParent: {tag}", "", "", BrowserFactory.Stopwatch.Elapsed);
            return driver.FindElementsByCssSelector($"{tag}:first-of-type");
        }

        /// <summary>
        /// Gets all elements that are focused
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementByFocus(this IWebDriver driver)
        {
            TestStepLog.GenerateTestStep("GetElementByFocus executed", "", "", BrowserFactory.Stopwatch.Elapsed);
            return driver.FindElementsByCssSelector("input:focus");
        }

        /// <summary>
        /// Gets all elements with a value that's in range
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithValueInRange(this IWebDriver driver)
        {
            TestStepLog.GenerateTestStep("GetElementsWithValueInRange executed", "", "", BrowserFactory.Stopwatch.Elapsed);
            return driver.FindElementsByCssSelector("input:in-range");
        }

        /// <summary>
        /// Gets all elements with an indeterminate state
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithIndeterminateState(this IWebDriver driver)
        {
            TestStepLog.GenerateTestStep("GetElementsWithIndeterminateState executed", "", "", BrowserFactory.Stopwatch.Elapsed);
            return driver.FindElementsByCssSelector("input:indeterminate");
        }

        /// <summary>
        /// Gets all elements with an invalid value
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithInvalidValue(this IWebDriver driver)
        {
            TestStepLog.GenerateTestStep("GetElementsWithInvalidValue executed", "", "", BrowserFactory.Stopwatch.Elapsed);
            return driver.FindElementsByCssSelector("input:invalid");
        }

        /// <summary>
        /// Gets all elements by tag that have a last child
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <param name="tag">The tag</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsByTagAndLastChild(this IWebDriver driver, string tag)
        {
            TestStepLog.GenerateTestStep($"GetElementsByTagAndLastChild: {tag}", "", "", BrowserFactory.Stopwatch.Elapsed);
            return driver.FindElementsByCssSelector($"{tag}:last-child");
        }

        /// <summary>
        /// Gets all elements by tag that have a last of type
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <param name="tag">The tag</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsByTagAndLastTypeOfParent(this IWebDriver driver, string tag)
        {
            TestStepLog.GenerateTestStep($"GetElementsByTagAndLastTypeOfParent: {tag}", "", "", BrowserFactory.Stopwatch.Elapsed);
            return driver.FindElementsByCssSelector($"{tag}:last-of-type");
        }

        /// <summary>
        /// Gets all elements that are links with an unvisited state
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetUnvisitedLinks(this IWebDriver driver)
        {
            TestStepLog.GenerateTestStep("GetUnvisitedLinks executed", "", "", BrowserFactory.Stopwatch.Elapsed);
            return driver.FindElementsByCssSelector("a:link");
        }

        /// <summary>
        /// Gets all elements that lack a specific tag
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <param name="tag">The tag</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsByNotTag(this IWebDriver driver, string tag)
        {
            TestStepLog.GenerateTestStep($"GetElementsByNotTag: {tag}", "", "", BrowserFactory.Stopwatch.Elapsed);
            return driver.FindElementsByCssSelector($":not({tag})");
        }

        /// <summary>
        /// Gets all elements by tag and child index
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <param name="tag">The tag</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsByTagAndChildIndex(this IWebDriver driver, string tag)
        {
            TestStepLog.GenerateTestStep($"GetElementsByTagAndChildIndex: {tag}", "", "", BrowserFactory.Stopwatch.Elapsed);
            return driver.FindElementsByCssSelector($"{tag}:nth-child(2)");
        }

        /// <summary>
        /// Gets all elements by tag and the index of the reversed child
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <param name="tag">The tag</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsByTagAndReversedChildIndex(this IWebDriver driver, string tag)
        {
            TestStepLog.GenerateTestStep($"GetElementsByTagAndReversedChildIndex: {tag}", "", "", BrowserFactory.Stopwatch.Elapsed);
            return driver.FindElementsByCssSelector($"{tag}:nth-last-child(2)");
        }

        /// <summary>
        /// Gets all elements by tag and the index of the child of type
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <param name="tag">The tag</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsBySameTagAndChildIndex(this IWebDriver driver, string tag)
        {
            TestStepLog.GenerateTestStep($"GetElementsBySameTagAndChildIndex: {tag}", "", "", BrowserFactory.Stopwatch.Elapsed);
            return driver.FindElementsByCssSelector($"{tag}:nth-of-type(2)");
        }

        /// <summary>
        /// Gets all elements by tag and the index of the last child of type
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <param name="tag">The tag</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsBySameTagAndReversedChildIndex(this IWebDriver driver, string tag)
        {
            TestStepLog.GenerateTestStep($"GetElementsBySameTagAndReversedChildIndex: {tag}", "", "", BrowserFactory.Stopwatch.Elapsed);
            return driver.FindElementsByCssSelector($"{tag}:nth-last-of-type(2)");
        }

        /// <summary>
        /// Gets all elements by tag and the index of the only child of type
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <param name="tag">The tag</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsBySameTagAndOnlyChildOfType(this IWebDriver driver, string tag)
        {
            TestStepLog.GenerateTestStep($"GetElementsBySameTagAndOnlyChildOfType: {tag}", "", "", BrowserFactory.Stopwatch.Elapsed);
            return driver.FindElementsByCssSelector($"{tag}:only-of-type");
        }

        /// <summary>
        /// Gets all elements by tag that have an only child
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <param name="tag">The tag</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsByTagAndOnlyChild(this IWebDriver driver, string tag)
        {
            TestStepLog.GenerateTestStep($"GetElementsByTagAndOnlyChild: {tag}", "", "", BrowserFactory.Stopwatch.Elapsed);
            return driver.FindElementsByCssSelector($"{tag}:only-child");
        }

        /// <summary>
        /// Gets all elements without the required attribute
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithoutRequiredAttribute(this IWebDriver driver)
        {
            TestStepLog.GenerateTestStep("GetElementsWithoutRequiredAttribute executed", "", "", BrowserFactory.Stopwatch.Elapsed);
            return driver.FindElementsByCssSelector("input:optional");
        }

        /// <summary>
        /// Gets all elements that have an out of range value
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithValueOutOfRange(this IWebDriver driver)
        {
            TestStepLog.GenerateTestStep("GetElementsWithValueOutOfRange executed", "", "", BrowserFactory.Stopwatch.Elapsed);
            return driver.FindElementsByCssSelector("input:out-of-range");
        }

        /// <summary>
        /// Gets all elements that have a placeholder value
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithPlaceholderValue(this IWebDriver driver)
        {
            TestStepLog.GenerateTestStep("GetElementsWithPlaceholderValue executed", "", "", BrowserFactory.Stopwatch.Elapsed);
            return driver.FindElementsByCssSelector("input::placeholder");
        }

        /// <summary>
        /// Gets all elements that have the read only attribute
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithReadOnlyAttribute(this IWebDriver driver)
        {
            TestStepLog.GenerateTestStep("GetElementsWithReadOnlyAttribute executed", "", "", BrowserFactory.Stopwatch.Elapsed);
            return driver.FindElementsByCssSelector("input:read-only");
        }

        /// <summary>
        /// Gets all elements thatlack the read only attribute
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithoutReadOnlyAttribute(this IWebDriver driver)
        {
            TestStepLog.GenerateTestStep("GetElementsWithoutReadOnlyAttribute executed", "", "", BrowserFactory.Stopwatch.Elapsed);
            return driver.FindElementsByCssSelector("input:read-write");
        }

        /// <summary>
        /// Gets all elements with the required attribute
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithRequiredAttribute(this IWebDriver driver)
        {
            TestStepLog.GenerateTestStep("GetElementsWithRequiredAttribute executed", "", "", BrowserFactory.Stopwatch.Elapsed);
            return driver.FindElementsByCssSelector("input:required");
        }

        /// <summary>
        /// Gets all elements at the root
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementAtRoot(this IWebDriver driver)
        {
            TestStepLog.GenerateTestStep("GetElementAtRoot executed", "", "", BrowserFactory.Stopwatch.Elapsed);
            return driver.FindElementsByCssSelector(":root");
        }

        /// <summary>
        /// Gets all elements selected by the user
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsSelectedByUser(this IWebDriver driver)
        {
            TestStepLog.GenerateTestStep("GetElementsSelectedByUser executed", "", "", BrowserFactory.Stopwatch.Elapsed);
            return driver.FindElementsByCssSelector("::selection");
        }

        /// <summary>
        /// Gets all elements with a valid value
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithValidValue(this IWebDriver driver)
        {
            TestStepLog.GenerateTestStep("GetElementsWithValidValue executed", "", "", BrowserFactory.Stopwatch.Elapsed);
            return driver.FindElementsByCssSelector("input:valid");
        }

        /// <summary>
        /// Gets all visited web links
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetVisitedWebLinks(this IWebDriver driver)
        {
            TestStepLog.GenerateTestStep("GetVisitedWebLinks executed", "", "", BrowserFactory.Stopwatch.Elapsed);
            return driver.FindElementsByCssSelector("a:visited");
        }

        #endregion CSS Selectors (IWebDriver)

        #region CSS Selectors (IWebElement)

        /// <summary>
        /// Gets all elements by css selector
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetAllElements(this IWebElement webElement)
        {
            TestStepLog.GenerateTestStep("GetAllElements executed", "", "", BrowserFactory.Stopwatch.Elapsed);
            return webElement.FindElementsByCssSelector("*");
        }

        /// <summary>
        /// Gets all elements by hierarchy using a css selector.  EX: div, p | div p | div > p | div + p | p ~ ul
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <param name="hierarchy">The hierarchy string</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsByTagHierarchy(this IWebElement webElement, string hierarchy)
        {
            TestStepLog.GenerateTestStep($"GetElementsByTagHierarchy: {hierarchy}", "", "", BrowserFactory.Stopwatch.Elapsed);
            return webElement.FindElementsByCssSelector(hierarchy);
        }

        /// <summary>
        /// Gets all elements with a target attribute
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <param name="attribute">the target attribute</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithTargetAttribute(this IWebElement webElement, string attribute)
        {
            TestStepLog.GenerateTestStep($"GetElementsWithTargetAttribute: {attribute}", "", "", BrowserFactory.Stopwatch.Elapsed);
            return webElement.FindElementsByCssSelector($"[{attribute}]");
        }

        /// <summary>
        /// Gets all elements with the blank target attribute
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithBlankTargetAttribute(this IWebElement webElement)
        {
            TestStepLog.GenerateTestStep("GetElementsWithBlankTargetAttribute executed", "", "", BrowserFactory.Stopwatch.Elapsed);
            return webElement.FindElementsByCssSelector($"[target = _blank]");
        }

        /// <summary>
        /// Gets all elements with an attribute containing a specified value
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <param name="attribute">The attribute</param>
        /// <param name="value">The value</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithAttributeContainingValue(this IWebElement webElement, string attribute, string value)
        {
            TestStepLog.GenerateTestStep($"GetElementsWithAttributeContainingValue executed. attribute: {attribute}, value: {value}", "", "", BrowserFactory.Stopwatch.Elapsed);
            return webElement.FindElementsByCssSelector($"[{attribute}~={value}]");
        }

        /// <summary>
        /// Gets all elements with an attribute starting with a specified value
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <param name="attribute">The attribute</param>
        /// <param name="value">The value</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithAttributeStartingWithValue(this IWebElement webElement, string attribute, string value)
        {
            TestStepLog.GenerateTestStep($"GetElementsWithAttributeStartingWithValue executed. attribute: {attribute}, value: {value}", "", "", BrowserFactory.Stopwatch.Elapsed);
            return webElement.FindElementsByCssSelector($"[{attribute}|={value}]");
        }

        /// <summary>
        /// Gets all elements with a tag and attribute starting with a specified value
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <param name="tag">the tag</param>
        /// <param name="attribute">The attribute</param>
        /// <param name="value">The value</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithTagAndAttributeStartingWithValue(this IWebElement webElement, string tag, string attribute, string value)
        {
            TestStepLog.GenerateTestStep($"GetElementsWithTagAndAttributeStartingWithValue executed. tag: {tag}, attribute: {attribute}, value: {value}", "", "", BrowserFactory.Stopwatch.Elapsed);
            return webElement.FindElementsByCssSelector($"{tag}[{attribute}^='{value}']");
        }

        /// <summary>
        /// Gets all elements with a tag and attribute ending with a specified value
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <param name="tag">The tag</param>
        /// <param name="attribute">The attribute</param>
        /// <param name="value">The value</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithTagAndAttributeEndingWithValue(this IWebElement webElement, string tag, string attribute, string value)
        {
            TestStepLog.GenerateTestStep($"GetElementsWithTagAndAttributeEndingWithValue executed. tag: {tag}, attribute: {attribute}, value: {value}", "", "", BrowserFactory.Stopwatch.Elapsed);
            return webElement.FindElementsByCssSelector($"{tag}[{attribute}$='{value}']");
        }

        /// <summary>
        /// Gets all elements with a tag and attribute starting with one value and ending with a second value
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <param name="tag">The tag</param>
        /// <param name="attribute">The attribute</param>
        /// <param name="startsWith">The beginning of the value</param>
        /// <param name="endsWith">The end of the value</param>
        /// <returns></returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithTagAndAttributeStartAndEndingWithValues(this IWebElement webElement, string tag, string attribute, string startsWith, string endsWith)
        {
            TestStepLog.GenerateTestStep($"GetElementsWithTagAndAttributeStartAndEndingWithValues executed. tag: {tag}, attribute: {attribute}, startsWith: {startsWith}, endsWith: {endsWith}", "", "", BrowserFactory.Stopwatch.Elapsed);
            return webElement.FindElementsByCssSelector($"{tag}[{attribute}^='{startsWith}'][{attribute}$='{endsWith}']");
        }

        /// <summary>
        /// Gets all elements with a tag and attribute containing a specified value
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <param name="tag">The tag</param>
        /// <param name="attribute">The attribute</param>
        /// <param name="value">The value</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithTagAndAttributeContainingValue(this IWebElement webElement, string tag, string attribute, string value)
        {
            TestStepLog.GenerateTestStep($"GetElementsWithTagAndAttributeContainingValue executed. tag: {tag}, attribute: {attribute}, value: {value}", "", "", BrowserFactory.Stopwatch.Elapsed);
            return webElement.FindElementsByCssSelector($"{tag}[{attribute}*='{value}']");
        }

        /// <summary>
        /// Gets all elements that are active web links
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetActiveWebLink(this IWebElement webElement)
        {
            TestStepLog.GenerateTestStep("GetActiveWebLink executed", "", "", BrowserFactory.Stopwatch.Elapsed);
            return webElement.FindElementsByCssSelector("a:active");
        }

        /// <summary>
        /// Gets all elements that have a checked state
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithCheckedState(this IWebElement webElement)
        {
            TestStepLog.GenerateTestStep("GetElementsWithCheckedState executed", "", "", BrowserFactory.Stopwatch.Elapsed);
            return webElement.FindElementsByCssSelector("input:checked");
        }

        /// <summary>
        /// Gets all elements that have a default state
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithDefaultState(this IWebElement webElement)
        {
            TestStepLog.GenerateTestStep("GetElementsWithDefaultState executed", "", "", BrowserFactory.Stopwatch.Elapsed);
            return webElement.FindElementsByCssSelector("input:default");
        }

        /// <summary>
        /// Gets all elements that have a disabled state
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithDisabledState(this IWebElement webElement)
        {
            TestStepLog.GenerateTestStep("GetElementsWithDisabledState executed", "", "", BrowserFactory.Stopwatch.Elapsed);
            return webElement.FindElementsByCssSelector("input:disabled");
        }

        /// <summary>
        /// Gets all elements by tag that have no children
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <param name="tag">The tag</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsByTagAndNoChildren(this IWebElement webElement, string tag)
        {
            TestStepLog.GenerateTestStep("GetElementsByTagAndNoChildren executed", "", "", BrowserFactory.Stopwatch.Elapsed);
            return webElement.FindElementsByCssSelector($"{tag}:empty");
        }

        /// <summary>
        /// Gets all elements with an enabled state
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithEnabledState(this IWebElement webElement)
        {
            TestStepLog.GenerateTestStep("GetElementsWithEnabledState executed", "", "", BrowserFactory.Stopwatch.Elapsed);
            return webElement.FindElementsByCssSelector("input:enabled");
        }

        /// <summary>
        /// Gets all elements by tag that have a first child
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <param name="tag"></param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsByTagAndFirstChild(this IWebElement webElement, string tag)
        {
            TestStepLog.GenerateTestStep($"GetElementsByTagAndFirstChild: {tag}", "", "", BrowserFactory.Stopwatch.Elapsed);
            return webElement.FindElementsByCssSelector($"{tag}:first-child");
        }

        /// <summary>
        /// Gets all elements by tag that have a first of type parent
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <param name="tag">The tag</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsByTagAndFirstTypeOfParent(this IWebElement webElement, string tag)
        {
            TestStepLog.GenerateTestStep($"GetElementsByTagAndFirstTypeOfParent: {tag}", "", "", BrowserFactory.Stopwatch.Elapsed);
            return webElement.FindElementsByCssSelector($"{tag}:first-of-type");
        }

        /// <summary>
        /// Gets all elements that are focused
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementByFocus(this IWebElement webElement)
        {
            TestStepLog.GenerateTestStep("GetElementByFocus executed", "", "", BrowserFactory.Stopwatch.Elapsed);
            return webElement.FindElementsByCssSelector("input:focus");
        }

        /// <summary>
        /// Gets all elements with a value that's in range
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithValueInRange(this IWebElement webElement)
        {
            TestStepLog.GenerateTestStep("GetElementsWithValueInRange executed", "", "", BrowserFactory.Stopwatch.Elapsed);
            return webElement.FindElementsByCssSelector("input:in-range");
        }

        /// <summary>
        /// Gets all elements with an indeterminate state
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithIndeterminateState(this IWebElement webElement)
        {
            TestStepLog.GenerateTestStep("GetElementsWithIndeterminateState executed", "", "", BrowserFactory.Stopwatch.Elapsed);
            return webElement.FindElementsByCssSelector("input:indeterminate");
        }

        /// <summary>
        /// Gets all elements with an invalid value
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithInvalidValue(this IWebElement webElement)
        {
            TestStepLog.GenerateTestStep("GetElementsWithInvalidValue executed", "", "", BrowserFactory.Stopwatch.Elapsed);
            return webElement.FindElementsByCssSelector("input:invalid");
        }

        /// <summary>
        /// Gets all elements by tag that have a last child
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <param name="tag">The tag</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsByTagAndLastChild(this IWebElement webElement, string tag)
        {
            TestStepLog.GenerateTestStep($"GetElementsByTagAndLastChild: {tag}", "", "", BrowserFactory.Stopwatch.Elapsed);
            return webElement.FindElementsByCssSelector($"{tag}:last-child");
        }

        /// <summary>
        /// Gets all elements by tag that have a last of type
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <param name="tag">The tag</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsByTagAndLastTypeOfParent(this IWebElement webElement, string tag)
        {
            TestStepLog.GenerateTestStep($"GetElementsByTagAndLastTypeOfParent: {tag}", "", "", BrowserFactory.Stopwatch.Elapsed);
            return webElement.FindElementsByCssSelector($"{tag}:last-of-type");
        }

        /// <summary>
        /// Gets all elements that are links with an unvisited state
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetUnvisitedLinks(this IWebElement webElement)
        {
            TestStepLog.GenerateTestStep("GetUnvisitedLinks executed", "", "", BrowserFactory.Stopwatch.Elapsed);
            return webElement.FindElementsByCssSelector("a:link");
        }

        /// <summary>
        /// Gets all elements that lack a specific tag
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <param name="tag">The tag</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsByNotTag(this IWebElement webElement, string tag)
        {
            TestStepLog.GenerateTestStep($"GetElementsByNotTag: {tag}", "", "", BrowserFactory.Stopwatch.Elapsed);
            return webElement.FindElementsByCssSelector($":not({tag})");
        }

        /// <summary>
        /// Gets all elements by tag and child index
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <param name="tag">The tag</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsByTagAndChildIndex(this IWebElement webElement, string tag)
        {
            TestStepLog.GenerateTestStep($"GetElementsByTagAndChildIndex: {tag}", "", "", BrowserFactory.Stopwatch.Elapsed);
            return webElement.FindElementsByCssSelector($"{tag}:nth-child(2)");
        }

        /// <summary>
        /// Gets all elements by tag and the index of the reversed child
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <param name="tag">The tag</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsByTagAndReversedChildIndex(this IWebElement webElement, string tag)
        {
            TestStepLog.GenerateTestStep($"GetElementsByTagAndReversedChildIndex: {tag}", "", "", BrowserFactory.Stopwatch.Elapsed);
            return webElement.FindElementsByCssSelector($"{tag}:nth-last-child(2)");
        }

        /// <summary>
        /// Gets all elements by tag and the index of the child of type
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <param name="tag">The tag</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsBySameTagAndChildIndex(this IWebElement webElement, string tag)
        {
            TestStepLog.GenerateTestStep($"GetElementsBySameTagAndChildIndex: {tag}", "", "", BrowserFactory.Stopwatch.Elapsed);
            return webElement.FindElementsByCssSelector($"{tag}:nth-of-type(2)");
        }

        /// <summary>
        /// Gets all elements by tag and the index of the last child of type
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <param name="tag">The tag</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsBySameTagAndReversedChildIndex(this IWebElement webElement, string tag)
        {
            TestStepLog.GenerateTestStep($"GetElementsBySameTagAndReversedChildIndex: {tag}", "", "", BrowserFactory.Stopwatch.Elapsed);
            return webElement.FindElementsByCssSelector($"{tag}:nth-last-of-type(2)");
        }

        /// <summary>
        /// Gets all elements by tag and the index of the only child of type
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <param name="tag">The tag</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsBySameTagAndOnlyChildOfType(this IWebElement webElement, string tag)
        {
            TestStepLog.GenerateTestStep($"GetElementsBySameTagAndOnlyChildOfType: {tag}", "", "", BrowserFactory.Stopwatch.Elapsed);
            return webElement.FindElementsByCssSelector($"{tag}:only-of-type");
        }

        /// <summary>
        /// Gets all elements by tag that have an only child
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <param name="tag">The tag</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsByTagAndOnlyChild(this IWebElement webElement, string tag)
        {
            TestStepLog.GenerateTestStep($"GetElementsByTagAndOnlyChild: {tag}", "", "", BrowserFactory.Stopwatch.Elapsed);
            return webElement.FindElementsByCssSelector($"{tag}:only-child");
        }

        /// <summary>
        /// Gets all elements without the required attribute
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithoutRequiredAttribute(this IWebElement webElement)
        {
            TestStepLog.GenerateTestStep("GetElementsWithoutRequiredAttribute executed", "", "", BrowserFactory.Stopwatch.Elapsed);
            return webElement.FindElementsByCssSelector("input:optional");
        }

        /// <summary>
        /// Gets all elements that have an out of range value
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithValueOutOfRange(this IWebElement webElement)
        {
            TestStepLog.GenerateTestStep("GetElementsWithValueOutOfRange executed", "", "", BrowserFactory.Stopwatch.Elapsed);
            return webElement.FindElementsByCssSelector("input:out-of-range");
        }

        /// <summary>
        /// Gets all elements that have a placeholder value
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithPlaceholderValue(this IWebElement webElement)
        {
            TestStepLog.GenerateTestStep("GetElementsWithPlaceholderValue executed", "", "", BrowserFactory.Stopwatch.Elapsed);
            return webElement.FindElementsByCssSelector("input::placeholder");
        }

        /// <summary>
        /// Gets all elements that have the read only attribute
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithReadOnlyAttribute(this IWebElement webElement)
        {
            TestStepLog.GenerateTestStep("GetElementsWithReadOnlyAttribute executed", "", "", BrowserFactory.Stopwatch.Elapsed);
            return webElement.FindElementsByCssSelector("input:read-only");
        }

        /// <summary>
        /// Gets all elements thatlack the read only attribute
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithoutReadOnlyAttribute(this IWebElement webElement)
        {
            TestStepLog.GenerateTestStep("GetElementsWithoutReadOnlyAttribute executed", "", "", BrowserFactory.Stopwatch.Elapsed);
            return webElement.FindElementsByCssSelector("input:read-write");
        }

        /// <summary>
        /// Gets all elements with the required attribute
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithRequiredAttribute(this IWebElement webElement)
        {
            TestStepLog.GenerateTestStep("GetElementsWithRequiredAttribute executed", "", "", BrowserFactory.Stopwatch.Elapsed);
            return webElement.FindElementsByCssSelector("input:required");
        }

        /// <summary>
        /// Gets all elements at the root
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementAtRoot(this IWebElement webElement)
        {
            TestStepLog.GenerateTestStep("GetElementAtRoot executed", "", "", BrowserFactory.Stopwatch.Elapsed);
            return webElement.FindElementsByCssSelector(":root");
        }

        /// <summary>
        /// Gets all elements selected by the user
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsSelectedByUser(this IWebElement webElement)
        {
            TestStepLog.GenerateTestStep("GetElementsSelectedByUser executed", "", "", BrowserFactory.Stopwatch.Elapsed);
            return webElement.FindElementsByCssSelector("::selection");
        }

        /// <summary>
        /// Gets all elements with a valid value
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithValidValue(this IWebElement webElement)
        {
            TestStepLog.GenerateTestStep("GetElementsWithValidValue executed", "", "", BrowserFactory.Stopwatch.Elapsed);
            return webElement.FindElementsByCssSelector("input:valid");
        }

        /// <summary>
        /// Gets all visited web links
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetVisitedWebLinks(this IWebElement webElement)
        {
            TestStepLog.GenerateTestStep("GetVisitedWebLinks executed", "", "", BrowserFactory.Stopwatch.Elapsed);
            return webElement.FindElementsByCssSelector("a:visited");
        }

        #endregion CSS Selectors (IWebElement)
    }
}
