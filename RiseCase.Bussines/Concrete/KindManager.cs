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
    public class KindManager : IKindService
    {
        IKindDAL _kindDAL;

        public KindManager(IKindDAL kindDAL)
        {
            _kindDAL = kindDAL;
        }

        public void T_Add(Kind t)
        {
            _kindDAL.Insert(t);
        }
        public void T_Delete(Kind t)
        {
            _kindDAL.Delete(t);
        }

        public Kind T_GetByID(int id)
        {
            return _kindDAL.GetByID(id);
        }

        public List<Kind> T_GetList()
        {
            return _kindDAL.GetList();
        }

        public void T_Update(Kind t)
        {
            _kindDAL.Update(t);
        }
    }
}
