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
        public void AssertTransferIsCompleted(int amount, int fromAccountId, int toAccountId)
        {
            Assert.AreEqual(string.Format(SuccessMessages.transferComplete,amount.ToString(),fromAccountId.ToString(),toAccountId.ToString()), GetPageText());
        }
    }
}
