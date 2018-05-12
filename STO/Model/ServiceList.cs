using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STO.Model
{
    class ServiceList
    {
        public int ID { get; private set; }

        public List<Service> services { get; private set; }

        private ServiceList() { }

        public ServiceList(int _ID)
        {
            ID = _ID;
            services = new List<Service>();
        }

        public List<Service> Services
        {
            get { return services.ToList(); }
        }

        public int GetServicesCount()
        {
            return services.Count;
        }

        public void AddService(Service _service)
        {
            services.Add(_service);
        }

        public void DeleteService(Service _service)
        {
            services.Remove(_service);
        }

        public Service GetService(string _service)
        {
            return services.Find((service) => service.name == _service);
        }
    }
}
