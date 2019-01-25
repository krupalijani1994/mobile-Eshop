using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public clsCustomer()
        {
        }

        public bool Active { get; set; }
        public int CustomerID { get; set; }
        public DateTime DOB { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string Gender { get; set; }
        public string HomeAddress { get; set; }
        public string LastName { get; set; }
        public string PhoneNo { get; set; }
    }
}