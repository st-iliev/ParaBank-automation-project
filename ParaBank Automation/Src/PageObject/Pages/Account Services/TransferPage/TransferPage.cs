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
        public void FillTransferFundsForm(int amount,int fromAccountId,int toAccountId)
        {
            amountField.SendKeys(amount.ToString());
            fromAccountField.SendKeys(fromAccountId.ToString());
            toAccountField.SendKeys(toAccountId.ToString());
        }
        public void TransferFunds()
        {
            transferButton.Click();
        }
      
    }
}
