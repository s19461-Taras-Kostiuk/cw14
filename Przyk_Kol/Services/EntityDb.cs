using Przyk_Kol.DTO;
using Przyk_Kol.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Przyk_Kol.Services
{
    public class EntityDb : IDb
    {

        private readonly CukierniaDbContext2 _context;
        
        public EntityDb(CukierniaDbContext2 context)
        {
            _context = context;
        }


        public IEnumerable<GET_Zamowienie_RESPONSE> GetZamowienies(string nazwisko)
        {
            var response = new List<GET_Zamowienie_RESPONSE>();

            if (nazwisko != null)
            {
                var sqlQuery = from client in _context.klient3
                               join order in _context.zamowienie on client.IdKlient equals order.IdKlient
                               join orderConfection in _context.zamowienie_Wyroby on order.IdZamowienia equals orderConfection.IdZamowienia
                               join confection in _context.wyrobCukierniczy on orderConfection.IdWyrobuCukierniczego equals confection.IdWyrobuCukierniczego
                               where client.Nazwisko == nazwisko
                               select new
                               {
                                   order.IdZamowienia,
                                   order.DataPrzyjecia,
                                   order.DataRealizacji,
                                   order.Uwagi,
                                   confection.Nazwa,
                                   confection.CenaZaSzt,
                                   confection.Typ
                               };

                foreach (var output in sqlQuery)
                {
                    response.Add(new GET_Zamowienie_RESPONSE
                    {
                        IdZamowienia = output.IdZamowienia,
                        DataPrzyjecia = output.DataPrzyjecia,
                        DataRealizacji = output.DataRealizacji,
                        Uwagi = output.Uwagi,
                        Nazwa = output.Nazwa,
                        CenaZaSzt = output.CenaZaSzt,
                        Typ = output.Typ
                    });
                }

                return response;
            }
            else
            {
                var sqlQuery = from client in _context.klient3
                               join order in _context.zamowienie on client.IdKlient equals order.IdKlient
                               join orderConfection in _context.zamowienie_Wyroby on order.IdZamowienia equals orderConfection.IdZamowienia
                               join confection in _context.wyrobCukierniczy on orderConfection.IdWyrobuCukierniczego equals confection.IdWyrobuCukierniczego
                               select new
                               {
                                   order.IdZamowienia,
                                   order.DataPrzyjecia,
                                   order.DataRealizacji,
                                   order.Uwagi,
                                   confection.Nazwa,
                                   confection.CenaZaSzt,
                                   confection.Typ
                               };

                foreach (var output in sqlQuery)
                {
                    response.Add(new GET_Zamowienie_RESPONSE
                    {
                        IdZamowienia = output.IdZamowienia,
                        DataPrzyjecia = output.DataPrzyjecia,
                        DataRealizacji = output.DataRealizacji,
                        Uwagi = output.Uwagi,
                        Nazwa = output.Nazwa,
                        CenaZaSzt = output.CenaZaSzt,
                        Typ = output.Typ
                    });
                }

                return response;
            }
        }


        public string NoweZamow(NoweZamowienie_REQUEST nz, int idKlient)
        {

            foreach (NowyWyrob_REQUEST w in nz.wyroby)
            {
                if (!(_context.wyrobCukierniczy.Any(e => e.Nazwa == w.Wyrob)))
                {
                    return "U nas w cukierni takiego nie ma";
                }
            }


            var noweza = new Zamowienie3 {
                IdPracownik = 1,
                DataPrzyjecia = nz.dataPrzyjecia,
                IdKlient = idKlient, 
                Uwagi = nz.Uwagi, 
                Zamowienie_WyrobCukiernicze = new List<Zamowienie_WyrobCukierniczy3>()
            };
           
            
            foreach (NowyWyrob_REQUEST w in nz.wyroby)
            {
                int id = _context.wyrobCukierniczy.FirstOrDefault(e => e.Nazwa == w.Wyrob).IdWyrobuCukierniczego;
                noweza.Zamowienie_WyrobCukiernicze.Add(new Zamowienie_WyrobCukierniczy3 { IdWyrobuCukierniczego = id, Uwagi = w.Uwagi, Ilosc = w.Ilosc });
            }

            _context.Add(noweza);
            _context.SaveChanges();

            return "added new zamowienie";

        }
    }
}
