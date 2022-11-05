using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaBank_Automation.Src.PageObject.Pages.Account_Services.RequestLoanPage
{
    public partial class RequestLoanPage : BasePage
    {
        public RequestLoanPage(IWebDriver driver) : base(driver)
        {

        }

        public override string PageURL => "https://parabank.parasoft.com/parabank/requestloan.htm";

        public void LoanRequest(long amount , long payment,int accountId)
        {
            loanAmount.Clear();
            loanAmount.SendKeys(amount.ToString());
            downPayment.Clear();
            downPayment.SendKeys(payment.ToString());
            fromAccount.SendKeys(accountId.ToString());
        }
        public void ApplyLoanRequest()
        {
            applyNowButton.Click();
        }
    }
}
