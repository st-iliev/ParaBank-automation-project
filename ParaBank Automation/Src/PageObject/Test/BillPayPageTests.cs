using NUnit.Framework;
using ParaBank_Automation.Src;
using ParaBank_Automation.Utilities;

namespace ParaBank_Automation.Tests
{
    internal class BillPayPageTests : BaseTest
    {
       
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
       
    }

}
