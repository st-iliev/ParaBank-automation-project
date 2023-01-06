using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using NUnit.Framework;
using ParaBank_Automation.Utilities;
using ParaBank_Automation.Src;

namespace ParaBank_Automation.Src.PageObject.TestScripts
{
    public  class SiteMapPageTest : IDisposable
    {
        private static IWebDriver driver;
        private static HomePage homePage;
        private static SiteMapPage siteMapPage;
        public SiteMapPageTest()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            homePage = new HomePage(driver);
            siteMapPage = new SiteMapPage(driver);
        }
        [Test]
        public void OpenAboutUsPage()
        {
            siteMapPage.Open();
            siteMapPage.aboutUs.Click();
            siteMapPage.AssertOpenCorrectPageFromAboutUsLink();
        }
        [Test]
        public void OpenServicesPage()
        {
            siteMapPage.Open();
            siteMapPage.services.Click();
            siteMapPage.AssertOpenCorrectPageFromServicesLink();
        }
        [Test]
        public void OpenProductsPage()
        {
            siteMapPage.Open();
            siteMapPage.products.Click();
            siteMapPage.AssertOpenCorrectPageFromProductsLink();
        }
        [Test]
        public void OpenLocationsPage()
        {
            siteMapPage.Open();
            siteMapPage.locations.Click();
            siteMapPage.AssertOpenCorrectPageFromLocationsLink();
        }
        [Test]
        public void OpenAdminPagePage()
        {
            siteMapPage.Open();
            siteMapPage.adminPage.Click();
            siteMapPage.AssertOpenCorrectPageFromAdminPageLink();
        }
        [Test]
        public void OpenNewAccountPage_WithoutUserBeingLogin()
        {
            siteMapPage.Open();
            siteMapPage.openNewAccount.Click();
            siteMapPage.AssertOpenCorrectPageAndGiveCorrectError();
        }
        [Test]
        public void OpenAccountOverviewPage_WithoutUserBeingLogin()
        {
            siteMapPage.Open();
            siteMapPage.accountOverview.Click();
            siteMapPage.AssertOpenCorrectPageAndGiveCorrectError();
        }
        [Test]
        public void OpenTransferFundsPage_WithoutUserBeingLogin()
        {
            siteMapPage.Open();
            siteMapPage.transferFunds.Click();
            siteMapPage.AssertOpenCorrectPageAndGiveCorrectError();
        }
        [Test]
        public void OpenBillPayPage_WithoutUserBeingLogin()
        {
            siteMapPage.Open();
            siteMapPage.billPay.Click();
            siteMapPage.AssertOpenCorrectPageAndGiveCorrectError();
        }
        [Test]
        public void OpenFindTransactionsPage_WithoutUserBeingLogin()
        {
            siteMapPage.Open();
            siteMapPage.findTransactions.Click();
            siteMapPage.AssertOpenCorrectPageAndGiveCorrectError();
        }
        [Test]
        public void OpenUpdateContactInfoPage_WithoutUserBeingLogin()
        {
            siteMapPage.Open();
            siteMapPage.updateContactInfo.Click();
            siteMapPage.AssertOpenCorrectPageAndGiveCorrectError();
        }
        [Test]
        public void OpenRequestLoanPage_WithoutUserBeingLogin()
        {
            siteMapPage.Open();
            siteMapPage.requestLoan.Click();
            siteMapPage.AssertOpenCorrectPageAndGiveCorrectError();
        }
        [Test]
        public void LogOutUser_WithoutUserBeingLogin()
        {
            siteMapPage.Open();
            siteMapPage.logOut.Click();
            homePage.AssertUserIsNotLogIn();
        }
        [Test,Order(1)]
        public void LogInUser_FromSiteMapPage()
        {
            siteMapPage.Open();
            homePage.FilledLogInForm();
            homePage.loginButton.Click();
            homePage.AssertUserIsLogIn();
        }
        [Test, Order(2)]
        public void OpenNewAccountPage_WhenUserBeingLogin()
        {
            siteMapPage.Open();
            siteMapPage.openNewAccount.Click();
            siteMapPage.AssertOpenCorrectPageFromOpenNewAccountLink();
        }
        [Test, Order(3)]
        public void OpenAccountOverviewPage_WhenUserBeingLogin()
        {
            siteMapPage.Open();
            siteMapPage.accountOverview.Click();
            siteMapPage.AssertOpenCorrectPageFromAccountOverviewLink();
        }
        [Test, Order(4)]
        public void OpenTransferFundsPage_WhenUserBeingLogin()
        {
            siteMapPage.Open();
            siteMapPage.transferFunds.Click();
            siteMapPage.AssertOpenCorrectPageFromTransferFundsLink();
        }
        [Test, Order(5)]
        public void OpenBillPayPage_WhenUserBeingLogin()
        {
            siteMapPage.Open();
            siteMapPage.billPay.Click();
            siteMapPage.AssertOpenCorrectPageFromBillPayLink();
        }
        [Test, Order(6)]
        public void OpenFindTransactionsPage_WhenUserBeingLogin()
        {
            siteMapPage.Open();
            siteMapPage.findTransactions.Click();
            siteMapPage.AssertOpenCorrectPageFromFindTransactionsLink();
        }
        [Test, Order(7)]
        public void OpenUpdateContactInfoPage_WhenUserBeingLogin()
        {
            siteMapPage.Open();
            siteMapPage.updateContactInfo.Click();
            siteMapPage.AssertOpenCorrectPageFromUpdateContactInfoLink();
        }
        [Test, Order(8)]
        public void OpenRequestLoanPage_WhenUserBeingLogin()
        {
            siteMapPage.Open();
            siteMapPage.requestLoan.Click();
            siteMapPage.AssertOpenCorrectPageFromRequestLoanLink();
        }
        [Test, Order(9)]
        public void LogOutUser_WhenUserBeingLogin()
        {
            siteMapPage.Open();
            siteMapPage.logOut.Click();
            homePage.AssertUserIsNotLogIn();
        }
        public void Dispose()
        {
           driver.Dispose();
        }
    }
}
