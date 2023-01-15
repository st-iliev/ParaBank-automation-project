using NUnit.Framework;
using ParaBank_Automation.Utilities;
using System;

namespace ParaBank_Automation.Src.PageObject.Pages.Account_Services.RequestLoanPage
{
    public partial class RequestLoanPage
    {
        private DateTime dateTime = DateTime.Now;
        public void AssertLoanRequestIsSuccessfuly()
        {
            Assert.AreEqual("Loan Request Processed", Driver.Title);

        }
        public void AssertLoanRequestProvider()
        {
            Assert.AreEqual("ParaBank", loanProvider.Text);
        }
        public void AssertLoanRequestDate()
        {
            Assert.AreEqual(dateTime.ToString("MM/dd/yyyy"), date.ToString());
        }
        public void AssertLoanRequestStatusApproved()
        {
            Assert.AreEqual("Approved", status.Text);
        }
        public void AssertLoanRequestStatusDenied()
        {
            Assert.AreEqual("Denied", status.Text);
        }
        public void AssertLoanRequstDownPaymentErrorMessageIsDisplayed()
        {
            Assert.AreEqual(ErrorMessages.downPayment, downPaymentAmountErrorMessage.Text);
        }
        public void AssertNewAccountNumberIsDisplayed()
        {
            Assert.True(newAccountId.Displayed);
        }
    }
}
