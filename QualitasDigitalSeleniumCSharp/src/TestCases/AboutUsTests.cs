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
    /// AboutUs Tests
    /// </summary>
    public class AboutUsTests : BaseTest
    {

        #region Tests

        /// <summary></summary>
        [Test]
        public void AboutUsLoad()
        {
            BrowserFactory.GoToPage(AboutUsPage.Url);
            BrowserFactory.WaitForPageLoad(10);
            Assert.IsTrue(Page.AboutUs.LogoImage.Displayed, "Page.AboutUs.LogoImage.Displayed");
        }

        /// <summary></summary>
        [Test]
        public void AboutUsContent()
        {
            BrowserFactory.GoToPage(AboutUsPage.Url);
            BrowserFactory.WaitForPageLoad(10);

            //Validate About Us Section
            Assert.AreEqual(AboutUsPageTestData.HeaderTitle, Page.AboutUs.HeaderTitle.GetInnertext());
            Assert.AreEqual(AboutUsPageTestData.AboutUsTitle, Page.AboutUs.Title.GetInnertext());
            StringAssert.Contains(AboutUsPageTestData.AboutUsImageSrc, Page.AboutUs.Image.GetSrc());
            Assert.AreEqual(AboutUsPageTestData.AboutUsBodyText, Page.AboutUs.BodyText.GetInnertext());
            Assert.AreEqual(AboutUsPageTestData.OurServicesLink, Page.AboutUs.OurServicesLink.GetHref());
            Assert.AreEqual(AboutUsPageTestData.ScheduleConsultationLink, Page.AboutUs.ScheduleConsultationLink.GetHref());
        }

        #endregion Tests
    }
}
