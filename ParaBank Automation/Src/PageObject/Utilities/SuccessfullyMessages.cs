

namespace ParaBank_Automation.Utilities
{
    public class SuccessfullyMessages
    {
        public const string creatAccountTitle = "Welcome " + Constants.username;
        public const string creatAccountText = "Your account was created successfully. You are now logged in.";
        public const string welcome = "Welcome " + Constants.firstName + " " + Constants.lastName;
        public const string accountOpened = "Account Opened!";
        public const string newAccount = "Congratulations, your account is now open.";
        public const string transferComplete = "${0} has been transferred from account #{1} to account #{2}.";
    }
}
