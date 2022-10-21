using NUnit.Framework;
using ParaBank_Automation.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParaBank_Automation.Tests
{
    internal class FooterPanelTests : BaseTest
    {
        [Test]
        public void VerifyFooterPanelElements()
        {
            var basePage = new HomePage(driver);
            basePage.Open();

            Assert.AreEqual(8, basePage.footerElements.Count);
            Assert.IsTrue(basePage.footerHome.Displayed);
            Assert.IsTrue(basePage.footerAboutUs.Displayed);
            Assert.IsTrue(basePage.footerServices.Displayed);
            Assert.IsTrue(basePage.footerProducts.Displayed);
            Assert.IsTrue(basePage.footerLocations.Displayed);
            Assert.IsTrue(basePage.footerForum.Displayed);
            Assert.IsTrue(basePage.footerSiteMap.Displayed);
            Assert.IsTrue(basePage.footerContactUs.Displayed);
        }
        [Test]
        public void VerifyFooterHomeRedirectToCorrectPage()
        {
            var page = new HomePage(driver);
            page.Open();
            page.contactButton.Click();
            page.footerHome.Click();
            Assert.That(driver.Url, Is.EqualTo(page.PageURL));
        }
        [Test]
        public void VerifyFooterAboutUsRedirectToCorrectPage()
        {
            var page = new AboutUs(driver);
            page.Open();
            Thread.Sleep(100);
            page.footerAboutUs.Click();
            Thread.Sleep(100);
            Assert.That(driver.Url, Is.EqualTo(page.PageURL));
        }
        [Test]
        public void VerifyFooterServicesRedirectToCorrectPage()
        {
            var page = new AboutUs(driver);
            page.Open();
            Thread.Sleep(100);
            page.footerServices.Click();
            Thread.Sleep(100);
            Assert.That(driver.Url, Is.EqualTo("https://parabank.parasoft.com/parabank/services.htm"));
        }
    }
}
