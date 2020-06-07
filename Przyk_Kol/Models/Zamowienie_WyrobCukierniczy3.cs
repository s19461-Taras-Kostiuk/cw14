using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Przyk_Kol.Models
{
    public class Zamowienie_WyrobCukierniczy3
    {

        public int IdWyrobuCukierniczego { get; set; }
        public int IdZamowienia { get; set; }
        public int Ilosc { get; set; }
        public string Uwagi { get; set; }
        public WyrobCukierniczy3 wyrobCukierniczy { get; set; }
        public Zamowienie3 zamowienie { get; set; }



    }
}
