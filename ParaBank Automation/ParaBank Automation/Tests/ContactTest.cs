using NUnit.Framework;
using OpenQA.Selenium;
using ParaBank_Automation.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaBank_Automation.Tests
{
    internal class ContactTest : BaseTest
    {
        private string formText = "Email support is available by filling out the following form.";
        [Test]
        public void CheckPageHeadingText()
        {
            var page = new Contact(driver);
            page.Open();
            Assert.AreEqual("ParaBank | Customer Care", page.GetPageTitle());
            Assert.AreEqual("Customer Care", page.GetPageHeadingText());

        }
        [Test]
        public void VerfyingContactForm()
        {
            var page = new Contact(driver);
            page.Open();
            var pagetext = driver.FindElement(By.XPath("//div[@id='rightPanel']/p"));
            Assert.That(pagetext.Text, Is.EqualTo(formText));
        }
    }
}
