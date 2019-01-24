using System;

namespace ClassLibrary
{
    public class clsProduct
    {
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductQuantity { get; set; }

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
                return "the Product name may not be blank";

            }
        }


        
    }
        

}