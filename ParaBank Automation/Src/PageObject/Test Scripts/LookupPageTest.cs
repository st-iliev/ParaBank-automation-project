using NUnit.Framework;
using ParaBank_Automation.Src;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParaBank_Automation.Utilities;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace ParaBank_Automation.Tests
{
    public  class LookupPageTest : IDisposable
    {
        private static IWebDriver driver;
        private static HomePage homePage;
        private static LookupPage lookupPage;
        public LookupPageTest()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            homePage = new HomePage(driver);
            lookupPage = new LookupPage(driver);
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
            lookupPage.FillLookupForm(Constants.firstName, Constants.lastName, Constants.address, Constants.city, Constants.state, Constants.zipCode, Constants.ssn);
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
