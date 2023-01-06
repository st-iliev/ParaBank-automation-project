using Constants = ParaBank_Automation.Utilities.Constants;

namespace ParaBank_Automation.Src.PageObject.Pages.RegisterPage
{
    public class RegistrationForm
    {
        public RegistrationForm()
        {
            FirstName = Constants.firstName;
            LastName = Constants.lastName;
            Address = Constants.address;
            City = Constants.city;
            State = Constants.state;
            ZipCode = Constants.zipCode;
            PhoneNumber = Constants.phone;
            SSN = Constants.SSN;
            Username = Constants.username;
            Password = Constants.password;
            ConfirmPassword = Constants.confirmPassword;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string PhoneNumber { get; set; }
        public string SSN { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
       
    }
}
