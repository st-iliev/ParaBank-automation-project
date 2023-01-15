using ParaBank_Automation.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaBank_Automation.Src
{
    public class ProfileForm
    {
        public ProfileForm()
        {
            FirstName = Constants.firstName;
            LastName = Constants.lastName;
            Address = Constants.address;
            City = Constants.city;
            State = Constants.state;
            ZipCode = Constants.zipCode;
            PhoneNumber = Constants.phone;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string PhoneNumber { get; set; }
       
    }
}
