using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Testclass
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOk()
        {

            clsStaffCollection AllStaff = new clsStaffCollection();
            Assert.IsNotNull(AllStaff);

        }
        //[TestMethod]
        //public void CountPropertyOk()
        //{

        //    clsStaffCollection AllStaff = new clsStaffCollection();
        //    Int32 Test = 3;
        //    AllStaff.Count = Test;
        //    Assert.AreEqual(AllStaff.Count, Test);
        //}

        [TestMethod]
        public void AllStaffOk()
        {

            clsStaffCollection Staff = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();
            TestItem.StaffID = 1;
            TestItem.StaffFirstName = "Angel";
            TestList.Add(TestItem);
            Staff.AllStaff = TestList;
            Assert.AreEqual(Staff.AllStaff, TestList);

        }
        //[TestMethod]
        //public void CountMatchesList()
        //{

        //    clsStaffCollection Staff = new clsStaffCollection();
        //    List<clsStaff> TestList = new List<clsStaff>();
        //    clsStaff TestItem = new clsStaff();
        //    TestItem.StaffID = 1;
        //    TestItem.StaffFirstName = "Angel";
        //    TestList.Add(TestItem);
        //    Staff.AllStaff = TestList;
        //    Assert.AreEqual(Staff.Count, TestList.Count);

        //}



        [TestMethod]
        public void StaffListOK()
        {
            // create instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //create the item of the test data
            clsStaff TestItem = new clsStaff();
            // set its properties
            TestItem.StaffID = 1;
            TestItem.StaffFirstName = "Angel";
            TestItem.StaffLastName = "kaul";
            TestItem.StaffGender = "female";
            TestItem.StaffPhoneNo = 1234567890;
            TestItem.StaffAddress = "99 cathrine street";
            TestItem.StaffEmail = "abc@gmail.com";
           

            // add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that 2 values are same
            Assert.AreEqual(AllStaff.StaffList, TestList);




        }
        [TestMethod]
        public void CountPropertyOK()
        {
            // create instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //create the item of the test data
            clsStaff TestItem = new clsStaff();
            // set its properties
            TestItem.StaffID = 1;
            TestItem.StaffFirstName = "Angel";
            TestItem.StaffLastName = "kaul";
            TestItem.StaffGender = "female";
            TestItem.StaffPhoneNo = 1234567890;
            TestItem.StaffAddress = "99 cathrine street";
            TestItem.StaffEmail = "abc@gmail.com";

            // add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that 2 values are same
            Assert.AreEqual(AllStaff.StaffList.Count, TestList.Count);


        
        }
        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            // create instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            clsStaff TestStaff = new clsStaff();
            // set its properties
            TestStaff.StaffID = 1;
            TestStaff.StaffFirstName = "Angel";
            TestStaff.StaffLastName = "kaul";
            TestStaff.StaffGender = "female";
            TestStaff.StaffPhoneNo = 1234567890;
            TestStaff.StaffAddress = "99 cathrine street";
            TestStaff.StaffEmail = "abc@gmail.com";
            //assign the data to the property
            AllStaff.ThisStaff = TestStaff;
            //test to see that 2 values are same
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);

        }



        //[TestMethod]
        //public void ListAndCountOK()
        //{
        //    // create instance of the class we want to create
        //    clsStaffCollection AllStaff = new clsStaffCollection();
        //    //create some test data to assign to the property
        //    //in this case data needs to be a list of objects
        //    List<clsStaff> TestList = new List<clsStaff>();
        //    //create the item of the test data
        //    clsStaff TestItem = new clsStaff();
        //    // set its properties
        //    TestItem.StaffID = 1;
        //    TestItem.StaffFirstName = "Angel";
        //    TestItem.StaffLastName = "kaul";
        //    TestItem.StaffGender = "female";
        //    TestItem.StaffPhoneNo = 1234567890;
        //    TestItem.StaffAddress = "99 cathrine street";
        //    TestItem.StaffEmail = "abc@gmail.com";
            
        //    // add the item to the test list
        //    TestList.Add(TestItem);
        //    //assign the data to the property
        //    AllStaff.StaffList = TestList;
        //    //test to see that 2 values are same
        //    Assert.AreEqual(AllStaff.Count, TestList.Count);

        //}

        //[TestMethod]
        //Redundant test
        //public void OneProductsPresent()
        //{

        //    clsStaffCollection Staff = new clsStaffCollection();

        //    Assert.AreEqual(Staff.Count, 1);

        //}




        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.StaffID = 1;
            TestItem.StaffFirstName = "Angele";
            TestItem.StaffLastName = "kaule";
            TestItem.StaffGender = "male";
            TestItem.StaffPhoneNo = 12345678;
            TestItem.StaffAddress = "99 cathrine street";
            TestItem.StaffEmail = "abc@gmail.com";
            TestItem.DOB = DateTime.Now.Date;
            //set ThisAddress to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.StaffID = PrimaryKey;
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }


        [TestMethod]
        public void DeleteMethodOK()
        {  //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.StaffID = 4;
            TestItem.StaffFirstName = "Angele";
            TestItem.StaffLastName = "kaule";
            TestItem.StaffGender = "male";
            TestItem.StaffPhoneNo = 1234567890;
            TestItem.StaffAddress = "99 cathrine street";
            TestItem.StaffEmail = "abc@gmail.com";
            TestItem.DOB = DateTime.Now.Date;
            //set ThisAddress to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.StaffID = PrimaryKey;
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //delete the record
            AllStaff.Delete();
            //now find the record   
            Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }




        [TestMethod]
        public void UpdateMethodOK()
        {

            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its property
            TestItem.StaffID = 1;
            TestItem.StaffFirstName = "Angel";
            TestItem.StaffLastName = "kaul";
            TestItem.StaffGender = "female";
            TestItem.StaffPhoneNo = 1234567890;
            TestItem.StaffAddress = "99 cathrine street";
            TestItem.StaffEmail = "abc@gmail.com";
            TestItem.DOB = DateTime.Now.Date;
            //set Thisproduct to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.StaffID = PrimaryKey;
            //modify the test data
            TestItem.StaffID = 1;
            TestItem.StaffFirstName = "Angel";
            TestItem.StaffLastName = "kaul";
            TestItem.StaffGender = "female";
            TestItem.StaffPhoneNo = 1234567890;
            TestItem.StaffAddress = "99 cathrine street";
            TestItem.StaffEmail = "abc@gmail.com";
            TestItem.DOB = DateTime.Now.Date;
            //set the record based on the new test data
            AllStaff.ThisStaff = TestItem;
            //update the record
            AllStaff.Update();
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see ThisAddress matches the test data 
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);

        }





        [TestMethod]
        public void FilterByStaffNameMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create an instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //apply a blank string (should return all records);
            FilteredStaff.FilterByStaffName("");
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, FilteredStaff.Count);
        }









    }



}
