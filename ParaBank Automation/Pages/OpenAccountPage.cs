﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaBank_Automation.Pages
{
    internal class OpenAccountPage : BasePage
    {
        public OpenAccountPage(IWebDriver driver) : base(driver)    
        {
        }
        public IWebElement accountType => driver.FindElement(By.XPath("//*[@id='type']"));
        public IWebElement accountTypeChecking => driver.FindElement(By.XPath("//*[@id='type']/option[1]"));
        public IWebElement accountTypeSaving => driver.FindElement(By.XPath("//*[@id='type']/option[1]"));
        public IWebElement fromAccountId => driver.FindElement(By.XPath("//*[@id='fromAccountId']"));
        public IWebElement openNewAccountButton => driver.FindElement(By.XPath("//*[@value='Open New Account']"));
        public IWebElement newAccountId => driver.FindElement(By.XPath("//*[@id='newAccountId']"));

        public void SelectAccountType(IWebElement type)
        {
            this.accountType.Click();
            type.Click();
        }
    }
}