using Constants = ParaBank_Automation.Utilities.Constants;

namespace ParaBank_Automation.Src.PageObject.Pages.Account_Services.BillPayPage
{
    public class BillPaymentForm
    {
        public BillPaymentForm()
        {
            PayeeName = Constants.username;
            Address = Constants.address;
            City = Constants.city;
            State = Constants.state;
            ZipCode = Constants.zipCode;
            PhoneNumber = Constants.phone;
        }
        public string PayeeName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Account { get; set; }
        public string VerifyAccount { get; set; }
        public string Amount { get; set; }
        public string FromAccount { get; set; }


    }
}
