using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiseCase.Bussines.Abstract
{
    public interface IGenericService<T>
    {
        void T_Add(T t);
        void T_Delete(T t);
        void T_Update(T t);
        List<T> T_GetList();
        T T_GetByID(int id);
    }
}
