using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaBank_Automation.Pages.Panels
{
    internal class FooterPanel: BasePage
    {
        public FooterPanel(IWebDriver driver) : base(driver)
        {

        }
        public override string PageURL => "https://parabank.parasoft.com/parabank/index.htm";
        public IReadOnlyCollection<IWebElement> footerElements => driver.FindElements(By.XPath("//*[@id='footerPanel']/ul[1]/li"));
        public IWebElement footerHome => driver.FindElement(By.XPath("//*[@id='footerPanel']/ul/li/a[contains(text(),'Home')]"));
        public IWebElement footerAboutUs => driver.FindElement(By.XPath("//*[@id='footerPanel']/ul/li/a[contains(text(),'About Us')]"));
        public IWebElement footerServices => driver.FindElement(By.XPath("//*[@id='footerPanel']/ul/li/a[contains(text(),'Services')]"));
        public IWebElement footerProducts => driver.FindElement(By.XPath("//*[@id='footerPanel']/ul/li/a[contains(text(),'Products')]"));
        public IWebElement footerLocations => driver.FindElement(By.XPath("//*[@id='footerPanel']/ul/li/a[contains(text(),'Locations')]"));
        public IWebElement footerForum => driver.FindElement(By.XPath("//*[@id='footerPanel']/ul/li/a[contains(text(),'Forum')]"));
        public IWebElement footerSiteMap => driver.FindElement(By.XPath("//*[@id='footerPanel']/ul/li/a[contains(text(),'Site Map')]"));
        public IWebElement footerContactUs => driver.FindElement(By.XPath("//*[@id='footerPanel']/ul/li/a[contains(text(),'Contact Us')]"));
        public IWebElement copyRightText => driver.FindElement(By.XPath("//div[@id='footerPanel']/p[@class='copyright']"));
    }
}
