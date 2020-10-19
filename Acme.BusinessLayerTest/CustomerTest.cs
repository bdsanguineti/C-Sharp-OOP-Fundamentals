using System;
using Acme.BusinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.BusinessLayerTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            // -- Arrange
            Customer customer = new Customer
            {
                FirstName = "Kenny",
                LastName = "Bell"
            };

            string expected = "Bell, Kenny";

            // -- Act
            string actual = customer.FullName;

            // -- Assert
            Assert.AreEqual(expected, actual);


        }
    }
}
