using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ParaBank_Automation.Pages
{
    public class ContactPage : BasePage
    {
        public ContactPage(IWebDriver driver) : base(driver)
        {

        }
        public override string PageURL => "https://parabank.parasoft.com/parabank/contact.htm";
        
        public IWebElement nameField => driver.FindElement(By.XPath("//*[@id='name']"));
        public IWebElement emailField => driver.FindElement(By.XPath("//*[@id='email']"));
        public IWebElement phoneField => driver.FindElement(By.XPath("//*[@id='phone']"));
        public IWebElement messageField => driver.FindElement(By.XPath("//*[@id='message']"));
        public IWebElement sendButton => driver.FindElement(By.XPath("//*[@id=\"contactForm\"]//input[@type='submit']"));

        public IWebElement nameErrorMessage => driver.FindElement(By.XPath("//*[@id='name.errors']"));
        public IWebElement emailErrorMessage => driver.FindElement(By.XPath("//*[@id='email.errors']"));
        public IWebElement phoneErrorMessage => driver.FindElement(By.XPath("//*[@id='phone.errors']"));
        public IWebElement messageErrorMessage => driver.FindElement(By.XPath("//*[@id='message.errors']"));

        public IWebElement successfulyMessage => driver.FindElement(By.XPath("//*[@id=\"rightPanel\"]/p[1]"));

        public void FilledContactForm(string name, string emial, string phone, string message)
        {
            nameField.SendKeys(name);
            emailField.SendKeys(emial);
            phoneField.SendKeys(phone);
            messageField.SendKeys(message);
            sendButton.Click();
        }
        public bool IsElementVisible(IWebElement element)
        {
            if (element.Displayed)
            {
                return true;
            }
            return false;
        }
        public void ClearFields()
        {
            nameField.Clear();
            emailField.Clear();
            phoneField.Clear();
            messageField.Clear();
        }
    }
}
