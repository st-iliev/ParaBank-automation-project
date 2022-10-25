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
        public IWebElement payeeNameField => WaitAndFindElement(By.XPath("//input[contains(@ng-model,'payee.name')]"));

        public IWebElement addressField => WaitAndFindElement(By.XPath("//input[contains(@ng-model,'payee.address.street')]"));
        public IWebElement cityField => WaitAndFindElement(By.XPath("//input[contains(@ng-model,'payee.address.city')]"));
        public IWebElement stateField => WaitAndFindElement(By.XPath("//input[contains(@ng-model,'payee.address.state')]"));
        public IWebElement zipCodeField => WaitAndFindElement(By.XPath("//input[contains(@ng-model,'payee.address.zipCode')]"));
        public IWebElement phoneField => WaitAndFindElement(By.XPath("//input[contains(@ng-model,'payee.phoneNumber')]"));
        public IWebElement accountField => WaitAndFindElement(By.XPath("//input[contains(@ng-model,'payee.accountNumber')]"));
        public IWebElement verifyAccountField => WaitAndFindElement(By.XPath("//input[contains(@ng-model,'verifyAccount')]"));
        public IWebElement amountField => WaitAndFindElement(By.XPath("//input[contains(@ng-model,'amount')]"));
        public IWebElement fromAccountField => WaitAndFindElement(By.XPath("//input[contains(@ng-model,'accountId')]"));
        public IWebElement sendPaymentButton => WaitAndFindElement(By.XPath("//*[@value='Send Payment']"));
        public IWebElement payneeNameErrorMessage => WaitAndFindElement(By.XPath("//*[@ng-show='!validationModel.name']"));
        public IWebElement addressErrorMessage => WaitAndFindElement(By.XPath("//*[@ng-show='!validationModel.address']"));
        public IWebElement cityErrorMessage => WaitAndFindElement(By.XPath("//*[@ng-show='!validationModel.city']"));
        public IWebElement stateErrorMessage => WaitAndFindElement(By.XPath("//*[@ng-show='!validationModel.state']"));
        public IWebElement zipCodeErrorMessage => WaitAndFindElement(By.XPath("//*[@ng-show='!validationModel.zipCode']"));
        public IWebElement phoneErrorMessage => WaitAndFindElement(By.XPath("//*[@ng-show='!validationModel.phoneNumber']"));
        public IWebElement emptyAcccountErrorMessage => WaitAndFindElement(By.XPath("//*[@ng-show=\"validationModel.account == 'empty'\"]"));
        public IWebElement invalidAcccountErrorMessage => WaitAndFindElement(By.XPath("//*[@ng-show=\"validationModel.account == 'invalid'\"]"));
        public IWebElement emptyVerifyAcccountErrorMessage => WaitAndFindElement(By.XPath("//*[@ng-show=\"validationModel.verifyAccount == 'empty'\"]"));
        public IWebElement invalidVerifyAcccountErrorMessage => WaitAndFindElement(By.XPath("//*[@ng-show=//\"validationModel.verifyAccount == 'invalid'\"]"));
        public IWebElement emptyAmountErrorMessage => WaitAndFindElement(By.XPath("//*[@ng-show=\"validationModel.amount == 'empty'\"]"));
        public IWebElement invalidAmountErrorMessage => WaitAndFindElement(By.XPath("//*[@ng-show=\"validationModel.amount == invalid'\"]"));
    }
}
