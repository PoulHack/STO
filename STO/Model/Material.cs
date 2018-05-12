using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STO.Model
{
    class Material
    {
        public int ID { get; private set; }

        public string name { get; private set; }

        private Material() { }

        public Material (string _name, int _ID)
        {
            ID = _ID;
            name = _name;
        }
    }
}
