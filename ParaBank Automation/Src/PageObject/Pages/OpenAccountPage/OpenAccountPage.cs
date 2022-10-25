using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaBank_Automation.Src
{
    public partial class OpenAccountPage : BasePage
    {
        public OpenAccountPage(IWebDriver driver) : base(driver)
        {
        }
        public override string PageURL => throw new System.NotImplementedException();

    }
}
