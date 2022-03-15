using NUnit.Framework;
using QualitasDigitalSeleniumCSharp.PageObjects;
using QualitasDigitalSeleniumCSharp.src.TestCases;
using QualitasDigitalSeleniumCSharp.src.TestData;
using QualitasDigitalSeleniumCSharp.WrapperFactory;
using System;

namespace QualitasDigitalSeleniumCSharp.TestCases
{
    /// <summary>
    /// PricingAndServices Tests
    /// </summary>
    public class PricingAndServicesTests : BaseTest
    {

        #region Tests

        /// <summary></summary>
        [Test]
        public void PricingAndServicesLoad()
        {
            BrowserFactory.GoToPage(PricingAndServicesPage.Url);
            BrowserFactory.WaitForPageLoad(10);
            Assert.IsTrue(Page.PricingAndServices.LogoImage.Displayed, "Page.PricingAndServices.LogoImage.Displayed");
        }

        /// <summary></summary>
        [Test]
        public void PricingAndServicesContent()
        {
            BrowserFactory.GoToPage(PricingAndServicesPage.Url);
            BrowserFactory.WaitForPageLoad(10);

            //Validate header
            Assert.AreEqual(PricingAndServicesPageTestData.PricingAndServicesTitle, Page.PricingAndServices.HeaderTitle.GetAttribute("innerText"));

            //Validate left subsection
            Assert.AreEqual(PricingAndServicesPageTestData.PricingAndServicesSubtitle, Page.PricingAndServices.Subtitle.GetAttribute("innerText"));
            Assert.AreEqual(PricingAndServicesPageTestData.OurCommitmentLink, Page.PricingAndServices.OurCommitmentLink.GetAttribute("href"));

            //Validate middle subsection
            Assert.AreEqual(PricingAndServicesPageTestData.AdditionalTestCoverageTitle, Page.PricingAndServices.AdditionalTestCoverageTitle.GetAttribute("innerText"));
            Assert.AreEqual(PricingAndServicesPageTestData.AdditionalTestCoverageBodyText, Page.PricingAndServices.AdditionalTestCoverageBodyText.GetAttribute("innerText"));
            Assert.AreEqual(PricingAndServicesPageTestData.FrameworkUpdatesTitle, Page.PricingAndServices.FrameworkUpdatesTitle.GetAttribute("innerText"));
            Assert.AreEqual(PricingAndServicesPageTestData.FrameworkUpdatesUpgradesBodyText, Page.PricingAndServices.FrameworkUpdatesUpgradesBodyText.GetAttribute("innerText"));
            Assert.AreEqual(PricingAndServicesPageTestData.FrameworkUpdatesCustomTailoredBodyText, Page.PricingAndServices.FrameworkUpdatesCustomTailoredBodyText.GetAttribute("innerText"));
            Assert.AreEqual(PricingAndServicesPageTestData.ProcessAutomationTitle, Page.PricingAndServices.ProcessAutomationTitle.GetAttribute("innerText"));
            Assert.AreEqual(PricingAndServicesPageTestData.ProcessAutomationBodyText, Page.PricingAndServices.ProcessAutomationBodyText.GetAttribute("innerText"));
            Assert.AreEqual(PricingAndServicesPageTestData.DashboardsTitle, Page.PricingAndServices.DashboardsTitle.GetAttribute("innerText"));
            Assert.AreEqual(PricingAndServicesPageTestData.DashboardsOnPremiseBodyText, Page.PricingAndServices.DashboardsOnPremiseBodyText.GetAttribute("innerText"));
            Assert.AreEqual(PricingAndServicesPageTestData.DashboardsSaasBodyText, Page.PricingAndServices.DashboardsSaasBodyText.GetAttribute("innerText"));
            Assert.AreEqual(PricingAndServicesPageTestData.DashboardsDisclaimerBodyText, Page.PricingAndServices.DashboardsDisclaimerBodyText.GetAttribute("innerText"));

            //Validate right subsection
            Assert.AreEqual(PricingAndServicesPageTestData.TrainingTitle, Page.PricingAndServices.TrainingTitle.GetAttribute("innerText"));
            Assert.AreEqual(PricingAndServicesPageTestData.TrainingBodyText, Page.PricingAndServices.TrainingBodyText.GetAttribute("innerText"));
            Assert.AreEqual(PricingAndServicesPageTestData.CoachingTitle, Page.PricingAndServices.CoachingTitle.GetAttribute("innerText"));
            Assert.AreEqual(PricingAndServicesPageTestData.CoachingBodyText, Page.PricingAndServices.CoachingBodyText.GetAttribute("innerText"));
            Assert.AreEqual(PricingAndServicesPageTestData.RoadmapsTitle, Page.PricingAndServices.RoadmapsTitle.GetAttribute("innerText"));
            Assert.AreEqual(PricingAndServicesPageTestData.RoadmapsBodyText, Page.PricingAndServices.RoadmapsBodyText.GetAttribute("innerText"));
            Assert.AreEqual(PricingAndServicesPageTestData.TrustedAdvisorTitle, Page.PricingAndServices.TrustedAdvisorTitle.GetAttribute("innerText"));
            Assert.AreEqual(PricingAndServicesPageTestData.TrustedAdvisorBodyText, Page.PricingAndServices.TrustedAdvisorBodyText.GetAttribute("innerText"));
            Assert.AreEqual(PricingAndServicesPageTestData.TechnicalCoFounderTitle, Page.PricingAndServices.TechnicalCoFounderTitle.GetAttribute("innerText"));
            Assert.AreEqual(PricingAndServicesPageTestData.TechnicalCoFounderBodyText, Page.PricingAndServices.TechnicalCoFounderBodyText.GetAttribute("innerText"));
        }

        #endregion Tests
    }
}
