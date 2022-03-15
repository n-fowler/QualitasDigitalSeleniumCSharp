using NUnit.Framework;
using OpenQA.Selenium;
using QualitasDigitalSeleniumCSharp.PageObjects;
using QualitasDigitalSeleniumCSharp.src.TestCases;
using QualitasDigitalSeleniumCSharp.WrapperFactory;
using System;
using System.Linq;

namespace QualitasDigitalSeleniumCSharp.TestCases
{
    /// <summary>
    /// NewsAndNotes Tests
    /// </summary>
    public class NewsAndNotesTests : BaseTest
    {

        #region Tests

        /// <summary></summary>
        [Test]
        public void NewsAndNotesLoad()
        {
            BrowserFactory.GoToPage(NewsAndNotesPage.Url);
            BrowserFactory.WaitForPageLoad(10);
            Assert.IsTrue(Page.NewsAndNotes.LogoImage.Displayed, "Page.NewsAndNotes.LogoImage.Displayed");
        }

        /// <summary></summary>
        [Test]
        public void NewsAndNotesContent()
        {
            BrowserFactory.GoToPage(NewsAndNotesPage.Url);
            BrowserFactory.WaitForPageLoad(10);

            /* The content here will change often over time so verify that an article is showing and that it can be opened. */

            //There should be at least one article
            Assert.IsTrue(Page.NewsAndNotes.Entries.Count >= 1, "Page.NewsAndNotes.Entries.Count >= 1");

            //It should have a date
            Assert.IsNotNull(Page.NewsAndNotes.Entries.First().FindElement(By.ClassName("date-wrapper")),
                "Page.NewsAndNotes.Entries.First().FindElementByClassName('date-wrapper') != null");

            //It should have clickable title
            var entryLink = Page.NewsAndNotes.Entries.First().FindElement(By.ClassName("entry-title")).FindElement(By.TagName("a"));
            Assert.IsNotNull(entryLink, "entryLink != null");
            Assert.AreNotEqual("", entryLink.GetAttribute("href"), "The entry article link was empty but shouldn't have been");
            Assert.AreNotEqual("", entryLink.GetAttribute("innerText"), "The entry article text was empty but shouldn't have been");

            //It should have a clickable category
            var entryCategory = Page.NewsAndNotes.Entries.First().FindElement(By.ClassName("blog-categories")).FindElement(By.TagName("a"));
            Assert.IsNotNull(entryCategory, "entryCategory != null");
            Assert.AreNotEqual("", entryCategory.GetAttribute("href"), "The entry category link was empty but shouldn't have been");
            Assert.AreNotEqual("", entryCategory.GetAttribute("innerText"), "The entry category text was empty but shouldn't have been");

            //It should have a summary body
            var entryExcerpt = Page.NewsAndNotes.Entries.First().FindElement(By.ClassName("entry-excerpt")).FindElement(By.TagName("p"));
            Assert.IsNotNull(entryExcerpt, "entryExcerpt != null");
            Assert.AreNotEqual("", entryExcerpt.GetAttribute("innerText"), "The entry excerpt text was empty but shouldn't have been");
        }

        #endregion Tests
    }
}
