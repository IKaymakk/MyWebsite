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
    public class AdminManager : IAdminService
    {
        IAdminDal _iadmindal;

        public AdminManager(IAdminDal iadmindal)
        {
            _iadmindal = iadmindal;
        }

        public Admin GetAdmin(string name, int password)
        {
            return _iadmindal.Get(x => x.AdminName == name && x.AdminPassword == password);
        }
    }
}
