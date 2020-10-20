using System;
using System.Collections.Generic;
using Acme.BusinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.BusinessLayerTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            // Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "kennybell@gmail.com",
                FirstName = "Kenny",
                LastName = "Bell",
                AddressList = new List<Address>()
                {
                    new Address()
                    {
                    AddressType = 1,
                    StreetLine1 = "Buenos Aires",
                    StreetLine2 = "Av. Pellegrini",
                    City = "Rosario",
                    State = "Santa Fe",
                    Country = "Argentina",
                    PostalCode = "2000"
                    },

                    new Address()
                    {
                    AddressType = 2,
                    StreetLine1 = "Cordoba",
                    StreetLine2 = "Laprida",
                    City = "Rosario",
                    State = "Santa Fe",
                    Country = "Middle Earth",
                    PostalCode = "2000"
                    },
                }
            };

            // Act
            var actual = customerRepository.Retrieve(1);

            // Assert
            // This will fail because to objects AreEquals if are pointed at the same instance.
            // Assert.AreEqual(expected, actual); 

            // For Fix that I can compare Field by Field
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);

            for(int i=0; i<1; i++)
            {
                Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.AreEqual(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
                Assert.AreEqual(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.AreEqual(expected.AddressList[i].State, actual.AddressList[i].State);
                Assert.AreEqual(expected.AddressList[i].Country, actual.AddressList[i].Country);
                Assert.AreEqual(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);
            }

        }
    }
}
