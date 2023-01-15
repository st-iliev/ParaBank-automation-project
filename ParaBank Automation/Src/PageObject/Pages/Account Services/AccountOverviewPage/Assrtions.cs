using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Globalization;
using System.Linq;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;

namespace ParaBank_Automation.Src
{
    public partial class AccountOverview
    {
        public void AssertNewAccountIsAdded_To_OverviewPage(int oldAccountNumbers)
        {
            Assert.Greater(allAccounts.Count, oldAccountNumbers);
        }
        public void AssertCheckingNewAccountId_IsContainedInList(string newAccount)
        {
            bool isAdded = false;
            Thread.Sleep(500);
            foreach (var element in allAccounts)
            {
                string currentElemenet = element.Text;
                if (currentElemenet == newAccount)
                {
                    isAdded = true;
                    break;
                }
            }
            Assert.IsTrue(isAdded);
        }
        public void AssertAccountBalanceIncrease(string before , string after)
        {
            double beforeTransaction = Convert.ToDouble(before.Split("$")[1]);
            double afterTransaction = Convert.ToDouble(after.Split("$")[1]);
            Assert.That(afterTransaction, Is.GreaterThan(beforeTransaction));
        }
        public void AssertAccountBalanceDecrease(string before, string after)
        {
            double beforeTransaction = Convert.ToDouble(before.Split("$")[1]);
            double afterTransaction = Convert.ToDouble(after.Split("$")[1]);
            Assert.That(beforeTransaction, Is.GreaterThan(afterTransaction));
        }
    }
}
