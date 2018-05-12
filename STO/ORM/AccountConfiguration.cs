using STO.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STO.ORM
{
    class AccountConfiguration : EntityTypeConfiguration<Account>
    {
        public AccountConfiguration()
        {
            HasKey(a => a.ID);
            HasRequired(a => a.customer);
            HasMany<Order>(a => a.orders).WithRequired();
        }
    }
}
