using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Globalization;
using System.Threading;

namespace ParaBank_Automation.Src.PageObject.Test_Scripts
{
    public class TransferPageTests : IDisposable
    {
        private static IWebDriver driver;
        private static HomePage homePage;
        private static TransferPage transferPage;
        private static AccountOverview accountOverview;
        public TransferPageTests()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            homePage = new HomePage(driver);
            transferPage = new TransferPage(driver);
            accountOverview = new AccountOverview(driver);
        }
        [OneTimeSetUp]
        public void LogIn()
        {
            homePage.Open();
            homePage.FilledLogInForm();
            homePage.HoverAndClick(homePage.loginButton);
        }
        [Test]
        public void Transfer_WithEmptyAmountField()
        {
            transferPage.Open();
            transferPage.HoverAndClick(transferPage.transferButton);
            transferPage.AssertEmptyAmountErrorIsDisplayed();

        }
        [Test]
        public void Transfer_WithInvalidAmountField()
        {
            accountOverview.Open();
            string mainAccount = accountOverview.allAccounts[0].Text;
            string lastAccount = accountOverview.allAccounts[accountOverview.allAccounts.Count - 1].Text;
            transferPage.Open();
            transferPage.FillTransferFundsForm(50, mainAccount, lastAccount);
            transferPage.amountField.Clear();
            transferPage.amountField.SendKeys("3,5");
            transferPage.HoverAndClick(transferPage.transferButton);
            transferPage.AssertInvalidAmountErrorIsDisplayed();
        }
        [Test]
        public void TransferWith_ValidAmount_FromMainAccountToLast()
        {
            double amount = 20;
            accountOverview.Open();
            Thread.Sleep(500);
            string mainAccountBeforeTransaction = accountOverview.allBalances[0].Text;
            string lastAccountBeforeTransaction = accountOverview.allBalances[accountOverview.allBalances.Count - 2].Text;
            string mainAccount = accountOverview.allAccounts[0].Text;
            string lastAccount = accountOverview.allAccounts[accountOverview.allAccounts.Count - 1].Text;
            transferPage.Open();
            transferPage.FillTransferFundsForm(amount, mainAccount, lastAccount);
            transferPage.HoverAndClick(transferPage.transferButton);
            transferPage.AssertTransferIsCompleted(amount, mainAccount, lastAccount);
            accountOverview.Open();
            Thread.Sleep(500);
            string mainAccountAfterTransaction = accountOverview.allBalances[0].Text;
            string lastAccountAfterTransaction = accountOverview.allBalances[accountOverview.allBalances.Count - 2].Text;
            accountOverview.AssertAccountBalanceDecrease(mainAccountBeforeTransaction, mainAccountAfterTransaction);
            accountOverview.AssertAccountBalanceIncrease(lastAccountBeforeTransaction, lastAccountAfterTransaction);
        }
        public void Dispose()
        {
            driver.Dispose();
        }
    }
}
