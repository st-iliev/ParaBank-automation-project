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
        public IWebElement pageLogo => WaitAndFindElement(By.XPath("//div[@id='topPanel']/img[@class='logo']"));
        public IWebElement homeButton => WaitAndFindElement(By.XPath("//a[contains(text(),'home')]"));
        public IWebElement aboutUsButton => WaitAndFindElement(By.XPath("//a[contains(text(),'aboutus')]"));
        public IWebElement contactButton => WaitAndFindElement(By.XPath("//a[contains(text(),'contact')]"));
        public IWebElement pageHeading => WaitAndFindElement(By.XPath("//div[@id='rightPanel']/h1"));
        public IWebElement pageText => WaitAndFindElement(By.XPath("//div[@id='rightPanel']/p"));

        public IWebElement atmServices => WaitAndFindElement(By.XPath("ul[@class='services']/li[@class='captionone']"));
        public IWebElement withdrawFunds => WaitAndFindElement(By.XPath("ul[@class='services']/li[2]"));
        public IWebElement transferFunds => WaitAndFindElement(By.XPath("ul[@class='services']/li[3]"));
        public IWebElement checkBalances => WaitAndFindElement(By.XPath("ul[@class='services']/li[4]"));
        public IWebElement makeDeposit => WaitAndFindElement(By.XPath("ul[@class='services']/li[5]"));
        public IWebElement onlineServices => WaitAndFindElement(By.XPath("ul[@class='servicestwo']/li[@class='captiontwo']"));
        public IWebElement billPay => WaitAndFindElement(By.XPath("ul[@class='servicestwo']/li[2]"));
        public IWebElement accountHistory => WaitAndFindElement(By.XPath("ul[@class='servicestwo']/li[3]"));
        public IWebElement onlineTransferFunds => WaitAndFindElement(By.XPath("ul[@class='servicestwo']/li[4]"));
        public IWebElement readMore => WaitAndFindElement(By.XPath("ul[@class='servicestwo']/a[@href='services.htm'"));
        public IWebElement latestNews => WaitAndFindElement(By.XPath("ul[@class='events']/li[@class='captionthree']"));
        public IWebElement newsOne => WaitAndFindElement(By.XPath("ul[@class='events']/li[2]"));
        public IWebElement newsTwo => WaitAndFindElement(By.XPath("ul[@class='events']/li[3]"));
        public IWebElement newsThree => WaitAndFindElement(By.XPath("ul[@class='events']/li[4]"));
        public IWebElement newsReadMore => WaitAndFindElement(By.XPath("ul[@class='events']/a[href='news.htm']"));

        public IWebElement openNewAccount => WaitAndFindElement(By.XPath("//a[contains(@href,'openaccount')]"));
        public IWebElement accountOverview => WaitAndFindElement(By.XPath("//a[contains(@href,'overview')]"));
        public IWebElement accTransferFunds => WaitAndFindElement(By.XPath("//a[contains(@href,'transfer')]"));
        public IWebElement accBillPay => WaitAndFindElement(By.XPath("//a[contains(@href,'billpay')]"));
        public IWebElement findTransactions => WaitAndFindElement(By.XPath("//a[contains(@href,'findtrans')]"));
        public IWebElement updateContactInfo => WaitAndFindElement(By.XPath("//a[contains(@href,'updateprofile')]"));
        public IWebElement requestLoan => WaitAndFindElement(By.XPath("//a[contains(@href,'requestloan')]"));
        public IWebElement logOut => WaitAndFindElement(By.XPath("//a[contains(@href,'logout')]"));

        public IWebElement loginTitle => WaitAndFindElement(By.XPath("//*[@id='leftPanel']/h2"));
        public IWebElement usernameField => WaitAndFindElement(By.XPath("//input[@name='username']"));
        public IWebElement passwordField => WaitAndFindElement(By.XPath("//input[@name='password']"));
        public IWebElement loginButton => WaitAndFindElement(By.XPath("//input[@class='button']"));
        public IWebElement forgotLogInInfo => WaitAndFindElement(By.XPath("//*[@id='loginPanel']/p[1]/a"));
        public IWebElement register => WaitAndFindElement(By.XPath("//form[@href='register.htm']"));

        public IWebElement solutions => WaitAndFindElement(By.XPath("//div[@class='Solutions']"));
        public IWebElement aboutUs => WaitAndFindElement(By.XPath("//a[@href='about.htm']"));
        public IWebElement services => WaitAndFindElement(By.XPath("//a[@href='services.htm']"));
        public IWebElement products => WaitAndFindElement(By.XPath("//a[@href='http://www.parasoft.com/jsp/products.jsp']"));
        public IWebElement locations => WaitAndFindElement(By.XPath("//a[@href='http://www.parasoft.com/jsp/pr/contacts.jsp']"));
        public IWebElement adminPage => WaitAndFindElement(By.XPath("//a[@href='admin.htm']"));

        public IWebElement footerElements => WaitAndFindElement(By.XPath("//*[@id='footerPanel']/ul[1]/li"));
        public IWebElement footerHome => WaitAndFindElement(By.XPath("//*[@id='footerPanel']/ul/li/a[contains(text(),'Home')]"));
        public IWebElement footerAboutUs => WaitAndFindElement(By.XPath("//*[@id='footerPanel']/ul/li/a[contains(text(),'About Us')]"));
        public IWebElement footerServices => WaitAndFindElement(By.XPath("//*[@id='footerPanel']/ul/li/a[contains(text(),'Services')]"));
        public IWebElement footerProducts => WaitAndFindElement(By.XPath("//*[@id='footerPanel']/ul/li/a[contains(text(),'Products')]"));
        public IWebElement footerLocations => WaitAndFindElement(By.XPath("//*[@id='footerPanel']/ul/li/a[contains(text(),'Locations')]"));
        public IWebElement footerForum => WaitAndFindElement(By.XPath("//*[@id='footerPanel']/ul/li/a[contains(text(),'Forum')]"));
        public IWebElement footerSiteMap => WaitAndFindElement(By.XPath("//*[@id='footerPanel']/ul/li/a[contains(text(),'Site Map')]"));
        public IWebElement footerContactUs => WaitAndFindElement(By.XPath("//*[@id='footerPanel']/ul/li/a[contains(text(),'Contact Us')]"));
        public IWebElement copyRightText => WaitAndFindElement(By.XPath("//div[@id='footerPanel']/p[@class='copyright']"));
    }
}
