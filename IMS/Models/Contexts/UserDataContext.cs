using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace IMS.Models.Contexts
{
    class UserDataContext : DbContext
    {
        public UserDataContext() : base("name=ConnectionName") { }
        public DbSet<UserData> UsersData { get; set; }
        //public DbSet<Logs> Logs { get; set; }
       
    }
}
