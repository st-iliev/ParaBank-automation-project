using OpenQA.Selenium;
using ParaBank_Automation.Src.PageObject.Pages.RegisterPage;
using ParaBank_Automation.Utilities;
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
        public virtual void FillRegisterForm(RegistrationForm registrationForm)
        {
            firstNameField.SendKeys(registrationForm.FirstName);
            lastNameField.SendKeys(registrationForm.LastName);
            addressField.SendKeys(registrationForm.Address);
            cityField.SendKeys(registrationForm.City);
            stateField.SendKeys(registrationForm.State);
            zipCodeField.SendKeys(registrationForm.ZipCode);
            phoneNumberField.SendKeys(registrationForm.PhoneNumber);
            ssnField.SendKeys(registrationForm.SSN);
            usernameField.SendKeys(registrationForm.Username);
            passwordField.SendKeys(registrationForm.Password);
            confirmField.SendKeys(registrationForm.ConfirmPassword);
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
