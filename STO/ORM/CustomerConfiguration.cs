using STO.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STO.ORM
{
    class CustomerConfiguration : EntityTypeConfiguration<Customer>
    {
        public CustomerConfiguration()
        {
            HasKey(c => c.ID);
            Property(c => c.Name).IsRequired();
            Property(c => c.Address).IsRequired();
            Property(c => c.Phone).HasMaxLength(10);
        }
    }
}
