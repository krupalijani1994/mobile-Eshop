using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class clsProduct
    {
        private Int32 mProductID;
        private string mProductName;
        private decimal mProductPrice;
        private int mProductQuantity;
        private Boolean mProductActive;
    
        public Int32 ProductID {

            get
            {
                return mProductID;

            }
            set
            {
                mProductID = value;

            }
        }
        public string ProductName {
            get
            {
                return mProductName;
            }

            set {

                mProductName = value;

            }
        }
        public decimal ProductPrice {

            get
            {
                return mProductPrice;
            }

            set
            {
                mProductPrice = value;
            }

        }
        public int ProductQuantity {

            get
            {

                return mProductQuantity;

            }
            set
            {

                mProductQuantity = value;
            }

        }
        public bool ProductActive
        {
            get
            {
                return mProductActive;

            }
            set
            {
                mProductActive = value;
            }


        }

       

        public bool Find(int ProductID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductID", ProductID);
            DB.Execute("sproc_tblProduct_FilterByProductID");
            if(DB.Count == 1)
            {

                mProductID = Convert.ToInt32(DB.DataTable.Rows[0]["ProductID"]);
                mProductActive = Convert.ToBoolean(DB.DataTable.Rows[0]["ProductActive"]);
                mProductName = Convert.ToString(DB.DataTable.Rows[0]["ProductName"]);
                mProductPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["ProductPrice"]); 
                mProductQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["ProductQuantity"]);
               
                return true;

            }
            else
            {
                return false;
            }

           
        }

        public string Valid(string ProductName,string ProductPrice, string ProductQuantity)
        {
            string Error = "";
            if (ProductName.Length == 0)
            {

                Error = Error + "cannot be blank";
            }

            if(ProductName.Length>50)
            {

                Error = Error + "Must be less than 50 characters";
            }
           

            try
            {
                decimal TempProductPrice;
                TempProductPrice = Convert.ToDecimal(ProductPrice);
                if (TempProductPrice < 0)
                {
                    Error = Error + "price is less than zero";
                }
                if (TempProductPrice > 1000000)
                {
                    Error = Error + "price is too high";
                }
            }
            catch
            {
                Error = Error + "price is not a valid number";
            }

            //if (ProductQuantity.Length == 0)
            //{
            //    Error = Error + "cannot be blank";
            //}


            //if (ProductQuantity.Length> 999)
            //{
            //    Error = Error + "cannot be more than 999";
            //}

           
            try
            {
                Int32 TempProductQuantity;
                TempProductQuantity = Convert.ToInt32(ProductQuantity);
                if (TempProductQuantity < 0)
                {
                    Error = Error + "price is less than zero";
                }
                if (TempProductQuantity > 1000000)
                {
                    Error = Error + "price is too high";
                }
            }
            catch
            {
                Error = Error + "price is not a valid number";
            }

            return Error;


        }
    }
        

}