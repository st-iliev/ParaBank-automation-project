using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ParaBank_Automation.Src.PageObject.Pages.RegisterPage;
using System;


namespace ParaBank_Automation.Src.PageObject.TestScripts
{
    public class RegistrationTest : IDisposable
    {
        private static IWebDriver driver;
        private static HomePage homePage;
        private static RegisterPage registerPage;
        private static RegistrationForm registrationForm;
        public RegistrationTest()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            homePage = new HomePage(driver);
            registerPage = new RegisterPage(driver);
            registrationForm = new RegistrationForm();
        }

        [Test,Order(4)]
        public void ClickOnRegisterButton_WhenRegisterFormIsEmpty()
        {
            homePage.Open();
           homePage.HoverAndClick(homePage.register);
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
        [Test,Order(3)]
        public void RegisterNewUser_WithWrongConfirmPassword()
        {
            homePage.Open();
           homePage.HoverAndClick(homePage.register);
            registerPage.ClearRegisterForm();
            registrationForm.ConfirmPassword = "a7GUH320ZR";
            registerPage.FillRegisterForm(registrationForm);
            registerPage.ClickOnRegister();
            registerPage.AssertCorrectConfirmPasswordNotMatchErrorMessage();
        }
       
        [Test,Order(1)]
        public void RegisterNewUser_WithValidData()
        {
            homePage.Open();
           homePage.HoverAndClick(homePage.register);
            registerPage.ClearRegisterForm();        
            registerPage.FillRegisterForm(registrationForm);
            registerPage.ClickOnRegister();
            homePage.AssertUserIsLogIn();
            homePage.HoverAndClick(homePage.logOut);
        }
        [Test,Order(2)]
       public void RegisterExsistingUser()
        {
            homePage.Open();
           homePage.HoverAndClick(homePage.register);
            registerPage.ClearRegisterForm();
            registerPage.FillRegisterForm(registrationForm);
            registerPage.ClickOnRegister();
            registerPage.AssertCorrectUsernameAlreadyExistErrorMessage();
        }

        public void Dispose()
        {
           driver.Dispose();
        }
    }
}
