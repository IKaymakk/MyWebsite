using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLaye.Abstract
{
    public interface IContactService
    {
        List<Contact> ContactList();
        void ContactAdd (Contact contact);
    }
}
