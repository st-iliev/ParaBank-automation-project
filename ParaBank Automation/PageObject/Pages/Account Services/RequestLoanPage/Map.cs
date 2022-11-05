using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaBank_Automation.Src.PageObject.Pages.Account_Services.RequestLoanPage
{
    public partial class RequestLoanPage
    {
        public IWebElement loanAmount => WaitAndFindElement(By.XPath("//input[@id='amount']"));
        public IWebElement downPayment => WaitAndFindElement(By.XPath("//input[@id='downPayment']"));
        public IWebElement fromAccount => WaitAndFindElement(By.XPath("//select[@id='fromAccountId']"));
        public IWebElement applyNowButton => WaitAndFindElement(By.XPath("//input[@value='Apply Now']"));
        public IWebElement loanProvider => WaitAndFindElement(By.XPath("//td[@id='loanProviderName']"));
        public IWebElement date => WaitAndFindElement(By.XPath("//td[@id='responseDate']"));
        public IWebElement status => WaitAndFindElement(By.XPath("//td[@id='loanStatus']"));
        public IWebElement congratsText => WaitAndFindElement(By.XPath("//div[@ng-if='loanResponse.approved']/p[1]"));
        public IWebElement newAccountId => WaitAndFindElement(By.XPath("//a[@id='newAccountId']"));
        public IWebElement downPaymentAmountErrorMessage => WaitAndFindElement(By.XPath("//p[@ng-if=\"loanResponse.message === 'error.insufficient.funds.and.down.payment'\"]"));
    }
}
