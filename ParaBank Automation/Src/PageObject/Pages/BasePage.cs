using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Collections.Generic;
using OpenQA.Selenium.Interactions;

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
        public void Open()
        {
            Driver.Navigate().GoToUrl(PageURL);
            WaitForPageLoad();
        }
        protected void WaitForPageLoad()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            wait.Until((x) =>
            {
                return ((IJavaScriptExecutor)Driver).ExecuteScript("return document.readyState").Equals("complete");
            });
        }
        public virtual  void HoverAndClick(IWebElement elemenet)
        {
            Actions actions = new Actions(Driver);
            actions.MoveToElement(elemenet);
            actions.Click().Build().Perform();
        }
        protected IWebElement WaitAndFindElements(By locator)
        {
            WebDriverWait w = new WebDriverWait(Driver, TimeSpan.FromSeconds(elementsTimeout));
            return w.Until(ExpectedConditions.ElementExists(locator));
        }
        public string GetPageTitle() => Driver.Title;
        public string GetPageHeading() => WaitAndFindElements(By.XPath("//*[@id='rightPanel']/h1")).Text;
        public virtual string GetPageText() => WaitAndFindElements(By.XPath("//*[@id='rightPanel']/p")).Text;
    }
}
