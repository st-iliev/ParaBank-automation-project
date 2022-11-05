using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ParaBank_Automation.Src
{ 
    public partial class RegisterPage : BasePage
    {
        public RegisterPage(IWebDriver driver) : base(driver)
        {

        }
        public override string PageURL => "https://parabank.parasoft.com/parabank/register.htm";
        public void FillRegisterForm(string firstName,string lastName,string address,string city,string state,string zipeCode,string phoneNumber,string ssn,string username,string password,string confirmPassword)
        {
            firstNameField.SendKeys(firstName);
            lastNameField.SendKeys(lastName);
            addressField.SendKeys(address);
            cityField.SendKeys(city);
            stateField.SendKeys(state);
            zipCodeField.SendKeys(zipeCode);
            phoneNumberField.SendKeys(phoneNumber);
            ssnField.SendKeys(ssn);
            usernameField.SendKeys(username);
            passwordField.SendKeys(password);
            confirmField.SendKeys(confirmPassword);
        }
        public void ClickOnRegister()
        {
            registerButton.Click();
        }
        public void ClearRegisterForm()
        {
            firstNameField.Clear();
            lastNameField.Clear();
            addressField.Clear();
            cityField.Clear();
            stateField.Clear();
            zipCodeField.Clear();
            phoneNumberField.Clear();
            ssnField.Clear();
            usernameField.Clear();
            passwordField.Clear();
            confirmField.Clear();
        }
    }
}
