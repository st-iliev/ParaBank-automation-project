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
        public IWebElement payeeNameField => driver.FindElement(By.XPath("//input[contains(@ng-model,'payee.name')]"));

        public IWebElement addressField => driver.FindElement(By.XPath("//input[contains(@ng-model,'payee.address.street')]"));
        public IWebElement cityField => driver.FindElement(By.XPath("//input[contains(@ng-model,'payee.address.city')]"));
        public IWebElement stateField => driver.FindElement(By.XPath("//input[contains(@ng-model,'payee.address.state')]"));
        public IWebElement zipCodeField => driver.FindElement(By.XPath("//input[contains(@ng-model,'payee.address.zipCode')]"));
        public IWebElement phoneField => driver.FindElement(By.XPath("//input[contains(@ng-model,'payee.phoneNumber')]"));
        public IWebElement accountField => driver.FindElement(By.XPath("//input[contains(@ng-model,'payee.accountNumber')]"));
        public IWebElement verifyAccountField => driver.FindElement(By.XPath("//input[contains(@ng-model,'verifyAccount')]"));
        public IWebElement amountField => driver.FindElement(By.XPath("//input[contains(@ng-model,'amount')]"));
        public IWebElement fromAccountField => driver.FindElement(By.XPath("//input[contains(@ng-model,'accountId')]"));
        public IWebElement sendPaymentButton => driver.FindElement(By.XPath("//*[@value='Send Payment']"));
        public IWebElement payneeNameErrorMessage => driver.FindElement(By.XPath("//*[@ng-show='!validationModel.name']"));
        public IWebElement addressErrorMessage => driver.FindElement(By.XPath("//*[@ng-show='!validationModel.address']"));
        public IWebElement cityErrorMessage => driver.FindElement(By.XPath("//*[@ng-show='!validationModel.city']"));
        public IWebElement stateErrorMessage => driver.FindElement(By.XPath("//*[@ng-show='!validationModel.state']"));
        public IWebElement zipCodeErrorMessage => driver.FindElement(By.XPath("//*[@ng-show='!validationModel.zipCode']"));
        public IWebElement phoneErrorMessage => driver.FindElement(By.XPath("//*[@ng-show='!validationModel.phoneNumber']"));
        public IWebElement emptyAcccountErrorMessage => driver.FindElement(By.XPath("//*[@ng-show=\"validationModel.account == 'empty'\"]"));
        public IWebElement invalidAcccountErrorMessage => driver.FindElement(By.XPath("//*[@ng-show=\"validationModel.account == 'invalid'\"]"));
        public IWebElement emptyVerifyAcccountErrorMessage => driver.FindElement(By.XPath("//*[@ng-show=\"validationModel.verifyAccount == 'empty'\"]"));
        public IWebElement invalidVerifyAcccountErrorMessage => driver.FindElement(By.XPath("//*[@ng-show=//\"validationModel.verifyAccount == 'invalid'\"]"));
        public IWebElement emptyAmountErrorMessage => driver.FindElement(By.XPath("//*[@ng-show=\"validationModel.amount == 'empty'\"]"));
        public IWebElement invalidAmountErrorMessage => driver.FindElement(By.XPath("//*[@ng-show=\"validationModel.amount == invalid'\"]"));
    }
}
