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
        public IWebElement selectAccountId => WaitAndFindElement(By.XPath("//select[@id='accountId']"));
        public IWebElement findByTransIdField => WaitAndFindElement(By.XPath("//input[@id='criteria.transactionId']"));
        public IWebElement findTransIdButton => WaitAndFindElement(By.XPath("//button[@ng-click=\"criteria.searchType = 'ID'\"]"));
        public IWebElement findByDateField => WaitAndFindElement(By.XPath("//input[@id='criteria.onDate']"));
        public IWebElement findByDateButton => WaitAndFindElement(By.XPath("//button[@ng-click=\"criteria.searchType = 'DATE'\"]"));
        public IWebElement findByDateRangeFromDateField => WaitAndFindElement(By.XPath("//input[@id='criteria.fromDate']"));
        public IWebElement findByDateRangeToDateField => WaitAndFindElement(By.XPath("//input[@id='criteria.toDate']"));
        public IWebElement findByDateRangeButton => WaitAndFindElement(By.XPath("//button[@ng-click=\"criteria.searchType = 'DATE_RANGE'\"]"));
        public IWebElement findByAmountField => WaitAndFindElement(By.XPath("//input[@id='criteria.amount']"));
        public IWebElement findByAmountButton => WaitAndFindElement(By.XPath("//button[@ng-click=\"criteria.searchType = 'AMOUNT'\"]"));
        public IWebElement transactionFound => WaitAndFindElement(By.XPath("//tr[@ng-repeat=\"transaction in transactions track by transaction.id\"]"));
    }
}
