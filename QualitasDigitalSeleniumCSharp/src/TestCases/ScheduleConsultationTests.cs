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
    /// Schedule Consultation Tests
    /// </summary>
    public class ScheduleConsultationTests : BaseTest
    {

        #region Tests

        /// <summary></summary>
        [Test]
        public void ScheduleConsultationLoad()
        {
            BrowserFactory.GoToPage(ScheduleConsultationPage.Url);
            BrowserFactory.WaitForPageLoad(10);
            Assert.IsTrue(Page.ScheduleConsultation.LogoImage.Displayed, "Page.ScheduleConsultation.LogoImage.Displayed");
        }

        /// <summary></summary>
        [Test]
        public void ScheduleConsultationContent()
        {
            BrowserFactory.GoToPage(ScheduleConsultationPage.Url);
            BrowserFactory.WaitForPageLoad(10);

            //Validate Title
            Assert.AreEqual(ScheduleConsultationPageData.HeaderContent, Page.ScheduleConsultation.HeaderContent.GetInnertext());

            //Validate left section
            Assert.AreEqual(ScheduleConsultationPageData.LeftContent, Page.ScheduleConsultation.LeftContent.GetInnertext());
            Assert.AreEqual(ScheduleConsultationPageData.OurCommitmentLink, Page.ScheduleConsultation.OurCommitmentLink.GetHref());
            Assert.AreEqual(ScheduleConsultationPageData.FaqLink, Page.ScheduleConsultation.FaqLink.GetHref());
            Assert.AreEqual(ScheduleConsultationPageData.TermsAndConditionsLink, Page.ScheduleConsultation.TermsAndConditionsLink.GetHref());

            //Validate right section
            Assert.AreEqual(ScheduleConsultationPageData.ScheduleConsultationButtonLink, Page.ScheduleConsultation.ScheduleConsultationButtonLink.GetHref());
        }

        //Due to the lack of test environments, there aren't any tests for scheduling the consultation on calendly, and their tests cover that anyway.

        #endregion Tests
    }
}
