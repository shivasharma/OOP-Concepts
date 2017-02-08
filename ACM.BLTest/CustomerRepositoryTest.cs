using System;
using System.Collections.Generic;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {

        [TestMethod]
        public void RetrieveExiting()
        {
            var cutomerRepository=new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "fbaggins@hobbition.me",
                FirstName = "Frodo",
                LastName = "Baggins"
            };

            var actual = cutomerRepository.Retrive(1);

            Assert.AreEqual(expected.CustomerId,actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress,actual.EmailAddress);
            Assert.AreEqual(expected.FirstName,actual.FirstName);
            Assert.AreEqual(expected.LastName,actual.LastName);
                
        }

        [TestMethod]
        public void RetrieveExistingWithAddress()
        {
            var customerRepositroy= new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "fbaggins@hobbition.me",
                FirstName = "Frodo",
                LastName = "Baggins",
                AddressList = new List<Address>()
                {
                    new Address()
                    {
                        AddressType = 1,
                        StreetLine1 = "Bag End",
                        StreetLine2 = "Bagshot Row",
                        City = "Hobbiton",
                        State = "shride",
                        Country = "Middle Earth",
                        PostalCode = "144"
                    },
                    new Address()
                    {
                        AddressType = 2,
                        StreetLine1 = "Bag End",
                        StreetLine2 = "Bagshot Row",
                        City = "Hobbiton",
                        State = "shride",
                        Country = "Middle Earth",
                        PostalCode = "144"
                    }
                }
            };

        //-Act

            var actual = customerRepositroy.Retrive(1);

            Assert.Equals(expected.CustomerId, actual.CustomerId);

            for (int i = 0; i <1; i++)
            {
                Assert.AreEqual(expected.  AddressList[i].AddressType,actual.AddressList[i].AddressType);
                
            }
        }
    }
}
