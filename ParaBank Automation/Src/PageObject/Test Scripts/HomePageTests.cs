using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace ParaBank_Automation.Src.PageObject.Test_Scripts
{
    public class HomePageTests : IDisposable
    {
        private static ChromeDriver driver;
        private static HomePage homePage;
        
        public HomePageTests()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            homePage = new HomePage(driver);
        }
        [Test]
        public void ClickOn_AboutUsLinkOnFooterPanel()
        {
            homePage.Open();
            homePage.HoverAndClick(homePage.footerAboutUs);
            homePage.AssertOpenCorrectAboutUsPage();
            
        }
        [Test]
        public void ClickOn_ServicesLinkOnFooterPanel()
        {
            homePage.Open();
            homePage.HoverAndClick(homePage.footerServices);
            homePage.AssertOpenCorrectServicesPage();

        }
        [Test]
        public void ClickOn_ProductsLinkOnFooterPanel()
        {
            homePage.Open();
            homePage.HoverAndClick(homePage.footerProducts);
            homePage.AssertOpenCorrectProductsPage();

        }
        [Test]
        public void ClickOn_LocationsLinkOnFooterPanel()
        {
            homePage.Open();
            homePage.HoverAndClick(homePage.footerLocations);
            homePage.AssertOpenCorrectLocationsPage();

        }
        [Test]
        public void ClickOn_ForumLinkOnFooterPanel()
        {
            homePage.Open();
            homePage.HoverAndClick(homePage.footerForum);
            homePage.AssertOpenCorrectForumPage();

        }
        [Test]
        public void ClickOn_SiteMapLinkOnFooterPanel()
        {
            homePage.Open();
            homePage.HoverAndClick(homePage.footerSiteMap);
            homePage.AssertOpenCorrectSiteMapPage();

        }
        [Test]
        public void ClickOn_ContactUsLinkOnFooterPanel()
        {
            homePage.Open();
            homePage.HoverAndClick(homePage.footerContactUs);
            homePage.AssertOpenCorrectContactUsPage();

        }
        [Test]
        public void ClickOn_HomeLinkOnFooterPanel()
        {
            homePage.Open();
            homePage.HoverAndClick(homePage.footerAboutUs);
            homePage.HoverAndClick(homePage.footerHome);
            homePage.AssertOpenCorrectHomePage();

        }
        [Test]
        public void ClickOn_AboutUsOnHeaderPanel()
        {
            homePage.Open();
            homePage.HoverAndClick(homePage.aboutUs);
            homePage.AssertOpenCorrectAboutUsPage();
        }
        [Test]
        public void ClickOn_ServicesOnHeaderPanel()
        {
            homePage.Open();
            homePage.HoverAndClick(homePage.services);
            homePage.AssertOpenCorrectServicesPage();
        }
        [Test]
        public void ClickOn_ProductsOnHeaderPanel()
        {
            homePage.Open();
            homePage.HoverAndClick(homePage.products);
            homePage.AssertOpenCorrectProductsPage();
        }
        [Test]
        public void ClickOn_LocationsOnHeaderPanel()
        {
            homePage.Open();
            homePage.HoverAndClick(homePage.locations);
            homePage.AssertOpenCorrectLocationsPage();
        }
        [Test]
        public void ClickOn_AdminPageOnHeaderPanel()
        {
            homePage.Open();
            homePage.HoverAndClick(homePage.adminPage);
            homePage.AssertOpenCorrectAdminPage();
        }
        [Test]
        public void Verify_ATMServicesContainsFollowingLinks()
        {
            homePage.Open();
            homePage.AssertATMServices_ContainWithdrawFundsLink();
            homePage.AssertATMServices_ContainTransferFundslink();
            homePage.AssertATMServices_ContainCheckBalanceslink();
            homePage.AssertATMServices_ContainMakeDepositslink();
        }
        [Test]
        public void Verify_OnlineServicesContainsFollowingLinks()
        {
            homePage.Open();
            homePage.AssertOnlineServices_ContainBillPaylink();
            homePage.AssertOnlineServices_ContainAccountHistorylink();
            homePage.AssertOnlineServices_ContainTransferFundslink();
        }
        [Test]
        public void LogIn_WithValidUserNameAndPassword()
        {
            homePage.Open();
            homePage.FilledLogInForm();
            homePage.HoverAndClick(homePage.loginButton);
            homePage.AssertUserIsLogIn();
        }
        [Test]
        public void LogOut()
        {
            homePage.Open();
            if (homePage.UserIsLogin())
            {
                homePage.HoverAndClick(homePage.logOut);
                homePage.UserIsLogOut();
            }
            else
            {
                homePage.FilledLogInForm();
                homePage.HoverAndClick(homePage.loginButton);
                homePage.AssertUserIsLogIn();
                homePage.HoverAndClick(homePage.logOut);
                homePage.UserIsLogOut();
            }
        }
        public void Dispose()
        {
            driver.Dispose();
        }
    }
}
