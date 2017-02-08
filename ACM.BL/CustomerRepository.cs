using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
  public  class CustomerRepository
    {

        private AddressRepository addressRepository { get; set; }

        public CustomerRepository()
        {
            addressRepository=new AddressRepository();
        }
        
        public Customer Retrive(int customerId)
        {
         Customer customer= new Customer(customerId);
            customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
            if (customerId == 1)
            {
                customer.EmailAddress = "fbaggins@hobbition.me";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
            }
            return customer;
        }
        public List<Customer> Retrive()
        {
            return new List<Customer>();
        }
        public bool save(Customer customer)
        {
            return true;
        }
    }
}
