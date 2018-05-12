using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace STO.Model
{
    class Report
    {

        private Sto sto;
        private TextWriter output;
        public Report(TextWriter output, Sto sto)
        {
            this.output = output;
            this.sto = sto;
        }

        public void generate()
        {
            showCatalog(sto.GetServiceList());
            showOrders(sto.Orders);
        }

        private void showCatalog(ServiceList sl)
        {
            output.WriteLine(" ==== ServiceList ==== ");

            for (int i = 0; i < sl.GetServicesCount(); i++ )
            {                
                output.WriteLine();
                output.WriteLine("service \"" + sl.Services.ElementAt(i).name + "\":");
                output.WriteLine("\tDescription: " + sl.Services.ElementAt(i).description);
                output.WriteLine("\tImage URL: " + sl.Services.ElementAt(i).imageURL);
            }

            output.WriteLine();
            output.WriteLine(" ==== End ServiceList ==== ");

            showProductPrices(sl);
        }

        private void showProductPrices(ServiceList sl)
        {
            output.Write("\tPrices: ");
            for (int i = 0; i < sl.GetServicesCount(); i++ )
            {
                output.Write(sl.Services.ElementAt(i).price + "   ");
                output.WriteLine(sl.Services.ElementAt(i).name);
            }
        }

        private void showOrders(IEnumerable<Order> orders)
        {
            output.WriteLine(" ==== Orders ==== ");

            foreach (Order order in orders)
                showOrder(order);

            output.WriteLine();
            output.WriteLine(" ==== End Orders ==== ");
        }


        private void showOrder(Order order)
        {
            output.WriteLine();
            output.Write("Order #");
            output.Write(order.ID);
            output.WriteLine(":");

            output.Write("\tStatus: ");
            output.WriteLine(order.isReady);

            output.Write("\tTotal cost: ");
            output.WriteLine(order.coast);

            foreach (Account accounts in sto.Accounts)
                foreach (Order orders in accounts.orders)
                    if (orders == order)
                        showDeliveryContact(accounts.customer);

            showOrderedProducts(order);
        }


        private void showDeliveryContact(Customer customer)
        {
            output.Write("\tName: ");
            output.WriteLine(customer.Name);

            output.Write("\tAddress: ");
            output.WriteLine(customer.Address);

            output.Write("\tPhone: ");
            output.WriteLine(customer.Phone);
        }

        private void showOrderedProducts(Order order)
        {
            foreach (Service services in order.Services)
            {
                output.WriteLine( "\\Service:" );
                output.WriteLine(services.name);
            }           
        }

    }
}
