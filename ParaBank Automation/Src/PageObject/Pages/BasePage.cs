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
            this.driver = driver;
            waitDriver = new WebDriverWait(driver,TimeSpan.FromSeconds(elementsTimeout));
        }
        protected IWebDriver driver { get; set; }
        protected WebDriverWait waitDriver { get; set; }  
        public abstract string PageURL { get; }
        public void Open() => driver.Navigate().GoToUrl(PageURL);
        protected virtual void WaitForPageLoad()
        {
        }
        protected IWebElement WaitAndFindElement(By locator)
        {
            WebDriverWait w = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
           return w.Until(ExpectedConditions.ElementExists(locator));   
        }
        public string GetPageTitle() => driver.Title;
        public string GetPageText() => WaitAndFindElement(By.XPath("//h1[@class='title']/p[1]")).Text;
    }
}
