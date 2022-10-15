using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaBank_Automation.Pages
{
    internal class Contact : BasePage
    {
        public Contact(IWebDriver driver) : base(driver)
        {

        }
        public override string PageURL => "https://parabank.parasoft.com/parabank/contact.htm";
        protected string formText = "Email support is available by filling out the following form.";
        public IWebElement nameField => driver.FindElement(By.XPath("//form[@id='contactForm']/input[@id='name']"));
        public IWebElement emailField => driver.FindElement(By.XPath("//form[@id='contactForm']/input[@id='email']"));
        public IWebElement phoneField => driver.FindElement(By.XPath("//form[@id='contactForm']/input[@id='phone']"));
        public IWebElement messageField => driver.FindElement(By.XPath("//form[@id='contactForm']/input[@id='message']"));
        public IWebElement sendButton => driver.FindElement(By.XPath("//form[@id='contactForm']/input[@class='button']"));
    }
}
