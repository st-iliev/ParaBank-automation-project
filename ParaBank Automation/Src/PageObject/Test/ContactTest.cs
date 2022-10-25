using NUnit.Framework;
using OpenQA.Selenium;
using ParaBank_Automation.Src;
using ParaBank_Automation.Utilities;

namespace ParaBank_Automation.Tests
{
    internal class ContactTest : BaseTest
    {
        private string formText = "Email support is available by filling out the following form.";
        [Test]
        public void CheckPageHeadingText()
        {
            var page = new ContactPage(driver);
            page.Open();
            Assert.That(page.GetPageTitle(), Is.EqualTo("ParaBank | Customer Care"));
           

        }
        [Test]
        public void VerfyingContactForm()
        {
            var page = new ContactPage(driver);
            page.Open();
            var pagetext = driver.FindElement(By.XPath("//div[@id='rightPanel']/p"));
            Assert.That(pagetext.Text, Is.EqualTo(formText));
        }
        [TestCase(Constants.firstName, "", "", "")]
        [TestCase("", Constants.email, "", "")]
        [TestCase("", "", Constants.phone, "")]
        [TestCase("", "", "", Constants.message)]
        [TestCase("", "", "", "")]
        public void VeryingErrorMessageOnContactForm(string name, string email, string phone, string message)
        {
            var page = new ContactPage(driver);
            page.Open();
            page.FilledContactForm(name, email, phone, message);  
            if (name == "")
            {
               
                Assert.That(page.nameErrorMessage.Text, Is.EqualTo(ErrorMessages.name));
            }
            if (email == "")
            {
                
                Assert.That(page.emailErrorMessage.Text, Is.EqualTo(ErrorMessages.email));
            }
            if (phone == "")
            {
               
                Assert.That(page.phoneErrorMessage.Text, Is.EqualTo(ErrorMessages.phone));
            }
            if (message == "")
            {
               
                Assert.That(page.messageErrorMessage.Text, Is.EqualTo(ErrorMessages.message));
            }
            page.ClearFields(); 
        }
        [Test]
        public void VerifyingSuccessfulySendedContactForm()
        {
            var page = new ContactPage(driver);
            page.Open();
            page.FilledContactForm(Constants.firstName, Constants.email, Constants.phone, Constants.message);
            Assert.That(page.successfullyMessage.Text,Is.EqualTo("Thank you" +" " + Constants.firstName));
        }
    }
}
