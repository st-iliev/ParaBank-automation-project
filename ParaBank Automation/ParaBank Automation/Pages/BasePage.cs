using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaBank_Automation.Pages
{
    public  class BasePage
    {
        private IWebDriver driver;
        public  IWebElement homeButton => driver.FindElement(By.XPath("//a[contains(text(),'home')]"));
        public IWebElement aboutUsButton => driver.FindElement(By.XPath("//a[contains(text(),'aboutus')]"));
        public IWebElement contactButton => driver.FindElement(By.XPath("//a[contains(text(),'contact')]"));
        public IWebElement pageHeading => driver.FindElement(By.XPath("//h1[@class='title']"));
        public IList<IWebElement> atmServices => driver.FindElements(By.XPath("//a[contains(text(),'services')]"));
        public IList<IWebElement> onlineServices => driver.FindElements(By.XPath("//a[contains(text(),'servicestwo'"));
        public IList<IWebElement> latestNews => driver.FindElements(By.XPath("//a[contains(text(),'events'"));
        public virtual string PageURL { get; }
        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
        public void Open()
        {
            driver.Navigate().GoToUrl(PageURL);
        }
        public bool IsOpen()
        {
            return driver.Url == PageURL;

        }
        public string GetPageTitle()
        {
            return driver.Title;
        }
       
        public string GetPageHeadingText()
        {
            return pageHeading.Text;
        }
    }
}
