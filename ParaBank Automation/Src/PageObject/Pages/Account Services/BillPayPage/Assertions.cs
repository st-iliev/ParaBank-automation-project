using NUnit.Framework;
using ParaBank_Automation.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaBank_Automation.Src
{ 
    public partial class BillPayPage
    {
        public void AssertPayeeNameErrorMessage()
        {
            Assert.AreEqual(ErrorMessages.payeeName, payneeNameErrorMessage.Text);
        }
        public void AssertAddressErrorMessage()
        {
            Assert.AreEqual(ErrorMessages.address, addressErrorMessage.Text);
        }
        public void AssertCityErrorMessage()
        {
            Assert.AreEqual(ErrorMessages.city, cityErrorMessage.Text);
        }
        public void AssertStateErrorMessage()
        {
            Assert.AreEqual(ErrorMessages.state, stateErrorMessage.Text);
        }
        public void AssertZipeCodeErrorMessage()
        {
            Assert.AreEqual(ErrorMessages.zipCode, zipCodeErrorMessage.Text);
        }
        public void AssertPhoneErrorMessaged()
        {
            Assert.AreEqual(ErrorMessages.phoneNumber, phoneNumberErrorMessage.Text);
        }
        public void AssertEmptyAccountNumberErrorMessage()
        {
            Assert.AreEqual(ErrorMessages.accountNumber, emptyAcccountErrorMessage.Text);
        }
        public void AssertInvalidAccountNumberErrorMessages()
        {
            Assert.AreEqual(ErrorMessages.invalidNumber,invalidAcccountErrorMessage.Text);
        }
        public void AssertEmptyVerifyAccountNumberErrorMessage()
        {
             Assert.AreEqual(ErrorMessages.accountNumber, emptyVerifyAcccountErrorMessage.Text);
        }
        public void AssertInvalidVerifyAccountNumberErrorMessage()
        {
            Assert.AreEqual(ErrorMessages.verifyAccountNumber, invalidVerifyAcccountErrorMessage.Text);
        }
        public void AssertAmountErrorMessage()
        {
            Assert.AreEqual(ErrorMessages.amount, emptyAmountErrorMessage.Text);
        }
        public void AssertInvalidAmountErrorMessage()
        {
            Assert.AreEqual(ErrorMessages.invalidAmount, invalidAmountErrorMessage.Text);
        }
        public void AssertBillPaymentIsSuccessful(string payeeName,int amount , int toAccountId)
        {
            Assert.AreEqual(string.Format(SuccessMessages.billPaymentSuccessful, payeeName,amount, toAccountId),GetPageText());
        }
    }
}
