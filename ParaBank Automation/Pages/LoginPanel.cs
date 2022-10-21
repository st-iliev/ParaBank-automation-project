using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaBank_Automation.Pages
{
    internal class LoginPanel : BasePage
    {
        public LoginPanel(IWebDriver driver) : base(driver)
        {

        }
        public override string PageURL => "https://parabank.parasoft.com/parabank/index.htm";
        public IWebElement loginTitle => driver.FindElement(By.XPath("//*[@id='leftPanel']/h2"));
        public IWebElement usernameField => driver.FindElement(By.XPath("//input[@name='username']"));
        public IWebElement passwordField => driver.FindElement(By.XPath("//input[@name='password']"));
        public IWebElement loginButton => driver.FindElement(By.XPath("//input[@class='button']"));
        public IWebElement forgotLogInInfo => driver.FindElement(By.XPath("//*[@id='loginPanel']/p[1]/a"));
        public IWebElement register => driver.FindElement(By.XPath("//form[@href='register.htm']"));

        public void FilledLogInForm(string username , string password)
        {
            usernameField.Clear();
            usernameField.SendKeys(username);
            passwordField.Clear();
            passwordField.SendKeys(password);
            loginButton.Click();
        }
    }
}
