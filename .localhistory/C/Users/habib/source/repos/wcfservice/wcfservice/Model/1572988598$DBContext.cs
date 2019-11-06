using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Data.Entity;

namespace wcfservice.Model
{
    public class DBContext : DbContext
    {

        public DBContext() : base("testEntities")
        {
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Employee> EmployeeS { get; set; }

    }
}
