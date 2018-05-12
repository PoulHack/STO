using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STO.Model
{
    class Customer
    {
        public int ID { get; private set; }
        public string Name { get; private set; }
        public string Address { get; private set; }
        public string Phone { get; private set; }

        private Customer() { }
        public Customer(string name, string address, string phone, int _ID)
        {
            ID = _ID;
            Name = name;
            Address = address;
            Phone = phone;
        }
    }
}
