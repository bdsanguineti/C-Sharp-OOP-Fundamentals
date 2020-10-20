using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.BusinessLayer
{
    public class AddressRepository
    {
        // Retrieve one Address.
        public Address Retrieve(int addressId)
        {
            Address address = new Address(addressId);

            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Bag End";
                address.StreetLine2 = "Bagshot row";
                address.City = "Hobbiton";
                address.State = "Shire";
                address.Country = "Middle Earth";
                address.PostalCode = "144";
            }

            return address; // I am returning just 1 Address. I want to retrieve all the Address at the same time.
        }

        // For that reason, I add a list of addresses for a specific customer.
        // Ienumerable is the recommended way to return a sequence of data because the results are more
        // flexible for the callers of the method.
        
        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Buenos Aires",
                StreetLine2 = "Av. Pellegrini",
                City = "Rosario",
                State = "Santa Fe",
                Country = "Argentina",
                PostalCode = "2000"
            };
            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "Cordoba",
                StreetLine2 = "Laprida",
                City = "Rosario",
                State = "Santa Fe",
                Country = "Middle Earth",
                PostalCode = "2000"
            };
            addressList.Add(address);

            return addressList;
        }


        public bool Save(Address address)
        {
            return true;
        }
    }
}
