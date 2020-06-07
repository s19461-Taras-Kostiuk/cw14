using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Przyk_Kol.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Przyk_Kol.Configurations
{
    public class Klient_Config :
        IEntityTypeConfiguration<Klient3>
    {
        public void Configure(EntityTypeBuilder<Klient3> builder)
        {
            builder.HasKey(key => key.IdKlient);
            builder.Property(e => e.Imie).HasMaxLength(50).IsRequired();
            builder.Property(e => e.Nazwisko).HasMaxLength(60).IsRequired();


            var klienci = new List<Klient3>();

            klienci.Add(new Klient3 { IdKlient = 1, Imie = "Ja", Nazwisko = "AAA" });
            klienci.Add(new Klient3 { IdKlient = 2, Imie = "Ty", Nazwisko = "BBB" });
            klienci.Add(new Klient3 { IdKlient = 3, Imie = "On", Nazwisko = "CCC" });

            builder.HasData(klienci);

        }
    }
}
