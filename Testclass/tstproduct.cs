using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testclass
{
    [TestClass]
    public class tstproduct
    {
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
            string TestData = "1";
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
            string TestData = "Iphone7";
            Error = AProduct.Valid(TestData);
            Assert.AreEqual(Error, "");

        }


        























}
}
