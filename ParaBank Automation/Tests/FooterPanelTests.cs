using NUnit.Framework;
using ParaBank_Automation.Pages;
using ParaBank_Automation.Pages.Panels;
using System.Threading;

namespace ParaBank_Automation.Tests
{
    internal class FooterPanelTests : BaseTest
    {
        [Test]
        public void VerifyFooterPanelElements()
        {
            var page = new FooterPanel(driver);
            page.Open();

            Assert.AreEqual(8,page.footerElements.Count);
            Assert.IsTrue(page.footerHome.Displayed);
            Assert.IsTrue(page.footerAboutUs.Displayed);
            Assert.IsTrue(page.footerServices.Displayed);
            Assert.IsTrue(page.footerProducts.Displayed);
            Assert.IsTrue(page.footerLocations.Displayed);
            Assert.IsTrue(page.footerForum.Displayed);
            Assert.IsTrue(page.footerSiteMap.Displayed);
            Assert.IsTrue(page.footerContactUs.Displayed);
        }
        [Test]
        public void VerifyFooterHomeRedirectToCorrectPage()
        {
            var page = new FooterPanel(driver);
            page.Open();
            page.contactButton.Click();
            page.footerHome.Click();
            Assert.That(driver.Url, Is.EqualTo(page.PageURL));
        }
        [Test]
        public void VerifyFooterAboutUsRedirectToCorrectPage()
        {
            var page = new FooterPanel(driver);
            page.Open();
            Thread.Sleep(100);
            page.footerAboutUs.Click();
            Thread.Sleep(100);
            Assert.That(driver.Url, Is.EqualTo(page.PageURL));
        }
        [Test]
        public void VerifyFooterServicesRedirectToCorrectPage()
        {
            var page = new FooterPanel(driver);
            page.Open();
            Thread.Sleep(100);
            page.footerServices.Click();
            Thread.Sleep(100);
            Assert.That(driver.Url, Is.EqualTo("https://parabank.parasoft.com/parabank/services.htm"));
        }
    }
}
