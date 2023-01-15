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
        public IWebElement loanAmount => WaitAndFindElements(By.XPath("//input[@id='amount']"));
        public IWebElement downPayment => WaitAndFindElements(By.XPath("//input[@id='downPayment']"));
        public IWebElement fromAccount => WaitAndFindElements(By.XPath("//select[@id='fromAccountId']"));
        public IWebElement applyNowButton => WaitAndFindElements(By.XPath("//input[@value='Apply Now']"));
        public IWebElement loanProvider => WaitAndFindElements(By.XPath("//td[@id='loanProviderName']"));
        public IWebElement date => WaitAndFindElements(By.XPath("//td[@id='responseDate']"));
        public IWebElement status => WaitAndFindElements(By.XPath("//td[@id='loanStatus']"));
        public IWebElement congratsText => WaitAndFindElements(By.XPath("//div[@ng-if='loanResponse.approved']/p[1]"));
        public IWebElement newAccountId => WaitAndFindElements(By.XPath("//a[@id='newAccountId']"));
        public IWebElement downPaymentAmountErrorMessage => WaitAndFindElements(By.XPath("//p[@ng-if=\"loanResponse.message === 'error.insufficient.funds.and.down.payment'\"]"));
    }
}
