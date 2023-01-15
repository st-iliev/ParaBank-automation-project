using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace ParaBank_Automation.Src
{
    public partial class AccountOverview
    {
        public IList<IWebElement> allAccounts => Driver.FindElements(By.XPath("//*[@id='accountTable']/tbody/tr/td[1]/a"));
        public IList<IWebElement> allBalances => Driver.FindElements(By.XPath("//*[@id='accountTable']/tbody/tr/td[2]"));
        public IWebElement totalAmount => WaitAndFindElements(By.XPath("//b[@class='ng-binding']"));
        public IWebElement mainAccount => WaitAndFindElements(By.XPath("//*[@id='accountTable']/tbody/tr[1]/td[1]/a"));
    }
}
