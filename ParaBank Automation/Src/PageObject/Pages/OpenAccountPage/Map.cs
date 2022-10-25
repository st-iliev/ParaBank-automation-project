using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaBank_Automation.Src
{
    public partial class OpenAccountPage
    {
        public IWebElement accountType => WaitAndFindElement(By.XPath("//*[@id='type']"));
        public IWebElement fromAccountId => WaitAndFindElement(By.XPath("//*[@id='fromAccountId']"));
        public IWebElement openNewAccountButton => WaitAndFindElement(By.XPath("//*[@value='Open New Account']"));
        public IWebElement newAccountId => WaitAndFindElement(By.XPath("//*[@id='newAccountId']"));
    }
}
