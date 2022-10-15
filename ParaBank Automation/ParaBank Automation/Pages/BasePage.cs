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
        protected IWebDriver driver;
        public IWebElement pageLogo => driver.FindElement(By.XPath("//div[@id='topPanel']/img[@class='logo']"));
        public  IWebElement homeButton => driver.FindElement(By.XPath("//a[contains(text(),'home')]"));
        public IWebElement aboutUsButton => driver.FindElement(By.XPath("//a[contains(text(),'aboutus')]"));
        public IWebElement contactButton => driver.FindElement(By.XPath("//a[contains(text(),'contact')]"));
        public IWebElement pageHeading => driver.FindElement(By.XPath("//h1[@class='title']"));
        public IWebElement solutions => driver.FindElement(By.XPath("//div[@class='Solutions']"));
        public IWebElement aboutUs => driver.FindElement(By.XPath("//a[@href='about.htm']"));
        public IWebElement services => driver.FindElement(By.XPath("//a[@href='services.htm']"));
        public IWebElement products => driver.FindElement(By.XPath("//a[@href='http://www.parasoft.com/jsp/products.jsp']"));
        public IWebElement locations => driver.FindElement(By.XPath("//a[@href='http://www.parasoft.com/jsp/pr/contacts.jsp']"));
        public IWebElement adminPage => driver.FindElement(By.XPath("//a[@href='admin.htm']"));
        public IWebElement footerHome => driver.FindElement(By.XPath("//div[@id='footermainPanel']/a[@href='/parabank/index.htm']"));
        public IWebElement footerAboutUs => driver.FindElement(By.XPath("//div[@id='footermainPanel']/a[@href='about.htm']"));
        public IWebElement footerServices => driver.FindElement(By.XPath("//div[@id='footermainPanel']/a[@href='services.htm']"));
        public IWebElement footerProducts => driver.FindElement(By.XPath("//div[@id='footermainPanel']/a[@href='http://www.parasoft.com/jsp/products.jsp']"));
        public IWebElement footerLocations => driver.FindElement(By.XPath("//div[@id='footermainPanel']/a[@href='http://www.parasoft.com/jsp/pr/contacts.jsp']"));
        public IWebElement footerForum => driver.FindElement(By.XPath("//div[@id='footermainPanel']/a[@href='http://forums.parasoft.com/']"));
        public IWebElement footerSiteMap => driver.FindElement(By.XPath("//div[@id='footermainPanel']/a[@href='/parabank/sitemap.htm']"));
        public IWebElement footerContactUs => driver.FindElement(By.XPath("//div[@id='footermainPanel']/a[@href='contact.htm']"));
        public IWebElement copyRightText => driver.FindElement(By.XPath("//div[@id='footermainPanel']/p[@class='copyright']"));
        public IWebElement customerLogin => driver.FindElement(By.XPath("//div[@id='leftPanel']/h2"));
        public IWebElement usernameField => driver.FindElement(By.XPath("//div[@id='loginPanel']/input[@name='username']"));
        public IWebElement passwordField => driver.FindElement(By.XPath("//div[@id='loginPanel']/input[@name='password']"));
        public IWebElement loginButton => driver.FindElement(By.XPath("//div[@clss='login']/intput[@class='button']"));
        public IWebElement forgotLoginInfo => driver.FindElement(By.XPath("//div[@id='loginPanel']/a[@href='lookup.htm']"));
        public IWebElement register => driver.FindElement(By.XPath("//div[@id='loginPanel']/a[@href='register.htm']"));
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
