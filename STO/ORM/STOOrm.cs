using STO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace STO.ORM
{
    class STOOrm
    {
        public static void Save(Sto network)
        {
            using (var context = new STODbContext())
            {
                context.Database.Delete();
                context.Orders.AddRange(network.Orders);
                context.Accounts.AddRange(network.Accounts);
                context.Services.AddRange(network.serviceList.Services);
                context.SaveChanges();
            }
        }

        public static Sto Restore()
        {
            Sto network = new Sto();

            using (var context = new STODbContext())
            {
                var servicesQuery = context.Services
                                            .Include(s => s.material);

                foreach (Service service in servicesQuery)
                {
                    network.serviceList.AddService(service);
                }

                var accountQuery = context.Accounts
                                            .Include(a => a.customer);

                foreach (Account acc in accountQuery)
                    network.Accounts.Add(acc);

                var ordersQuery = context.Orders;

                foreach (Order o in ordersQuery)
                    network.Orders.Add(o);

            }

            return network;
        }

    }
}
