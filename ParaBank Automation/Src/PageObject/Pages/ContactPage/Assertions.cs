using NUnit.Framework;
using ParaBank_Automation.Utilities;

namespace ParaBank_Automation.Src
{
    public partial class ContactPage
    {
        public void AssertCorrectPageIsLoade()
        {
            Assert.AreEqual("ParaBank | Customer Care", GetPageTitle());
        }
        public void AssertSuccessfullyTextIsCorrect(string name)
        {
            Assert.AreEqual($"Thank you {name}", GetPageText());
        }
        public void AssertNameErrorMessageIsCorrect()
        {
            Assert.AreEqual(ErrorMessages.name, nameErrorMessage.Text);
        }
        public void AssertEmailErrorMessageIsCorrect()
        {
            Assert.AreEqual(ErrorMessages.email, emailErrorMessage.Text);
        }
        public void AssertPhoneErrorMessageIsCorrect()
        {
            Assert.AreEqual(ErrorMessages.phone, phoneErrorMessage.Text);
        }
        public void AssertMessageErrorMessageIsCorrect()
        {
            Assert.AreEqual(ErrorMessages.message, messageErrorMessage.Text);
        }
        

    }
}
