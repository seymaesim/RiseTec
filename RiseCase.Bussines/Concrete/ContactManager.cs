using RiseCase.Bussines.Abstract;
using RiseCase.DataAcces.Abstract;
using RiseCase.DataAcces.EntityFramework;
using RiseCase.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiseCase.Bussines.Concrete
{
    public class ContactManager : IContactService
    {
        IContactDAL _contactDAL;

        public ContactManager(IContactDAL contactDAL)
        {
            _contactDAL = contactDAL;
        }

        public void T_Add(Contact t)
        {
            _contactDAL.Insert(t);
        }

        public void T_Delete(Contact t)
        {
             _contactDAL.Delete(t);
        }

        public Contact T_GetByID(int id)
        {
            return _contactDAL.GetByID(id);
        }

        public List<Contact> T_GetList()
        {
            return _contactDAL.GetList();
        }

        public void T_Update(Contact t)
        {
           _contactDAL.Update(t);
        }
    }
}

