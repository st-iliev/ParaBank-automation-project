using OpenQA.Selenium;
using ParaBank_Automation.Src.PageObject.Pages.Account_Services.BillPayPage;
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
        public void FillBillPaymentForm(BillPaymentForm billPaymentForm)
        {
            ClearAllFields();
            payeeNameField.SendKeys(billPaymentForm.PayeeName);
            addressField.SendKeys(billPaymentForm.Address);
            cityField.SendKeys(billPaymentForm.City);
            stateField.SendKeys(billPaymentForm.State);
            zipCodeField.SendKeys(billPaymentForm.ZipCode);
            phoneNumberField.SendKeys(billPaymentForm.PhoneNumber);
            accountField.SendKeys(billPaymentForm.Account);
            verifyAccountField.SendKeys(billPaymentForm.VerifyAccount);
            amountField.SendKeys(billPaymentForm.Amount);
            fromAccountField.SendKeys(billPaymentForm.FromAccount);        
        }
        public void SendPayment()
        {
            sendPaymentButton.Click();
        }
    }
}
