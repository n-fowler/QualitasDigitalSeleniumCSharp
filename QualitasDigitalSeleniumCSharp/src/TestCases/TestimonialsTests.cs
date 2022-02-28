using NUnit.Framework;
using QualitasDigitalSeleniumCSharp.Extensions;
using QualitasDigitalSeleniumCSharp.PageObjects;
using QualitasDigitalSeleniumCSharp.src.TestCases;
using QualitasDigitalSeleniumCSharp.src.TestData;
using QualitasDigitalSeleniumCSharp.WrapperFactory;
using System;

namespace QualitasDigitalSeleniumCSharp.TestCases
{
    /// <summary>
    /// Testimonials Tests
    /// </summary>
    public class TestimonialsTests : BaseTest
    {
        #region Tests

        /// <summary></summary>
        [Test]
        public void TestimonialsLoad()
        {
            BrowserFactory.GoToPage(TestimonialsPage.Url);
            BrowserFactory.WaitForPageLoad(10);
            Assert.IsTrue(Page.Testimonials.LogoImage.Displayed, "Page.Testimonials.LogoImage.Displayed");
        }

        /// <summary></summary>
        [Test]
        public void TestimonialsContent()
        {
            BrowserFactory.GoToPage(TestimonialsPage.Url);
            BrowserFactory.WaitForPageLoad(10);

            //There should be a centered review in green #0d5
            Assert.AreEqual(TestimonialsPageData.HighlightedReviewContent, Page.Testimonials.HighlightedReviewContent.GetInnertext());
            Assert.AreEqual("rgba(0, 221, 85, 1)", Page.Testimonials.HighlightedReviewContent.GetCssValue("color"));
            Assert.AreEqual(TestimonialsPageData.HighlightedReviewAuthor, Page.Testimonials.HighlightedReviewAuthor.GetInnertext());
            Assert.AreEqual("rgba(0, 221, 85, 0.6)", Page.Testimonials.HighlightedReviewAuthor.GetCssValue("color"));


            //There should be a mid page title 'Others have had this to say...
            Assert.AreEqual(TestimonialsPageData.MidPageTitle, Page.Testimonials.MidPageTitle.GetInnertext());

            //The mid page title isn't the same color as the highlighted review
            Assert.AreNotEqual("rgba(0, 221, 85, 1)", Page.Testimonials.MidPageTitle.GetCssValue("color"));

            //Validate that the color of linked in review elements isn't the same as the highlighted review
            Assert.AreNotEqual("rgba(0, 221, 85, 1)", Page.Testimonials.ReviewOneContent.GetCssValue("color"));
            Assert.AreNotEqual("rgba(0, 221, 85, 1)", Page.Testimonials.ReviewTwoContent.GetCssValue("color"));
            Assert.AreNotEqual("rgba(0, 221, 85, 1)", Page.Testimonials.ReviewThreeContent.GetCssValue("color"));
            Assert.AreNotEqual("rgba(0, 221, 85, 1)", Page.Testimonials.ReviewFourContent.GetCssValue("color"));
            Assert.AreNotEqual("rgba(0, 221, 85, 1)", Page.Testimonials.ReviewFiveContent.GetCssValue("color"));

            //There should be five linked in based reviews that also aren't in green
            Assert.AreEqual(TestimonialsPageData.ReviewOneContent, Page.Testimonials.ReviewOneContent.GetInnertext());
            Assert.AreEqual(TestimonialsPageData.ReviewOneAuthor, Page.Testimonials.ReviewOneAuthor.GetInnertext());
            Assert.AreEqual(TestimonialsPageData.ReviewTwoContent, Page.Testimonials.ReviewTwoContent.GetInnertext());
            Assert.AreEqual(TestimonialsPageData.ReviewTwoAuthor, Page.Testimonials.ReviewTwoAuthor.GetInnertext());
            Assert.AreEqual(TestimonialsPageData.ReviewThreeContent, Page.Testimonials.ReviewThreeContent.GetInnertext());
            Assert.AreEqual(TestimonialsPageData.ReviewThreeAuthor, Page.Testimonials.ReviewThreeAuthor.GetInnertext());
            Assert.AreEqual(TestimonialsPageData.ReviewFourContent, Page.Testimonials.ReviewFourContent.GetInnertext());
            Assert.AreEqual(TestimonialsPageData.ReviewFourAuthor, Page.Testimonials.ReviewFourAuthor.GetInnertext());
            Assert.AreEqual(TestimonialsPageData.ReviewFiveContent, Page.Testimonials.ReviewFiveContent.GetInnertext());
            Assert.AreEqual(TestimonialsPageData.ReviewFiveAuthor, Page.Testimonials.ReviewFiveAuthor.GetInnertext());
        }

        #endregion Tests
    }
}
