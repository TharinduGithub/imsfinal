using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace IMS.Models.Contexts
{
    class VendorContext : DbContext
    {
        public VendorContext() : base("name=ConnectionName") { }
        public DbSet<Vendor> Venders { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Supplier>().HasOptional(c => c.Vendor).WithOptionalDependent().WillCascadeOnDelete(true);
            //base.OnModelCreating(modelBuilder);
        }
    }
}


//31812806293507