using Microsoft.EntityFrameworkCore;
using RiseCase.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiseCase.DataAcces.Concrete
{
    public class Context : DbContext 
    {
        //public Context(DbContextOptions<Context> options) :
        //    base(options)
        //{ 
        //}

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.UseSerialColumns();
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost; Database=dbRiseTec; Port=5432; User Id=postgres; Password=*");
        }

        public DbSet<User> Users { get; set; } //Kişilerin bilgileri
        public DbSet<Contact> Contacts { get; set; } //İletişim bilgileri  
        public DbSet<Kind> Kinds { get; set; }  //İletişim tür bilgileri
    }
}
