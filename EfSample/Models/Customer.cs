using System;
using System.Collections.Generic;

namespace EfSample.Models
{
    public class Customer 
    {
        public Customer()
        {           
            Addresses = new List<Address>();
        }

        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        //public ICollection<Order> Orders { get; set; }
        public ICollection<Address> Addresses { get; set; }
    }
}