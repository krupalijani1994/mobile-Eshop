using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        private List<clsStaff> mAllStaff = new List<clsStaff>();
        public clsStaffCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStaff_SelectAll");
            Int32 RecordCount = DB.Count;
            Int32 Index = 0;
            while (Index < RecordCount)
            {
                clsStaff AStaff = new clsStaff();
                AStaff.StaffFirstName = DB.DataTable.Rows[Index]["StaffFirstName"].ToString();
                AStaff.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                mAllStaff.Add(AStaff);
                Index++;
            }
        }

        public int Count
        {
            get
            {
                return mAllStaff.Count;

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


    }
}

