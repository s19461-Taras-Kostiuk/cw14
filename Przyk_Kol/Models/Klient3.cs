using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Przyk_Kol.Models
{
    public class Klient3
    {
        public int IdKlient { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public ICollection<Zamowienie3> Zamowienia { get; set; }
    }
}
