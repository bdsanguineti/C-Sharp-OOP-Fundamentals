using System;
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
                LastName = "Bell"
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

        }
    }
}
