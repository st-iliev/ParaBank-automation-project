using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaBank_Automation.Pages.Panels
{
    internal class AccountServicePanel : BasePage
    {
        public AccountServicePanel(IWebDriver driver) : base(driver)
        {

        }
        public override string PageURL => "https://parabank.parasoft.com/parabank/index.htm";
        public IWebElement openNewAccount => driver.FindElement(By.XPath("//a[contains(@href,'openaccount')]"));
        public IWebElement accountOverview => driver.FindElement(By.XPath("//a[contains(@href,'overview')]"));
        public IWebElement transferFunds => driver.FindElement(By.XPath("//a[contains(@href,'transfer')]"));
        public IWebElement billPay => driver.FindElement(By.XPath("//a[contains(@href,'billpay')]"));
        public IWebElement findTransactions => driver.FindElement(By.XPath("//a[contains(@href,'findtrans')]"));
        public IWebElement updateContactInfo => driver.FindElement(By.XPath("//a[contains(@href,'updateprofile')]"));
        public IWebElement requestLoan => driver.FindElement(By.XPath("//a[contains(@href,'requestloan')]"));
        public IWebElement logOut => driver.FindElement(By.XPath("//a[contains(@href,'logout')]"));
    }
}
