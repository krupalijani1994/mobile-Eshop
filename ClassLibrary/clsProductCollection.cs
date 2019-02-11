using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsProductCollection
    {
        private List<clsProduct> mAllProducts = new List<clsProduct>();
        public clsProductCollection()
        {

            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblProduct_SelectAll");
            Int32 RecordCount = DB.Count;
            Int32 Index = 0;
            while (Index < RecordCount)
            {
                clsProduct Aproduct = new clsProduct();
                Aproduct.ProductName = DB.DataTable.Rows[Index]["ProductName"].ToString();
                Aproduct.ProductID = Convert.ToInt32(DB.DataTable.Rows[Index]["productID"]);
                mAllProducts.Add(Aproduct);
                Index++;
            }
        }
            //clsProduct Aproduct = new clsProduct();
            //Aproduct.ProductName = "iphone7";
            //mAllProducts.Add(Aproduct);
            //Aproduct = new clsProduct();
            //Aproduct.ProductName = "iphone8";
            //mAllProducts.Add(Aproduct);
        

        public int Count
        {

            get
            {
                return mAllProducts.Count;

            }
            set
            {

                //

            }

        }
        public List<clsProduct> AllProducts
            
        { get

            {
                return mAllProducts;

            }
                
          set
            {

                mAllProducts = value;

            }
        }
    }
}