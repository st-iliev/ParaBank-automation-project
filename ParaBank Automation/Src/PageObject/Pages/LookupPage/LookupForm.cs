using ParaBank_Automation.Utilities;

namespace ParaBank_Automation.Src.PageObject.Pages
{
    public class LookupForm
    {
        public LookupForm()
        {
            FirstName = Constants.firstName;
            LastName = Constants.lastName;
            Address = Constants.address;
            City = Constants.city;
            State = Constants.state;
            ZipCode = Constants.zipCode;
            SSN = Constants.SSN;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string SSN { get; set; }
        
    }
}
