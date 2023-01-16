using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace ParaBank_Automation.Src.PageObject.Test_Scripts
{
    public class RequestLoanPageTests : IDisposable
    {
        private static IWebDriver driver;
        private static HomePage homePage;
        private static AccountOverview accountOverview;
        private static RequestLoanPage requestLoanPage;
        private static Random random;
        
        public RequestLoanPageTests()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            homePage = new HomePage(driver);
            requestLoanPage = new RequestLoanPage(driver);
            random = new Random();
            accountOverview = new AccountOverview(driver);
        }
        private static int RandomLoanAmount()
        {
            int lowerBound = 1;
            int upperBound = 100;
            return random.Next(lowerBound, upperBound);
        }
        private static double CalculateDownPayment()
        {
            return RandomLoanAmount() * 0.05;
        }
        [OneTimeSetUp]
        public void LogIn()
        {
            homePage.Open();
            homePage.FilledLogInForm();
            homePage.LogIn();
        }
        [Test]
        public void ApplyForLoan_WithValidData()
        {
            accountOverview.Open();
            string mainAccount = accountOverview.mainAccount.Text;
            requestLoanPage.Open();
            requestLoanPage.FillLoanRequestForm(RandomLoanAmount(), CalculateDownPayment(), mainAccount);
            requestLoanPage.ApplyLoanRequest();
            requestLoanPage.AssertLoanRequestStatusApproved();
            requestLoanPage.AssertLoanRequestCongratulationText();
            requestLoanPage.OpenTheNewLoanAccount();
            Thread.Sleep(500);
            accountOverview.AssertAccountTypeIsLOAN();
        }
        [Test]
        public void ApplyForLoan_WithDownPaymentUnderRequired()
        {
            accountOverview.Open();
            string mainAccount = accountOverview.mainAccount.Text;
            requestLoanPage.Open();
            requestLoanPage.FillLoanRequestForm(RandomLoanAmount(), 0.001, mainAccount);
            requestLoanPage.ApplyLoanRequest();
            requestLoanPage.AssertLoanRequestStatusDenied();
            requestLoanPage.AssertDownPaymentIsUnderRequired();
        }
        [Test]
        public void ApplyForLoan_WithDownPaymentMoreThanAvaliableAmount()
        {
            accountOverview.Open();
            string mainAccount = accountOverview.mainAccount.Text;
            requestLoanPage.Open();
            requestLoanPage.FillLoanRequestForm(RandomLoanAmount(), 10000, mainAccount);
            requestLoanPage.ApplyLoanRequest();
            requestLoanPage.AssertLoanRequestStatusDenied();
            requestLoanPage.AssertDownPaymenetNotEnoughFunds();
        }
        public void Dispose()
        {
            driver.Dispose();
        }
    }
}
