using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Linq;
using System.Threading;

namespace ParaBank_Automation.Src
{
    public class UpdateContactInfoPageTests : IDisposable
    {
        private static IWebDriver driver;
        private static HomePage homePage;
        private static UpdateContactInfoPage updateContactInfoPage;
        private static ProfileForm profileForm;
        private static Random random;
        public UpdateContactInfoPageTests()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            homePage = new HomePage(driver);
            updateContactInfoPage = new UpdateContactInfoPage(driver);
            profileForm = new ProfileForm();
            random = new Random();
        }
        private static string RandomString()
        {
            const string chars = "ABCDEFGHIJKLMN";
            return new string(Enumerable.Repeat(chars, 5)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        [OneTimeSetUp]
        public void LogIn()
        {
            homePage.Open();
            homePage.FilledLogInForm();
            homePage.HoverAndClick(homePage.loginButton);
        }
        [Test]
        public void OpenContactForm_AndVerifyThatInformationIsCorrect()
        {
            updateContactInfoPage.Open();
            Thread.Sleep(500);
            updateContactInfoPage.AssertFirstNameIsCorrect();
            updateContactInfoPage.AssertLastNameIsCorrect();
            updateContactInfoPage.AssertAddressIsCorrect();
            updateContactInfoPage.AssertCityIsCorrect();
            updateContactInfoPage.AssertStateIsCorrect();
            updateContactInfoPage.AssertZipCodeIsCorrect();
            updateContactInfoPage.AssertPhoneNumberIsCorrect();
        }
        [Test]
        public void UpdateInformation_WhenFormIsEmpty()
        {
            updateContactInfoPage.Open();
            Thread.Sleep(500);
            updateContactInfoPage.ClearForm();
            updateContactInfoPage.HoverAndClick(updateContactInfoPage.updateProfileButton);
            updateContactInfoPage.AssertFirstNameErrorMessageIsDisplayed();
            updateContactInfoPage.AssertLastNameErrorMessageIsDisplayed();
            updateContactInfoPage.AssertAddressErrorMessageIsDisplayed();
            updateContactInfoPage.AssertCityErrorMessageIsDisplayed();
            updateContactInfoPage.AssertStateErrorMessageIsDisplayed();
            updateContactInfoPage.AssertZipCodeErrorMessageIsDisplayed();           
        }
        [Test]
        public void ChangeFirstName_AndUpdateInformation()
        {
            updateContactInfoPage.Open();
            profileForm.FirstName += RandomString();
            updateContactInfoPage.FillUpdateProfileForm(profileForm);
            updateContactInfoPage.HoverAndClick(updateContactInfoPage.updateProfileButton);
            updateContactInfoPage.AssertProfileUpdateSuccessfullyTitle();
            updateContactInfoPage.AssertProfileUpdateSuccessfullyText();
            updateContactInfoPage.Open();
            updateContactInfoPage.AssertFirstNameIsChanged();
        }
        [Test]
        public void ChangeLastName_AndUpdateInformation()
        {
            updateContactInfoPage.Open();
            profileForm.LastName += RandomString();
            updateContactInfoPage.FillUpdateProfileForm(profileForm);
            updateContactInfoPage.HoverAndClick(updateContactInfoPage.updateProfileButton);
            updateContactInfoPage.AssertProfileUpdateSuccessfullyTitle();
            updateContactInfoPage.AssertProfileUpdateSuccessfullyText();
            updateContactInfoPage.Open();
            updateContactInfoPage.AssertLastNameIsChanged();
        }
        [Test]
        public void ChangeAddress_AndUpdateInformation()
        {
            updateContactInfoPage.Open();
            profileForm.Address += RandomString();
            updateContactInfoPage.FillUpdateProfileForm(profileForm);
            updateContactInfoPage.HoverAndClick(updateContactInfoPage.updateProfileButton);
            updateContactInfoPage.AssertProfileUpdateSuccessfullyTitle();
            updateContactInfoPage.AssertProfileUpdateSuccessfullyText();
            updateContactInfoPage.Open();
            updateContactInfoPage.AssertAddressIsChanged();
        }
        [Test]
        public void ChangeCity_AndUpdateInformation()
        {
            updateContactInfoPage.Open();
            profileForm.City += RandomString();
            updateContactInfoPage.FillUpdateProfileForm(profileForm);
            updateContactInfoPage.HoverAndClick(updateContactInfoPage.updateProfileButton);
            updateContactInfoPage.AssertProfileUpdateSuccessfullyTitle();
            updateContactInfoPage.AssertProfileUpdateSuccessfullyText();
            updateContactInfoPage.Open();
            updateContactInfoPage.AssertCityIsChanged();
        }
        [Test]
        public void ChangeState_AndUpdateInformation()
        {
            updateContactInfoPage.Open();
            profileForm.State += RandomString();
            updateContactInfoPage.FillUpdateProfileForm(profileForm);
            updateContactInfoPage.HoverAndClick(updateContactInfoPage.updateProfileButton);
            updateContactInfoPage.AssertProfileUpdateSuccessfullyTitle();
            updateContactInfoPage.AssertProfileUpdateSuccessfullyText();
            updateContactInfoPage.Open();
            updateContactInfoPage.AssertStateIsChanged();
        }
        [Test]
        public void ChangeZipCode_AndUpdateInformation()
        {
            updateContactInfoPage.Open();
            profileForm.ZipCode += RandomString();
            updateContactInfoPage.FillUpdateProfileForm(profileForm);
            updateContactInfoPage.HoverAndClick(updateContactInfoPage.updateProfileButton);
            updateContactInfoPage.AssertProfileUpdateSuccessfullyTitle();
            updateContactInfoPage.AssertProfileUpdateSuccessfullyText();
            updateContactInfoPage.Open();
            updateContactInfoPage.AssertZipCodeIsChanged();
        }
        public void Dispose()
        {
            driver.Dispose();
        }
    }
}
