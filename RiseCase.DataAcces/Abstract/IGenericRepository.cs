using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiseCase.DataAcces.Abstract
{
    public interface IGenericDAL<T> where T : class
    {
        //CRUD işlemleri için genel methodlar
        void Insert(T t);

        void Delete(T t);

        void Update(T t);
        List<T> GetList();

        T GetByID(int id);

    }
}
