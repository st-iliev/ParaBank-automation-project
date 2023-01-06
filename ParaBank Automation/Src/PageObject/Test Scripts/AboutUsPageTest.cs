using NUnit.Framework;
using ParaBank_Automation.Src;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;

namespace ParaBank_Automation.Src.PageObject.TestScripts
{ 
    public class AboutUsPageTest : IDisposable
    {
        private static IWebDriver driver;
        private static HomePage homePage;
        private static AboutUs aboutusPage;
        public AboutUsPageTest()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            homePage = new HomePage(driver);
            aboutusPage = new AboutUs(driver);
        }
        [Test]
        public void OpenAboutUsPageFromButton()
        {
            homePage.Open();
            homePage.aboutUsButton.Click();
            aboutusPage.AssertPageTitleIsCorrect();
            aboutusPage.AssertWarrningTextIsCorrect();
        }
        [Test]
        public void OpenAboutUsPageLeftPanel()
        {
            homePage.Open();
            homePage.aboutUs.Click();
            aboutusPage.AssertPageTitleIsCorrect();
            aboutusPage.AssertWarrningTextIsCorrect();
        }
        [Test]
        public void OpenAboutUsPageFooterPanel()
        {
            homePage.Open();
            homePage.footerAboutUs.Click();
            aboutusPage.AssertPageTitleIsCorrect();
            aboutusPage.AssertWarrningTextIsCorrect();
        }

        public void Dispose()
        {
            driver.Dispose();
        }
    }
}
