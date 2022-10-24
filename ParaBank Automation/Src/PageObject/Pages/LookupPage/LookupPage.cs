using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaBank_Automation.Src
{
    public partial class LookupPage : BasePage
    {
        public LookupPage(IWebDriver driver) : base(driver)
        {

        }
        public override string PageURL => "https://parabank.parasoft.com/parabank/lookup.htm";
      

        public void CleanLookupForm()
        {
            firstNameField.Clear();
            lastNameField.Clear();
            addressField.Clear();
            cityField.Clear();
            stateField.Clear();
            zipCodeField.Clear();
            ssnField.Clear();
        }
        public void FillLookupForm(string firstName,string lastName,string address,string city,string zipCode,string snn)
        {
            firstNameField.SendKeys(firstName);
            lastNameField.SendKeys(lastName);
            addressField.SendKeys(address);
            cityField.SendKeys(city);
            zipCodeField.SendKeys(zipCode);
            ssnField.SendKeys(snn);
        }
    }
}
