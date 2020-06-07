using Microsoft.AspNetCore.Mvc;
using Przyk_Kol.DTO;
using Przyk_Kol.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Przyk_Kol.Controllers
{
    [Route("api/orders")]
    [ApiController]
    public class zad1 : ControllerBase

    {
        private readonly IDb _service;

        public zad1(IDb service)
        {
            _service = service;
        }


        [HttpGet]
        public IActionResult GetOrders(string nazwisko)
        {
            return Ok(_service.GetZamowienies(nazwisko));
        }



     


    
    }
}


