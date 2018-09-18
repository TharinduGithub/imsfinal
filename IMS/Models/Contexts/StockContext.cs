using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace IMS.Models.Contexts
{
    class StockContext : DbContext
    {
        public StockContext() : base("name=ConnectionName")
        {
        }

        public DbSet<StockIn> StockIns { get; set; }
        public DbSet<StockOut> StockOuts { get; set; }
        public DbSet<StockInItem> StockInItems { get; set; }
        public DbSet<StockOutItem> StockOutItems { get; set; }     
    }
}
