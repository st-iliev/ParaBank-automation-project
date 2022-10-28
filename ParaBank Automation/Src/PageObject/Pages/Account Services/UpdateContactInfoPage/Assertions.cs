using NUnit.Framework;
using ParaBank_Automation.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaBank_Automation.Src.PageObject.Pages.Account_Services.UpdateContactInfoPage
{
    public partial class UpdateContactInfoPage
    {
        public void AssertFirstNameErrorMessageIsDisplayed()
        {
            Assert.AreEqual(ErrorMessages.firstName, firstNameErrorMessage.Text);
        }
        public void AssertLastNameErrorMessageIsDisplayed()
        {
            Assert.AreEqual(ErrorMessages.lastNamee, lastNameErrorMessage.Text);
        }
        public void AssertAddressErrorMessageIsDisplayed()
        {
            Assert.AreEqual(ErrorMessages.address, addressErrorMessage.Text);
        }
        public void AssertCityErrorMessageIsDisplayed()
        {
            Assert.AreEqual(ErrorMessages.city, cityErrorMessage.Text);
        }
        public void AssertStateErrorMessageIsDisplayed()
        {
            Assert.AreEqual(ErrorMessages.state, stateErrorMessage.Text);
        }
        public void AssertZipeCodeErrorMessageIsDisplayed()
        {
            Assert.AreEqual(ErrorMessages.zipCode, zipeCodeErrorMessage.Text);
        }
        public void AssertProfileUpdateSuccessfullyTitle()
        {
            Assert.AreEqual("Profile Updated", driver.Title);
        }
        public void AssertProfileUpdateSuccessfullyText()
        {
            Assert.AreEqual("Your updated address and phone number have been added to the system.", successfulyUpdated.Text);
        }
    }
}
