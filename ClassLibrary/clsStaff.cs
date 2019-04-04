using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        private Int32 mStaffID;
        private string mStaffFirstName;
        private string mStaffLastName;
        private string mStaffGender;
        private int mStaffPhoneNo;
        private string mStaffAddress;
        private string mStaffEmail;
        private DateTime mDOB;
        private Boolean mActive;



        public Int32 StaffID {
            get
            {
                return mStaffID;

            }
            set
            {
                mStaffID = value;
            }

        }
        public string StaffAddress {

            get
            {
                return mStaffAddress;
            }
            set
            {
                mStaffAddress = value;
            }


        }
        public string StaffEmail {

            get
            {
                return mStaffEmail;
            }
            set
            {
                mStaffEmail = value;

            }


        }
        public string StaffFirstName {

            get
            {
                return mStaffFirstName;
            }
            set
            {
                mStaffFirstName = value;
            }

        }
        public string StaffLastName {
            get
            {
                return mStaffLastName;
            }
            set
            {
                mStaffLastName = value;
            }
        }
        public string StaffGender {

            get
            {
                return mStaffGender;

            }

            set
            {
                mStaffGender = value;
            }
        }
        public int StaffPhoneNo {

            get
            {
                return mStaffPhoneNo;
            }
            set
            {
                mStaffPhoneNo = value;
            }


        }
        public DateTime DOB {

            get
            {
                return mDOB;
            }
            set
            {
                mDOB = value;
            }

        }
        public bool Active {

            get
            {
                return mActive;
            }
            set
            {
                mActive = value;
            }
        }

        

        public string Valid(string StaffFirstName, string StaffLastName, string StaffGender, string StaffPhoneNo, string StaffAddress, string StaffEmail, string DOB)
        {
            string Error = "";
            if (StaffFirstName.Length == 0)
            {

                Error = Error + "Name cannot be blank";
            }

            if (StaffFirstName.Length > 20)
            {

                Error = Error + "name cannot be this long";
            }

            if (StaffLastName.Length == 0)
            {

                Error = Error + " Name cannot be blank";
            }

            if (StaffLastName.Length > 20)
            {

                Error = Error + "Name cannot be this long";
            }
            if (StaffGender.Length == 0)
            {

                Error = Error + "Gender cannot be blank";
            }

            if (StaffGender.Length > 6)
            {

                Error = Error + "Gender cannot be this long";
            }

            if (StaffAddress.Length == 0)
            {

                Error = Error + "Address cannot be blank";
            }

            if (StaffAddress.Length > 100)
            {

                Error = Error + "Address cannot be this long";
            }

            if (StaffEmail.Length == 0)
            {

                Error = Error + "Email email cannot be blank";
            }

            if (StaffEmail.Length > 50)
            {

                Error = Error + "Email cannot be this long";
            }


           

            return Error;
        }

        public bool Find(int StaffID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffID", StaffID);
            DB.Execute("sproc_tblStaff_FilterByStaffID");
            if (DB.Count == 1)
            {

                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                mStaffFirstName = Convert.ToString(DB.DataTable.Rows[0]["StaffFirstName"]);
                mStaffLastName = Convert.ToString(DB.DataTable.Rows[0]["StaffLastName"]);
                mStaffGender = Convert.ToString(DB.DataTable.Rows[0]["StaffGender"]);
                mStaffPhoneNo = Convert.ToInt32(DB.DataTable.Rows[0]["StaffPhoneNo"]);
                mStaffAddress = Convert.ToString(DB.DataTable.Rows[0]["StaffAddress"]);
                mStaffEmail = Convert.ToString(DB.DataTable.Rows[0]["StaffEmail"]);
                mDOB = Convert.ToDateTime(DB.DataTable.Rows[0]["DOB"]);

                return true;

            }
            else
            {
                return false;
            }


        }
    }
    }
