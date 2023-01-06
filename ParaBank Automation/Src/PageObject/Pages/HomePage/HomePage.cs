using Microsoft.VisualBasic;
using OpenQA.Selenium;
using Constants = ParaBank_Automation.Utilities.Constants;

namespace ParaBank_Automation.Src
{
    public partial class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {

        }
        public override string PageURL => "https://parabank.parasoft.com/parabank/index.htm";
        public void FilledLogInForm()
        {
            usernameField.Clear();
            usernameField.SendKeys(Constants.username);
            passwordField.Clear();
            passwordField.SendKeys(Constants.password);
        }
        public void LogIn() => loginButton.Click();
       
        public void OpenNewRegisterForm() => register.Click();
       
        public void ForgotLoginInfo() => forgotLogInInfo.Click();
        
        public void LogOut() => logOut.Click();
       
    }
}
