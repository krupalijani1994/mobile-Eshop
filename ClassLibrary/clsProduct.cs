using System;

namespace ClassLibrary
{
    public class clsProduct
    {
        public Int32 ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductQuantity { get; set; }

        public string Valid(string ProductName)
        {
            string Error = "";
            if (ProductName.Length> 50)
            {
                Error = "Name of the product cannot be more than 50 characters";
            }

            if(ProductName.Length==0)
            {
                Error = "The Product name cannot be blank";
            }
                 
            //if(ProductPrice == 0)
            //{

            //    Error = "sss";
            //}

            //if (ProductPrice > 10)
            //{
            //    Error = "The xxxx";
            //}
            return Error;
        }

       
    }
        

}