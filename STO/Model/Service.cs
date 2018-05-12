using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STO.Model
{
    class Service
    {
        public int ID { get; private set; }

        public int price {get; private set;}

        public string name { get; private set; }

        public string description { get; private set; }

        public string imageURL { get; private set; }

        public bool hidden { get; set; }

        public Material material { get; private set; }

        public int materialAmount { get; private set; }

        private Service() { }
        public Service(int _price, string _name, string _description, string _imageURL, int _ID, Material _material, int _amount)
        {
            material = _material;
            materialAmount = _amount;
            ID = _ID;
            price = _price;
            name = _name;
            description = _description;
            imageURL = _imageURL;
            hidden = false;
        }

    }
}
