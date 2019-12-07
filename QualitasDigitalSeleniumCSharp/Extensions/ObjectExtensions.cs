using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Support.UI;
using System;
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

        public static void DragAndDrop(this IWebElement element, int xPos, int yPos)
        {
            IWebDriver driver = ((IWrapsDriver)element).WrappedDriver;
            Actions move = new Actions(driver);
            move.DragAndDropToOffset(element, xPos, yPos).Perform();
        }

        public static void ScrollTo(this IWebElement element)
        {
            string js = $"window.scroll(0, {element.Location.Y});";
            IWebDriver driver = ((IWrapsDriver)element).WrappedDriver;
            ((IJavaScriptExecutor)driver).ExecuteScript(js);
        }

        public static void WaitForVisibility(this IWebElement element, string cssSelector, int timeLimit = 30)
        {
            IWebDriver driver = ((IWrapsDriver)element).WrappedDriver;
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeLimit));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.CssSelector(cssSelector)));
        }

        #endregion Advanced Element Operations

        #region CSS Selectors

        public static IReadOnlyCollection<IWebElement> GetAllElements(this IWebDriver driver)
        {
            return driver.FindElementsByCssSelector("*");
        }

        /// <summary>
        /// Gets all elements by hierarchy using a css selector.  EX: div, p | div p | div > p | div + p | p ~ ul
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="hierarchy"></param>
        /// <returns></returns>
        public static IReadOnlyCollection<IWebElement> GetElementsByTagHierarchy(this IWebDriver driver, string hierarchy)
        {
            return driver.FindElementsByCssSelector(hierarchy);
        }

        public static IReadOnlyCollection<IWebElement> GetElementsWithTargetAttribute(this IWebDriver driver, string attribute)
        {
            return driver.FindElementsByCssSelector($"[{attribute}]");
        }

        public static IReadOnlyCollection<IWebElement> GetElementsWithBlankTargetAttribute(this IWebDriver driver)
        {
            return driver.FindElementsByCssSelector($"[target = _blank]");
        }

        public static IReadOnlyCollection<IWebElement> GetElementsWithAttributeContainingValue(this IWebDriver driver, string attribute, string value)
        {
            return driver.FindElementsByCssSelector($"[{attribute}~={value}]");
        }

        public static IReadOnlyCollection<IWebElement> GetElementsWithAttributeStartingWithValue(this IWebDriver driver, string attribute, string value)
        {
            return driver.FindElementsByCssSelector($"[{attribute}|={value}]");
        }

        public static IReadOnlyCollection<IWebElement> GetElementsWithTagAndAttributeStartingWithValue(this IWebDriver driver, string tag, string attribute, string value)
        {
            return driver.FindElementsByCssSelector($"{tag}[{attribute}^='{value}']");
        }

        public static IReadOnlyCollection<IWebElement> GetElementsWithTagAndAttributeEndingWithValue(this IWebDriver driver, string tag, string attribute, string value)
        {
            return driver.FindElementsByCssSelector($"{tag}[{attribute}$='{value}']");
        }

        public static IReadOnlyCollection<IWebElement> GetElementsWithTagAndAttributeContainingValue(this IWebDriver driver, string tag, string attribute, string value)
        {
            return driver.FindElementsByCssSelector($"{tag}[{attribute}*='{value}']");
        }

        public static IReadOnlyCollection<IWebElement> GetActiveWebLink(this IWebDriver driver)
        {
            return driver.FindElementsByCssSelector("a:active");
        }

        public static IReadOnlyCollection<IWebElement> GetElementsWithCheckedState(this IWebDriver driver)
        {
            return driver.FindElementsByCssSelector("input:checked");
        }

        public static IReadOnlyCollection<IWebElement> GetElementsWithDefaultState(this IWebDriver driver)
        {
            return driver.FindElementsByCssSelector("input:default");
        }

        public static IReadOnlyCollection<IWebElement> GetElementsWithDisabledState(this IWebDriver driver)
        {
            return driver.FindElementsByCssSelector("input:disabled");
        }

        public static IReadOnlyCollection<IWebElement> GetElementsByTagAndNoChildren(this IWebDriver driver, string tag)
        {
            return driver.FindElementsByCssSelector($"{tag}:empty");
        }

        public static IReadOnlyCollection<IWebElement> GetElementsWithEnabledState(this IWebDriver driver)
        {
            return driver.FindElementsByCssSelector("input:enabled");
        }

        public static IReadOnlyCollection<IWebElement> GetElementsByTagAndFirstChild(this IWebDriver driver, string tag)
        {
            return driver.FindElementsByCssSelector($"{tag}:first-child");
        }

        public static IReadOnlyCollection<IWebElement> GetElementsByTagAndFirstTypeOfParent(this IWebDriver driver, string tag)
        {
            return driver.FindElementsByCssSelector($"{tag}:first-of-type");
        }

        public static IReadOnlyCollection<IWebElement> GetElementByFocus(this IWebDriver driver)
        {
            return driver.FindElementsByCssSelector("input:focus");
        }

        public static IReadOnlyCollection<IWebElement> GetElementsWithValueInRange(this IWebDriver driver)
        {
            return driver.FindElementsByCssSelector("input:in-range");
        }

        public static IReadOnlyCollection<IWebElement> GetElementsWithIndeterminateState(this IWebDriver driver)
        {
            return driver.FindElementsByCssSelector("input:indeterminate");
        }

        public static IReadOnlyCollection<IWebElement> GetElementsWithInvalidValue(this IWebDriver driver)
        {
            return driver.FindElementsByCssSelector("input:invalid");
        }

        public static IReadOnlyCollection<IWebElement> GetElementsByTagAndLastChild(this IWebDriver driver, string tag)
        {
            return driver.FindElementsByCssSelector($"{tag}:last-child");
        }

        public static IReadOnlyCollection<IWebElement> GetElementsByTagAndLastTypeOfParent(this IWebDriver driver, string tag)
        {
            return driver.FindElementsByCssSelector($"{tag}:last-of-type");
        }

        public static IReadOnlyCollection<IWebElement> GetUnvisitedLinks(this IWebDriver driver)
        {
            return driver.FindElementsByCssSelector("a:link");
        }

        public static IReadOnlyCollection<IWebElement> GetElementsByNotTag(this IWebDriver driver, string tag)
        {
            return driver.FindElementsByCssSelector($":not({tag})");
        }

        public static IReadOnlyCollection<IWebElement> GetElementsByTagAndChildIndex(this IWebDriver driver, string tag)
        {
            return driver.FindElementsByCssSelector($"{tag}:nth-child(2)");
        }

        public static IReadOnlyCollection<IWebElement> GetElementsByTagAndReversedChildIndex(this IWebDriver driver, string tag)
        {
            return driver.FindElementsByCssSelector($"{tag}:nth-last-child(2)");
        }

        public static IReadOnlyCollection<IWebElement> GetElementsBySameTagAndChildIndex(this IWebDriver driver, string tag)
        {
            return driver.FindElementsByCssSelector($"{tag}:nth-of-type(2)");
        }

        public static IReadOnlyCollection<IWebElement> GetElementsBySameTagAndReversedChildIndex(this IWebDriver driver, string tag)
        {
            return driver.FindElementsByCssSelector($"{tag}:nth-last-of-type(2)");
        }

        public static IReadOnlyCollection<IWebElement> GetElementsBySameTagAndOnlyChildOfType(this IWebDriver driver, string tag)
        {
            return driver.FindElementsByCssSelector($"{tag}:only-of-type");
        }

        public static IReadOnlyCollection<IWebElement> GetElementsByTagAndOnlyChild(this IWebDriver driver, string tag)
        {
            return driver.FindElementsByCssSelector($"{tag}:only-child");
        }

        public static IReadOnlyCollection<IWebElement> GetElementsWithoutRequiredAttribute(this IWebDriver driver)
        {
            return driver.FindElementsByCssSelector("input:optional");
        }

        public static IReadOnlyCollection<IWebElement> GetElementsWithValueOutOfRange(this IWebDriver driver)
        {
            return driver.FindElementsByCssSelector("input:out-of-range");
        }

        public static IReadOnlyCollection<IWebElement> GetElementsWithPlaceholderValue(this IWebDriver driver)
        {
            return driver.FindElementsByCssSelector("input::placeholder");
        }

        public static IReadOnlyCollection<IWebElement> GetElementsWithReadOnlyAttribute(this IWebDriver driver)
        {
            return driver.FindElementsByCssSelector("input:read-only");
        }

        public static IReadOnlyCollection<IWebElement> GetElementsWithoutReadOnlyAttribute(this IWebDriver driver)
        {
            return driver.FindElementsByCssSelector("input:read-write");
        }

        public static IReadOnlyCollection<IWebElement> GetElementsWithRequiredAttribute(this IWebDriver driver)
        {
            return driver.FindElementsByCssSelector("input:required");
        }

        public static IReadOnlyCollection<IWebElement> GetElementAtRoot(this IWebDriver driver)
        {
            return driver.FindElementsByCssSelector(":root");
        }

        public static IReadOnlyCollection<IWebElement> GetElementSelectedByUser(this IWebDriver driver)
        {
            return driver.FindElementsByCssSelector("::selection");
        }

        public static IReadOnlyCollection<IWebElement> GetElementsWithValidValue(this IWebDriver driver)
        {
            return driver.FindElementsByCssSelector("input:valid");
        }

        public static IReadOnlyCollection<IWebElement> GetVisitedWebLinks(this IWebDriver driver)
        {
            return driver.FindElementsByCssSelector("a:visited");
        }

        #endregion CSS Selectors
    }
}
