using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaBank_Automation.Src
{
    public partial class UpdateContactInfoPage : BasePage
    {
        public UpdateContactInfoPage(IWebDriver driver) : base(driver)
        {

        }
        public override string PageURL => "https://parabank.parasoft.com/parabank/updateprofile.htm";

        public void FillUpdateProfileForm(ProfileForm profileForm)
        {
            firstNameField.Clear();
            firstNameField.SendKeys(profileForm.FirstName);
            lastNameField.Clear();
            lastNameField.SendKeys(profileForm.LastName);
            addressField.Clear();
            addressField.SendKeys(profileForm.Address);
            cityField.Clear();
            cityField.SendKeys(profileForm.City);
            stateField.Clear();
            stateField.SendKeys(profileForm.State);
            zipeCodeField.Clear();
            zipeCodeField.SendKeys(profileForm.ZipCode);
            phoneNumberField.Clear();
            phoneNumberField.SendKeys(profileForm.PhoneNumber);
        }
        public void ClearForm()
        {
            firstNameField.Clear();
            lastNameField.Clear();
            addressField.Clear();
            cityField.Clear();
            stateField.Clear();
            zipeCodeField.Clear();
            phoneNumberField.Clear();
        }
        public override void HoverAndClick(IWebElement elemenet)
        {
            base.HoverAndClick(elemenet);
        }

    }
}
