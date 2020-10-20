using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.BusinessLayer
{
    public class Customer
    {
        // Two constructors with the same name and differents parammeters (overloading the constructor)
        // We need to define the default constructor as well, otherwise we wont be able to create
        // A instance of the object without the parameter.
        public Customer(): this(0) // Constructor Chaining
        {
        }
        public Customer(int customerId) // Snipped ctor tabtab
        {
            CustomerId = CustomerId;
            AddressList = new List<Address>(); // Prevent Null Exception
        }
        // Adding Composition References
        public List<Address> AddressList { get; set; }

        public int CustomerId { get; private set; }

        // Adding Inheritance
        public int CustomerType{ get; set; }
        public string EmailAddress  { get; set; } 
        public string FirstName {get; set;} // Auto Implemented Property.
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if(!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName
                }
                return fullName;
            }
        }
        
        // Use the Static Modifier to declare members that belong to the class itself
        // And not to an instance of that class.
        public static int InstanceCount { get; set; }

        // Validates the customer data.
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }

        // Retrieve all the customers
        public List<Customer> Retrieve()
        {
            // Code that retrieves all of the Customers
            return new List<Customer>();
        }
    }
}
