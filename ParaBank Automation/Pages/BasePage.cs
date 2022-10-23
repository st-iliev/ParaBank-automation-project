using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using ParaBank_Automation.Pages.Panels;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaBank_Automation.Pages
{
    public  class BasePage
    {
        protected IWebDriver driver;
       
        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
        public IWebElement pageLogo => driver.FindElement(By.XPath("//div[@id='topPanel']/img[@class='logo']"));
        public IWebElement homeButton => driver.FindElement(By.XPath("//a[contains(text(),'home')]"));
        public IWebElement aboutUsButton => driver.FindElement(By.XPath("//a[contains(text(),'aboutus')]"));
        public IWebElement contactButton => driver.FindElement(By.XPath("//a[contains(text(),'contact')]"));
        public IWebElement pageHeading => driver.FindElement(By.XPath("//div[@id='rightPanel']/h1"));
        public IWebElement pageText => driver.FindElement(By.XPath("//div[@id='rightPanel']/p"));
      
        public virtual string PageURL { get; }
        public void WaitForElementById(IWebElement element)
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
