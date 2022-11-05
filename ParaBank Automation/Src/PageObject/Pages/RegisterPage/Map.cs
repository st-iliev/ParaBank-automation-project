using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaBank_Automation.Src
{
    public partial class RegisterPage
    {
        public IWebElement firstNameField => WaitAndFindElement(By.XPath("//input[@id='customer.firstName']"));
        public IWebElement lastNameField => WaitAndFindElement(By.XPath("//input[@id='customer.lastName']"));
        public IWebElement addressField => WaitAndFindElement(By.XPath("//input[@id='customer.address.street']"));
        public IWebElement cityField => WaitAndFindElement(By.XPath("//input[@id='customer.address.city']"));
        public IWebElement stateField => WaitAndFindElement(By.XPath("//input[@id='customer.address.state']"));
        public IWebElement zipCodeField => WaitAndFindElement(By.XPath("//input[@id='customer.address.zipCode']"));
        public IWebElement phoneNumberField => WaitAndFindElement(By.XPath("//input[@id='customer.phoneNumber']"));
        public IWebElement ssnField => WaitAndFindElement(By.XPath("//input[@id='customer.ssn']"));
        public IWebElement usernameField => WaitAndFindElement(By.XPath("//input[@id='customer.username']"));
        public IWebElement passwordField => WaitAndFindElement(By.XPath("//input[@id='customer.password']"));
        public IWebElement confirmField => WaitAndFindElement(By.XPath("//input[@id='repeatedPassword']"));
        public IWebElement registerButton => WaitAndFindElement(By.XPath("//input[@value='Register']"));
        public IWebElement firstNameErrorMessage => WaitAndFindElement(By.XPath("//span[@id='customer.firstName.errors']"));
        public IWebElement lastNameErrorMessage => WaitAndFindElement(By.XPath("//span[@id='customer.lastName.errors']"));
        public IWebElement addressErrorMessage => WaitAndFindElement(By.XPath("//span[@id='customer.address.street.errors']"));
        public IWebElement cityErrorMessage => WaitAndFindElement(By.XPath("//span[@id='customer.address.city.errors']"));
        public IWebElement stateErrorMessage => WaitAndFindElement(By.XPath("//span[@id='customer.address.state.errors']"));
        public IWebElement zipCodeErrorMessage => WaitAndFindElement(By.XPath("//span[@id='customer.address.zipCode.errors']"));
        public IWebElement ssnErrorMessage => WaitAndFindElement(By.XPath("//span[@id='customer.ssn.errors']"));
        public IWebElement usernameErrorMessage => WaitAndFindElement(By.XPath("//span[@id='customer.username.errors']"));
        public IWebElement passwordErrorMessage => WaitAndFindElement(By.XPath("//span[@id='customer.password.errors']"));
        public IWebElement confirmErrorMessage => WaitAndFindElement(By.XPath("//span[@id='repeatedPassword.errors']"));

    }
}
