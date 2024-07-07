using BusinessLaye.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLaye.Concrete
{
    public class MyServiceManager : IMyservicesService
    {
        IServiceDal _iservicedal;
        public MyServiceManager(IServiceDal iservicedal)
        {
            _iservicedal = iservicedal;
        }
        public void AddService(MyService service)
        {
            _iservicedal.Add(service);
        }

        public void DeleteService(MyService service)
        {
            _iservicedal.Remove(service);
        }

        public List<MyService> ServicesList()
        {
            return _iservicedal.List();
        }

        public void UpdateService(MyService service)
        {
            _iservicedal.Update(service);
        }
    }
}
