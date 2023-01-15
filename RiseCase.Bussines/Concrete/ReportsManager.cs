using Microsoft.EntityFrameworkCore;
using Npgsql;
using RiseCase.Bussines.Abstract;
using RiseCase.Bussines.DAL;
using RiseCase.DataAcces.Concrete;
using RiseCase.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace RiseCase.Bussines.Concrete
{
    public class ReportsManager : IReportsService
    {
        private readonly Context _context;

        public ReportsManager(Context context)
        {
            _context = context;
        }

        public IEnumerable<UserDetailReport> UserDetailList()
        {
            List<UserDetailReport> model = new List<UserDetailReport>();
            var efquery = (from u in _context.Users
                           join c in _context.Contacts on u.ID equals c.UserID
                           join k in _context.Kinds on c.KindID equals k.ID
                           select new
                           {
                               Ad = u.Ad,
                               SoyAd = u.SoyAd,
                               Firma = u.Firma,
                               IletisimTipi = k.TurAdi,
                               IletisimBilgisi = c.ContactValue
                           });

            foreach (var item in efquery)
            {
                model.Add(new UserDetailReport
                {
                    Ad = item.Ad,
                    Soyad = item.SoyAd,
                    Firma = item.Firma,
                    IletisimTipi = item.IletisimTipi,
                    IletisimBilgisi = item.IletisimBilgisi
                });
            }
            return model;
        }

        public void T_Add(ReportsDAL t)
        {
            throw new NotImplementedException();
        }

        public void T_Delete(ReportsDAL t)
        {
            throw new NotImplementedException();
        }

        public ReportsDAL T_GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<ReportsDAL> T_GetList()
        {
            throw new NotImplementedException();
        }

        public void T_Update(ReportsDAL t)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserDetailLocationCountReport> UserLogationCountList()
        {
            List<UserDetailLocationCountReport> model = new List<UserDetailLocationCountReport>();

            var query = from u in _context.Set<User>()
                        join c in _context.Set<Contact>() on u.ID equals c.UserID
                        join k in _context.Set<Kind>() on c.KindID equals k.ID
                        where k.TurAdi == "Konum"
                        group c by c.ContactValue
                        into g
                        select new { g.Key, Count = g.Count() };

            foreach (var item in query)
            {
                model.Add(new UserDetailLocationCountReport
                {
                    Konum = item.Key,
                    KisiSayisi = item.Count
                });
            }
            return model;
        }

        public IEnumerable<UserDetailLocationCountReport> UserLocationCountParameterList(string konum)
        {
            List<UserDetailLocationCountReport> model = new List<UserDetailLocationCountReport>();

            var query = from u in _context.Set<User>()
                        join c in _context.Set<Contact>() on u.ID equals c.UserID
                        join k in _context.Set<Kind>() on c.KindID equals k.ID
                        where k.TurAdi == "Konum" && c.ContactValue == konum
                        group c by c.ContactValue
                        into g
                        select new { g.Key, Count = g.Count() };

            foreach (var item in query)
            {
                model.Add(new UserDetailLocationCountReport
                {
                    Konum = item.Key,
                    KisiSayisi = item.Count
                });
            }
            return model;
        }


        public IEnumerable<UserDetailLocationNumberCountReport> UserLocationNumberCountParameterList(string konum)
        {
            List<UserDetailLocationNumberCountReport> model = new List<UserDetailLocationNumberCountReport>();
            var query = (from u in _context.Set<User>()
                             join c in _context.Set<Contact>() on u.ID equals c.UserID
                             group c by new {  c.KindID, c.ContactValue } into g
                             select new
                             {
                                 g.Key,
                                 Score = (from t2 in g where t2.KindID == 2 select t2.ContactValue).Count()

                             }).Where(x => x.Key.ContactValue == konum);
            foreach (var item in query)
            {
                model.Add(new UserDetailLocationNumberCountReport
                {
                    Konum = konum,
                    KisiTelefonSayisi = item.Score
                });
            }

            return model;
        }
    }
}
