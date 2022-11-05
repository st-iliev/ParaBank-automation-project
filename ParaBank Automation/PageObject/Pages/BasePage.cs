using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace ParaBank_Automation.Src
{
    public abstract class BasePage
    {
        private int elementsTimeout = 10;
        public BasePage(IWebDriver driver)
        {
            Driver = driver;
            waitDriver = new WebDriverWait(Driver,TimeSpan.FromSeconds(elementsTimeout));
        }
        protected IWebDriver Driver { get; set; }
        protected WebDriverWait waitDriver { get; set; }
        public abstract string PageURL { get; }
        public void Open() => Driver.Navigate().GoToUrl(PageURL);
        protected virtual void WaitForPageLoad()
        {
        }
        protected IWebElement WaitAndFindElement(By locator)
        {
            WebDriverWait w = new WebDriverWait(Driver, TimeSpan.FromSeconds(elementsTimeout));
            return w.Until(ExpectedConditions.ElementExists(locator));
        }
        public string GetPageTitle() => Driver.Title;
        public string GetPageHeading() => WaitAndFindElement(By.XPath("//*[@id='rightPanel']/h1")).Text;
        public string GetPageText() => WaitAndFindElement(By.XPath("//*[@id='rightPanel']/p")).Text;
    }
}
