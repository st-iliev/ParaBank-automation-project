using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaBank_Automation.Src
{
    public partial class FindTransactionsPage
    {
        public IWebElement selectAccountId => WaitAndFindElements(By.XPath("//select[@id='accountId']"));
        public IWebElement findByIdField => WaitAndFindElements(By.XPath("//input[@id='criteria.transactionId']"));
        public IWebElement findTransIdButton => WaitAndFindElements(By.XPath("//button[@ng-click=\"criteria.searchType = 'ID'\"]"));
        public IWebElement findByDateField => WaitAndFindElements(By.XPath("//input[@id='criteria.onDate']"));
        public IWebElement findByDateButton => WaitAndFindElements(By.XPath("//button[@ng-click=\"criteria.searchType = 'DATE'\"]"));
        public IWebElement findByDateRangeFromDateField => WaitAndFindElements(By.XPath("//input[@id='criteria.fromDate']"));
        public IWebElement findByDateRangeToDateField => WaitAndFindElements(By.XPath("//input[@id='criteria.toDate']"));
        public IWebElement findByDateRangeButton => WaitAndFindElements(By.XPath("//button[@ng-click=\"criteria.searchType = 'DATE_RANGE'\"]"));
        public IWebElement findByAmountField => WaitAndFindElements(By.XPath("//input[@id='criteria.amount']"));
        public IWebElement findByAmountButton => WaitAndFindElements(By.XPath("//button[@ng-click=\"criteria.searchType = 'AMOUNT'\"]"));
        public IWebElement transactionFound => WaitAndFindElements(By.XPath("//tr[@ng-repeat='transaction in transactions track by transaction.id']"));

        public IList<IWebElement> transactionDates => Driver.FindElements(By.XPath("//*[@id='transactionTable']/tbody/tr/td[1]"));
        public IList<IWebElement> transactionTypes => Driver.FindElements(By.XPath("//*[@id='transactionTable']/tbody/tr/td[2]/a"));
        
    }
}
