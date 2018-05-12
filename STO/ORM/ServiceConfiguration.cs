using STO.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STO.ORM
{
    class ServiceConfiguration : EntityTypeConfiguration<Service>
    {
        public ServiceConfiguration()
        {
            HasKey(s => s.ID);
            Property(s => s.name).IsRequired();
            Property(s => s.price).IsRequired();
            Property(s => s.description).IsRequired();
            HasRequired(s => s.material);
            Property(s => s.materialAmount).IsRequired();
        }
    }
}
