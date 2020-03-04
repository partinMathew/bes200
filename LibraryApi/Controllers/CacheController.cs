using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApi.Controllers
{
    public class CacheController : Controller
    {
        [HttpGet("/time")]
        [ResponseCache(Duration = 30, Location = ResponseCacheLocation.Any)]
        public ActionResult<string> GetTime()
        {
            return Ok(new { data = $"The time is {DateTime.Now.ToLongTimeString()}" });
        }
    }
}
