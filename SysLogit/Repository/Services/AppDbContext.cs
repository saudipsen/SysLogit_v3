using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysLogit.Models;
using System.Data.Entity;

namespace SysLogit.Repository.Services
{


    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("name=ShipmentDb") { }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Shipment> Shipments { get; set; }
    }

}
