using NUnit.Framework;
using ParaBank_Automation.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaBank_Automation.Src
{
    public partial class HomePage
    {
        public void AssertOpenCorrectHomePage()
        {
            Assert.AreEqual("ParaBank | Welcome | Online Banking",GetPageTitle());
        }
        public void AssertOpenCorrectAboutUsPage()
        {
            Assert.AreEqual("ParaBank | About Us", GetPageTitle());
        }
        public void AssertOpenCorrectServicesPage()
        {
            Assert.AreEqual("ParaBank | Services", GetPageTitle());
        }
        public void AssertOpenCorrectProductsPage()
        {
            Assert.AreEqual("Automated Software Testing Tool Suite | Parasoft", GetPageTitle());
        }
        public void AssertOpenCorrectLocationsPage()
        {
            Assert.AreEqual("Automated Software Testing Solutions For Every Testing Need", GetPageTitle());
        }
        public void AssertOpenCorrectForumPage()
        {
            Assert.AreEqual("Welcome to the Forums", GetPageTitle());
        }
        public void AssertOpenCorrectSiteMapPage()
        {
            Assert.AreEqual("ParaBank | Site Map", GetPageTitle());
        }
        public void AssertOpenCorrectContactUsPage()
        {
            Assert.AreEqual("ParaBank | Customer Care", GetPageTitle());
        }
        public void AssertOpenCorrectAdminPage()
        {
            Assert.AreEqual("ParaBank | Administration", GetPageTitle());
        }
        public void AssertUserIsLogOut()
        {
            Assert.That(usernameField.Displayed);
            Assert.That(passwordField.Displayed);
        }
        public void AssertUserIsLogIn()
        {
            Assert.AreEqual(SuccessMessages.welcome, welcomeUserText.Text);
        }
        public void AssertATMServices_ContainWithdrawFundsLink()
        {
            Assert.AreEqual("Withdraw Funds", atmServices[1].Text);
        }
        public void AssertATMServices_ContainTransferFundslink()
        {
            Assert.AreEqual("Transfer Funds", atmServices[2].Text);
        }
        public void AssertATMServices_ContainCheckBalanceslink()
        {
            Assert.AreEqual("Check Balances", atmServices[3].Text);
        } 
        public void AssertATMServices_ContainMakeDepositslink()
        {
            Assert.AreEqual("Make Deposits", atmServices[4].Text);
        }
        public void AssertOnlineServices_ContainBillPaylink()
        {
            Assert.AreEqual("Bill Pay", onlineServices[1].Text);
        }
        public void AssertOnlineServices_ContainAccountHistorylink()
        {
            Assert.AreEqual("Account History", onlineServices[2].Text);
        } 
        public void AssertOnlineServices_ContainTransferFundslink()
        {
            Assert.AreEqual("Transfer Funds", onlineServices[3].Text);
        }
    }
}
