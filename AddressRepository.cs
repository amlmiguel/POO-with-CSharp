using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM
{
    public class AddressRepository
    {
        /// <summary>
        /// Retrieve one address
        /// </summary>
        /// 
        public Address Retrieve(int addressId)
        {
            // Create the instance of the Address class
            // Pass in the requested Id

            Address address = new Address(addressId);

            // Code that retrieves the defined address

            // Temporary hard coded values to return
            // a populated address

            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Street 1";
                address.StreetLine2 = "Street 2";
                address.City = "City";
                address.State = "State";
                address.Country = "Country";
                address.PostalCode = "Postal Code";
            }

            return address;

        }

        public IEnumerable<Address> RetrieveByCustomerId(int CustomerId)
        {
            // Code that retrieves the defined addresses
            // for the customer

            //Temporary hard-coded values to return
            //a set if addresses for a customer

            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Street 1",
                StreetLine2 = "Street 2",
                City = "City",
                State = "State",
                Country = "Country",
                PostalCode = "Postal Code"
            };

            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "Street 11",
                StreetLine2 = "Street 21",
                City = "City1",
                State = "State1",
                Country = "Country1",
                PostalCode = "Postal Code1"
            };
            addressList.Add(address);

            return addressList;
        }


        ///<summary>
        ///Saves the current address.
        /// </summary>
        ///<returns></returns>
        ///
        public bool Save(Address address)
        {
            // Code that saves the passed in address

            return true;
        }



    }
}

