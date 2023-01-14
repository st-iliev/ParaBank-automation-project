using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ParaBank_Automation.Src.PageObject.Utilities;
using System;
using System.Threading;

namespace ParaBank_Automation.Src.PageObject.Test_Scripts
{
    public class OpenNewAccountPageTest : IDisposable
    {
        private static IWebDriver driver;
        private static HomePage homePage;
        private static AccountOverview accountOverview;
        private static OpenAccountPage openAccountPage;
        public OpenNewAccountPageTest()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            homePage = new HomePage(driver);
            accountOverview = new AccountOverview(driver);
            openAccountPage = new OpenAccountPage(driver);
            
        }
        [OneTimeSetUp]
        public void LogIn()
        {
            homePage.Open();
            homePage.FilledLogInForm();
            homePage.LogIn();
        }
        [Test]
        public void OpenNew_Checking_Account()
        {
            accountOverview.Open();
            string firstAccountId = accountOverview.allAccounts[0].Text;
            openAccountPage.Open();
            openAccountPage.OpenNewAccount(AccountType.CHECKING, firstAccountId);
            openAccountPage.Hovering(openAccountPage.openNewAccountButton);
            string newAccountId = openAccountPage.newAccountId.Text;
            openAccountPage.AssertNewAccountIsSuccessfullyOpened();
            accountOverview.Open();
            accountOverview.AssertCheckingNewAccountId_IsContainedInList(newAccountId);
           
        }
        [Test]
        public void OpenNew_Saving_Account()
        {
            accountOverview.Open();
            string firstAccountId = accountOverview.allAccounts[0].Text;
            openAccountPage.Open();
            openAccountPage.OpenNewAccount(AccountType.SAVINGS, firstAccountId);
            openAccountPage.Hovering(openAccountPage.openNewAccountButton);
            string newAccountId = openAccountPage.newAccountId.Text;
            openAccountPage.AssertNewAccountIsSuccessfullyOpened();
            accountOverview.Open();
            accountOverview.AssertCheckingNewAccountId_IsContainedInList(newAccountId);

        }
        public void Dispose()
        {
            driver.Dispose();
        }
    }
}
