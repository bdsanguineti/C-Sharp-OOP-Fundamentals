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
            Assert.AreEqual(expected, actual);
        }
    }
}
