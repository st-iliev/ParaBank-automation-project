using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaBank_Automation.Pages
{
    internal class AccountOverview : BasePage
    {
        public AccountOverview(IWebDriver driver) : base(driver)
        {

        }
        public override string PageURL => "https://parabank.parasoft.com/parabank/overview.htm";
        public IWebElement firstAccount => driver.FindElement(By.XPath("//*[@id='accountTable']/tbody/tr[1]/td[1]/a"));
        public IList<IWebElement> allAccounts => driver.FindElements(By.XPath("//*[@id='accountTable']/tbody/tr"));
        public IWebElement totalAmount => driver.FindElement(By.XPath("//*[@id='accountTable']/tbody/tr["+accountsNumbers()+"]"));
        public int accountsNumbers() => allAccounts.Count;

    }
}
