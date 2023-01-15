using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaBank_Automation.Src
{
    public partial class BillPayPage
    {
        public IWebElement payeeNameField => WaitAndFindElements(By.XPath("//input[contains(@ng-model,'payee.name')]"));
        public IWebElement addressField => WaitAndFindElements(By.XPath("//input[contains(@ng-model,'payee.address.street')]"));
        public IWebElement cityField => WaitAndFindElements(By.XPath("//input[contains(@ng-model,'payee.address.city')]"));
        public IWebElement stateField => WaitAndFindElements(By.XPath("//input[contains(@ng-model,'payee.address.state')]"));
        public IWebElement zipCodeField => WaitAndFindElements(By.XPath("//input[contains(@ng-model,'payee.address.zipCode')]"));
        public IWebElement phoneNumberField => WaitAndFindElements(By.XPath("//input[contains(@ng-model,'payee.phoneNumber')]"));
        public IWebElement accountField => WaitAndFindElements(By.XPath("//input[contains(@ng-model,'payee.accountNumber')]"));
        public IWebElement verifyAccountField => WaitAndFindElements(By.XPath("//input[contains(@ng-model,'verifyAccount')]"));
        public IWebElement amountField => WaitAndFindElements(By.XPath("//input[contains(@ng-model,'amount')]"));
        public IWebElement fromAccountField => WaitAndFindElements(By.XPath("//*[@name='fromAccountId']"));
        public IWebElement sendPaymentButton => WaitAndFindElements(By.XPath("//*[@value='Send Payment']"));
        public IWebElement payneeNameErrorMessage => WaitAndFindElements(By.XPath("//*[@ng-show='!validationModel.name']"));
        public IWebElement addressErrorMessage => WaitAndFindElements(By.XPath("//*[@ng-show='!validationModel.address']"));
        public IWebElement cityErrorMessage => WaitAndFindElements(By.XPath("//*[@ng-show='!validationModel.city']"));
        public IWebElement stateErrorMessage => WaitAndFindElements(By.XPath("//*[@ng-show='!validationModel.state']"));
        public IWebElement zipCodeErrorMessage => WaitAndFindElements(By.XPath("//*[@ng-show='!validationModel.zipCode']"));
        public IWebElement phoneNumberErrorMessage => WaitAndFindElements(By.XPath("//*[@ng-show='!validationModel.phoneNumber']"));
        public IWebElement emptyAcccountErrorMessage => WaitAndFindElements(By.XPath("//*[@ng-show=\"validationModel.account == 'empty'\"]"));
        public IWebElement invalidAcccountErrorMessage => WaitAndFindElements(By.XPath("//*[@ng-show=\"validationModel.account == 'invalid'\"]"));
        public IWebElement emptyVerifyAcccountErrorMessage => WaitAndFindElements(By.XPath("//*[@ng-show=\"validationModel.verifyAccount == 'empty'\"]"));
        public IWebElement invalidVerifyAcccountErrorMessage => WaitAndFindElements(By.XPath("//*[@ng-show=//\"validationModel.verifyAccount == 'invalid'\"]"));
        public IWebElement emptyAmountErrorMessage => WaitAndFindElements(By.XPath("//*[@ng-show=\"validationModel.amount == 'empty'\"]"));
        public IWebElement invalidAmountErrorMessage => WaitAndFindElements(By.XPath("//*[@ng-show=\"validationModel.amount == invalid'\"]"));
    }
}
