using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Przyk_Kol.Models;

namespace Przyk_Kol.Configurations
{
    public class WyrobCukierniczy_Config :
        IEntityTypeConfiguration<WyrobCukierniczy3>
    {

        public void Configure(EntityTypeBuilder<WyrobCukierniczy3> builder)
        {

            builder.HasKey(key => key.IdWyrobuCukierniczego);
            builder.Property(e => e.Nazwa).HasMaxLength(200).IsRequired();
            builder.Property(e => e.CenaZaSzt).IsRequired();
            builder.Property(e => e.Typ).HasMaxLength(40).IsRequired();


            var wyrobyCukiernicze = new List<WyrobCukierniczy3>();

            wyrobyCukiernicze.Add(new WyrobCukierniczy3 { IdWyrobuCukierniczego = 1,Nazwa="Mak",CenaZaSzt=20,Typ="Cukierka"});
            wyrobyCukiernicze.Add(new WyrobCukierniczy3 { IdWyrobuCukierniczego = 2, Nazwa = "Artek", CenaZaSzt = 30, Typ = "Wafelka" });
           
            builder.HasData(wyrobyCukiernicze);
     








        }
    }
}
