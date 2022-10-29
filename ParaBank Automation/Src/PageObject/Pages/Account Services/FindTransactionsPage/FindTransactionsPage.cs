using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaBank_Automation.Src
{
    public partial class FindTransactionsPage : BasePage
    {
        public FindTransactionsPage(IWebDriver driver) : base(driver)
        {

        }
        public override string PageURL => "https://parabank.parasoft.com/parabank/findtrans.htm";
        public void SelectAnAccount(int accountId)
        {
            selectAccountId.SendKeys(accountId.ToString());
        }
        public void FindTransactionById(int id)
        {
            findByTransIdField.Clear();
            findByTransIdField.SendKeys(id.ToString());
            findTransIdButton.Click();
        }
        public void FindTransactionByDate(DateTime date)
        {
            findByDateField.Clear();
            findByDateField.SendKeys(date.ToString());
            findByDateButton.Click();
        }
        public void FindTransactionByDateRange(DateTime fromDate, DateTime toDate)
        {
            findByDateRangeFromDateField.Clear();
            findByDateRangeFromDateField.SendKeys(fromDate.ToString());
            findByDateRangeToDateField.Clear();
            findByDateRangeToDateField.SendKeys(toDate.ToString());
            findByDateRangeButton.Click();
        }
        public void FindTransactionByAmount(int amount)
        {
            findByAmountField.Clear();
            findByAmountField.SendKeys(amount.ToString());
            findByAmountButton.Click();
        }
    }
}
