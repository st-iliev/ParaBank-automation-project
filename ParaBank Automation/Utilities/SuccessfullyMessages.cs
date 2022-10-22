using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaBank_Automation.Utilities
{
    public  class SuccessfullyMessages
    {
        public const string creatAccountTitle = "Welcome " + Constants.username; 
        public const string creatAccountText = "Your account was created successfully. You are now logged in."; 
        public const string welcome = "Welcome "+ Constants.firstName + " " +Constants.lastName;
        public const string accountOpened = "Account Opened!";
        public const string congratsAccountIsOpened = "Congratulations, your account is now open.";
    }
}
