using NUnit.Framework;
using ParaBank_Automation.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParaBank_Automation.Utilities;

namespace ParaBank_Automation.Tests
{
    internal class LookupPageTest : BaseTest
    {
        [Test]
        public void VerifyAllFieldsAndButtonAreDisplayed()
        {
            var page = new LookupPage(driver);
            page.Open();
            Assert.IsTrue(page.firstNameField.Displayed);
            Assert.IsTrue(page.lastNameField.Displayed);
            Assert.IsTrue(page.addressField.Displayed);
            Assert.IsTrue(page.cityField.Displayed);
            Assert.IsTrue(page.stateField.Displayed);
            Assert.IsTrue(page.zipCodeField.Displayed);
            Assert.IsTrue(page.ssnField.Displayed);
            Assert.IsTrue(page.finyMyLoginInfoButton.Displayed);
        }
        [Test]
        public void VerifyAllErrorMessages()
        {
            var page = new LookupPage(driver);
            page.Open();
            page.CleanLookupForm();
            page.finyMyLoginInfoButton.Click();
            Assert.AreEqual(ErrorMessages.firstName, page.firstNameErrorMsg.Text);
            Assert.AreEqual(ErrorMessages.lastNamee, page.lastNameErrorMsg.Text);
            Assert.AreEqual(ErrorMessages.address, page.addressErrorMsg.Text);
            Assert.AreEqual(ErrorMessages.city, page.cityErrorMsg.Text);
            Assert.AreEqual(ErrorMessages.state, page.stateErrorMsg.Text);
            Assert.AreEqual(ErrorMessages.zipCode, page.zipErrorMsg.Text);
            Assert.AreEqual(ErrorMessages.SSN, page.ssnErrorMsg.Text);
        }
       
    }
}
