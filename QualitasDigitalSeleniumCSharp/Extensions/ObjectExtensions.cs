using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace QualitasDigitalSeleniumCSharp.Extensions
{
    public static class ObjectExtensions
    {
        #region Find Element

        public static IWebElement FindElementByClassName(this IWebDriver driver, string className)
        {
            return driver.FindElement(By.ClassName(className));
        }

        public static IWebElement FindElementByCssSelector(this IWebDriver driver, string cssSelector)
        {
            return driver.FindElement(By.CssSelector(cssSelector));
        }

        public static IWebElement FindElementById(this IWebDriver driver, string id)
        {
            return driver.FindElement(By.Id(id));
        }

        public static IWebElement FindElementByLinkText(this IWebDriver driver, string linkText)
        {
            return driver.FindElement(By.LinkText(linkText));
        }

        public static IWebElement FindElementByName(this IWebDriver driver, string name)
        {
            return driver.FindElement(By.Name(name));
        }

        public static IWebElement FindElementByPartialLinkText(this IWebDriver driver, string partialLinkText)
        {
            return driver.FindElement(By.PartialLinkText(partialLinkText));
        }

        public static IWebElement FindElementByTagName(this IWebDriver driver, string tagName)
        {
            return driver.FindElement(By.TagName(tagName));
        }

        public static IWebElement FindElementByXPath(this IWebDriver driver, string xPath)
        {
            return driver.FindElement(By.XPath(xPath));
        }

        #endregion Find Element

        #region Find Elements

        public static ReadOnlyCollection<IWebElement> FindElementsByClassName(this IWebDriver driver, string className)
        {
            return driver.FindElements(By.ClassName(className));
        }

        public static ReadOnlyCollection<IWebElement> FindElementsByCssSelector(this IWebDriver driver, string cssSelector)
        {
            return driver.FindElements(By.CssSelector(cssSelector));
        }

        public static ReadOnlyCollection<IWebElement> FindElementsById(this IWebDriver driver, string id)
        {
            return driver.FindElements(By.Id(id));
        }

        public static ReadOnlyCollection<IWebElement> FindElementsByLinkText(this IWebDriver driver, string linkText)
        {
            return driver.FindElements(By.LinkText(linkText));
        }

        public static ReadOnlyCollection<IWebElement> FindElementsByName(this IWebDriver driver, string name)
        {
            return driver.FindElements(By.Name(name));
        }

        public static ReadOnlyCollection<IWebElement> FindElementsByPartialLinkText(this IWebDriver driver, string partialLinkText)
        {
            return driver.FindElements(By.PartialLinkText(partialLinkText));
        }

        public static ReadOnlyCollection<IWebElement> FindElementsByTagName(this IWebDriver driver, string tagName)
        {
            return driver.FindElements(By.TagName(tagName));
        }

        public static ReadOnlyCollection<IWebElement> FindElementsByXPath(this IWebDriver driver, string xPath)
        {
            return driver.FindElements(By.XPath(xPath));
        }

        #endregion Find Elements

        #region Basic Element Operations

        public static void ClickWhenReady(this IWebElement element)
        {
            element.Click();
        }

        public static void EnterText(this IWebElement element, string value)
        {
            element.SendKeys(value);
        }

        public static void ClearElement(this IWebElement element)
        {
            element.Clear();
        }

        public static void SubmitElement(this IWebElement element)
        {
            element.Submit();
        }

        public static string GetInnertext(this IWebElement element)
        {
            return element.Text;
        }

        public static bool IsEnabled(this IWebElement element)
        {
            return element.Enabled;
        }

        public static bool IsDisplayed(this IWebElement element)
        {
            return element.Displayed;
        }

        public static bool IsSelected(this IWebElement element)
        {
            return element.Selected;
        }

        public static void SelectByIndex(this IWebElement element, int index)
        {
            new SelectElement(element).SelectByIndex(index);
        }

        public static void DeselectByIndex(this IWebElement element, int index)
        {
            new SelectElement(element).DeselectByIndex(index);
        }

        public static void SelectByText(this IWebElement element, string text)
        {
            new SelectElement(element).SelectByText(text);
        }

        public static void DeselectByText(this IWebElement element, string text)
        {
            new SelectElement(element).DeselectByText(text);
        }

        public static void SelectByValue(this IWebElement element, string value)
        {
            new SelectElement(element).SelectByValue(value);
        }

        public static void DeselectByValue(this IWebElement element, string value)
        {
            new SelectElement(element).DeselectByValue(value);
        }

        public static void DeselectAll(this IWebElement element)
        {
            new SelectElement(element).DeselectAll();
        }

        public static IWebElement GetSelectedOption(this IWebElement element)
        {
            return new SelectElement(element).SelectedOption;
        }

        public static IList<IWebElement> GetAllSelectedOptions(this IWebElement element)
        {
            return new SelectElement(element).AllSelectedOptions;
        }

        public static bool IsMultipleSelect(this IWebElement element)
        {
            return new SelectElement(element).IsMultiple;
        }

        #endregion Basic Element Operations

        #region Advanced Element Operations
        #endregion Advanced Element Operations

        #region Basic Browser Operations
        #endregion Basic Browser Operations

        #region Advanced Browser Operations
        #endregion Advanced Browser Operations

        #region Advanced Browser Configurations
        #endregion Advanced Browser Configurations
    }
}
