using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaBank_Automation.Pages.Panels
{
    internal class SolutionsPanel : BasePage
    {
        public SolutionsPanel(IWebDriver driver) : base(driver)
        {

        }
        public override string PageURL => "https://parabank.parasoft.com/parabank/index.htm";
        public IWebElement solutions => driver.FindElement(By.XPath("//div[@class='Solutions']"));
        public IWebElement aboutUs => driver.FindElement(By.XPath("//a[@href='about.htm']"));
        public IWebElement services => driver.FindElement(By.XPath("//a[@href='services.htm']"));
        public IWebElement products => driver.FindElement(By.XPath("//a[@href='http://www.parasoft.com/jsp/products.jsp']"));
        public IWebElement locations => driver.FindElement(By.XPath("//a[@href='http://www.parasoft.com/jsp/pr/contacts.jsp']"));
        public IWebElement adminPage => driver.FindElement(By.XPath("//a[@href='admin.htm']"));
    }
}
