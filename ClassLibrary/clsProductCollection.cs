using System;
using System.Collections.Generic;
using ClassLibrary;

namespace ClassLibrary
{
    public class clsProductCollection
    {



        //private data member for list
        List<clsProduct> mProductList = new List<clsProduct>();
        //private data member thisproduct
        clsProduct mThisProduct = new clsProduct();



        public List<clsProduct> ProductList
        {
            get
            {
                //return private data
                return mProductList;

            }

            set
            {
                //set private data
                mProductList = value;
            }


        }




        private List<clsProduct> mAllProducts = new List<clsProduct>();
        public clsProductCollection()
        {


            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblProduct_SelectAll");
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
            mProductList = new List<clsProduct>();
            //while there are records to process
            while (Index < RecordCount)
            {
                clsProduct AProduct = new clsProduct();


                //read in the fields from the current record
                AProduct.ProductActive = Convert.ToBoolean(DB.DataTable.Rows[Index]["ProductActive"]);
                AProduct.ProductID = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductID"]);
                AProduct.ProductName = Convert.ToString(DB.DataTable.Rows[Index]["ProductName"]);
                AProduct.ProductPrice = Convert.ToDecimal(DB.DataTable.Rows[Index]["ProductPrice"]);
                AProduct.ProductQuantity = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductQuantity"]);
                mProductList.Add(AProduct);
                Index++;

            }
        }



        public int Count
        {

            get
            {
                return mProductList.Count;

            }
            set
            {

                //

            }

        }
        public List<clsProduct> AllProducts

        {
            get

            {
                return mAllProducts;

            }

            set
            {

                mAllProducts = value;

            }
        }


        public clsProduct ThisProduct
        {


            get
            {

                return mThisProduct;
            }

            set
            {
                mThisProduct = value;


            }
        }












        public int Add()
        {
            //adds a new record to the database on the valued of this product
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameter for the stored procedure
            DB.AddParameter("@ProductActive", mThisProduct.ProductActive);
            DB.AddParameter("@ProductName", mThisProduct.ProductName);
            DB.AddParameter("@ProductPrice", mThisProduct.ProductPrice);
            DB.AddParameter("@ProductQuantity", mThisProduct.ProductQuantity);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblProduct_Insert");

        }

        public void Delete()
        {
            //deletes the record pointed to by thisAddress
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@ProductID", mThisProduct.ProductID);
            //execute the stored procedure
            DB.Execute("sproc_tbl_Product_Delete");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductActive", mThisProduct.ProductActive);
            DB.AddParameter("@ProductID", mThisProduct.ProductID);
            DB.AddParameter("@ProductName", mThisProduct.ProductName);
            DB.AddParameter("@ProductPrice", mThisProduct.ProductPrice);
            DB.AddParameter("@ProductQuantity", mThisProduct.ProductQuantity);
            DB.Execute("sproc_tblProduct_Update");
        }

        public void FilterByProductName(string ProductName)
        {
            //filter the record based on the full or partial  name
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductName", ProductName);
            DB.Execute("sproc_tblProduct_FilterByProductName");
            PopulateArray(DB);
        }
    }
}

