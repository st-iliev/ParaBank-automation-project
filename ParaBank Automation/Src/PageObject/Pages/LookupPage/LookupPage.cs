using OpenQA.Selenium;
using ParaBank_Automation.Src.PageObject.Pages;

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
        public void FillLookupForm(LookupForm lookupForm)
        {
            firstNameField.SendKeys(lookupForm.FirstName);
            lastNameField.SendKeys(lookupForm.LastName);
            addressField.SendKeys(lookupForm.Address);
            cityField.SendKeys(lookupForm.City);
            stateField.SendKeys(lookupForm.State);
            zipCodeField.SendKeys(lookupForm.ZipCode);
            ssnField.SendKeys(lookupForm.SSN);
        }
        public void ClickOnLoginInfo()
        {
            finyMyLoginInfoButton.Click();
        }
    }
}
