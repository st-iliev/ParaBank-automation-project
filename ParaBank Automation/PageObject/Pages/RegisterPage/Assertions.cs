using NUnit.Framework;
using ParaBank_Automation.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaBank_Automation.Src
{
    public partial class RegisterPage
    {
        public void AssertCorrectFirstNameErrorMessage()
        {
            Assert.AreEqual(ErrorMessages.firstName, firstNameErrorMessage.Text);
           
        }
        public void AssertCorrectLastNameErrorMessage()
        {
            Assert.AreEqual(ErrorMessages.lastNamee, lastNameErrorMessage.Text);

        }
        public void AssertCorrectAddressErrorMessage()
        {
            Assert.AreEqual(ErrorMessages.address, addressErrorMessage.Text);

        }
        public void AssertCorrectCityErrorMessage()
        {
            Assert.AreEqual(ErrorMessages.city, cityErrorMessage.Text);

        }
        public void AssertCorrectStateErrorMessage()
        {
            Assert.AreEqual(ErrorMessages.state, stateErrorMessage.Text);

        }
        public void AssertCorrectZipCodeErrorMessage()
        {
            Assert.AreEqual(ErrorMessages.zipCode, zipCodeErrorMessage.Text);

        }
        public void AssertCorrectSSNErrorMessage()
        {
            Assert.AreEqual(ErrorMessages.SSN, ssnErrorMessage.Text);

        }
        public void AssertCorrectUsernameErrorMessage()
        {
            Assert.AreEqual(ErrorMessages.usernamee, usernameErrorMessage.Text);

        }
        public void AssertCorrectUsernameAlreadyExistErrorMessage()
        {
            Assert.AreEqual(ErrorMessages.existUsername, usernameErrorMessage.Text);
        }
        public void AssertCorrectPasswordErrorMessage()
        {
            Assert.AreEqual(ErrorMessages.password, passwordErrorMessage.Text);

        }
        public void AssertCorrectConfirmPasswordErrorMessage()
        {
            Assert.AreEqual(ErrorMessages.confirmPassword, confirmErrorMessage.Text);

        }
        public void AssertCorrectConfirmPasswordNotMatchErrorMessage()
        {
            Assert.AreEqual(ErrorMessages.passwordNotMatch, confirmErrorMessage.Text);
        }
        public void AssertCorrectSuccessfullyCreatedAccountText()
        {
            Assert.AreEqual(SuccessMessages.creatAccount, GetPageText());
        }
    }
}
