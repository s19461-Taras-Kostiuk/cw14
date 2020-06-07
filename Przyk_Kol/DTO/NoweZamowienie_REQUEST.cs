using Przyk_Kol.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Przyk_Kol.DTO
{
    public class NoweZamowienie_REQUEST
    {
        public DateTime dataPrzyjecia { get; set; }
        public string Uwagi { get; set; }
        public List<NowyWyrob_REQUEST>  wyroby { get; set; }
    }
}
