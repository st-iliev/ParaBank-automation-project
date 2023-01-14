using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ParaBank_Automation.Src;
using ParaBank_Automation.Src.PageObject.Pages.Account_Services.BillPayPage;
using ParaBank_Automation.Utilities;
using System;
using System.Threading;

namespace ParaBank_Automation.Src.PageObject.TestScripts
{
    public class BillPayPageTests : IDisposable
    {
        private static IWebDriver driver;
        private static HomePage homePage;
        private static BillPayPage billPayPage;
        private static BillPaymentForm billPaymentForm;
        private static AccountOverview accountOverview;
        public BillPayPageTests()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            homePage = new HomePage(driver);
            billPayPage = new BillPayPage(driver);
            billPaymentForm = new BillPaymentForm();
            accountOverview = new AccountOverview(driver);
        }
        [OneTimeSetUp]
        public void LogIn()
        {
            homePage.Open();
            homePage.FilledLogInForm();
            homePage.LogIn();
        }
        [Test]
        public void ClickOnSendPayment_When_PaymenetFormIsEmpty()
        {
            billPayPage.Open();
            billPayPage.ClearAllFields();
            billPayPage.SendPayment();
            billPayPage.AssertPayeeNameErrorMessage();
            billPayPage.AssertAddressErrorMessage();
            billPayPage.AssertCityErrorMessage();
            billPayPage.AssertStateErrorMessage();
            billPayPage.AssertZipeCodeErrorMessage();
            billPayPage.AssertPhoneErrorMessaged();
            billPayPage.AssertEmptyAccountNumberErrorMessage();
            billPayPage.AssertEmptyVerifyAccountNumberErrorMessage();
        }
        [Test]
        public void SendPaymenet_WithValidData()
        {
            accountOverview.Open();
            string account = accountOverview.allAccounts[0].Text;
            string accountBalanceBeforePaymenet = accountOverview.allBalances[0].Text;
            billPayPage.Open();
            billPayPage.ClearAllFields();
            billPaymentForm.Account = "13777";
            billPaymentForm.VerifyAccount = "13777";
            billPaymentForm.Amount = "50";
            billPaymentForm.FromAccount = account;
            billPayPage.FillBillPaymentForm(billPaymentForm);
            billPayPage.Hovering(billPayPage.sendPaymentButton);
            accountOverview.Open();
            Thread.Sleep(500);
            string accountBalanceAfterPaymenet = accountOverview.allBalances[0].Text;
            accountOverview.AssertAccountBalanceDecrease(accountBalanceBeforePaymenet, accountBalanceAfterPaymenet);

        }
        public void Dispose()
        {
            driver.Dispose();
        }
    }

}
