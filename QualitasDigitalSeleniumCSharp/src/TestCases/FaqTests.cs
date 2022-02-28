using NUnit.Framework;
using QualitasDigitalSeleniumCSharp.Extensions;
using QualitasDigitalSeleniumCSharp.PageObjects;
using QualitasDigitalSeleniumCSharp.src.TestCases;
using QualitasDigitalSeleniumCSharp.src.TestData;
using QualitasDigitalSeleniumCSharp.WrapperFactory;
using System;
using System.Collections.Generic;

namespace QualitasDigitalSeleniumCSharp.TestCases
{
    /// <summary>
    /// Faq Tests
    /// </summary>
    public class FaqTests : BaseTest
    {

        #region Tests

        /// <summary></summary>
        [Test]
        public void FaqLoad()
        {
            BrowserFactory.GoToPage(FaqPage.Url);
            BrowserFactory.WaitForPageLoad(10);
            Assert.IsTrue(Page.Faq.LogoImage.Displayed, "Page.Faq.LogoImage.Displayed");
        }

        /// <summary></summary>
        [Test]
        public void FaqContent()
        {
            BrowserFactory.GoToPage(FaqPage.Url);
            BrowserFactory.WaitForPageLoad(10);

            //Validate header
            Assert.AreEqual(FaqPageTestData.FaqTitle, Page.Faq.HeaderContent.GetInnertext());

            //Validate left subsection
            Assert.AreEqual(FaqPageTestData.FaqSubtitle, Page.Faq.SidebarContent.GetInnertext());
            Assert.AreEqual(FaqPageTestData.ContactUsLink, Page.Faq.ContactUsLink.GetHref());

            //Validate middle subsection
            var faqPageExpectedTitles = new List<string>
            {
                FaqPageTestData.TitleOne,
                FaqPageTestData.TitleTwo,
                FaqPageTestData.TitleThree,
                FaqPageTestData.TitleFour,
                FaqPageTestData.TitleFive,
                FaqPageTestData.TitleSix,
                FaqPageTestData.TitleSeven,
                FaqPageTestData.TitleEight,
                FaqPageTestData.TitleNine,
                FaqPageTestData.TitleTen,
                FaqPageTestData.TitleEleven,
                FaqPageTestData.TitleTwelve,
                FaqPageTestData.TitleThirteen,
                FaqPageTestData.TitleFourteen,
                FaqPageTestData.TitleFifteen
            };

            var faqPageExpectedBodies = new List<string>
            {
                FaqPageTestData.BodyOne,
                FaqPageTestData.BodyTwo,
                FaqPageTestData.BodyThree,
                FaqPageTestData.BodyFour,
                FaqPageTestData.BodyFive,
                FaqPageTestData.BodySix,
                FaqPageTestData.BodySeven,
                FaqPageTestData.BodyEight,
                FaqPageTestData.BodyNine,
                FaqPageTestData.BodyTen,
                FaqPageTestData.BodyEleven,
                FaqPageTestData.BodyTwelve,
                FaqPageTestData.BodyThirteen,
                FaqPageTestData.BodyFourteen,
                FaqPageTestData.BodyFifteen,
                string.Empty //Section has one empty body
            };

            var faqPageActualTitles = FaqPage.GetFaqPageTitles();
            var faqPageActualBodies = FaqPage.GetFaqPageBodies();

            CollectionAssert.AreEqual(faqPageExpectedTitles, faqPageActualTitles);
            CollectionAssert.AreEqual(faqPageExpectedBodies, faqPageActualBodies);
        }

        #endregion Tests
    }
}
