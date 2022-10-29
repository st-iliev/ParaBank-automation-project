using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParaBank_Automation.Src.PageObject.Utilities;

namespace ParaBank_Automation.Src
{
    public partial class OpenAccountPage : BasePage
    {
        public OpenAccountPage(IWebDriver driver) : base(driver)
        {
        }
        public override string PageURL => "https://parabank.parasoft.com/parabank/openaccount.htm";

        public void OpenNewAccount(AccountType type, int accountID)
        {
            accountType.SendKeys(type.ToString());
            fromAccountId.SendKeys(accountID.ToString());
            openNewAccountButton.Click();
        }
      
    }
}
