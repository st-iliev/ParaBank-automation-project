using NUnit.Framework;
using OpenQA.Selenium;
using ParaBank_Automation.Pages;
using ParaBank_Automation.Pages.Panels;
using ParaBank_Automation.Methods;
using ParaBank_Automation.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaBank_Automation.Tests
{
    internal class BillPayPageTests : BaseTest
    {
        [OneTimeSetUp]
        public void CheckIfUserIsLogIn()
        {
            var login = new LoginPanel(driver);
            login.Open();
            LogInOut.LogInUser(login.usernameField, login.passwordField, login.loginButton);
        }
        [Test]
        public void VerifyErrorMessages_WhenFieldsAreEmpty()
        {
            var page = new BillPayPage(driver);
            page.Open();           
            page.ClearAllFields();
            page.sendPaymentButton.Click();
            Assert.AreEqual(ErrorMessages.payeeName, page.payneeNameErrorMessage.Text);
            Assert.AreEqual(ErrorMessages.address, page.addressErrorMessage.Text);
            Assert.AreEqual(ErrorMessages.city, page.cityErrorMessage.Text);
            Assert.AreEqual(ErrorMessages.state, page.stateErrorMessage.Text);
            Assert.AreEqual(ErrorMessages.zipCode, page.zipCodeErrorMessage.Text);
            Assert.AreEqual(ErrorMessages.phoneNumber, page.phoneErrorMessage.Text);
            Assert.AreEqual(ErrorMessages.accountNumber, page.emptyAcccountErrorMessage.Text);
            Assert.AreEqual(ErrorMessages.accountNumber, page.emptyVerifyAcccountErrorMessage.Text);
            Assert.AreEqual(ErrorMessages.amount, page.emptyAmountErrorMessage.Text);
        }
        [OneTimeTearDown]
        public void CheckIfUserIsLogOut()
        {
            var login = new LoginPanel(driver);
            login.Open();
            LogInOut.LogOutUser(login.loginButton);
        }
    }

}
