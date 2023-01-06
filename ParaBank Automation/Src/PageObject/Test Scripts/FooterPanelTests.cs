using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using ParaBank_Automation.Src;
using System.Threading;
using System;

namespace ParaBank_Automation.Src.PageObject.TestScripts
{
    public class FooterPanelTests : IDisposable
    {
        private static IWebDriver driver;
        private static HomePage homePage;
       
        public FooterPanelTests()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            homePage = new HomePage(driver);          
        }
        [Test]
        public void OpenHomeUsPage()
        {
            homePage.Open();
            homePage.footerHome.Click();
            homePage.AssertOpenCorrectPageFromFooterHomeLink();
        }
        [Test]
        public void OpenAboutUsPage()
        {
            homePage.Open();
            homePage.footerAboutUs.Click();
            homePage.AssertOpenCorrectPageFromFooterAboutUsLink();
        }
        [Test]
        public void OpenServicesPage()
        {
            homePage.Open();
            homePage.footerServices.Click();
            homePage.AssertOpenCorrectPageFromFooterServicesLink();
        }
        [Test]
        public void OpenProductsPage()
        {
            homePage.Open();
            homePage.footerProducts.Click();
            homePage.AssertOpenCorrectPageFromFooterProductsLink();
        }
        [Test]
        public void OpenLocationsPage()
        {
            homePage.Open();
            homePage.footerLocations.Click();
            homePage.AssertOpenCorrectPageFromFooterLocationsLink();
        }
        [Test]
        public void OpenForumPage()
        {
            homePage.Open();
            homePage.footerForum.Click();
            homePage.AssertOpenCorrectPageFromFooterForumLink();
        }
        [Test]
        public void OpenSiteMapPage()
        {
            homePage.Open();
            homePage.footerSiteMap.Click();
            homePage.AssertOpenCorrectPageFromFooterSiteMapLink();
        }
        [Test]
        public void OpenContactUsPage()
        {
            homePage.Open();
            homePage.footerContactUs.Click();
            homePage.AssertOpenCorrectPageFromFooterContactUsLink();
        }
        public void Dispose()
        {
            driver.Dispose();
        }
    }
}
