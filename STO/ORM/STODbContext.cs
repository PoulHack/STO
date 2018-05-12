using STO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace STO.ORM
{
    class STODbContext : DbContext
    {
        static STODbContext ()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges< STODbContext >());
        }

        public DbSet<Service> Services { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Account> Accounts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CustomerConfiguration());
            modelBuilder.Configurations.Add(new MaterialConfiguration());
            modelBuilder.Configurations.Add(new OrderConfiguration());
            modelBuilder.Configurations.Add(new ServiceConfiguration());
            modelBuilder.Configurations.Add(new ServiceListConfiguration());
            modelBuilder.Configurations.Add(new AccountConfiguration());
        }
    }
}
