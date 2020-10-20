using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.BusinessLayer
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        private AddressRepository addressRepository { get; set; }
        // Retrive one customer.
        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);

            // Code that retrieves the defined customer
            if (customerId == 1)
            {
                customer.EmailAddress = "kennybell@gmail.com";
                customer.FirstName = "Kenny";
                customer.LastName = "Bell";
                customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
            }
            return customer;
        }

        // Saves the current Customer
        public bool Save(Customer customer)
        {
            // Code that saves the passed in customer
            return true;
        }
    }
}
