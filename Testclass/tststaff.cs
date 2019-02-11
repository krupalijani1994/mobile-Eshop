using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testclass
{
    [TestClass]
    public class tststaff
    {
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
            Int32 TestData = 1234567890;
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
        public void ValidMethodOk()
        {
            //creates an instance of a class
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string TestData = "Angel";
            Error = AStaff.Valid(TestData);
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void StaffActivePropertyOK()
        {
            clsStaff AStaff = new clsStaff();
            Boolean TestData = true;
            AStaff.Active = TestData;
            Assert.AreEqual(AStaff.Active, TestData);
        }













        //Staff Address test

        [TestMethod]
        public void StaffAddressMinMinusOne()
        {
            //creates an instance of a class
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string StaffAddress = "";
            Error = AStaff.Valid(StaffAddress);
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void StaffAddressMin()
        {
            //creates an instance of a class
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string StaffAddress = "A";
            Error = AStaff.Valid(StaffAddress);
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void StaffAddressMinplusOne()
        {
            //creates an instance of a class
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string StaffAddress = "aa";
            Error = AStaff.Valid(StaffAddress);
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
            Error = AStaff.Valid(StaffAddress);
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
            Error = AStaff.Valid(StaffAddress);
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
            Error = AStaff.Valid(StaffAddress);
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
            Error = AStaff.Valid(StaffAddress);
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
            Error = AStaff.Valid(StaffAddress);
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
            Error = AStaff.Valid(StaffEmail);
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void StaffEmailMin()
        {
            //creates an instance of a class
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string StaffEmail = "A";
            Error = AStaff.Valid(StaffEmail);
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void StaffEmailMinplusOne()
        {
            //creates an instance of a class
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string StaffEmail = "aa";
            Error = AStaff.Valid(StaffEmail);
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
            Error = AStaff.Valid(StaffAddress);
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
            Error = AStaff.Valid(StaffEmail);
            Assert.AreEqual(Error, "");

        }
        //[TestMethod]
        //public void StaffEmailMaxPlusOne()
        //{
        //    //creates an instance of a class
        //    clsStaff AStaff = new clsStaff();
        //    string Error = "";
        //    string StaffAddress = "";
        //    StaffAddress = StaffAddress.PadRight(51, 'A');
        //    Error = AStaff.Valid(StaffAddress);
        //    Assert.AreNotEqual(Error, "");

        //}

        [TestMethod]
        public void StaffEmailMid()
        {
            //creates an instance of a class
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string StaffAddress = "";
            StaffAddress = StaffAddress.PadRight(25, 'A');
            Error = AStaff.Valid(StaffAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailExtermeMax()
        {
            //creates an instance of a class
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string StaffAddress = "";
            StaffAddress = StaffAddress.PadRight(200, 'A');
            Error = AStaff.Valid(StaffAddress);
            Assert.AreNotEqual(Error, "");

        }


        //Staff First name-------------------------------

        [TestMethod]
        public void StaffFirstNameMinMinusOne()
        {
            //creates an instance of a class
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string StaffFirstName = "";
            Error = AStaff.Valid(StaffFirstName);
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void StaffFirstNameMin()
        {
            //creates an instance of a class
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string StaffFirstName = "A";
            Error = AStaff.Valid(StaffFirstName);
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void StaffFirstNameMinplusOne()
        {
            //creates an instance of a class
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string StaffFirstName = "aa";
            Error = AStaff.Valid(StaffFirstName);
            Assert.AreEqual(Error, "");

        }



        [TestMethod]
        public void StaffFirstNameMaxMinusOne()
        {
            //creates an instance of a class
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string StaffFirstName = "";
            StaffFirstName = StaffFirstName.PadRight(19, 'A');
            Error = AStaff.Valid(StaffFirstName);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StaffFirstNameMax()
        {
            //creates an instance of a class
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string StaffFirstName = "";
            StaffFirstName = StaffFirstName.PadRight(20, 'A');
            Error = AStaff.Valid(StaffFirstName);
            Assert.AreEqual(Error, "");

        }
        //[TestMethod]
        //public void StaffFirstNameMaxPlusOne()
        //{
        //    //creates an instance of a class
        //    clsStaff AStaff = new clsStaff();
        //    string Error = "";
        //    string StaffFirstName = "";
        //    StaffFirstName = StaffFirstName.PadRight(21, 'A');
        //    Error = AStaff.Valid(StaffFirstName);
        //    Assert.AreNotEqual(Error, "");

        //}

        [TestMethod]
        public void StaffFirstNameMid()
        {
            //creates an instance of a class
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string StaffAddress = "";
            StaffAddress = StaffAddress.PadRight(10, 'A');
            Error = AStaff.Valid(StaffAddress);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StaffFirstNameExtermeMax()
        {
            //creates an instance of a class
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string StaffFirstName = "";
            StaffFirstName = StaffFirstName.PadRight(150, 'A');
            Error = AStaff.Valid(StaffFirstName);
            Assert.AreNotEqual(Error, "");

        }







    }
}
