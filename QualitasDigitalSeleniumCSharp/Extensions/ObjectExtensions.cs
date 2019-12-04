using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;

namespace QualitasDigitalSeleniumCSharp.Extensions
{
    public static class ObjectExtensions
    {
        public static void EnterText(this IWebElement element, string value)
        {
            element.SendKeys(value);
        }

        public static void SelectDropDownByText(this IWebElement element, string value)
        {
            new SelectElement(element).SelectByText(value);
        }

        public static void SelectDropDownByIndex(this IWebElement element, int index)
        {
            new SelectElement(element).SelectByIndex(index);
        }

        public static string GetText(IWebElement element)
        {
            return element.GetAttribute("value");
        }

        public static string GetTextFromDropDownList(IWebElement element)
        {
            return new SelectElement(element).AllSelectedOptions.SingleOrDefault().Text;
        }

        public static IWebElement GetChild(IWebElement element)
        {
            throw new NotImplementedException();
        }
    }
}
