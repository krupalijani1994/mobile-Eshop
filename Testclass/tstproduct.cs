using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testclass
{
    [TestClass]
    public class tstproduct
    {

        // performing property test
        [TestMethod]
        public void InstanceOk()
        {
            //creates an instance of a class
            clsProduct Aproduct = new clsProduct();
            Assert.IsNotNull(Aproduct);

        }

        [TestMethod]
        public void ProductIDPropertyOk()
        {
            //creates an instance of a class
            clsProduct Aproduct = new clsProduct();
            Int32 TestData = 1;
            Aproduct.ProductID = TestData;
            Assert.AreEqual(Aproduct.ProductID, TestData);

        }


        [TestMethod]
        public void ProductNamePropertyOk()
        {
            //creates an instance of a class
            clsProduct Aproduct = new clsProduct();
            string TestData = "iphone7";
            Aproduct.ProductName = TestData;
            Assert.AreEqual(Aproduct.ProductName, TestData);

        }


        [TestMethod]
        public void ProductPricePropertyOk()
        {
            //creates an instance of a class
            clsProduct Aproduct = new clsProduct();
            decimal TestData = (decimal) 200.99;
            Aproduct.ProductPrice = TestData;
            Assert.AreEqual(Aproduct.ProductPrice, TestData);

        }

        [TestMethod]
        public void ProductQuantityPropertyOk()
        {
            //creates an instance of a class
            clsProduct Aproduct = new clsProduct();
            Int32 TestData = 1;
            Aproduct.ProductQuantity = TestData;
            Assert.AreEqual(Aproduct.ProductQuantity, TestData);

        }



        [TestMethod]
        public void ValidMethodOk()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string ProductName = "Iphone7";
            //decimal ProductPrice = (decimal)10.00;
            Error = AProduct.Valid(ProductName);
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
            //decimal ProductPrice = (decimal)10.00;
            Error = AProduct.Valid(ProductName);
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
            Error = AProduct.Valid(ProductName);
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void ProductNameMinPlusOne()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string ProductName = "Ab";
            Error = AProduct.Valid(ProductName);
            Assert.AreEqual(Error, "");

        }



        [TestMethod]
        public void ProductNameMaxMinusOne()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string ProductName = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVW";
            Error = AProduct.Valid(ProductName);
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void ProductNameMax()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string ProductName = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWX";
            Error = AProduct.Valid(ProductName);
            Assert.AreEqual(Error, "");

        }



        [TestMethod]
        public void ProductNameMaxPlusOne()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string ProductName = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXY";
            Error = AProduct.Valid(ProductName);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void ProductNameMid()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string ProductName = "ABCDEFGHIJKLMNOPQRSTUVWXY";
            Error = AProduct.Valid(ProductName);
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
            Error = AProduct.Valid(ProductName);
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
            Error = AProduct.Valid(ProductPrice);
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void ProductPriceMin()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string ProductPrice = "1.01";
            Error = AProduct.Valid(ProductPrice);
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void ProductPriceMinPlusOne()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string ProductPrice = "12.1";
            Error = AProduct.Valid(ProductPrice);
            Assert.AreEqual(Error, "");

        }



        [TestMethod]
        public void ProductPriceMaxMinusOne()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string ProductPrice = "012345678.01";
            Error = AProduct.Valid(ProductPrice);
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void ProductPriceMax()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string ProductPrice = "01234567890.00";
            Error = AProduct.Valid(ProductPrice);
            Assert.AreEqual(Error, "");

        }



        //[TestMethod]
        //public void productpricemaxplusone()
        //{
        //    //creates an instance of a class
        //    clsProduct AProduct = new clsProduct();
        //    string error = "";
        //    string ProductPrice = "01234567890.00";
        //    error = AProduct.Valid(ProductPrice);
        //    Assert.AreNotEqual(error, "");

        //}

        [TestMethod]
        public void ProductPriceMid()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string ProductPrice = "01234.00";
            Error = AProduct.Valid(ProductPrice);
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
            Error = AProduct.Valid(ProductQuantity);
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void ProductQuantityMin()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string ProductQuantity = "1";
            Error = AProduct.Valid(ProductQuantity);
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void ProductQuantityMinPlusOne()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string ProductQuantity = "12";
            Error = AProduct.Valid(ProductQuantity);
            Assert.AreEqual(Error, "");

        }



        [TestMethod]
        public void ProductQuantityMaxMinusOne()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string ProductQuantity = "999";
            Error = AProduct.Valid(ProductQuantity);
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void ProductQuantityMax()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string ProductQuantity = "9999";
            Error = AProduct.Valid(ProductQuantity);
            Assert.AreEqual(Error, "");

        }



        //[TestMethod]
        //public void ProductQuantityMaxPlusOne()
        //{
        //    //creates an instance of a class
        //    clsProduct AProduct = new clsProduct();
        //    string Error = "";
        //    string ProductQuantity = "10000";
        //    Error = AProduct.Valid(ProductQuantity);
        //    Assert.AreNotEqual(Error, "");

        //}

        [TestMethod]
        public void ProductQuantityMid()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string ProductQuantity = "99";
            Error = AProduct.Valid(ProductQuantity);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ProductQuantityExtremeMax()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string ProductQuantity = "";
            ProductQuantity = ProductQuantity.PadRight(100, '1');
            Error = AProduct.Valid(ProductQuantity);
            Assert.AreNotEqual(Error, "");

        }

































    }
}
