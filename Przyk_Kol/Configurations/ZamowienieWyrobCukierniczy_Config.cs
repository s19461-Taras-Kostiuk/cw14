using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Przyk_Kol.Models;



namespace Przyk_Kol.Configurations
{
    public class ZamowienieWyrobCukierniczy_Config :
        IEntityTypeConfiguration<Zamowienie_WyrobCukierniczy3>
    {
        public void Configure(EntityTypeBuilder<Zamowienie_WyrobCukierniczy3> builder)
        {
            builder.HasKey(key =>new { key.IdWyrobuCukierniczego, key.IdZamowienia });
            builder.HasOne(e => e.zamowienie).WithMany().HasForeignKey(e => e.IdZamowienia);
            builder.HasOne(e => e.wyrobCukierniczy).WithMany().HasForeignKey(e => e.IdWyrobuCukierniczego);
            builder.Property(e => e.Ilosc).IsRequired();
            builder.Property(e => e.Uwagi).HasMaxLength(300).IsRequired();
            

            var zamow_wyrob = new List<Zamowienie_WyrobCukierniczy3>();

            zamow_wyrob.Add(new Zamowienie_WyrobCukierniczy3
            {
                IdWyrobuCukierniczego = 1,
                IdZamowienia = 1,
                Ilosc=12,
                Uwagi="Bardzo dobre slodycze"

            }) ;

            zamow_wyrob.Add(new Zamowienie_WyrobCukierniczy3
            {
                IdWyrobuCukierniczego = 2,
                IdZamowienia = 2,
                Ilosc = 19,
                Uwagi = "Bardzo dobre wafelki"
            });


            builder.HasData(zamow_wyrob);
        }
    }
}
