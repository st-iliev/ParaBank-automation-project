using NUnit.Framework;
using ParaBank_Automation.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaBank_Automation.Src
{
    public partial class TransferPage
    {
        public void AssertAmountErrorIsDisplayed()
        {
            Assert.AreEqual(ErrorMessages.amount, amountErrorMessage.Text);
        }
        public void AssertTransferIsCompleted()
        {
            Assert.AreEqual(SuccessfullyMessages.transferComplete, GetPageText());
        }
    }
}
