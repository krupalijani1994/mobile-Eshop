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
            string TestData = "1";
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

    }
}
