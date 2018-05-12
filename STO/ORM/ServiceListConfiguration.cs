using STO.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STO.ORM
{
    class ServiceListConfiguration : EntityTypeConfiguration<ServiceList>
    {
        public ServiceListConfiguration()
        {
            
            var s = HasKey(sl => sl.ID);
            HasMany<Service>(sl => sl.Services).WithMany();
        }
    }
}
