using NUnit.Framework;
using ParaBank_Automation.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaBank_Automation.Src
{
    public partial class UpdateContactInfoPage
    {
        public void AssertFirstNameIsCorrect()
        {
           
            Assert.AreEqual(Constants.firstName, firstNameField.GetAttribute("value"));
        } 
        public void AssertFirstNameIsChanged()
        {
            Assert.That(firstNameField.Text, Is.Not.EqualTo(Constants.firstName));
        }
        public void AssertLastNameIsCorrect()
        {
            Assert.AreEqual(Constants.lastName, lastNameField.GetAttribute("value"));
        }
        public void AssertLastNameIsChanged()
        {
            Assert.That(lastNameField.Text, Is.Not.EqualTo(Constants.lastName));
        }
        public void AssertAddressIsCorrect()
        {
            Assert.AreEqual(Constants.address, addressField.GetAttribute("value"));
        }
        public void AssertAddressIsChanged()
        {
            Assert.That(addressField.Text, Is.Not.EqualTo(Constants.address));
        }
        public void AssertCityIsCorrect()
        {
            Assert.AreEqual(Constants.city, cityField.GetAttribute("value"));
        } 
        public void AssertCityIsChanged()
        {
            Assert.That(cityField.Text, Is.Not.EqualTo(Constants.city));
        }
        public void AssertStateIsCorrect()
        {
            Assert.AreEqual(Constants.state, stateField.GetAttribute("value"));
        }
        public void AssertStateIsChanged()
        {
            Assert.That(stateField.Text, Is.Not.EqualTo(Constants.state));
        }
        public void AssertZipCodeIsCorrect()
        {
            Assert.AreEqual(Constants.zipCode, zipeCodeField.GetAttribute("value"));
        }
        public void AssertZipCodeIsChanged()
        {
            Assert.That(zipeCodeField.Text, Is.Not.EqualTo(Constants.zipCode));
        }
        public void AssertPhoneNumberIsCorrect()
        {
            Assert.AreEqual(Constants.phone, phoneNumberField.GetAttribute("value"));
        }
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
        public void AssertZipCodeErrorMessageIsDisplayed()
        {
            Assert.AreEqual(ErrorMessages.zipCode, zipCodeErrorMessage.Text);
        }
        public void AssertProfileUpdateSuccessfullyTitle()
        {
            Assert.AreEqual("ParaBank | Update Profile", Driver.Title);
        }
        public void AssertProfileUpdateSuccessfullyText()
        {
            Assert.AreEqual("Your updated address and phone number have been added to the system.", successfulyUpdated.Text);
        }
    }
}
