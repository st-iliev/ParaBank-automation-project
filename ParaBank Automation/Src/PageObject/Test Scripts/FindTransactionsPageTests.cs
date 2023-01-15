using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace ParaBank_Automation.Src.PageObject.Test_Scripts
{
    public class FindTransactionsPageTests : IDisposable
    {
        private static IWebDriver driver;
        private static HomePage homePage;
        private static AccountOverview accountOverview;
        private static FindTransactionsPage findTransactionsPage;
        private static Random random;
        public FindTransactionsPageTests()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            homePage = new HomePage(driver);
            accountOverview = new AccountOverview(driver);
            findTransactionsPage = new FindTransactionsPage(driver);
            random = new Random();
        }

        private static string RandomString()
        {
            const string chars = "ABCDEFGHIJKLMN";
            return new string(Enumerable.Repeat(chars, 5)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        private static List<string> CreditsAndDebits()
        {
            List<string> debits = accountOverview.TransactionDebits();
            List<string> credits = accountOverview.TransactionCredits();
            if (debits.Count > 0)
            {
                return debits;
            }
            return credits;
        }
        [OneTimeSetUp]
        public void LogIn()
        {
            homePage.Open();
            homePage.FilledLogInForm();
            homePage.LogIn();
        }
        [Test]
        public void Search_WithValidTransactionId()
        {
            accountOverview.Open();
            accountOverview.HoverAndClick(accountOverview.mainAccount);
            accountOverview.HoverAndClick(accountOverview.firstTransaction);
            string transactionId = findTransactionsPage.transactionId.Text;
            findTransactionsPage.Open();
            findTransactionsPage.FindTransactionById(transactionId);
            findTransactionsPage.HoverAndClick(findTransactionsPage.findTransIdButton);
            findTransactionsPage.AssertTransactionFound();
            findTransactionsPage.AssertTransactionDateIsDisplayed();
            findTransactionsPage.AssertTransactionTypeIsDisplayed();
        }
        [Test]
        public void Search_WithInvalidTransactionId()
        {

            findTransactionsPage.Open();
            findTransactionsPage.FindTransactionById("1234");
            findTransactionsPage.HoverAndClick(findTransactionsPage.findTransIdButton);
            findTransactionsPage.AssertCorrectErrorMessageIsDisplayed();
        }
        [Test]
        public void Search_WithValidDate()
        {
            accountOverview.Open();
            accountOverview.HoverAndClick(accountOverview.mainAccount);
            accountOverview.HoverAndClick(accountOverview.firstTransaction);
            string transactionDate = findTransactionsPage.transactionDate.Text;
            findTransactionsPage.Open();
            findTransactionsPage.FindTransactionByDate(transactionDate);
            findTransactionsPage.HoverAndClick(findTransactionsPage.findByDateButton);
            findTransactionsPage.AssertTransactionFound();
            findTransactionsPage.AssertTransactionDateIsDisplayed();
            findTransactionsPage.AssertTransactionTypeIsDisplayed();

        }
        [Test]
        public void Search_WithInvalidDate()
        {
            findTransactionsPage.Open();
            findTransactionsPage.FindTransactionByDate("31/10/2015");
            findTransactionsPage.HoverAndClick(findTransactionsPage.findByDateButton);
            findTransactionsPage.AssertCorrectErrorMessageIsDisplayed();
        }
        [Test]
        public void Search_WithValidDateRange()
        {
            accountOverview.Open();
            Thread.Sleep(500);
            accountOverview.HoverAndClick(accountOverview.mainAccount);
            Thread.Sleep(500);
            accountOverview.HoverAndClick(accountOverview.firstTransaction);
            string transactionDate = findTransactionsPage.transactionDate.Text;
            findTransactionsPage.Open();
            findTransactionsPage.FindTransactionByDateRange(transactionDate, transactionDate);
            findTransactionsPage.HoverAndClick(findTransactionsPage.findByDateRangeButton);
            findTransactionsPage.AssertTransactionFound();
            findTransactionsPage.AssertTransactionDateIsDisplayed();
            findTransactionsPage.AssertTransactionTypeIsDisplayed();
        }
        [Test]
        public void Search_WithInvalidDateRange()
        {
            findTransactionsPage.Open();
            findTransactionsPage.FindTransactionByDateRange("31/10/2015", "29/05/2023");
            findTransactionsPage.HoverAndClick(findTransactionsPage.findByDateRangeButton);
            findTransactionsPage.AssertCorrectErrorMessageIsDisplayed();

        }
        [Test]
        public void Search_WithValidAmount()
        {
            string amount = "";
            accountOverview.Open();
            accountOverview.HoverAndClick(accountOverview.mainAccount);
            Thread.Sleep(500);
            amount = CreditsAndDebits()[0];           
            findTransactionsPage.Open();
            findTransactionsPage.FindTransactionByAmount(amount);
            findTransactionsPage.HoverAndClick(findTransactionsPage.findByAmountButton);
            findTransactionsPage.AssertTransactionFound();
            findTransactionsPage.AssertTransactionDateIsDisplayed();
            findTransactionsPage.AssertTransactionTypeIsDisplayed();

        }
        [Test]
        public void Search_WithNotExistAmount()
        {
            findTransactionsPage.Open();
            findTransactionsPage.FindTransactionByAmount("-100");
            findTransactionsPage.HoverAndClick(findTransactionsPage.findByAmountButton);
            findTransactionsPage.AssertTransactionDateIsNotDisplayed();
            findTransactionsPage.AssertTransactionTypeIsNotDisplayed();

        }
        [Test]
        public void Search_WithInvalidAmount()
        {
            findTransactionsPage.Open();
            findTransactionsPage.FindTransactionByAmount(RandomString());
            findTransactionsPage.HoverAndClick(findTransactionsPage.findByAmountButton);
            findTransactionsPage.AssertCorrectErrorMessageIsDisplayed();
        }
        public void Dispose()
        {
            driver.Dispose();
        }
    }
}
