using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ParaBank_Automation.Src;
using ParaBank_Automation.Utilities;
using System;

namespace ParaBank_Automation.Src.PageObject.TestScripts
{
    public class ContactPageTest : IDisposable
    {
        private static IWebDriver driver;
        private static HomePage homePage;
        private static ContactPage contactPage;
        public ContactPageTest()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            homePage = new HomePage(driver);
            contactPage = new ContactPage(driver);
        }
        [Test,Order(1)]
        public void OpenContactUsPageFromContactUsButton()
        {
            homePage.Open();
            homePage.contactButton.Click();
            contactPage.AssertCorrectPageIsLoade();     
        }
        [Test, Order(2)]
        public void OpenContactUsPageFromFooterPanel()
        {
            homePage.Open();
            homePage.footerContactUs.Click();
            contactPage.AssertCorrectPageIsLoade();
        }
        [Test, Order(3)]
        public void SendEmptyContactForm()
        {
            homePage.Open();
            homePage.contactButton.Click();
            contactPage.ClearContactForm();
            contactPage.sendButton.Click();
            contactPage.AssertNameErrorMessageIsCorrect();
            contactPage.AssertEmailErrorMessageIsCorrect();
            contactPage.AssertPhoneErrorMessageIsCorrect();
            contactPage.AssertMessageErrorMessageIsCorrect();
        }
        [Test, Order(4)]
        public void FillContactForm_WithValidData()
        {
            homePage.Open();
            homePage.contactButton.Click();
            contactPage.ClearContactForm();
            contactPage.FilledContactForm(Constants.firstName,Constants.email,Constants.phone,Constants.message);
            contactPage.sendButton.Click();
        }
        public void Dispose()
        {
           driver.Dispose();
        }
    }
}
