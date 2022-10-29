using NUnit.Framework;
using ParaBank_Automation.Src;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaBank_Automation.Tests
{
    internal class AboutUsTest : BaseTest
    {
        
        [Test]
        public void OpenAboutUsPage()
        {
            var page = new AboutUs(driver);
            page.Open();
            Assert.AreEqual("ParaBank | About Us", page.GetPageTitle());

        }
    }
}
