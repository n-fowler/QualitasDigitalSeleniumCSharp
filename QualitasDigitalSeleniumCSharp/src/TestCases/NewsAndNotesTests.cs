using NUnit.Framework;
using QualitasDigitalSeleniumCSharp.Extensions;
using QualitasDigitalSeleniumCSharp.PageObjects;
using QualitasDigitalSeleniumCSharp.WrapperFactory;
using System;
using System.Linq;

namespace QualitasDigitalSeleniumCSharp.TestCases
{
    /// <summary>
    /// NewsAndNotes Tests
    /// </summary>
    public class NewsAndNotesTests
    {
        #region Fields

        private BrowserFactory.WebDriver webDriverEnum = BrowserFactory.WebDriver.Chrome;

        #endregion Fields

        #region Shared

        /// <summary>
        /// The one time test setup method
        /// </summary>
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            BrowserFactory.InitBrowserHeadless(webDriverEnum);
        }

        /// <summary>
        /// The one time test tear down method
        /// </summary>
        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            BrowserFactory.CloseAllDrivers();
        }

        /// <summary>
        /// The individual test setup method
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            Logging.SetTestRunId();
            Logging.TestStartTime = DateTime.Now;
        }

        /// <summary>
        /// The individual test tear down method
        /// </summary>
        [TearDown]
        public void TearDown()
        {
            Logging.TestEndTime = DateTime.Now;
            BrowserFactory.ReportTestStatus(TestContext.CurrentContext);
        }

        #endregion Shared

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
            Assert.IsNotNull(Page.NewsAndNotes.Entries.First().FindElementByClassName("date-wrapper"),
                "Page.NewsAndNotes.Entries.First().FindElementByClassName('date-wrapper') != null");

            //It should have clickable title
            var entryLink = Page.NewsAndNotes.Entries.First().FindElementByClassName("entry-title").FindElementByTagName("a");
            Assert.IsNotNull(entryLink, "entryLink != null");
            Assert.AreNotEqual("", entryLink.GetHref(), "The entry article link was empty but shouldn't have been");
            Assert.AreNotEqual("", entryLink.GetInnertext(), "The entry article text was empty but shouldn't have been");

            //It should have a clickable category
            var entryCategory = Page.NewsAndNotes.Entries.First().FindElementByClassName("blog-categories").FindElementByTagName("a");
            Assert.IsNotNull(entryCategory, "entryCategory != null");
            Assert.AreNotEqual("", entryCategory.GetHref(), "The entry category link was empty but shouldn't have been");
            Assert.AreNotEqual("", entryCategory.GetInnertext(), "The entry category text was empty but shouldn't have been");

            //It should have a summary body
            var entryExcerpt = Page.NewsAndNotes.Entries.First().FindElementByClassName("entry-excerpt").FindElementByTagName("p");
            Assert.IsNotNull(entryExcerpt, "entryExcerpt != null");
            Assert.AreNotEqual("", entryExcerpt.GetInnertext(), "The entry excerpt text was empty but shouldn't have been");
        }

        #endregion Tests
    }
}
