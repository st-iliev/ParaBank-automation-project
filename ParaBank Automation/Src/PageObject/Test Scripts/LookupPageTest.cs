using NUnit.Framework;
using ParaBank_Automation.Src;
using System;
using ParaBank_Automation.Utilities;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using ParaBank_Automation.Src.PageObject.Pages;

namespace ParaBank_Automation.Src.PageObject.TestScripts
{
    public  class LookupPageTest : IDisposable
    {
        private static IWebDriver driver;
        private static HomePage homePage;
        private static LookupPage lookupPage;
        private static LookupForm lookupForm;
        public LookupPageTest()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            homePage = new HomePage(driver);
            lookupPage = new LookupPage(driver);
            lookupForm = new LookupForm();
        }
        [Test,Order(1)]
        public void ClickOnFindMyLoginInfo_WhenLookupFormIsEmpty()
        {
            homePage.Open();
            homePage.ForgotLoginInfo();
            lookupPage.CleanLookupForm();
            lookupPage.ClickOnLoginInfo();
            lookupPage.AssertCorrectFirstNameErrorMessage();
            lookupPage.AssertCorrectLasatNameErrorMessage();
            lookupPage.AssertCorrectAddressErrorMessage();
            lookupPage.AssertCorrectCityErrorMessage();
            lookupPage.AssertCorrectStateErrorMessage();
            lookupPage.AssertCorrectZipCodeErrorMessage();
            lookupPage.AssertCorrectSSNErrorMessage();

        }
        [Test,Order(2)]
        public void FillLookupForm_WithValidData()
        {
            lookupPage.Open();
            lookupPage.CleanLookupForm();
            lookupPage.FillLookupForm(lookupForm);
            lookupPage.ClickOnLoginInfo();
            lookupPage.AssertUserSuccessfullyLogIn();
            lookupPage.AssertUsernameIsCorrect();
            lookupPage.AssertPasswordIsCorrect();
            homePage.LogOut();
        }
        public void Dispose()
        {
            driver.Dispose();
        }
    }
}
