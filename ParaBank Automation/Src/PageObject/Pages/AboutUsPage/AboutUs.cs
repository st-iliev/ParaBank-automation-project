using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaBank_Automation.Pages
{
    internal class AboutUs : BasePage
    {
        public AboutUs(IWebDriver driver) : base(driver)
        {

        }
        public override string PageURL => "https://parabank.parasoft.com/parabank/about.htm";
    }
}

