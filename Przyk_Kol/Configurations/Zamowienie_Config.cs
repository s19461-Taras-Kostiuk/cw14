using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Przyk_Kol.Models;


namespace Przyk_Kol.Configurations
{
    public class Zamowienie_Config :
        IEntityTypeConfiguration<Zamowienie3>
    {
        
        public void Configure(EntityTypeBuilder<Zamowienie3> builder)
        {

            builder.HasKey(key => key.IdZamowienia );
            builder.HasOne(e => e.klient3).WithMany().HasForeignKey(e => e.IdKlient);
            builder.HasOne(e => e.pracownik3).WithMany().HasForeignKey(e => e.IdPracownik);
            builder.Property(e => e.DataPrzyjecia).IsRequired();
            builder.Property(e => e.DataRealizacji).IsRequired();
            builder.Property(e => e.Uwagi).HasMaxLength(300).IsRequired();
            var zamowienia = new List<Zamowienie3>();

            zamowienia.Add(new Zamowienie3
            {
                IdZamowienia = 1,
                IdKlient = 1,
                IdPracownik = 1,
                DataPrzyjecia = Convert.ToDateTime("2006-01-10"),
                DataRealizacji = Convert.ToDateTime("2007-01-10"),
                Uwagi = "Wszystko ok"
            }) ;
            zamowienia.Add(new Zamowienie3
            {
                IdZamowienia = 2,
                IdKlient = 2,
                IdPracownik = 2,
                DataPrzyjecia = Convert.ToDateTime("2008-01-10"),
                DataRealizacji = Convert.ToDateTime("2009-01-10"),
                Uwagi = "Cos nie poszlo :( "
            });
           

            builder.HasData(zamowienia);















        }
    }
}
