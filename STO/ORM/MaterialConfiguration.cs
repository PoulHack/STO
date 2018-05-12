using STO.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STO.ORM
{
    class MaterialConfiguration : EntityTypeConfiguration<Material>
    {
        public MaterialConfiguration()
        {
            HasKey(m => m.ID);
            Property(m => m.name).IsRequired();
        }
    }
}
