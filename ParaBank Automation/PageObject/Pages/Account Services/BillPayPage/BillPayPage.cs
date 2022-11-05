using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaBank_Automation.Src
{
    public partial class BillPayPage : BasePage
    {
        public BillPayPage(IWebDriver driver) : base(driver)
        {
        }
        public override string PageURL => "https://parabank.parasoft.com/parabank/billpay.htm";
       

        public void ClearAllFields()
        {
            IList<IWebElement> List1 = Driver.FindElements(By.TagName("input"));
            for (int i = 0; i < List1.Count-1; i++)
            {
                List1[i].Clear();
            }
        }
        public void FillBillPaymentForm(string payeeName, string address, string city, string state, int zipeCode, string phoneNumber, string accountId, string verifyAccountId, int amount, int fromAccountId)
        {
            ClearAllFields();
            payeeNameField.SendKeys(payeeName);
            addressField.SendKeys(address);
            cityField.SendKeys(city);
            stateField.SendKeys(state);
            zipCodeField.SendKeys(zipeCode.ToString());
            phoneNumberField.SendKeys(phoneNumber.ToString());
            accountField.SendKeys(accountId.ToString());
            verifyAccountField.SendKeys(verifyAccountId.ToString());
            amountField.SendKeys(amount.ToString());
            fromAccountField.SendKeys(fromAccountId.ToString());
            sendPaymentButton.Click();
        }
    }
}
