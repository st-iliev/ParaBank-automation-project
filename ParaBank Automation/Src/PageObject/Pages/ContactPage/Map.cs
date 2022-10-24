using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaBank_Automation.Src
{ 
    public partial class ContactPage
    {
        public IWebElement nameField => driver.FindElement(By.XPath("//*[@id='name']"));
        public IWebElement emailField => driver.FindElement(By.XPath("//*[@id='email']"));
        public IWebElement phoneField => driver.FindElement(By.XPath("//*[@id='phone']"));
        public IWebElement messageField => driver.FindElement(By.XPath("//*[@id='message']"));
        public IWebElement sendButton => driver.FindElement(By.XPath("//*[@id='contactForm']//input[@type='submit']"));
        public IWebElement nameErrorMessage => driver.FindElement(By.XPath("//*[@id='name.errors']"));
        public IWebElement emailErrorMessage => driver.FindElement(By.XPath("//*[@id='email.errors']"));
        public IWebElement phoneErrorMessage => driver.FindElement(By.XPath("//*[@id='phone.errors']"));
        public IWebElement messageErrorMessage => driver.FindElement(By.XPath("//*[@id='message.errors']"));
        public IWebElement successfullyMessage => driver.FindElement(By.XPath("//*[@id='rightPanel']/p[1]"));
    }
}
