using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
//using nihonhotelapi.Models;

namespace nihonhotelapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        public CityController()
        {
        }

        [HttpGet("")]
        public IEnumerable<string> GetStrings()
        {
            //return new List<string> { };
            return new string[]{"Atlanta,","Florida","Los Angeles"};
        }
    }
}