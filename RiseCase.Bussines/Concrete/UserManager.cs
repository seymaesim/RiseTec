using Microsoft.EntityFrameworkCore;
using RiseCase.Bussines.Abstract;
using RiseCase.DataAcces.Abstract;
using RiseCase.DataAcces.Concrete;
using RiseCase.DataAcces.EntityFramework;
using RiseCase.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace RiseCase.Bussines.Concrete
{
    public class UserManager : IUserService
    {
        IUserDAL _userDAL;

        User model = new User();
        public UserManager(IUserDAL userDAL)
        {
            _userDAL = userDAL;
        }

        public void T_Add(User t)
        {
            _userDAL.Insert(t);
        }

        public void T_Delete(User t)
        {
            _userDAL.Delete(t);
        }

        public void T_Update(User t)
        {
            _userDAL.Update(t);
        }

        public List<User> T_GetList()
        {
            return _userDAL.GetList();
        }

        public User T_GetByID(int id)
        {
            return _userDAL.GetByID(id);
        }

        public bool T_GetByUserControl(User userModel)
        {
            int ID = 0;
            try
            {
                ID = _userDAL.GetList()?.Where(x => x.Ad == userModel.Ad && x.SoyAd == userModel.SoyAd && x.Firma == userModel.Firma)?.FirstOrDefault()?.ID ?? 0;
                if (ID == 0)
                {
                    return false;
                }
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
         
        }
    }
}
