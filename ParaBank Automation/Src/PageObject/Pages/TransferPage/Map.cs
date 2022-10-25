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
        public IWebElement amountField => WaitAndFindElement(By.XPath("//*[@id='amount']"));
        public IWebElement fromAccountField => WaitAndFindElement(By.XPath("//*[@id='fromAccountId']"));
        public IWebElement toAccountField => WaitAndFindElement(By.XPath("//*[@id='toAccountId']"));
        public IWebElement transferButton => WaitAndFindElement(By.XPath("//*[@value='Transfer']"));
        public IWebElement amountErrorMessage => WaitAndFindElement(By.XPath("//*[@id='toAccountId']"));
    }
}
