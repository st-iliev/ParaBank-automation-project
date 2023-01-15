using NUnit.Core.Extensibility;
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
        public void AssertEmptyAmountErrorIsDisplayed()
        {
            Assert.AreEqual(ErrorMessages.emptyAmount, emptyAmountError.Text);
        }
        public void AssertInvalidAmountErrorIsDisplayed()
        {
            Assert.AreEqual(ErrorMessages.invalidAmount, invalidAmountError.Text);
        }

        public void AssertTransferIsCompleted(double amount, string fromAccountId, string toAccountId)
        {
            Assert.AreEqual(string.Format(SuccessMessages.transferComplete,amount,fromAccountId,toAccountId), GetPageText());
        }
    }
}
