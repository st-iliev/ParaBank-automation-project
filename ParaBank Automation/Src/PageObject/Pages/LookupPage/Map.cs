using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaBank_Automation.Src
{
    public partial class LookupPage
    {
        public IWebElement firstNameField => driver.FindElement(By.XPath("//input[@id='firstName']"));
        public IWebElement firstNameErrorMsg => driver.FindElement(By.XPath("//span[@id='firstName.errors']"));
        public IWebElement lastNameField => driver.FindElement(By.XPath("//input[@id='lastName']"));
        public IWebElement lastNameErrorMsg => driver.FindElement(By.XPath("//span[@id='lastName.errors']"));
        public IWebElement addressField => driver.FindElement(By.XPath("//input[@id='address.street']"));
        public IWebElement addressErrorMsg => driver.FindElement(By.XPath("//span[@id='address.street.errors']"));
        public IWebElement cityField => driver.FindElement(By.XPath("//input[@id='address.city']"));
        public IWebElement cityErrorMsg => driver.FindElement(By.XPath("//span[@id='address.city.errors']"));
        public IWebElement stateField => driver.FindElement(By.XPath("//input[@id='address.state']"));
        public IWebElement stateErrorMsg => driver.FindElement(By.XPath("//span[@id='address.state.errors']"));
        public IWebElement zipCodeField => driver.FindElement(By.XPath("//input[@id='address.zipCode']"));
        public IWebElement zipErrorMsg => driver.FindElement(By.XPath("//span[@id='address.zipCode.errors']"));
        public IWebElement ssnField => driver.FindElement(By.XPath("//input[@id='ssn']"));
        public IWebElement ssnErrorMsg => driver.FindElement(By.XPath("//span[@id='ssn.errors']"));
        public IWebElement finyMyLoginInfoButton => driver.FindElement(By.XPath("//input[@value='Find My Login Info']"));
    }
}
