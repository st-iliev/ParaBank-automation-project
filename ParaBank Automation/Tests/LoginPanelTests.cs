using Microsoft.VisualBasic;
using NUnit.Framework;
using OpenQA.Selenium;
using ParaBank_Automation.Pages;
using ParaBank_Automation.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Constants = ParaBank_Automation.Utilities.Constants;

namespace ParaBank_Automation.Tests
{
    public class LoginPanelTests : BaseTest
    {
        private const string loginUrl = "https://parabank.parasoft.com/parabank/login.htm";
        private const string overviewUrl = "https://parabank.parasoft.com/parabank/overview.htm";
        private string currentUrl => driver.Url.Split(";")[0];

        [TestCase(Constants.username,"")]
        [TestCase("",Constants.password)]
        [TestCase("","")]
        public void LoginWithoutValidUsernameOrValidPassword(string username,string password)
        {
            var page = new LoginPanel(driver);
            page.Open();
            page.FilledLogInForm(username, password);
            Assert.That(currentUrl, Is.EqualTo(loginUrl));
            Assert.AreEqual(ErrorMessages.errorHeadingText, page.GetPageHeadingText());
            Assert.AreEqual(ErrorMessages.enterUsernameAndPassword, page.GetPageText());

        }
        [TestCase("john77test", "maxim88test")]
        [TestCase("harez19test", "pez33test")]
        [TestCase("felixtest", "doubtest")]
        public void LoginWithInvalidUsernameAndInvalidPassword(string username, string password)
        {
            var page = new LoginPanel(driver);
            page.Open();
            page.FilledLogInForm(username, password);
            Assert.That(currentUrl, Is.EqualTo(loginUrl));
            Assert.AreEqual(ErrorMessages.errorHeadingText, page.GetPageHeadingText());
            Assert.AreEqual(ErrorMessages.wrongUsernameOrPassword, page.GetPageText());
        }
        [TestCase(Constants.username, "maxim88test")]
        [TestCase(Constants.username, "pez33test")]
        [TestCase(Constants.username, "doubtest")]
        public void LoginWithValidUsernameAndInvalidPassword(string username, string password)
        {
            var page = new LoginPanel(driver);
            page.Open();
            page.FilledLogInForm(username, password);
            Assert.That(currentUrl, Is.EqualTo(loginUrl));
            Assert.AreEqual(ErrorMessages.errorHeadingText, page.GetPageHeadingText());
            Assert.AreEqual(ErrorMessages.wrongUsernameOrPassword, page.GetPageText());
        }
        [TestCase("john77test", Constants.password)]
        [TestCase("harez19test", Constants.password)]
        [TestCase("felixtest", Constants.password)]
        public void LoginWithInvalidUsernameAndValidPassword(string username, string password)
        {
            var page = new LoginPanel(driver);
            page.Open();
            page.FilledLogInForm(username, password);
            Assert.That(currentUrl, Is.EqualTo(loginUrl));
            Assert.AreEqual(ErrorMessages.errorHeadingText, page.GetPageHeadingText());
            Assert.AreEqual(ErrorMessages.wrongUsernameOrPassword, page.GetPageText());
        }
        [Test]
        public void LoginWithValidUsernameAndPassword()
        {
            var page = new LoginPanel(driver);
            page.Open();
            page.FilledLogInForm(Constants.username, Constants.password); 
            Assert.That(currentUrl, Is.EqualTo(overviewUrl));
            string welcomeMessage = driver.FindElement(By.XPath("//p[@class='smallText']")).Text;
            Assert.AreEqual(SuccessfullyMessages.welcome,welcomeMessage);
        }
    }
}
