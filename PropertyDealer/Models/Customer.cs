using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PropertyDealer.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public string AdrsStreet { get; set; }
        public Adrs Adrs { get; set; }
    }
}