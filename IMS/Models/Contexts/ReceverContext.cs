using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace IMS.Models.Contexts
{
    class ReceverContext : DbContext
    {
        public ReceverContext() : base("name=ConnectionName") {}
        public DbSet<Recever> Recevers { get; set; }

    }
}
