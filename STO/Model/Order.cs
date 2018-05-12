using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STO.Model
{
    class Order
    {
        public List<Service> services { get; private set; }

        public int ID { get; private set; }

        public int coast { get; private set; }

        public bool isReady { get; private set; }

        private Order() { }
        public Order(int id)
        {
            ID = id;
            services = new List<Service>();
            coast = 0;
            isReady = false;
        }

        public IEnumerable<Service> Services
        {
            get { return services; }
        }

        public void AddService(Service _service)
        {
            services.Add(_service);
            CountingTheCost(_service, 1);
        }

        public void DeleteService(Service _service)
        {
            services.Remove(_service);
            CountingTheCost(_service, -1);
        }

        private void CountingTheCost(Service _service, int i)
        {
            coast += _service.price*i;
        }

        public void ChangeReady()
        {
            isReady = true;
        }
    }
}
