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
        public IWebElement nameField => WaitAndFindElement(By.XPath("//*[@id='name']"));
        public IWebElement emailField => WaitAndFindElement(By.XPath("//*[@id='email']"));
        public IWebElement phoneField => WaitAndFindElement(By.XPath("//*[@id='phone']"));
        public IWebElement messageField => WaitAndFindElement(By.XPath("//*[@id='message']"));
        public IWebElement sendButton => WaitAndFindElement(By.XPath("//*[@id='contactForm']//input[@type='submit']"));
        public IWebElement nameErrorMessage => WaitAndFindElement(By.XPath("//*[@id='name.errors']"));
        public IWebElement emailErrorMessage => WaitAndFindElement(By.XPath("//*[@id='email.errors']"));
        public IWebElement phoneErrorMessage => WaitAndFindElement(By.XPath("//*[@id='phone.errors']"));
        public IWebElement messageErrorMessage => WaitAndFindElement(By.XPath("//*[@id='message.errors']"));
        public IWebElement successfullyMessage => WaitAndFindElement(By.XPath("//*[@id='rightPanel']/p[1]"));
    }
}
