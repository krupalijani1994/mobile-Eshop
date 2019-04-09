using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testclass
{
    [TestClass]
    public class tststaff
    {
        string StaffFirstName=" Angel";
        string StaffLastName="kaul";
        string StaffGender= "female";
        string StaffPhoneNo= "1234567890";
        string StaffAddress="99 cathrine street";
        string StaffEmail="abc@gmail.com";
        string DOB= "";

        [TestMethod]
        public void InstanceOk()
        {
            //creates an instance of a class
            clsStaff Astaff = new clsStaff();
            Assert.IsNotNull(Astaff);

        }

        [TestMethod]
        public void StaffIDPropertyOk()
        {
            //creates an instance of a class
            clsStaff Astaff = new clsStaff();
            Int32 TestData = 1;
            Astaff.StaffID = TestData;
            Assert.AreEqual(Astaff.StaffID, TestData);

        }

        [TestMethod]
        public void StaffAddressPropertyOk()
        {
            //creates an instance of a class
            clsStaff Astaff = new clsStaff();
            string TestData = "99 cathrine street";
            Astaff.StaffAddress = TestData;
            Assert.AreEqual(Astaff.StaffAddress, TestData);

        }

        [TestMethod]
        public void StaffEmailPropertyOk()
        {
            //creates an instance of a class
            clsStaff Astaff = new clsStaff();
            string TestData = "abc@gmail.com";
            Astaff.StaffEmail = TestData;
            Assert.AreEqual(Astaff.StaffEmail, TestData);

        }

        [TestMethod]
        public void StaffFirstNamePropertyOk()
        {
            //creates an instance of a class
            clsStaff Astaff = new clsStaff();
            string TestData = "Angel";
            Astaff.StaffFirstName = TestData;
            Assert.AreEqual(Astaff.StaffFirstName, TestData);

        }

        [TestMethod]
        public void StaffLastNamePropertyOk()
        {
            //creates an instance of a class
            clsStaff Astaff = new clsStaff();
            string TestData = "kaul";
            Astaff.StaffLastName = TestData;
            Assert.AreEqual(Astaff.StaffLastName, TestData);

        }

        [TestMethod]
        public void StaffGenderPropertyOK()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Female";
            //assign the property for the test data
            AStaff.StaffGender = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AStaff.StaffGender, TestData);
        }

        [TestMethod]
        public void StaffPhoneNoPropertyOK()
        {
           
            clsStaff AStaff = new clsStaff();
            string TestData = "1234567890";
            AStaff.StaffPhoneNo = TestData;
            Assert.AreEqual(AStaff.StaffPhoneNo, TestData);
        }


        [TestMethod]
        public void StaffDOBOK()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            DateTime TestData = DateTime.Now.Date;
            AStaff.DOB = TestData;
            Assert.AreEqual(AStaff.DOB, TestData);
        }
        [TestMethod]
        public void StaffActivePropertyOK()
        {
            clsStaff AStaff = new clsStaff();
            Boolean TestData = true;
            AStaff.Active = TestData;
            Assert.AreEqual(AStaff.Active, TestData);
        }

        [TestMethod]
        public void ValidMethodOk()
        {
            //creates an instance of a class
            clsStaff AStaff = new clsStaff();
            string Error = "";
            //string TestData = "Angel";
            Error = AStaff.Valid(StaffFirstName,StaffLastName,StaffGender,StaffPhoneNo,StaffAddress,StaffEmail,DOB);
            Assert.AreEqual(Error, "");

        }


        




        //Staff Address test

        [TestMethod]
        public void StaffAddressMinMinusOne()
        {
            //creates an instance of a class
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string StaffAddress = "";
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffGender, StaffPhoneNo, StaffAddress, StaffEmail, DOB);
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void StaffAddressMin()
        {
            //creates an instance of a class
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string StaffAddress = "A";
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffGender, StaffPhoneNo, StaffAddress, StaffEmail, DOB);
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void StaffAddressMinplusOne()
        {
            //creates an instance of a class
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string StaffAddress = "aa";
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffGender, StaffPhoneNo, StaffAddress, StaffEmail, DOB);
            Assert.AreEqual(Error, "");

        }



        [TestMethod]
        public void StaffAddressMaxMinusOne()
        {
            //creates an instance of a class
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string StaffAddress = "";
            StaffAddress = StaffAddress.PadRight(99, 'A');
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffGender, StaffPhoneNo, StaffAddress, StaffEmail, DOB);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StaffAddressMax()
        {
            //creates an instance of a class
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string StaffAddress = "";
            StaffAddress = StaffAddress.PadRight(100, 'A');
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffGender, StaffPhoneNo, StaffAddress, StaffEmail, DOB);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void StaffAddressMaxPlusOne()
        {
            //creates an instance of a class
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string StaffAddress = "";
            StaffAddress = StaffAddress.PadRight(101, 'A');
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffGender, StaffPhoneNo, StaffAddress, StaffEmail, DOB);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void StaffAddressMid()
        {
            //creates an instance of a class
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string StaffAddress = "";
            StaffAddress = StaffAddress.PadRight(50, 'A');
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffGender, StaffPhoneNo, StaffAddress, StaffEmail, DOB);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StaffAddressExtermeMax()
        {
            //creates an instance of a class
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string StaffAddress = "";
            StaffAddress = StaffAddress.PadRight(150, 'A');
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffGender, StaffPhoneNo, StaffAddress, StaffEmail, DOB);
            Assert.AreNotEqual(Error, "");

        }


        //Staff Date and time.....





































        //staff email id





        [TestMethod]
        public void StaffEmailMinMinusOne()
        {
            //creates an instance of a class
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string StaffEmail = "";
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffGender, StaffPhoneNo, StaffAddress, StaffEmail, DOB);
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void StaffEmailMin()
        {
            //creates an instance of a class
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string StaffEmail = "A";
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffGender, StaffPhoneNo, StaffAddress, StaffEmail, DOB);
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void StaffEmailMinplusOne()
        {
            //creates an instance of a class
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string StaffEmail = "aa";
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffGender, StaffPhoneNo, StaffAddress, StaffEmail, DOB);
            Assert.AreEqual(Error, "");

        }



        [TestMethod]
        public void StaffEmailMaxMinusOne()
        {
            //creates an instance of a class
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string StaffAddress = "";
            StaffAddress = StaffAddress.PadRight(49, 'A');
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffGender, StaffPhoneNo, StaffAddress, StaffEmail, DOB);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StaffEmailMax()
        {
            //creates an instance of a class
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string StaffEmail = "";
            StaffEmail = StaffEmail.PadRight(50, 'A');
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffGender, StaffPhoneNo, StaffAddress, StaffEmail, DOB);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void StaffEmailMaxPlusOne()
        {
            //creates an instance of a class
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string StaffEmail = "";
            StaffEmail = StaffEmail.PadRight(51, 'A');
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffGender, StaffPhoneNo, StaffAddress, StaffEmail, DOB);
            Assert.AreNotEqual(Error, "");

        }




























        //found

        [TestMethod]
        public void TestStaffIDFound()
        {
            //creates an instance of a class
            clsStaff Astaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record the data is ok
            Boolean Ok = true;
            //create some data for testing with the method
            Int32 StaffID = 1;
            //invoke the method
            Found = Astaff.Find(StaffID);
            // check the product id

            if (Astaff.StaffID != 1)
            {

                Ok = false;
            }
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestStaffFirstNameFound()
        {
            //creates an instance of a class
            clsStaff Astaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record the data is ok
            Boolean Ok = true;
            //create some data for testing with the method
            Int32 StaffID = 1;
            //invoke the method
            Found = Astaff.Find(StaffID);
            // check the product id

            if (Astaff.StaffFirstName != "Angel")
            {

                Ok = false;
            }
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void TestStaffLastNameFound()
        {
            //creates an instance of a class
            clsStaff Astaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record the data is ok
            Boolean Ok = true;
            //create some data for testing with the method
            Int32 StaffID = 1;
            //invoke the method
            Found = Astaff.Find(StaffID);
            // check the product id

            if (Astaff.StaffLastName != "kaul")
            {

                Ok = false;
            }
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void TestStaffGenderFound()
        {
            //creates an instance of a class
            clsStaff Astaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record the data is ok
            Boolean Ok = true;
            //create some data for testing with the method
            Int32 StaffID = 1;
            //invoke the method
            Found = Astaff.Find(StaffID);
            // check the product id

            if (Astaff.StaffGender != "female")
            {

                Ok = false;
            }
            Assert.IsTrue(Ok);
        }




        [TestMethod]
        public void TestStaffPhoneNoFound()
        {
            //creates an instance of a class
            clsStaff Astaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record the data is ok
            Boolean Ok = true;
            //create some data for testing with the method
            Int32 StaffID = 1;
            //invoke the method
            Found = Astaff.Find(StaffID);
            // check the product id

            if (Astaff.StaffPhoneNo != "1234567890")
            {

                Ok = false;
            }
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestStaffAddressFound()
        {
            //creates an instance of a class
            clsStaff Astaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record the data is ok
            Boolean Ok = true;
            //create some data for testing with the method
            Int32 StaffID = 1;
            //invoke the method
            Found = Astaff.Find(StaffID);
            // check the product id

            if (Astaff.StaffAddress != "99 cathrine street")
            {

                Ok = false;
            }
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestStaffEmailFound()
        {
            //creates an instance of a class
            clsStaff Astaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record the data is ok
            Boolean Ok = true;
            //create some data for testing with the method
            Int32 StaffID = 1;
            //invoke the method
            Found = Astaff.Find(StaffID);
            // check the product id

            if (Astaff.StaffEmail != "abc@gmail.com")
            {

                Ok = false;
            }
            Assert.IsTrue(Ok);
        }

        //[TestMethod]
        //public void TestDOBFound()
        //{
        //    //creates an instance of a class
        //    clsStaff Astaff = new clsStaff();
        //    //boolean variable to store the result of the validation
        //    Boolean Found = false;
        //    //boolean variable to record the data is ok
        //    Boolean Ok = true;
        //    //create some data for testing with the method
        //    Int32 StaffID = 1;
        //    //invoke the method
        //    Found = Astaff.Find(StaffID);
        //    // check the product id

        //    if (Astaff.DOB != Convert.ToDateTime("7/02/2019"))
        //    {

        //        Ok = false;
        //    }
        //    Assert.IsTrue(Ok);
        //}


        



    }
}
