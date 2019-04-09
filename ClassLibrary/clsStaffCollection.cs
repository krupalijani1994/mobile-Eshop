using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        clsStaff mThisStaff = new clsStaff();
        List<clsStaff> mStaffList = new List<clsStaff>();
        private List<clsStaff> mAllStaff = new List<clsStaff>();
        public clsStaffCollection()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblStaff_SelectAll");
            PopulateArray(DB);
        }




        void PopulateArray(clsDataConnection DB)
        {

            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mStaffList = new List<clsStaff>();
            //while there are records to process
            while (Index < RecordCount)
            {
                clsStaff Astaff = new clsStaff();


                //read in the fields from the current record
                Astaff.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                Astaff.StaffFirstName = Convert.ToString(DB.DataTable.Rows[Index]["StaffFirstName"]);
                Astaff.StaffLastName = Convert.ToString(DB.DataTable.Rows[Index]["StaffLastName"]);
                Astaff.StaffGender = Convert.ToString(DB.DataTable.Rows[Index]["StaffGender"]);
                Astaff.StaffPhoneNo = Convert.ToString(DB.DataTable.Rows[Index]["StaffPhoneNo"]);
                Astaff.StaffAddress = Convert.ToString(DB.DataTable.Rows[Index]["StaffAddress"]);
                Astaff.StaffEmail = Convert.ToString(DB.DataTable.Rows[Index]["StaffEmail"]);
                Astaff.DOB = Convert.ToDateTime(DB.DataTable.Rows[Index]["DOB"]);
                mStaffList.Add(Astaff);
                Index++;

            }
        }



        
        public int Count
        {
            get
            {
                return mStaffList.Count;

            }
            set
            {

                //

            }
        }

        public List<clsStaff> AllStaff
        {
            get

            {
                return mAllStaff;

            }

            set
            {

                mAllStaff = value;

            }
        }

        public List<clsStaff> StaffList {

            get
            {
                return mStaffList;
            }

            set
            {

                mStaffList = value;
            }


        }


        public clsStaff ThisStaff {

            get
            {

                return mThisStaff;

            }
            set
            {

                mThisStaff = value;

            }


        }







        public int Add()
        {
            //adds a new record to the database on the valued of this product
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameter for the stored procedure
            DB.AddParameter("@StaffFirstName", mThisStaff.StaffFirstName);
            DB.AddParameter("@StaffLastName", mThisStaff.StaffLastName);
            DB.AddParameter("@StaffGender", mThisStaff.StaffGender);
            DB.AddParameter("@StaffPhoneNo", mThisStaff.StaffPhoneNo);
            DB.AddParameter("@StaffAddress", mThisStaff.StaffAddress);
            DB.AddParameter("@StaffEmail", mThisStaff.StaffEmail);
            DB.AddParameter("@DOB", mThisStaff.DOB);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblStaff_Insert");

        }

        public void Delete()
        {
            //deletes the record pointed to by thisAddress
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            //execute the stored procedure
            DB.Execute("Sproc_tblStaff_Delete");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            DB.AddParameter("@StaffFirstName", mThisStaff.StaffFirstName);
            DB.AddParameter("@StaffLastName", mThisStaff.StaffLastName);
            DB.AddParameter("@StaffGender", mThisStaff.StaffGender);
            DB.AddParameter("@StaffPhoneNo", mThisStaff.StaffPhoneNo);
            DB.AddParameter("@StaffAddress", mThisStaff.StaffAddress);
            DB.AddParameter("@StaffEmail", mThisStaff.StaffEmail);
            DB.AddParameter("@DOB", mThisStaff.DOB);
            DB.Execute("sproc_tblStaff_Update");
        }

        public void FilterByStaffName(string StaffFirstName)
        {
            //filter the record based on the full or partial  name
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffFirstName", StaffFirstName);
            DB.Execute("sproc_tblStaff_FilterByStaffFirstName");
            PopulateArray(DB);
        }
    }


















      






    }
  
