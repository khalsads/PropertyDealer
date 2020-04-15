using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PropertyDealer.Models
{
    public class Adrs
    {
        public int AdrsId { get; set; }
        public string AdrsStreet { get; set; }
        public string PostalCode { get; set; }

        public string CityName { get; set; }
        public City City { get; set; }

        public string ProvinceName { get; set; }
        public Province Province { get; set; }

        public string CountryName { get; set; }
        public Country Country { get; set; }

        public List<Customer> Customers { get; set; }
    }
}