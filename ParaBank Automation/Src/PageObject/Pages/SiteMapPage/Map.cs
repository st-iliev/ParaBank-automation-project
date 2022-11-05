using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaBank_Automation.Src
{
    public partial class SiteMapPage
    {
        public IWebElement aboutUs => WaitAndFindElement(By.XPath("//div[@id='rightPanel']/ul[@class='leftmenu']/li[2]/a"));
        public IWebElement services => WaitAndFindElement(By.XPath("//div[@id='rightPanel']/ul[@class='leftmenu']/li[a[contains(@href,'services.htm')]]"));
        public IWebElement products => WaitAndFindElement(By.XPath("//*[@id='rightPanel']/ul[1]/li[4]/a"));
        public IWebElement locations => WaitAndFindElement(By.XPath("//*[@id='rightPanel']/ul[1]/li[5]/a"));
        public IWebElement adminPage => WaitAndFindElement(By.XPath("//*[@id='rightPanel']/ul[1]/li[6]/a"));
        public IWebElement openNewAccount => WaitAndFindElement(By.XPath("//*[@id='rightPanel']/ul[2]/li[1]/a"));
        public IWebElement accountOverview => WaitAndFindElement(By.XPath("//*[@id='rightPanel']/ul[2]/li[2]/a"));
        public IWebElement transferFunds => WaitAndFindElement(By.XPath("//*[@id='rightPanel']/ul[2]/li[3]/a"));
        public IWebElement billPay => WaitAndFindElement(By.XPath("//*[@id='rightPanel']/ul[2]/li[4]/a"));
        public IWebElement findTransactions => WaitAndFindElement(By.XPath("//*[@id='rightPanel']/ul[2]/li[5]/a"));
        public IWebElement updateContactInfo => WaitAndFindElement(By.XPath("//*[@id='rightPanel']/ul[2]/li[6]/a"));
        public IWebElement requestLoan => WaitAndFindElement(By.XPath("//*[@id='rightPanel']/ul[2]/li[7]/a"));
        public IWebElement logOut => WaitAndFindElement(By.XPath("//*[@id='rightPanel']/ul[2]/li[8]/a"));
        

    }
}
