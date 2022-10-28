using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaBank_Automation.Src.PageObject.Pages.Account_Services.UpdateContactInfoPage
{
    public partial class UpdateContactInfoPage
    {
        public IWebElement firstNameField => WaitAndFindElement(By.XPath("//input[@id='customer.firstName']"));
        public IWebElement lastNameField => WaitAndFindElement(By.XPath("//input[@id='customer.lastName']"));
        public IWebElement addressField => WaitAndFindElement(By.XPath("//input[@id='customer.address.street']"));
        public IWebElement cityField => WaitAndFindElement(By.XPath("//input[@id='customer.address.city']"));
        public IWebElement stateField => WaitAndFindElement(By.XPath("//input[@id='customer.address.state']"));
        public IWebElement zipeCodeField => WaitAndFindElement(By.XPath("//input[@id='customer.address.zipCode']"));
        public IWebElement phoneNumberField => WaitAndFindElement(By.XPath("//input[@id='customer.address.phoneNumber']"));
        public IWebElement updateProfileButton => WaitAndFindElement(By.XPath("//input[@value='Update Profile']"));
        public IWebElement firstNameErrorMessage => WaitAndFindElement(By.XPath("//span[@ng-if='customer && !customer.firstName']"));
        public IWebElement lastNameErrorMessage => WaitAndFindElement(By.XPath("//span[@ng-if='customer && !customer.lastName']"));
        public IWebElement addressErrorMessage => WaitAndFindElement(By.XPath("//span[@ng-if='customer && !customer.address.street']"));
        public IWebElement cityErrorMessage => WaitAndFindElement(By.XPath("//span[@ng-if='customer && !customer.address.city']"));
        public IWebElement stateErrorMessage => WaitAndFindElement(By.XPath("//span[@ng-if='customer && !customer.address.state']"));
        public IWebElement zipeCodeErrorMessage => WaitAndFindElement(By.XPath("//span[@ng-if='customer && !customer.address.zipeCode']"));
        public IWebElement successfulyUpdated => WaitAndFindElement(By.XPath("//h1[@class='title']/p"));
    }
}
