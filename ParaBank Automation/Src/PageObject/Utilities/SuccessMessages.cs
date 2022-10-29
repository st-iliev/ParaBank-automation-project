

namespace ParaBank_Automation.Utilities
{
    public static class SuccessMessages
    {
        public const string creatAccountTitle = "Welcome " + Constants.username;
        public const string creatAccountText = "Your account was created successfully. You are now logged in.";
        public const string welcome = "Welcome " + Constants.firstName + " " + Constants.lastName;
        public const string accountOpened = "Account Opened!";
        public const string newAccount = "Congratulations, your account is now open.";
        public const string transferComplete = "${0} has been transferred from account #{1} to account #{2}.";
        public const string billPaymentSuccessful = "Bill Payment to {0} in the amount of ${1} from account {2} was successful.";
    }
}
