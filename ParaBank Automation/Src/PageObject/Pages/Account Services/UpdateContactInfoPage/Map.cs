using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaBank_Automation.Src
{
    public partial class UpdateContactInfoPage
    {
        public IWebElement firstNameField => WaitAndFindElements(By.XPath("//input[@id='customer.firstName']"));
        public IWebElement lastNameField => WaitAndFindElements(By.XPath("//input[@id='customer.lastName']"));
        public IWebElement addressField => WaitAndFindElements(By.XPath("//input[@id='customer.address.street']"));
        public IWebElement cityField => WaitAndFindElements(By.XPath("//input[@id='customer.address.city']"));
        public IWebElement stateField => WaitAndFindElements(By.XPath("//input[@id='customer.address.state']"));
        public IWebElement zipeCodeField => WaitAndFindElements(By.XPath("//input[@id='customer.address.zipCode']"));
        public IWebElement phoneNumberField => WaitAndFindElements(By.XPath("//input[@id='customer.phoneNumber']"));
        public IWebElement updateProfileButton => WaitAndFindElements(By.XPath("//input[@value='Update Profile']"));
        public IWebElement firstNameErrorMessage => WaitAndFindElements(By.XPath("//span[@ng-if='customer && !customer.firstName']"));
        public IWebElement lastNameErrorMessage => WaitAndFindElements(By.XPath("//span[@ng-if='customer && !customer.lastName']"));
        public IWebElement addressErrorMessage => WaitAndFindElements(By.XPath("//span[@ng-if='customer && !customer.address.street']"));
        public IWebElement cityErrorMessage => WaitAndFindElements(By.XPath("//span[@ng-if='customer && !customer.address.city']"));
        public IWebElement stateErrorMessage => WaitAndFindElements(By.XPath("//span[@ng-if='customer && !customer.address.state']"));
        public IWebElement zipCodeErrorMessage => WaitAndFindElements(By.XPath("//span[@ng-if='customer && !customer.address.zipCode']"));
        public IWebElement successfulyUpdated => WaitAndFindElements(By.XPath("//*[@id='rightPanel']/div/div/p"));
    }
}
