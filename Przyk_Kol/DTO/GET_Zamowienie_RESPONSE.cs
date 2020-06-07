using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Przyk_Kol.DTO
{
    public class GET_Zamowienie_RESPONSE
    {
        public int IdZamowienia { get; set; }
        public DateTime DataPrzyjecia { get; set; }
        public DateTime DataRealizacji { get; set; }
        public string Uwagi { get; set; }
        public string Nazwa { get; set; }
        public float CenaZaSzt { get; set; }
        public string Typ { get; set; }
    }
}
