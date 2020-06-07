using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Przyk_Kol.Models;

namespace Przyk_Kol.Configurations
{
    public class Pracownik_Config :
        IEntityTypeConfiguration<Pracownik3>
    {

        public void Configure(EntityTypeBuilder<Pracownik3> builder)
        {
            builder.HasKey(key => key.IdPracownik);
            builder.Property(e => e.Imie).HasMaxLength(50).IsRequired();
            builder.Property(e => e.Nazwisko).HasMaxLength(60).IsRequired();


            var pracowniki = new List<Pracownik3>();

            pracowniki.Add(new Pracownik3 { IdPracownik = 1, Imie = "Ala", Nazwisko = "AAA" });
            pracowniki.Add(new Pracownik3 { IdPracownik = 2, Imie = "Bob", Nazwisko = "BBB" });
            pracowniki.Add(new Pracownik3 { IdPracownik = 3, Imie = "Cezary", Nazwisko = "CCC" });

            builder.HasData(pracowniki);

        }
    }
}
