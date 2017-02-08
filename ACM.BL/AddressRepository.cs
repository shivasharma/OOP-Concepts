using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class AddressRepository
    {
        public Address Retrieve(int addressId)
        {
            Address address= new Address(addressId);

            if (addressId == 1)
            {
                address.StreetLine1 = "Bag End";
                address.StreetLine2 = "Bagshot row";
                address.City = "Hobbition";
                address.State = "Shire";
                address.Country = "Middle Earth";
                address.PostalCode = "144";
            }
            return address;
        }
        public IEnumerable<Address> RetrieveByCustomerId(int cutomerId)
        {
            //Code that retrieves the defined addresss for the customer

            //Temporart hard coded values to return 
            //a set of address for  a customer

            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Bag End",
                StreetLine2 = "Bagshot row",
                City = "Hobbiton",
                State = "Shrine",
                Country = "Middle Earth",
                PostalCode = "144"
            };
            addressList.Add(address);

             address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "Bag End2",
                StreetLine2 = "Bagshot row2",
                City = "Hobbiton2",
                State = "Shrine2",
                Country = "Middle Earth2",
                PostalCode = "1442"
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
