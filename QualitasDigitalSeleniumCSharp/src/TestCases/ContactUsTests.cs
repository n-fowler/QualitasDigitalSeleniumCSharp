using NUnit.Framework;
using OpenQA.Selenium;
using QualitasDigitalSeleniumCSharp.PageObjects;
using QualitasDigitalSeleniumCSharp.src.TestCases;
using QualitasDigitalSeleniumCSharp.src.TestData;
using QualitasDigitalSeleniumCSharp.WrapperFactory;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QualitasDigitalSeleniumCSharp.TestCases
{
    /// <summary>
    /// Contact Us Tests
    /// </summary>
    public class ContactUsTests : BaseTest
    {

        #region Tests

        /// <summary></summary>
        [Test]
        public void ContactUsLoad()
        {
            BrowserFactory.GoToPage(ContactUsPage.Url);
            BrowserFactory.WaitForPageLoad(10);
            Assert.IsTrue(Page.ContactUs.LogoImage.Displayed, "Page.ContactUs.LogoImage.Displayed");
        }

        /// <summary></summary>
        [Test]
        public void ContactUsContent()
        {
            BrowserFactory.GoToPage(ContactUsPage.Url);
            BrowserFactory.WaitForPageLoad(10);

            //Validate Title
            Assert.AreEqual(ContactUsPageData.HeaderContent, Page.ContactUs.HeaderContent.GetAttribute("innerText"));

            //Validate left section
            Assert.AreEqual(ContactUsPageData.LeftContent, Page.ContactUs.SidebarContent.GetAttribute("innerText"));
            Assert.AreEqual(ContactUsPageData.OurCommitmentLink, Page.ContactUs.OurCommitmentLink.GetAttribute("href"));
            Assert.AreEqual(ContactUsPageData.FaqLink, Page.ContactUs.FaqLink.GetAttribute("href"));
            Assert.AreEqual(ContactUsPageData.TermsAndConditionsLink, Page.ContactUs.TermsAndConditionsLink.GetAttribute("href"));

            //Validate right section

            //There should be a first name field
            Assert.NotNull(Page.ContactUs.FirstNameField, "Page.ContactUs.FirstNameField != null");

            //There should be a last name field
            Assert.NotNull(Page.ContactUs.LastNameField, "Page.ContactUs.LastNameField != null");

            //There should be an email field
            Assert.NotNull(Page.ContactUs.EmailField, "Page.ContactUs.EmailField != null");

            /*There should be a series of checkboxes with the following organization: 
                Additional Test Coverage
                Framework Updates
                Process Automation
                Dashboards
                Training
                Coaching
                Road maps
                Trusted Advisor
                Technical Co-Founder
                Other* (Include additional detail below)
            */

            var options = Page.ContactUs.CheckboxSection.FindElements(By.TagName("div")).ToList();
            var expectedOptions = new List<string>
            {
                "Additional Test Coverage",
                "Framework Updates",
                "Process Automation",
                "Dashboards",
                "Training",
                "Coaching",
                "Road maps",
                "Trusted Advisor",
                "Technical Co-Founder",
                "Other* (Include additional detail below)"
            };

            for (int i = 0; i < options.Count; i++)
            {
                //Verify the checkbox
                Assert.AreEqual("checkbox", options[i].FindElement(By.TagName("label")).FindElement(By.TagName("input")).GetDomProperty("type"));
                Assert.AreEqual(expectedOptions[i], options[i].FindElement(By.TagName("label")).FindElement(By.TagName("input")).GetDomProperty("value"));
            }

            //There should be an additional message field
            Assert.NotNull(Page.ContactUs.AdditionalMessageTextArea, "Page.ContactUs.AdditionalMessageTextArea != null");

            //There should be a submit button
            Assert.NotNull(Page.ContactUs.SubmitButton, "Page.ContactUs.SubmitButton != null");
            Assert.AreEqual("submit", Page.ContactUs.SubmitButton.GetDomProperty("type"));
            Assert.AreEqual("Submit", Page.ContactUs.SubmitButton.GetDomProperty("value"));
        }

        #endregion Tests
    }
}
