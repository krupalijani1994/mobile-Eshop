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
        public void ProductistOK()
        {
            // create instance of the class we want to create
            clsProductCollection AllProducts = new clsProductCollection();
            //create some test data to assign to the property
            //in this case data needs to be a list of objects
            List<clsProduct> TestList = new List<clsProduct>();
            //add an itrem to the list
            //create the item of the test data
            clsProduct TestItem = new clsProduct();
            // set its properties
            TestItem.ProductActive = true;
            TestItem.ProductID = 1;
            TestItem.ProductName = "iphone7";
            TestItem.ProductPrice = (decimal)10.10;
            TestItem.ProductQuantity = 10;
            // add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllProducts.ProductList = TestList;
            //test to see that 2 values are same
            Assert.AreEqual(AllProducts.ProductList, TestList);




        }

        [TestMethod]
        public void CountPropertyOk()
        {


            // create instance of the class we want to create
            clsProductCollection AllProducts = new clsProductCollection();
            //create some test data to assign to the property
            //in this case data needs to be a list of objects
            List<clsProduct> TestList = new List<clsProduct>();
            //add an itrem to the list
            //create the item of the test data
            clsProduct TestItem = new clsProduct();
            // set its properties
            TestItem.ProductActive = true;
            TestItem.ProductID = 1;
            TestItem.ProductName = "iphone7";
            TestItem.ProductPrice = (decimal)10.10;
            TestItem.ProductQuantity = 10;
            // add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllProducts.ProductList = TestList;
            //test to see that 2 values are same
            Assert.AreEqual(AllProducts.Count, TestList.Count);



        }
        //redundant test
        //[TestMethod]
        //public void AllProductsOk()
        //{

        //    clsProductCollection Products = new clsProductCollection();
        //    List<clsProduct> TestList = new List<clsProduct>();
        //    clsProduct TestItem = new clsProduct();
        //    TestItem.ProductID = 1;
        //    TestItem.ProductName = "iphone7";
        //    TestList.Add(TestItem);
        //    Products.AllProducts = TestList;
        //    Assert.AreEqual(Products.AllProducts, TestList);

        //}

        //redundant test
        //[TestMethod]
        //public void CountMatchesList()
        //{

        //    clsProductCollection Products = new clsProductCollection();
        //    List<clsProduct> TestList = new List<clsProduct>();
        //    clsProduct TestItem = new clsProduct();
        //    TestItem.ProductID = 1;
        //    TestItem.ProductName = "iphone7";
        //    TestList.Add(TestItem);
        //    Products.AllProducts = TestList;
        //    Assert.AreEqual(Products.Count, TestList.Count);

        //}

        [TestMethod]
        public void ThisProductPropertyOK()
        {
            // create instance of the class we want to create
            clsProductCollection AllProducts = new clsProductCollection();
            //create some test data to assign to the property
            clsProduct TestProduct = new clsProduct();
            // set its properties
            TestProduct.ProductActive = true;
            TestProduct.ProductID = 1;
            TestProduct.ProductName = "iphone7";
            TestProduct.ProductPrice = (decimal)10.10;
            TestProduct.ProductQuantity = 10;
            //assign the data to the property
            AllProducts.ThisProduct = TestProduct;
            //test to see that 2 values are same
            Assert.AreEqual(AllProducts.ThisProduct, TestProduct);

        }

        [TestMethod]
        public void ListAndCountOK()
        {
            // create instance of the class we want to create
            clsProductCollection AllProducts = new clsProductCollection();
            //create some test data to assign to the property
            //in this case data needs to be a list of objects
            List<clsProduct> TestList = new List<clsProduct>();
            //add an itrem to the list
            //create the item of the test data
            clsProduct TestItem = new clsProduct();

            // set its properties
            TestItem.ProductActive = true;
            TestItem.ProductID = 1;
            TestItem.ProductName = "iphone7";
            TestItem.ProductPrice = (decimal)10.10;
            TestItem.ProductQuantity = 10;
            
            // add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllProducts.ProductList = TestList;
            //test to see that 2 values are same
            Assert.AreEqual(AllProducts.Count, TestList.Count);

        }



        //[TestMethod]Redundant test 
        //public void TwoProductsPresent()
        //{

        //    clsProductCollection Products = new clsProductCollection();

        //    Assert.AreEqual(Products.Count,2);

        //}




        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsProductCollection AllProducts = new clsProductCollection();
            //create the item of test data
            clsProduct TestItem = new clsProduct();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.ProductActive = true;
            TestItem.ProductID = 1;
            TestItem.ProductName = "iphone7plus";
            TestItem.ProductPrice = (decimal)10.10;
            TestItem.ProductQuantity = 10;

            //set ThisAddress to the test data
            AllProducts.ThisProduct = TestItem;
            //add the record
            PrimaryKey = AllProducts.Add();
            //set the primary key of the test data
            TestItem.ProductID = PrimaryKey;
            //find the record
            AllProducts.ThisProduct.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllProducts.ThisProduct, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsProductCollection Allproducts = new clsProductCollection();
            //create the item of test data
            clsProduct TestItem = new clsProduct();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.ProductActive = true;
           // TestItem.ProductID = 1;
            TestItem.ProductName = "iphone7plus";
            TestItem.ProductPrice = (decimal)10.10;
            TestItem.ProductQuantity = 10;
            //set Thisproduct to the test data
            Allproducts.ThisProduct = TestItem;
            //add the record
            PrimaryKey = Allproducts.Add();
            //set the primary key of the test data
            TestItem.ProductID = PrimaryKey;
            //find the record
            Allproducts.ThisProduct.Find(PrimaryKey);
            //delete the record
            Allproducts.Delete();
            //now find the record   
            Boolean Found = Allproducts.ThisProduct.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }



        [TestMethod]
        public void UpdateMethodOK()
        {

            //create an instance of the class we want to create
            clsProductCollection Allproducts = new clsProductCollection();
            //create the item of test data
            clsProduct TestItem = new clsProduct();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.ProductActive = false;
            TestItem.ProductID = 1;
            TestItem.ProductName = "iphone88";
            TestItem.ProductPrice = (decimal)21.10;
            TestItem.ProductQuantity = 1;
            //set Thisproduct to the test data
            Allproducts.ThisProduct = TestItem;
            //add the record
            PrimaryKey = Allproducts.Add();
            //set the primary key of the test data
            TestItem.ProductID = PrimaryKey;
            //modify the test data
            TestItem.ProductActive = true;
            TestItem.ProductID = 1;
            TestItem.ProductName = "iphone7";
            TestItem.ProductPrice = (decimal)10.10;
            TestItem.ProductQuantity = 10;
            //set the record based on the new test data
            Allproducts.ThisProduct = TestItem;
            //update the record
            Allproducts.Update();
            //find the record
            Allproducts.ThisProduct.Find(PrimaryKey);
            //test to see ThisAddress matches the test data 
            Assert.AreEqual(Allproducts.ThisProduct, TestItem);

        }



        [TestMethod]
        public void FilterByProductNameMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsProductCollection AllProducts = new clsProductCollection();
            //create an instance of the filtered data
            clsProductCollection FilteredProducts = new clsProductCollection();
            //apply a blank string (should return all records);
            FilteredProducts.FilterByProductName("");
            //test to see that the two values are the same
            Assert.AreEqual(AllProducts.Count, FilteredProducts.Count);
        }









    }















}
