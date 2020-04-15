using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PropertyDealer.Models
{
    public class Province
    {
        public int ProvinceId { get; set; }
        public string ProvinceName { get; set; }
        public List<Adrs> Adrs { get; set; }
    }
}