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
    public class ContactManager : IContactService
    {
        IContactDal _icontactdal;

        public ContactManager(IContactDal icontactdal)
        {
            _icontactdal = icontactdal;
        }

        public void ContactAdd(Contact contact)
        {
            _icontactdal.Add(contact);
        }

        public List<Contact> ContactList()
        {
           return _icontactdal.List();
        }
    }
}
