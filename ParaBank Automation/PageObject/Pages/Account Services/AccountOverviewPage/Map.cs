using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaBank_Automation.Src
{
    public partial class AccountOverview
    {
        public IWebElement firstAccount => WaitAndFindElement(By.XPath("//*[@id='accountTable']/tbody/tr[1]/td[1]/a"));
        public IWebElement allAccounts => WaitAndFindElement(By.XPath("//*[@id='accountTable']/tbody/tr"));
        public IWebElement totalAmount => WaitAndFindElement(By.XPath("//b[@class='ng-binding']"));
    }
}
