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
        [TestMethod]
        public void CountPropertyOk()
        {

            clsStaffCollection AllStaff = new clsStaffCollection();
            Int32 Test = 1;
            AllStaff.Count = Test;
            Assert.AreEqual(AllStaff.Count, Test);
        }

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
        [TestMethod]
        public void CountMatchesList()
        {

            clsStaffCollection Staff = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();
            TestItem.StaffID = 1;
            TestItem.StaffFirstName = "Angel";
            TestList.Add(TestItem);
            Staff.AllStaff = TestList;
            Assert.AreEqual(Staff.Count, TestList.Count);

        }



        //[TestMethod]
     
        //public void TwoProductsPresent()
        //{

        //    clsStaffCollection Staff = new clsStaffCollection();

        //    Assert.AreEqual(Staff.Count,2);

        //}
    }
}
