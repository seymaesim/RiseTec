using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using RiseCase.DataAcces.Abstract;
using RiseCase.DataAcces.Concrete;
using RiseCase.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiseCase.DataAcces.Repository
{
    public class GenericRepository<T> : IGenericDAL<T> where T : class
    {
        //gelen listeyi sil
        public void Delete(T t)
        {
            using var c = new Context();
            c.Remove(t);
            c.SaveChanges();
        }
 
        public T GetByID(int id)
        {
            using var c = new Context();

            return c.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            using var c = new Context();
            return c.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            using var c = new Context();
            c.Add(t);
            c.SaveChanges();
        }

        public void Update(T t)
        {
            using var c = new Context();
            c.Update(t);
            c.SaveChanges();
        }

    
    }
}
