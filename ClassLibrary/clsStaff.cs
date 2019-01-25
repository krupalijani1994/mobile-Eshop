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
            if (TestData != "")
            {
                //return a blank string
                return "";
            }

            else
            {
                // return an error message
                return "the Staff may not be blank";

            }
        }
    }
}