using NUnit.Framework;
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
            Assert.AreEqual(AboutUsPageTestData.HeaderTitle, Page.AboutUs.HeaderTitle.GetAttribute("innerText"));
            Assert.AreEqual(AboutUsPageTestData.AboutUsTitle, Page.AboutUs.Title.GetAttribute("innerText"));
            StringAssert.Contains(AboutUsPageTestData.AboutUsImageSrc, Page.AboutUs.Image.GetAttribute("src"));
            Assert.AreEqual(AboutUsPageTestData.AboutUsBodyText, Page.AboutUs.BodyText.GetAttribute("innerText"));
            Assert.AreEqual(AboutUsPageTestData.OurServicesLink, Page.AboutUs.OurServicesLink.GetAttribute("href"));
            Assert.AreEqual(AboutUsPageTestData.ScheduleConsultationLink, Page.AboutUs.ScheduleConsultationLink.GetAttribute("href"));
        }

        #endregion Tests
    }
}
