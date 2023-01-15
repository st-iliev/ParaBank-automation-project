using NUnit.Framework;
using ParaBank_Automation.Utilities;

namespace ParaBank_Automation.Src
{
    public partial class FindTransactionsPage
    {
        public void AssertTransactionFound()
        {
            Assert.IsTrue(transactionFound.Displayed);
        }
        public void AssertTransactionDateIsDisplayed()
        {
            Assert.Greater(transactionDates.Count,0);
        }
        public void AssertTransactionTypeIsDisplayed()
        {
            Assert.Greater(transactionTypes.Count,0);
        }      
        public void AssertCorrectErrorMessageIsDisplayed()
        {
            Assert.That(GetPageText(), Is.EqualTo(ErrorMessages.internalError));
        }
        public void AssertTransactionDateIsNotDisplayed()
        {
            Assert.That(transactionDates.Count, Is.EqualTo(0));
        }
        public void AssertTransactionTypeIsNotDisplayed()
        {
            Assert.That(transactionTypes.Count, Is.EqualTo(0));
        }
    }
}
