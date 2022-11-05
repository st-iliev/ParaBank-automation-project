using NUnit.Framework;
using ParaBank_Automation.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaBank_Automation.Src
{
    public partial class SiteMapPage
    {
        public void AssertOpenCorrectPageFromAboutUsLink()
        {
            Assert.AreEqual("ParaBank | About Us", GetPageTitle());
        }
        public void AssertOpenCorrectPageFromServicesLink()
        {
            Assert.AreEqual("ParaBank | Services", GetPageTitle());
        }
        public void AssertOpenCorrectPageFromProductsLink()
        {
            Assert.AreEqual("Automated Software Testing Tool Suite | Parasoft", GetPageTitle());
        }
        public void AssertOpenCorrectPageFromLocationsLink()
        {
            Assert.AreEqual("Automated Software Testing Solutions For Every Testing Need", GetPageTitle());
        }
        public void AssertOpenCorrectPageFromAdminPageLink()
        {
            Assert.AreEqual("ParaBank | Administration", GetPageTitle());
        }
        public void AssertOpenCorrectPageFromOpenNewAccountLink()
        {
            Assert.AreEqual("ParaBank | Open Account", GetPageTitle());
        }
        public void AssertOpenCorrectPageFromAccountOverviewLink()
        {
            Assert.AreEqual("ParaBank | Accounts Overview", GetPageTitle());
        }
        public void AssertOpenCorrectPageFromTransferFundsLink()
        {
            Assert.AreEqual("ParaBank | Transfer Funds", GetPageTitle());
        } 
        public void AssertOpenCorrectPageFromBillPayLink()
        {
            Assert.AreEqual("ParaBank | Bill Pay", GetPageTitle());   
        }
        public void AssertOpenCorrectPageFromFindTransactionsLink()
        {
            Assert.AreEqual("ParaBank | Find Transactions", GetPageTitle());   
        }
        public void AssertOpenCorrectPageFromUpdateContactInfoLink()
        {
            Assert.AreEqual("ParaBank | Update Profile", GetPageTitle());   
        }
        public void AssertOpenCorrectPageFromRequestLoanLink()
        {
            Assert.AreEqual("ParaBank | Loan Request", GetPageTitle());   
        }
        public void AssertOpenCorrectPageAndGiveCorrectError()
        {
            Assert.AreEqual("ParaBank | Error", GetPageTitle());
            Assert.AreEqual(ErrorMessages.errorHeadingText,GetPageHeading());
            Assert.AreEqual(ErrorMessages.internalError,GetPageText());
        }

    }
}
