using STO.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STO.ORM
{
    class OrderConfiguration : EntityTypeConfiguration<Order>
    {
        public OrderConfiguration()
        {
            HasKey(o => o.ID);
            HasMany<Service>(o => o.services).WithRequired();
        }
    }
}
