using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Przyk_Kol.Models
{
    public class WyrobCukierniczy3
    {
        public int IdWyrobuCukierniczego { get; set; }
        public string Nazwa { get; set; }
        public float CenaZaSzt { get; set; }
        public string Typ { get; set; }
        public ICollection<Zamowienie_WyrobCukierniczy3> Zamowienie_WyrobCukierniczy { get; set; }

    }
}
