using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Testclass
{
    [TestClass]
    public class tstProductCollection
    {
        [TestMethod]
        public void InstanceOk()
        {

            clsProductCollection AllProducts = new clsProductCollection();
            Assert.IsNotNull(AllProducts);

        }

        [TestMethod]
        public void CountPropertyOk()
        {

            clsProductCollection AllProducts = new clsProductCollection();
            Int32 Test = 3;
            AllProducts.Count = Test;
            Assert.AreEqual(AllProducts.Count, Test);
        }

        [TestMethod]
        public void AllProductsOk()
        {

            clsProductCollection Products = new clsProductCollection();
            List<clsProduct> TestList = new List<clsProduct>();
            clsProduct TestItem = new clsProduct();
            TestItem.ProductID = 1;
            TestItem.ProductName = "iphone7";
            TestList.Add(TestItem);
            Products.AllProducts = TestList;
            Assert.AreEqual(Products.AllProducts, TestList);

        }


        [TestMethod]
        public void CountMatchesList()
        {

            clsProductCollection Products = new clsProductCollection();
            List<clsProduct> TestList = new List<clsProduct>();
            clsProduct TestItem = new clsProduct();
            TestItem.ProductID = 1;
            TestItem.ProductName = "iphone7";
            TestList.Add(TestItem);
            Products.AllProducts = TestList;
            Assert.AreEqual(Products.Count, TestList.Count);

        }


        


        //[TestMethod]Redundant test 
        //public void TwoProductsPresent()
        //{

        //    clsProductCollection Products = new clsProductCollection();
           
        //    Assert.AreEqual(Products.Count,2);

        //}







    }















}
