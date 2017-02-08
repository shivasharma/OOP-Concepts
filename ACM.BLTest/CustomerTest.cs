using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //-- Arrange
            Customer customer= new Customer();
            customer.FirstName = "Bilbo";
            customer.LastName = "Baggins";
            string expected = "Bilbo, Baggins";
            //-- Act
            string actual = customer.FullName;
            //-- Assert
            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            var c1=new Customer();
            c1.FirstName = "Bilbo";
            Customer.InstanceCount+=1;

            var C2= new Customer();
            C2.FirstName = "Frodo";
            Customer.InstanceCount += 1;
            var c3= new Customer();
            C2.FirstName = "Rosie";
            Customer.InstanceCount += 1;
        }

        [TestMethod]
        public void ValidateValid()
        {
            var customer=new Customer();
            customer.LastName = "Baggins";
            customer.EmailAddress = "fbaggins@hobbiton.me";
            var expected = true;

            var actual = customer.Validate();

           Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void ValidateMisslingLastName()
        {
            var customer = new Customer();
             customer.EmailAddress = "fbaggins@hobbiton.me";
            var expected = false;

            var actual = customer.Validate();

            Assert.AreEqual(expected, actual);
        }
    }
}
