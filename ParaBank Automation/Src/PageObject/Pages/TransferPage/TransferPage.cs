using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaBank_Automation.Src
{
    public partial class TransferPage : BasePage
    {
        public TransferPage(IWebDriver driver) : base(driver)
        {

        }
        public override string PageURL => "https://parabank.parasoft.com/parabank/transfer.htm";

        public IWebElement amountField => driver.FindElement(By.XPath("//*[@id='amount']"));
        public IWebElement fromAccountField => driver.FindElement(By.XPath("//*[@id='fromAccountId']"));
        public IWebElement toAccountField => driver.FindElement(By.XPath("//*[@id='toAccountId']"));
        public IWebElement transferButton => driver.FindElement(By.XPath("//*[@value='Transfer']"));
        public IWebElement amountErrorMessage => driver.FindElement(By.XPath("//*[@id='toAccountId']"));
    }
}
