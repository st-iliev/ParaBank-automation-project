using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaBank_Automation.Src
{
    public partial class HomePage
    {
        public IWebElement pageLogo => driver.FindElement(By.XPath("//div[@id='topPanel']/img[@class='logo']"));
        public IWebElement homeButton => driver.FindElement(By.XPath("//a[contains(text(),'home')]"));
        public IWebElement aboutUsButton => driver.FindElement(By.XPath("//a[contains(text(),'aboutus')]"));
        public IWebElement contactButton => driver.FindElement(By.XPath("//a[contains(text(),'contact')]"));
        public IWebElement pageHeading => driver.FindElement(By.XPath("//div[@id='rightPanel']/h1"));
        public IWebElement pageText => driver.FindElement(By.XPath("//div[@id='rightPanel']/p"));

        public IWebElement atmServices => driver.FindElement(By.XPath("ul[@class='services']/li[@class='captionone']"));
        public IWebElement withdrawFunds => driver.FindElement(By.XPath("ul[@class='services']/li[2]"));
        public IWebElement transferFunds => driver.FindElement(By.XPath("ul[@class='services']/li[3]"));
        public IWebElement checkBalances => driver.FindElement(By.XPath("ul[@class='services']/li[4]"));
        public IWebElement makeDeposit => driver.FindElement(By.XPath("ul[@class='services']/li[5]"));
        public IWebElement onlineServices => driver.FindElement(By.XPath("ul[@class='servicestwo']/li[@class='captiontwo']"));
        public IWebElement billPay => driver.FindElement(By.XPath("ul[@class='servicestwo']/li[2]"));
        public IWebElement accountHistory => driver.FindElement(By.XPath("ul[@class='servicestwo']/li[3]"));
        public IWebElement onlineTransferFunds => driver.FindElement(By.XPath("ul[@class='servicestwo']/li[4]"));
        public IWebElement readMore => driver.FindElement(By.XPath("ul[@class='servicestwo']/a[@href='services.htm'"));
        public IWebElement latestNews => driver.FindElement(By.XPath("ul[@class='events']/li[@class='captionthree']"));
        public IWebElement newsOne => driver.FindElement(By.XPath("ul[@class='events']/li[2]"));
        public IWebElement newsTwo => driver.FindElement(By.XPath("ul[@class='events']/li[3]"));
        public IWebElement newsThree => driver.FindElement(By.XPath("ul[@class='events']/li[4]"));
        public IWebElement newsReadMore => driver.FindElement(By.XPath("ul[@class='events']/a[href='news.htm']"));

        public IWebElement openNewAccount => driver.FindElement(By.XPath("//a[contains(@href,'openaccount')]"));
        public IWebElement accountOverview => driver.FindElement(By.XPath("//a[contains(@href,'overview')]"));
        public IWebElement accTransferFunds => driver.FindElement(By.XPath("//a[contains(@href,'transfer')]"));
        public IWebElement accBillPay => driver.FindElement(By.XPath("//a[contains(@href,'billpay')]"));
        public IWebElement findTransactions => driver.FindElement(By.XPath("//a[contains(@href,'findtrans')]"));
        public IWebElement updateContactInfo => driver.FindElement(By.XPath("//a[contains(@href,'updateprofile')]"));
        public IWebElement requestLoan => driver.FindElement(By.XPath("//a[contains(@href,'requestloan')]"));
        public IWebElement logOut => driver.FindElement(By.XPath("//a[contains(@href,'logout')]"));

        public IWebElement loginTitle => driver.FindElement(By.XPath("//*[@id='leftPanel']/h2"));
        public IWebElement usernameField => driver.FindElement(By.XPath("//input[@name='username']"));
        public IWebElement passwordField => driver.FindElement(By.XPath("//input[@name='password']"));
        public IWebElement loginButton => driver.FindElement(By.XPath("//input[@class='button']"));
        public IWebElement forgotLogInInfo => driver.FindElement(By.XPath("//*[@id='loginPanel']/p[1]/a"));
        public IWebElement register => driver.FindElement(By.XPath("//form[@href='register.htm']"));

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
    }
}
