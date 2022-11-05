using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ParaBank_Automation.Src
{
    public  class SiteMapPageTest : IDisposable
    {
        private static IWebDriver driver;
        private static HomePage homePage;
        private static SiteMapPage siteMapPage;
        public SiteMapPageTest()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            homePage = new HomePage(driver);
            siteMapPage = new SiteMapPage(driver);
        }
        [Test]
        public void OpenAboutUsPage()
        {
            siteMapPage.Open();
            siteMapPage.aboutUs.Click();
            siteMapPage.AssertOpenCorrectPageFromAboutUsLink();
        }
        [Test]
        public void OpenServicesPage()
        {
            siteMapPage.Open();
            siteMapPage.services.Click();
            siteMapPage.AssertOpenCorrectPageFromServicesLink();
        }
        [Test]
        public void OpenProductsPage()
        {
            siteMapPage.Open();
            siteMapPage.products.Click();
            siteMapPage.AssertOpenCorrectPageFromProductsLink();
        }
        [Test]
        public void OpenLocationsPage()
        {
            siteMapPage.Open();
            siteMapPage.locations.Click();
            siteMapPage.AssertOpenCorrectPageFromLocationsLink();
        }
        [Test]
        public void OpenAdminPagePage()
        {
            siteMapPage.Open();
            siteMapPage.adminPage.Click();
            siteMapPage.AssertOpenCorrectPageFromAdminPageLink();
        }    
        public void Dispose()
        {
           driver.Dispose();
        }
    }
}
