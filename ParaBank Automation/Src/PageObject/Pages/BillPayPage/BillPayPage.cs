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
            IList<IWebElement> List1 = driver.FindElements(By.TagName("input"));
            for (int i = 0; i < List1.Count-1; i++)
            {
                List1[i].Clear();
            }
        }
      
    }
}
