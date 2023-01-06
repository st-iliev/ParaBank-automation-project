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
        public void AssertOpenCorrectPageFromFooterHomeLink()
        {
            Assert.AreEqual("ParaBank | Welcome | Online Banking",GetPageTitle());
        }
        public void AssertOpenCorrectPageFromFooterAboutUsLink()
        {
            Assert.AreEqual("ParaBank | About Us", GetPageTitle());
        }
        public void AssertOpenCorrectPageFromFooterServicesLink()
        {
            Assert.AreEqual("ParaBank | Services", GetPageTitle());
        }
        public void AssertOpenCorrectPageFromFooterProductsLink()
        {
            Assert.AreEqual("Automated Software Testing Tool Suite | Parasoft", GetPageTitle());
        }
        public void AssertOpenCorrectPageFromFooterLocationsLink()
        {
            Assert.AreEqual("Automated Software Testing Solutions For Every Testing Need", GetPageTitle());
        }
        public void AssertOpenCorrectPageFromFooterForumLink()
        {
            Assert.AreEqual("Welcome to the Forums", GetPageTitle());
        }
        public void AssertOpenCorrectPageFromFooterSiteMapLink()
        {
            Assert.AreEqual("ParaBank | Site Map", GetPageTitle());
        }
        public void AssertOpenCorrectPageFromFooterContactUsLink()
        {
            Assert.AreEqual("ParaBank | Customer Care", GetPageTitle());
        }
        public void AssertUserIsNotLogIn()
        {
            Assert.That(usernameField.Displayed);
            Assert.That(passwordField.Displayed);
        }
        public void AssertUserIsLogIn()
        {
            Assert.AreEqual(SuccessMessages.welcome, welcomeUserText.Text);
        }
    }
}
