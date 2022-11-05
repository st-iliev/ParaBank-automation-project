using NUnit.Framework;
using OpenQA.Selenium;
using ParaBank_Automation.Utilities;

namespace ParaBank_Automation.Src
{
    public partial class OpenAccountPage
    {
       public void AssertNewAccountIsSuccessfullyOpened()
        {
            Assert.AreEqual(SuccessMessages.newAccount, GetPageText());
        }
    }
}
