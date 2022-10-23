using NUnit.Framework;
using OpenQA.Selenium;
using ParaBank_Automation.Utilities;

namespace ParaBank_Automation.Methods
{
    
    public  static class LogInOut
    {
        public static void LogInUser(IWebElement usernameField,IWebElement passowrdField,IWebElement button)
        {
           if (usernameField.Displayed && passowrdField.Displayed && button.Displayed)
            {
                usernameField.SendKeys(Constants.username);
                passowrdField.SendKeys(Constants.password);
                button.Click();
            }
        }
        public static void LogOutUser(IWebElement logOutButton)
        {
            if(logOutButton.Displayed)
            {
                logOutButton.Click();
            }
        }
       
    }
}
