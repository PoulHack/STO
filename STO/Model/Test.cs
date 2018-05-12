using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STO.Model
{
    class Test
    {
        public Sto generate()
        {
            Sto sto = new Sto();
            AddServices(sto.GetServiceList());
            AddOrders(sto, sto.GetServiceList());
            return sto;
        }

        private void AddServices(ServiceList sl)
        {
            Material m1 = new Material("material1",1);
            Material m2 = new Material("material2",2);
            Material m3 = new Material("material3",3);

            Service s1 = new Service(400, "замена лобового стекла", ".........", ".......\\image.jpg", 1,m1,2);
            Service s2 = new Service(800, "замена переднего бампера", ".........", ".......\\image2.jpg", 2,m2,3);
            Service s3 = new Service(1000, "замена тормозов", ".........", ".......\\image3.jpg", 3,m3,5);

            sl.AddService(s1);
            sl.AddService(s2);
            sl.AddService(s3);
        }

        private void AddOrders(Sto sto, ServiceList sl)
        {
            Customer c1 = new Customer("Vanya", "dom 3", "333-33-33",1);
            Customer c2 = new Customer("Petya", "dom 5", "333-33-34",2);

            Account acc1 = new Account(c1,1);
            Account acc2 = new Account(c2,2);

            acc1.AddOrder(sl.GetService("замена лобового стекла"), sto.GetOrdersCount());
            foreach (Order order in acc1.orders)
                sto.AddOrder(order);

            acc2.AddOrder(sl.GetService("замена тормозов"), sto.GetOrdersCount());
            acc2.AddServiceToOrder(sl.GetService("замена переднего бампера"));
            foreach (Order order in acc2.orders)
                sto.AddOrder(order);

            sto.AddAccount(acc1);
            sto.AddAccount(acc2);

                
            
        }
    }
}
