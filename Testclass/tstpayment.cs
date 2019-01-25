using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testclass
{
    [TestClass]
    public class tstpayment
    {
        [TestMethod]
        public void InstanceOk()
        {
            //creates an instance of a class
            clsPayment APayment = new clsPayment();
            Assert.IsNotNull(APayment);

        }

        [TestMethod]
        public void PaymentIDPropertyOk()
        {
            //creates an instance of a class
            clsPayment Apayment = new clsPayment();
            string TestData = "1";
            Apayment.PaymentID = TestData;
            Assert.AreEqual(Apayment.PaymentID, TestData);

        }

        [TestMethod]
        public void PaymentDatePropertyOk()
        {
            //creates an instance of a class
            clsPayment Apayment = new clsPayment();
            string TestData = "1";
            Apayment.PaymentDate = TestData;
            Assert.AreEqual(Apayment.PaymentDate, TestData);

        }

     //----------------------------------------------------------------------------------------------------------------------
     //need to look on the class diagram and re-think of the payment class











    }
}
