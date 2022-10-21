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
        public IWebElement homeButton => driver.FindElement(By.XPath("//a[contains(text(),'home')]"));
        public IWebElement aboutUsButton => driver.FindElement(By.XPath("//a[contains(text(),'aboutus')]"));
        public IWebElement contactButton => driver.FindElement(By.XPath("//a[contains(text(),'contact')]"));
        public IWebElement pageHeading => driver.FindElement(By.XPath("//div[@id='rightPanel']/h1"));
        public IWebElement pageText => driver.FindElement(By.XPath("//div[@id='rightPanel']/p"));
        public IWebElement solutions => driver.FindElement(By.XPath("//div[@class='Solutions']"));
        public IWebElement aboutUs => driver.FindElement(By.XPath("//a[@href='about.htm']"));
        public IWebElement services => driver.FindElement(By.XPath("//a[@href='services.htm']"));
        public IWebElement products => driver.FindElement(By.XPath("//a[@href='http://www.parasoft.com/jsp/products.jsp']"));
        public IWebElement locations => driver.FindElement(By.XPath("//a[@href='http://www.parasoft.com/jsp/pr/contacts.jsp']"));
        public IWebElement adminPage => driver.FindElement(By.XPath("//a[@href='admin.htm']"));
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
        public string GetPageText()
        {
            return pageText.Text;
        }
        public bool IsElementVisible(IWebElement element) => element.Displayed ? true : false;
        
    }
}
