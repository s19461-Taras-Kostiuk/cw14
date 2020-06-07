using Microsoft.EntityFrameworkCore;
using Przyk_Kol.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Przyk_Kol.Models
{
    public class CukierniaDbContext2 : DbContext
    {

        public DbSet<Pracownik3> pracownik3 { get; set; }
        public DbSet<Klient3> klient3 { get; set; }
        public DbSet<Zamowienie3> zamowienie { get; set; }
        public DbSet<WyrobCukierniczy3> wyrobCukierniczy { get; set; }
        public DbSet<Zamowienie_WyrobCukierniczy3> zamowienie_Wyroby { get; set; }

        public CukierniaDbContext2(DbContextOptions opt)
           : base(opt)
        {

        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new Klient_Config());
            modelBuilder.ApplyConfiguration(new Pracownik_Config());
            modelBuilder.ApplyConfiguration(new WyrobCukierniczy_Config());
            modelBuilder.ApplyConfiguration(new Zamowienie_Config());
            modelBuilder.ApplyConfiguration(new ZamowienieWyrobCukierniczy_Config());
        }


    }
}
