using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaBank_Automation.Src
{
    public partial class AccountOverview
    {
        public IWebElement accountNumber => WaitAndFindElements(By.XPath("//*[@id='accountId']"));
        public IWebElement accountType => WaitAndFindElements(By.XPath("//*[@id='accountType']"));
        public IWebElement balance => WaitAndFindElements(By.XPath("//*[@id='balance']"));
        public IWebElement avaliable => WaitAndFindElements(By.XPath("//*[@id='availableBalance']"));
        public IWebElement activityPeriod => WaitAndFindElements(By.XPath("//*[@id='month']"));
        public IWebElement type => WaitAndFindElements(By.XPath("//*[@id='transactionType']"));
        public IWebElement goButton => WaitAndFindElements(By.XPath("//input[@class='button']"));
        public IList<IWebElement> transferDates => Driver.FindElements(By.XPath("//*[@id='transactionTable']/tbody/tr/td[1]"));
        public IList<IWebElement> transactionType => Driver.FindElements(By.XPath("//*[@id='transactionTable']/tbody/tr/td[2]/a"));
        public IList<IWebElement> transactionDebits => Driver.FindElements(By.XPath("//*[@id='transactionTable']/tbody/tr/td[3]"));
        public IList<IWebElement> transactionCredits => Driver.FindElements(By.XPath("//*[@id='transactionTable']/tbody/tr/td[4]/a"));
        public IWebElement firstTransaction => WaitAndFindElements(By.XPath("//*[@id='transactionTable']/tbody/tr[1]/td[2]/a"));

    }
}
