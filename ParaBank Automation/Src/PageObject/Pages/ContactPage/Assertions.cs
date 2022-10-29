using NUnit.Framework;
using OpenQA.Selenium.DevTools.V104.Database;
using ParaBank_Automation.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaBank_Automation.Src
{
    public partial class ContactPage
    {
        public void AssertRequestSendedSuccessfully()
        {
            Assert.AreEqual("Customer Care", GetPageTitle());
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
