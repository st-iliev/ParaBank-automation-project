﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaBank_Automation.Src
{
    public partial class OpenAccountPage
    {
        public IWebElement accountType => WaitAndFindElements(By.XPath("//*[@id='type']"));
        public IWebElement fromAccountId => WaitAndFindElements(By.XPath("//*[@id='fromAccountId']"));
        public IWebElement openNewAccountButton => WaitAndFindElements(By.XPath("//*[@value='Open New Account']"));
        public IWebElement newAccountId => WaitAndFindElements(By.XPath("//*[@id='newAccountId']"));

    }
}
