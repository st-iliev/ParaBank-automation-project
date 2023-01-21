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
        public IWebElement pageLogo => WaitAndFindElements(By.XPath("//div[@id='topPanel']/img[@class='logo']"));
        public IWebElement homeButton => WaitAndFindElements(By.XPath("//a[contains(text(),'home')]"));
        public IWebElement aboutUsButton => WaitAndFindElements(By.XPath("//li[@class='aboutus']/a"));
        public IWebElement contactButton => WaitAndFindElements(By.XPath("//a[contains(text(),'contact')]"));
        public IWebElement pageHeading => WaitAndFindElements(By.XPath("//div[@id='rightPanel']/h1"));
        public IWebElement pageText => WaitAndFindElements(By.XPath("//div[@id='rightPanel']/p"));

        public IWebElement welcomeUserText => WaitAndFindElements(By.XPath("//*[@id='leftPanel']/p"));
        public IWebElement openNewAccount => WaitAndFindElements(By.XPath("//a[contains(@href,'openaccount')]"));
        public IWebElement accountOverview => WaitAndFindElements(By.XPath("//a[contains(@href,'overview')]"));
        public IWebElement accTransferFunds => WaitAndFindElements(By.XPath("//a[contains(@href,'transfer')]"));
        public IWebElement accBillPay => WaitAndFindElements(By.XPath("//a[contains(@href,'billpay')]"));
        public IWebElement findTransactions => WaitAndFindElements(By.XPath("//a[contains(@href,'findtrans')]"));
        public IWebElement updateContactInfo => WaitAndFindElements(By.XPath("//a[contains(@href,'updateprofile')]"));
        public IWebElement requestLoan => WaitAndFindElements(By.XPath("//a[contains(@href,'requestloan')]"));
        public IWebElement logOut => WaitAndFindElements(By.XPath("//a[contains(@href,'logout')]"));

        public IWebElement loginTitle => WaitAndFindElements(By.XPath("//*[@id='leftPanel']/h2"));
        public IWebElement usernameField => WaitAndFindElements(By.XPath("//input[@name='username']"));
        public IWebElement passwordField => WaitAndFindElements(By.XPath("//input[@name='password']"));
        public IWebElement loginButton => WaitAndFindElements(By.XPath("//input[@class='button']"));
        public IWebElement forgotLogInInfo => WaitAndFindElements(By.XPath("//*[@id='loginPanel']/p[1]/a"));
        public IWebElement register => WaitAndFindElements(By.XPath("//*[contains(@href,'register.htm')]"));

        public IWebElement solutions => WaitAndFindElements(By.XPath("//div[@class='Solutions']"));
        public IWebElement aboutUs => WaitAndFindElements(By.XPath("//a[@href='about.htm']"));
        public IWebElement services => WaitAndFindElements(By.XPath("//a[@href='services.htm']"));
        public IWebElement products => WaitAndFindElements(By.XPath("//a[@href='http://www.parasoft.com/jsp/products.jsp']"));
        public IWebElement locations => WaitAndFindElements(By.XPath("//a[@href='http://www.parasoft.com/jsp/pr/contacts.jsp']"));
        public IWebElement adminPage => WaitAndFindElements(By.XPath("//a[contains(text(),'Admin Page')]"));

        public IWebElement footerElements => WaitAndFindElements(By.XPath("//*[@id='footerPanel']/ul[1]/li"));
        public IWebElement footerHome => WaitAndFindElements(By.XPath("//*[@id='footerPanel']/ul/li/a[contains(text(),'Home')]"));
        public IWebElement footerAboutUs => WaitAndFindElements(By.XPath("//*[@id='footerPanel']/ul/li/a[contains(text(),'About Us')]"));
        public IWebElement footerServices => WaitAndFindElements(By.XPath("//*[@id='footerPanel']/ul/li/a[contains(text(),'Services')]"));
        public IWebElement footerProducts => WaitAndFindElements(By.XPath("//*[@id='footerPanel']/ul/li/a[contains(text(),'Products')]"));
        public IWebElement footerLocations => WaitAndFindElements(By.XPath("//*[@id='footerPanel']/ul/li/a[contains(text(),'Locations')]"));
        public IWebElement footerForum => WaitAndFindElements(By.XPath("//*[@id='footerPanel']/ul/li/a[contains(text(),'Forum')]"));
        public IWebElement footerSiteMap => WaitAndFindElements(By.XPath("//*[@id='footerPanel']/ul/li/a[contains(text(),'Site Map')]"));
        public IWebElement footerContactUs => WaitAndFindElements(By.XPath("//*[@id='footerPanel']/ul/li/a[contains(text(),'Contact Us')]"));
        public IWebElement copyRightText => WaitAndFindElements(By.XPath("//div[@id='footerPanel']/p[@class='copyright']"));
        public IList<IWebElement> atmServices => Driver.FindElements(By.XPath("//*[@id='rightPanel']/ul[1]/li"));
        public IList<IWebElement> onlineServices => Driver.FindElements(By.XPath("//*[@id='rightPanel']/ul[2]/li"));
    }
}
