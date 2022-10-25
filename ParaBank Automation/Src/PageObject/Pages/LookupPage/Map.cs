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
        public IWebElement firstNameField => WaitAndFindElement(By.XPath("//input[@id='firstName']"));
        public IWebElement firstNameErrorMsg => WaitAndFindElement(By.XPath("//span[@id='firstName.errors']"));
        public IWebElement lastNameField => WaitAndFindElement(By.XPath("//input[@id='lastName']"));
        public IWebElement lastNameErrorMsg => WaitAndFindElement(By.XPath("//span[@id='lastName.errors']"));
        public IWebElement addressField => WaitAndFindElement(By.XPath("//input[@id='address.street']"));
        public IWebElement addressErrorMsg => WaitAndFindElement(By.XPath("//span[@id='address.street.errors']"));
        public IWebElement cityField => WaitAndFindElement(By.XPath("//input[@id='address.city']"));
        public IWebElement cityErrorMsg => WaitAndFindElement(By.XPath("//span[@id='address.city.errors']"));
        public IWebElement stateField => WaitAndFindElement(By.XPath("//input[@id='address.state']"));
        public IWebElement stateErrorMsg => WaitAndFindElement(By.XPath("//span[@id='address.state.errors']"));
        public IWebElement zipCodeField => WaitAndFindElement(By.XPath("//input[@id='address.zipCode']"));
        public IWebElement zipErrorMsg => WaitAndFindElement(By.XPath("//span[@id='address.zipCode.errors']"));
        public IWebElement ssnField => WaitAndFindElement(By.XPath("//input[@id='ssn']"));
        public IWebElement ssnErrorMsg => WaitAndFindElement(By.XPath("//span[@id='ssn.errors']"));
        public IWebElement finyMyLoginInfoButton => WaitAndFindElement(By.XPath("//input[@value='Find My Login Info']"));
    }
}
