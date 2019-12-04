using NUnit.Framework;
using QualitasDigitalSeleniumCSharp.PageObjects;
using QualitasDigitalSeleniumCSharp.WrapperFactory;
using System;
using System.Collections.Generic;

namespace QualitasDigitalSeleniumCSharp.TestCases
{
    [TestFixture]
    public class HomeTests
    {
        #region Fields

        private BrowserFactory.WebDriver webDriverEnum = BrowserFactory.WebDriver.Chrome;

        #endregion Fields

        #region Shared

        private void SetUp()
        {
            BrowserFactory.InitBrowser(webDriverEnum);
            BrowserFactory.GoTo(Page.Home.url);
        }

        private void TearDown()
        {
            BrowserFactory.CloseAllDrivers();
        }

        #endregion Shared

        #region Tests

        [TestCase()]
        public void HomePageLoad()
        {
            try
            {
                SetUp();

                Assert.IsTrue(Page.Home.LogoImage.Displayed, "homePage.LogoImage.Displayed");
            }
            catch (Exception e)
            {
                //Logging goes here
            }
            finally
            {
                TearDown();
            }
        }

        [TestCase()]
        public void HomePageNavigation()
        {
            try
            {
                SetUp();

                //Open navigation
                Page.Home.NavToggleOpen.Click();

                //Close the nav toggle
                Page.Home.NavToggleClose.Click();

                //Reopen navigation
                Page.Home.NavToggleOpen.Click();

                //Verify all expected link texts
                List<string> expectedLinkTexts = new List<string>
                {
                    "Home",
                    "About Us",
                    "Pricing + Services",
                    "FAQ",
                    "News + Notes",
                    "Testimonials",
                    "Schedule Consultation",
                    "Contact Us"
                };

                List<string> actualLinkTexts = Page.Home.GetLinkTexts();

                //Click all links and validate navigation
            }
            catch (Exception e)
            {
                //Logging goes here
            }
            finally
            {
                TearDown();
            }
        }

        [TestCase()]
        public void HomePageSearch()
        {
            try
            {
                SetUp();
            }
            catch (Exception e)
            {
                //Logging goes here
            }
            finally
            {
                TearDown();
            }
        }

        [TestCase()]
        public void HomePageContent()
        {
            try
            {
                SetUp();
            }
            catch (Exception e)
            {
                //Logging goes here
            }
            finally
            {
                TearDown();
            }
        }

        [TestCase()]
        public void HomePageLinks()
        {
            try
            {
                SetUp();
            }
            catch (Exception e)
            {
                //Logging goes here
            }
            finally
            {
                TearDown();
            }
        }

        #endregion Tests
    }
}
