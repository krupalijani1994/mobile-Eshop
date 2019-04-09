using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testclass
{
   

    [TestClass]
    public class tstproduct
    {
        
        string ProductName="iphone4";
        string ProductPrice= "522.00";
        string ProductQuantity = "22";
        

        // performing property test
        [TestMethod]
        public void InstanceOk()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            Assert.IsNotNull(AProduct);

        }

        public void ActivePropertyok()
        {
            //creates an instance of a class
            clsProduct Aproduct = new clsProduct();
            Boolean TestData = true;
            Aproduct.ProductActive = TestData;
            Assert.AreEqual(Aproduct.ProductActive, TestData);

        }

        [TestMethod]
        public void FindmethodOk()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            Boolean Found = false;
            Int32 ProductID = 193;
            Found = AProduct.Find(ProductID);
            Assert.IsTrue(Found);

        }


        [TestMethod]
        public void ProductIDPropertyOk()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            Int32 TestData = 1;
            AProduct.ProductID = TestData;
            Assert.AreEqual(AProduct.ProductID, TestData);

        }


        [TestMethod]
        public void ProductNamePropertyOk()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            string TestData = "iphone7";
            AProduct.ProductName = TestData;
            Assert.AreEqual(AProduct.ProductName, TestData);

        }


        [TestMethod]
        public void ProductPricePropertyOk()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            decimal TestData = (decimal) 200.99;
            AProduct.ProductPrice = TestData;
            Assert.AreEqual(AProduct.ProductPrice, TestData);

        }

        [TestMethod]
        public void ProductQuantityPropertyOk()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            Int32 TestData = 1;
            AProduct.ProductQuantity = TestData;
            Assert.AreEqual(AProduct.ProductQuantity, TestData);

        }



        [TestMethod]
        public void ValidMethodOk()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            string Error = "";
            //string ProductName = "iphone7";
            //decimal ProductPrice = (decimal)10.00;
            Error = AProduct.Valid(ProductName, ProductPrice, ProductQuantity);
            Assert.AreEqual(Error, "");

        }


        //performing the test according to the test plan.

        //Product Name test

        [TestMethod]
        public void ProductNameMinMinusOne()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string ProductName = "";
           
            Error = AProduct.Valid(ProductName,ProductPrice,ProductQuantity);
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void ProductNameMin()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string ProductName = "Iphone7";
            //decimal ProductPrice = (decimal)10.00;
            Error = AProduct.Valid(ProductName, ProductPrice, ProductQuantity);
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void ProductNameMinPlusOne()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string ProductName = "Ab";
            Error = AProduct.Valid(ProductName, ProductPrice, ProductQuantity);
            Assert.AreEqual(Error, "");

        }



        [TestMethod]
        public void ProductNameMaxMinusOne()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string ProductName = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVW";
            Error = AProduct.Valid(ProductName,ProductPrice, ProductQuantity);
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void ProductNameMax()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string ProductName = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWX";
            Error = AProduct.Valid(ProductName, ProductPrice, ProductQuantity);
            Assert.AreEqual(Error, "");

        }



        [TestMethod]
        public void ProductNameMaxPlusOne()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string ProductName = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXY";
            Error = AProduct.Valid(ProductName, ProductPrice, ProductQuantity);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void ProductNameMid()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string ProductName = "ABCDEFGHIJKLMNOPQRSTUVWXY";
            Error = AProduct.Valid(ProductName,ProductPrice, ProductQuantity);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ProductNameExtremeMax()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string ProductName = "";
            ProductName = ProductName.PadRight(100, 'a');
            Error = AProduct.Valid(ProductName, ProductPrice, ProductQuantity);
            Assert.AreNotEqual(Error, "");

        }


        //Testing Product Price according to the test plan


        [TestMethod]
        public void ProductPriceMinMinusOne()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string ProductPrice = "";
            Error = AProduct.Valid(ProductName, ProductPrice, ProductQuantity);
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void ProductPriceMin()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string ProductPrice = "1.01";
            Error = AProduct.Valid(ProductName, ProductPrice, ProductQuantity);
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void ProductPriceMinPlusOne()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string ProductPrice = "12.1";
            Error = AProduct.Valid(ProductName, ProductPrice, ProductQuantity);
            Assert.AreEqual(Error, "");

        }



        [TestMethod]
        public void ProductPriceMaxMinusOne()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string ProductPrice = "999999.99";
            Error = AProduct.Valid(ProductName, ProductPrice, ProductQuantity);
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void ProductPriceMax()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string ProductPrice = "1000000";
            Error = AProduct.Valid(ProductName, ProductPrice, ProductQuantity);
            Assert.AreEqual(Error, "");

        }



        [TestMethod]
        public void productpricemaxplusone()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            string error = "";
            string ProductPrice = "1000000.01";
            error = AProduct.Valid(ProductName, ProductPrice, ProductQuantity);
            Assert.AreNotEqual(error, "");

        }

        [TestMethod]
        public void ProductPriceMid()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string ProductPrice = "01234.00";
            Error = AProduct.Valid(ProductName, ProductPrice, ProductQuantity);
            Assert.AreEqual(Error, "");

        }




        //product quantity



        [TestMethod]
        public void ProductQuantityMinMinusOne()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string ProductQuantity = "";
            Error = AProduct.Valid(ProductName, ProductPrice, ProductQuantity);
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void ProductQuantityMin()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string ProductQuantity = "1";
            Error = AProduct.Valid(ProductName, ProductPrice, ProductQuantity);
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void ProductQuantityMinPlusOne()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string ProductQuantity = "12";
            Error = AProduct.Valid(ProductName, ProductPrice, ProductQuantity);
            Assert.AreEqual(Error, "");

        }



        [TestMethod]
        public void ProductQuantityMaxMinusOne()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string ProductQuantity = "999";
            Error = AProduct.Valid(ProductName, ProductPrice, ProductQuantity);
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void ProductQuantityMax()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string ProductQuantity = "9999";
            Error = AProduct.Valid(ProductName, ProductPrice, ProductQuantity);
            Assert.AreEqual(Error, "");

        }



        [TestMethod]
        public void ProductQuantityMaxPlusOne()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string ProductQuantity = "1000001";
            Error = AProduct.Valid(ProductName, ProductPrice, ProductQuantity);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void ProductQuantityMid()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string ProductQuantity = "99";
            Error = AProduct.Valid(ProductName, ProductPrice, ProductQuantity);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ProductQuantityExtremeMax()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string ProductQuantity = "";
            ProductQuantity = ProductQuantity.PadRight(999, '1');
            Error = AProduct.Valid(ProductName, ProductPrice, ProductQuantity);
            Assert.AreNotEqual(Error, "");

        }




                //found

        [TestMethod]
        public void TestProductIDFound()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record the data is ok
            Boolean Ok = true;
            //create some data for testing with the method
            Int32 ProductID = 193;
            //invoke the method
            Found = AProduct.Find(ProductID);
            // check the product id

            if (AProduct.ProductID != 193)
            {

                Ok = false;
            }
            Assert.IsTrue(Ok);
        }


        [TestMethod]
        public void TestProductNameFound()
        {

            clsProduct AProduct = new clsProduct();

            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductID = 193;
            Found = AProduct.Find(ProductID);
            if (AProduct.ProductName != "iphone4")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestProductPriceFound()
        {

            clsProduct AProduct = new clsProduct();

            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductID = 193;
            Found = AProduct.Find(ProductID);
            if (AProduct.ProductPrice != (decimal)522.00)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestProductQuantityFound()
        {

            clsProduct AProduct = new clsProduct();

            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductID = 193;
            Found = AProduct.Find(ProductID);
            if (AProduct.ProductQuantity != 22)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }


        [TestMethod]
        public void TestActiveFound()
        {

            clsProduct AProduct = new clsProduct();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductID = 193;
            Found = AProduct.Find(ProductID);
            if (AProduct.ProductActive != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }











    }
}
