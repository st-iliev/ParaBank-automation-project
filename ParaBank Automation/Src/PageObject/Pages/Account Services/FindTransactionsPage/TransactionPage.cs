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
        public IWebElement transactionId => WaitAndFindElements(By.XPath("//*[@id='rightPanel']/table/tbody/tr[1]/td[2]"));
        public IWebElement transactionDate => WaitAndFindElements(By.XPath("//*[@id='rightPanel']/table/tbody/tr[2]/td[2]"));
        public IWebElement transferDescription => WaitAndFindElements(By.XPath("//*[@id='rightPanel']/table/tbody/tr[3]/td[2]"));
        public IWebElement transferDebit => WaitAndFindElements(By.XPath("//*[@id='rightPanel']/table/tbody/tr[4]/td[2]"));
        public IWebElement transferAmount => WaitAndFindElements(By.XPath("//*[@id='rightPanel']/table/tbody/tr[5]/td[2]"));
        
    }
}
