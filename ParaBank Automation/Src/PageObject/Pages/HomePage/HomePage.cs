using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaBank_Automation.Src
{ 
    public partial class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {

        }
        public override string PageURL => "https://parabank.parasoft.com/parabank/index.htm";
        public void FilledLogInForm(string username, string password)
        {
            usernameField.Clear();
            usernameField.SendKeys(username);
            passwordField.Clear();
            passwordField.SendKeys(password);
            loginButton.Click();
        }

    }
}
