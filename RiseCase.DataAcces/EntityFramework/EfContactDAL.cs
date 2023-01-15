using Microsoft.EntityFrameworkCore;
using RiseCase.DataAcces.Abstract;
using RiseCase.DataAcces.Concrete;
using RiseCase.DataAcces.Repository;
using RiseCase.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiseCase.DataAcces.EntityFramework
{
    public class EfContactDAL : GenericRepository<Contact>, IContactDAL
    {
       
    }
}
