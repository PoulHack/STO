using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STO.Model
{
    class Warehouse
    {
        public Dictionary<Material, int> materials { get; private set; }

        public Warehouse()
        {

        }

        public void AddMaterials(Material _material, int _amount)
        {
            this.materials.Add(_material, _amount);
        }
    }
}
