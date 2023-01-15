using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaBank_Automation.Src
{
    public partial class AccountOverview : BasePage
    {
        public AccountOverview(IWebDriver driver) : base(driver)
        {

        }
        public override string PageURL => "https://parabank.parasoft.com/parabank/overview.htm";
        public List<string> TransactionDebits()
        {
            List<string> debitsResult = new List<string>();
            foreach (var debit in transactionDebits)
            {
                string debitText = debit.Text;
                if (debitText != "")
                {
                    debitsResult.Add(debit.Text.Split("$")[1]);
                }
            }
            return debitsResult;
        }
        public List<string> TransactionCredits()
        {
            List<string> creditsResult = new List<string>();
            foreach (var credit in transactionCredits)
            {
                string creditText = credit.Text;
                if (creditText != "")
                {
                    creditsResult.Add(credit.Text.Split("$")[1]);
                }
            }
            return creditsResult;
        }
    }
}
