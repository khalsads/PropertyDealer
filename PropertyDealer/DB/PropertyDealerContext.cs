using Microsoft.Owin.BuilderProperties;
using PropertyDealer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PropertyDealer.DB
{
    public class PropertyDealerContext :DbContext
    {
        public PropertyDealerContext() : base("DefaultConnection")
        { }

        public DbSet<Adrs> Adrs { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<Country> Countries { get; set; }
    }
}