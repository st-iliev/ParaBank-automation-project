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
            homePage.AssertOpenCorrectHomePage();
        }
        [Test]
        public void OpenAboutUsPage()
        {
            homePage.Open();
            homePage.footerAboutUs.Click();
            homePage.AssertOpenCorrectAboutUsPage();
        }
        [Test]
        public void OpenServicesPage()
        {
            homePage.Open();
            homePage.footerServices.Click();
            homePage.AssertOpenCorrectServicesPage();
        }
        [Test]
        public void OpenProductsPage()
        {
            homePage.Open();
            homePage.footerProducts.Click();
            homePage.AssertOpenCorrectProductsPage();
        }
        [Test]
        public void OpenLocationsPage()
        {
            homePage.Open();
            homePage.footerLocations.Click();
            homePage.AssertOpenCorrectLocationsPage();
        }
        [Test]
        public void OpenForumPage()
        {
            homePage.Open();
            homePage.footerForum.Click();
            homePage.AssertOpenCorrectForumPage();
        }
        [Test]
        public void OpenSiteMapPage()
        {
            homePage.Open();
            homePage.footerSiteMap.Click();
            homePage.AssertOpenCorrectSiteMapPage();
        }
        [Test]
        public void OpenContactUsPage()
        {
            homePage.Open();
            homePage.footerContactUs.Click();
            homePage.AssertOpenCorrectContactUsPage();
        }
        public void Dispose()
        {
            driver.Dispose();
        }
    }
}
