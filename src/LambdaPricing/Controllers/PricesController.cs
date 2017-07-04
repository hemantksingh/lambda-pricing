using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LambdaPricing.Controllers
{
    [Route("api/[controller]")]
    public class PricesController : Controller
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Price", "1" };
        }
    }
}
