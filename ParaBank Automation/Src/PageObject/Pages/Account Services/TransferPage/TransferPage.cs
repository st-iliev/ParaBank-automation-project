using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParaBank_Automation.Src
{
    public partial class TransferPage : BasePage
    {
        public TransferPage(IWebDriver driver) : base(driver)
        {

        }
        public override string PageURL => "https://parabank.parasoft.com/parabank/transfer.htm";
        
        public void FillTransferFundsForm(double amount,string fromAccountId,string toAccountId)
        {
            HoverAndClick(amountField);
            amountField.SendKeys(amount.ToString());
            fromAccountField.Click();
            SelectElement fromAccountSelect = new SelectElement(fromAccountField);
            fromAccountSelect.SelectByValue(fromAccountId);
            SelectElement toAccountSelect = new SelectElement(toAccountField);
            toAccountSelect.SelectByValue(toAccountId);
        }
        public override void HoverAndClick(IWebElement elemenet)
        {
            base.HoverAndClick(elemenet);
        }
        public override string GetPageText() => WaitAndFindElements(By.XPath("//*[@id='rightPanel']/div/div/p[1]")).Text;
       
    }
}
