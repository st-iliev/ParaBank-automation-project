using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaBank_Automation.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {

        }
        public override string PageURL => "https://parabank.parasoft.com/parabank/index.htm";
        public IWebElement atmServices => driver.FindElement(By.XPath("ul[@class='services']/li[@class='captionone']"));
        public IWebElement withdrawFunds => driver.FindElement(By.XPath("ul[@class='services']/li[2]"));
        public IWebElement transferFunds => driver.FindElement(By.XPath("ul[@class='services']/li[3]"));
        public IWebElement checkBalances => driver.FindElement(By.XPath("ul[@class='services']/li[4]"));
        public IWebElement makeDeposit => driver.FindElement(By.XPath("ul[@class='services']/li[5]"));
        public IWebElement onlineServices => driver.FindElement(By.XPath("ul[@class='servicestwo']/li[@class='captiontwo']"));
        public IWebElement billPay => driver.FindElement(By.XPath("ul[@class='servicestwo']/li[2]"));
        public IWebElement accountHistory => driver.FindElement(By.XPath("ul[@class='servicestwo']/li[3]"));
        public IWebElement onlineTransferFunds => driver.FindElement(By.XPath("ul[@class='servicestwo']/li[4]"));
        public IWebElement readMore => driver.FindElement(By.XPath("ul[@class='servicestwo']/a[@href='services.htm'"));
        public IWebElement latestNews => driver.FindElement(By.XPath("ul[@class='events']/li[@class='captionthree']"));
        public IWebElement newsOne => driver.FindElement(By.XPath("ul[@class='events']/li[2]"));
        public IWebElement newsTwo => driver.FindElement(By.XPath("ul[@class='events']/li[3]"));
        public IWebElement newsThree => driver.FindElement(By.XPath("ul[@class='events']/li[4]"));
        public IWebElement newsReadMore => driver.FindElement(By.XPath("ul[@class='events']/a[href='news.htm']"));
    }
}
