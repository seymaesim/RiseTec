using Microsoft.EntityFrameworkCore;
using RiseCase.DataAcces.Abstract;
using RiseCase.DataAcces.Concrete;
using RiseCase.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiseCase.Bussines.Abstract
{
    public interface IUserService :  IGenericService<User>
    {
        bool T_GetByUserControl(User userModel);
    }
}
