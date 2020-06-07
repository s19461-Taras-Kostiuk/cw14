using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Przyk_Kol.Models
{
    public class Zamowienie3
    {
        public int IdZamowienia { get; set; }
        public DateTime DataPrzyjecia { get; set; }
        public DateTime DataRealizacji { get; set; }
        public string Uwagi { get; set; }
        public int IdKlient { get; set; }
        public int IdPracownik { get; set; }

        public Klient3 klient3 { get; set; }
        public Pracownik3 pracownik3 { get; set; }
        public ICollection<Zamowienie_WyrobCukierniczy3> Zamowienie_WyrobCukiernicze { get; set; }
    }
}
