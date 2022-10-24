﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaBank_Automation.Src
{
    public partial class AccountOverview
    {
        public IWebElement firstAccount => driver.FindElement(By.XPath("//*[@id='accountTable']/tbody/tr[1]/td[1]/a"));
        public IList<IWebElement> allAccounts => driver.FindElements(By.XPath("//*[@id='accountTable']/tbody/tr"));
        public IWebElement totalAmount => driver.FindElement(By.XPath("//*[@id='accountTable']/tbody/tr[" + accountsNumbers() + "]"));
    }
}