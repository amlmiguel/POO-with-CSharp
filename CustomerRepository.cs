﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }

        private AddressRepository addressRepository { get; set; }

        /// Retrieve one customer
        /// </summary>
        /// 

        public Customer Retrieve(int customerId)
        {
            // Create the instance of the Customer class
            // Pass in the requested id

            Customer customer = new Customer(customerId);

            if (customerId == 1)
            {
                customer.EmailAddress = "fbaggins@hobbiton.me";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
                customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
            }
            return customer;
        }

        ///<summary>
        /// Saves the current customer
        /// </summary>
        /// <returns></returns>
        /// 

        public bool Save(Customer customer)
        {
            // Code that saves the passed in customer

            return true;

        }

    }
}
