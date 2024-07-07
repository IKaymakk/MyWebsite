using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLaye.Abstract
{
    public interface IMyservicesService
    {
        List<MyService> ServicesList();
        void AddService (MyService service);
        void UpdateService (MyService service);
        void DeleteService (MyService service);
    }
}
