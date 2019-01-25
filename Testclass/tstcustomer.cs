using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testclass
{
    [TestClass]
    public class tstcustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create instance of the class
            clsCustomer ACustomer = new clsCustomer();
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void CustomerActivePropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean TestData = true;
            ACustomer.Active = TestData;
            Assert.AreEqual(ACustomer.Active, TestData);
        }

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            int TestData = 1;
            ACustomer.CustomerID = TestData;
            Assert.AreEqual(ACustomer.CustomerID, TestData);
        }

        [TestMethod]
        public void CustomerDOBPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            DateTime TestData = DateTime.Now.Date;
            ACustomer.DOB = TestData;
            Assert.AreEqual(ACustomer.DOB, TestData);
        }

        [TestMethod]
        public void CustomerEmailPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "abcd12@gmail.com";
            ACustomer.EmailAddress = TestData;
            Assert.AreEqual(ACustomer.EmailAddress, TestData);
        }



        [TestMethod]
        public void CustomerFirstNamePropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "John";
            ACustomer.FirstName = TestData;
            Assert.AreEqual(ACustomer.FirstName, TestData);
        }

        [TestMethod]
        public void CustomerGenderPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "Male";
            ACustomer.Gender = TestData;
            Assert.AreEqual(ACustomer.Gender, TestData);
        }

        [TestMethod]
        public void CustomerAddressPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "6 Cavendish Mews";
            ACustomer.HomeAddress = TestData;
            Assert.AreEqual(ACustomer.HomeAddress, TestData);
        }

        [TestMethod]
        public void CustomerLastNamePropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "Doe";
            ACustomer.LastName = TestData;
            Assert.AreEqual(ACustomer.LastName, TestData);
        }

        [TestMethod]
        public void CustomerPhoneNoPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "1234567890";
            ACustomer.PhoneNo = TestData;
            Assert.AreEqual(ACustomer.PhoneNo, TestData);
        }




    }
}
