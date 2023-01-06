using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ParaBank_Automation.Src;
using ParaBank_Automation.Src.PageObject.Pages.Account_Services.BillPayPage;
using ParaBank_Automation.Utilities;
using System;

namespace ParaBank_Automation.Src.PageObject.TestScripts
{
    public class BillPayPageTests : IDisposable
    {
        private static IWebDriver driver;
        private static HomePage homePage;
        private static BillPayPage billPayPage;
        private static BillPaymentForm billPaymentForm;
        public BillPayPageTests()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            homePage = new HomePage(driver);
            billPayPage = new BillPayPage(driver);
            billPaymentForm = new BillPaymentForm();
        }
        [Test]
        public void ClickOnSendPayment_When_PaymenetFormIsEmpty()
        {
            homePage.Open();
            homePage.FilledLogInForm();
            homePage.LogIn();
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








        public void Dispose()
        {
            driver.Dispose();
        }
    }

}
