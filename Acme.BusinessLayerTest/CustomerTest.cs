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
        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            // -- Arrange
            Customer customer = new Customer
            {
                LastName = "Bell"
            };

            string expected = "Bell";

            // -- Act
            string actual = customer.FullName;

            // -- Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            // -- Arrange
            Customer customer = new Customer
            {
                FirstName = "Kenny"
            };

            string expected = "Kenny";

            // -- Act
            string actual = customer.FullName;

            // -- Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void StaticTest()
        {
            // -- Arrange
            var c1 = new Customer();
            c1.FirstName = "Kenny";
            Customer.InstanceCount++;

            var c2 = new Customer();
            c1.FirstName = "Julio";
            Customer.InstanceCount++;

            var c3 = new Customer();
            c1.FirstName = "Jackie";
            Customer.InstanceCount++;

            // -- Act

            // -- Assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }

        [TestMethod]
        public void ValidateValid()
        {
            // -- Arrange
            var customer = new Customer
            {
                LastName = "Sieras",
                EmailAddress = "jackiesieras@gmail.com"
            };

            var expected = true;

            // -- Act
            var actual = customer.Validate();

            // -- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingLastName()
        {
            // -- Arrange
            var customer = new Customer
            {
                EmailAddress = "jackiesieras@gmail.com"
            };

            var expected = false;

            // -- Act
            var actual = customer.Validate();

            // -- Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
