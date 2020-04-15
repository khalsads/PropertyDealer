using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PropertyDealer.Models
{
    public class Country
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }

        public List<Adrs> Adrs { get; set; }
    }
}