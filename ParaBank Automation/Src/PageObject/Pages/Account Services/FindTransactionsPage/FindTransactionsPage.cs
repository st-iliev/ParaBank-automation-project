using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
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
        public override string GetPageText() => WaitAndFindElements(By.XPath("//*[@id='rightPanel']/div/div/p")).Text;
       

        public void SelectAnAccount(string accountId)
        {
            SelectElement toAccountSelect = new SelectElement(selectAccountId);
            toAccountSelect.SelectByValue(accountId);
        }
        public void FindTransactionById(string id)
        {
            findByIdField.Clear();
            findByIdField.SendKeys(id);
            
        }
        public void FindTransactionByDate(string date)
        {
            findByDateField.Clear();
            findByDateField.SendKeys(date);
            
        }
        public void FindTransactionByDateRange(string fromDate, string toDate)
        {
            findByDateRangeFromDateField.Clear();
            findByDateRangeFromDateField.SendKeys(fromDate);
            findByDateRangeToDateField.Clear();
            findByDateRangeToDateField.SendKeys(toDate);
            
        }
        public void FindTransactionByAmount(string amount)
        {
            findByAmountField.Clear();
            findByAmountField.SendKeys(amount);
        }
        public override void HoverAndClick(IWebElement elemenet)
        {
            base.HoverAndClick(elemenet);
        }
        
    }
}
