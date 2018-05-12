using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STO.Model
{
    class Sto
    {
        public ServiceList serviceList { get; private set; }

        public List<Order> orders { get; private set; }

        public List<Account> accounts { get; private set; }

        public Sto()
        {
            serviceList = new ServiceList(1);
            orders = new List<Order>();
            accounts = new List<Account>();
        }

        public IList<Account> Accounts
        {
            get { return accounts; }
        }

        public void AddAccount(Account account)
        {
            accounts.Add(account);
        }

        public IList<Order> Orders
        {
            get { return orders; }
        }

        public ServiceList GetServiceList()
        {
            return serviceList;
        }

        public int GetOrdersCount()
        {
            return orders.Count;
        }

        public void AddOrder(Order order)
        {
            orders.Add(order);
        }
    }
}
