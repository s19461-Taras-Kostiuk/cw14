using Przyk_Kol.DTO;
using Przyk_Kol.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Przyk_Kol.Services
{
    public interface IDb
    {
        public IEnumerable<GET_Zamowienie_RESPONSE> GetZamowienies(string nazwisko);

        public string NoweZamow(NoweZamowienie_REQUEST nz, int idKlient);
    
    }
}
