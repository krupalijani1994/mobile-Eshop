using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        public string StaffID { get; set; }
        public string StaffAddress { get; set; }
        public string StaffEmail { get; set; }
        public string StaffFirstName { get; set; }
        public string StaffLastName { get; set; }
        public string StaffGender { get; set; }
        public int StaffPhoneNo { get; set; }
        public DateTime DOB { get; set; }
        public bool Active { get; set; }

        public string Valid(string TestData)
        {
            string Error = "";
            if (TestData.Length > 100)
            {
                Error = "Name of the product cannot be more than 100 characters";
            }

            if (TestData.Length == 0)
            {
                Error = "The Product name cannot be blank";
            }
            return Error;
        }
        }
    }
