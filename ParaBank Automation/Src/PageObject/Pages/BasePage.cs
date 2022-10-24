using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace ParaBank_Automation.Src
{
    public  class BasePage
    {
        protected IWebDriver driver;
       
        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
      
      
        public virtual string PageURL { get; }
        //protected IWebElement WaitAndFindElement(By locator)
        //{
        //    return WebDriverWait.Until(ExpectedConditions.ElementExists(locator));
        //}
        protected void WaitForElementById(IWebElement element)
        {
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 30));
            wait.Until(d => d.FindElement(By.XPath(element.GetAttribute("xpath"))));
        }
        public void Open() => driver.Navigate().GoToUrl(PageURL);
        public bool IsOpen() => driver.Url == PageURL;
        public string GetPageTitle() => driver.Title;
        public string GetPageHeadingText() => pageHeading.Text;
        public string GetPageText() => pageText.Text;
        public bool IsElementVisible(IWebElement element) => element.Displayed ? true : false;
    }
}
