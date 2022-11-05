using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using Constants = ParaBank_Automation.Utilities.Constants;

namespace ParaBank_Automation.Src
{
    public class RegistrationTest : IDisposable
    {
        private static IWebDriver driver;
        private static HomePage homePage;
        private static RegisterPage registerPage;
        public RegistrationTest()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            homePage = new HomePage(driver);
            registerPage = new RegisterPage(driver);
        }
        [Test,Order(1)]
        public void ClickOnRegisterButton_WhenRegisterFormIsEmpty()
        {
            homePage.Open();
            homePage.OpenNewRegisterForm();
            registerPage.ClearRegisterForm();
            registerPage.ClickOnRegister();
            registerPage.AssertCorrectFirstNameErrorMessage();
            registerPage.AssertCorrectLastNameErrorMessage();
            registerPage.AssertCorrectAddressErrorMessage();
            registerPage.AssertCorrectCityErrorMessage();
            registerPage.AssertCorrectStateErrorMessage();
            registerPage.AssertCorrectZipCodeErrorMessage();
            registerPage.AssertCorrectSSNErrorMessage();
            registerPage.AssertCorrectUsernameErrorMessage();
            registerPage.AssertCorrectPasswordErrorMessage();
            registerPage.AssertCorrectConfirmPasswordErrorMessage();
        }
        [Test,Order(2)]
        public void RegisterNewUser_WithWrongConfirmPassword()
        {
            homePage.Open();
            homePage.OpenNewRegisterForm();
            registerPage.ClearRegisterForm();
            registerPage.FillRegisterForm(Constants.firstName, Constants.lastName, Constants.address, Constants.city, Constants.state, Constants.zipCode, Constants.phone, Constants.ssn, Constants.username, Constants.password, " ");
            registerPage.ClickOnRegister();
            registerPage.AssertCorrectConfirmPasswordNotMatchErrorMessage();
        }
       
        [Test,Order(3)]
        public void RegisterNewUser_WithValidData()
        {
            homePage.Open();
            homePage.OpenNewRegisterForm();
            registerPage.ClearRegisterForm();
            registerPage.FillRegisterForm(Constants.firstName, Constants.lastName, Constants.address, Constants.city, Constants.state,Constants.zipCode, Constants.phone, Constants.ssn, Constants.username, Constants.password, Constants.confirmPssword);
            registerPage.ClickOnRegister();
            registerPage.AssertCorrectSuccessfullyCreatedAccountText();
            homePage.LogOut();
        }
        [Test,Order(4)]
       public void RegisterOldUser_WithValidData()
        {
            homePage.Open();
            homePage.OpenNewRegisterForm();
            registerPage.ClearRegisterForm();
            registerPage.FillRegisterForm(Constants.firstName, Constants.lastName, Constants.address, Constants.city, Constants.state, Constants.zipCode, Constants.phone, Constants.ssn, Constants.username, Constants.password,Constants.confirmPssword);
            registerPage.ClickOnRegister();
            registerPage.AssertCorrectUsernameAlreadyExistErrorMessage();
        }

        public void Dispose()
        {
           driver.Dispose();
        }
    }
}
