using NUnit.Framework;
using ParaBank_Automation.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaBank_Automation.Src
{
    public partial class LookupPage
    {
        public void AssertCorrectFirstNameErrorMessage()
        {
            Assert.AreEqual(ErrorMessages.firstName, firstNameErrorMsg.Text);
        }
        public void AssertCorrectLasatNameErrorMessage()
        {
            Assert.AreEqual(ErrorMessages.lastNamee, lastNameErrorMsg.Text);
        }
        public void AssertCorrectAddressErrorMessage()
        {
            Assert.AreEqual(ErrorMessages.address, addressErrorMsg.Text);
        }
        public void AssertCorrectCityErrorMessage()
        {
            Assert.AreEqual(ErrorMessages.city, cityErrorMsg.Text);
        }
        public void AssertCorrectStateErrorMessage()
        {
            Assert.AreEqual(ErrorMessages.state, stateErrorMsg.Text);
        }
        public void AssertCorrectZipCodeErrorMessage()
        {
            Assert.AreEqual(ErrorMessages.zipCode, zipErrorMsg.Text);
        }
        public void AssertCorrectSSNErrorMessage()
        {
            Assert.AreEqual(ErrorMessages.SSN, ssnErrorMsg.Text);
        }
        public void AssertUserSuccessfullyLogIn()
        {
            Assert.AreEqual(SuccessMessages.loginInformation,successfullyLoginText.Text);
        }
        public void AssertUsernameIsCorrect()
        {
            Assert.That(usernameInfo.Text.Contains(Constants.username));
        }
        public void AssertPasswordIsCorrect()
        {
            Assert.That(usernameInfo.Text.Contains(Constants.password));
        }
    }
}
