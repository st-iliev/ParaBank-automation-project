﻿using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ParaBank_Automation.Src
{
    public partial class ContactPage : BasePage
    {
        public ContactPage(IWebDriver driver) : base(driver)
        {

        }
        public override string PageURL => "https://parabank.parasoft.com/parabank/contact.htm";
        
       

        public void FilledContactForm(string name, string emial, string phone, string message)
        {
            nameField.SendKeys(name);
            emailField.SendKeys(emial);
            phoneField.SendKeys(phone);
            messageField.SendKeys(message);
            sendButton.Click();
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
