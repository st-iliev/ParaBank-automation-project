using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaBank_Automation.Src
{
    public partial class TransferPage
    {
        public IWebElement amountField => WaitAndFindElements(By.XPath("//*[@id='amount']"));
        public IWebElement fromAccountField => WaitAndFindElements(By.XPath("//*[@id='fromAccountId']"));
        public IWebElement toAccountField => WaitAndFindElements(By.XPath("//*[@id='toAccountId']"));
        public IWebElement transferButton => WaitAndFindElements(By.XPath("//input[@type='submit']"));
        public IWebElement emptyAmountError => WaitAndFindElements(By.XPath("//*[@ng-if='showEmptyAmountError']"));
        public IWebElement invalidAmountError => WaitAndFindElements(By.XPath("//*[@ng-if='showInvalidValueError']"));
    }
}
