using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaBank_Automation.Src.PageObject.Pages.Account_Services.UpdateContactInfoPage
{
    public partial class UpdateContactInfoPage : BasePage
    {
        public UpdateContactInfoPage(IWebDriver driver) : base(driver)
        {

        }
        public override string PageURL => "https://parabank.parasoft.com/parabank/updateprofile.htm";

        public void FillUpdateProfileForm(string firstName, string lastName, string address, string city, string state, int zipCode, string phoneNumber)
        {
            firstNameField.Clear();
            firstNameField.SendKeys(firstName);
            lastNameField.Clear();
            lastNameField.SendKeys(lastName);
            addressField.Clear();
            addressField.SendKeys(address);
            cityField.Clear();
            cityField.SendKeys(city);
            stateField.Clear();
            stateField.SendKeys(state);
            zipeCodeField.Clear();
            zipeCodeField.SendKeys(zipCode.ToString());
            phoneNumberField.Clear();
            phoneNumberField.SendKeys(phoneNumber);
        }
        public void ClickOnUpdateButton()
        {
            updateProfileButton.Click();
        }
        protected override void WaitForPageLoad()
        {
            WaitAndFindElement(By.XPath("//h1[@class='title']"));
        }
    }
}
