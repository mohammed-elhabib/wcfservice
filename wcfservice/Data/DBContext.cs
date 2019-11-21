using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Data.Entity;
using MySql.Data.Entity;
using SDK.Model;

namespace Date.Model
{

    public class DbInitializer : CreateDatabaseIfNotExists<DBContext>
    {
        protected override void Seed(DBContext context)
        {
            for (int i = 0; i < 1000000; i++)
            {
                context.Employees.Add(new Employee
                {
                    BirthDayDate = DateTime.Today.AddDays(-1 * i),
                    DateAt = DateTime.Now,
                    DateUp = DateTime.Now,
                    FirstMidName = $"First name {i}",
                    Job = $"Job {i}",
                    LastName = $"Last name {i}",
                    Pay = 233m * i,
                });

                if (i % 1000 == 0)
                {
                    context.SaveChanges();
                }
            }
            base.Seed(context);
        }
    }

    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class DBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Employee> Employees { get; set; }

        public DBContext() : base("name=minproject")
        {
            
        }




    }
}
