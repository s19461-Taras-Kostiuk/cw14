using Microsoft.AspNetCore.Mvc;
using Przyk_Kol.DTO;
using Przyk_Kol.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Przyk_Kol.Controllers
{
    [ApiController]
    public class zad2 : ControllerBase
    {


        private readonly IDb _service;

        public zad2(IDb service)
        {
            _service = service;
        }



        [HttpGet("{id}")]
        [Route("api/clients/{id}/orders")]
        public IActionResult NoweZamow(int id, NoweZamowienie_REQUEST nz)
        {
            
            var odp =_service.NoweZamow(nz, id));
        
            if(odp == null)
            {
                return BadRequest();
            }
            return Ok(odp);
        
        }
    }
}
