using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STO.Model
{
    class Account
    {
        public Customer customer { get; private set; }

        public int ID { get; private set; }

        public List<Order> orders { get; private set; }

        private Account() { }
        public Account(Customer _customer, int _ID)
        {
            ID = _ID;
            customer = _customer;
            orders = new List<Order>();
        }


        public void AddOrder(Service _service, int id)
        {
            Order order = new Order(id);
            orders.Add(order);
            AddServiceToOrder(_service);
        }

        public void AddServiceToOrder(Service _service)
        {
            if (!orders.Last().isReady)
                orders.Last().AddService(_service);
        }
    }
}
