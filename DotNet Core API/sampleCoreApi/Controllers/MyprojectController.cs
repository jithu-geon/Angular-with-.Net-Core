using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using sampleCoreApi.Models;


namespace sampleCoreApi.Controllers
{
    [Route("api/[controller]")]
    public class MyprojectController : Controller
    {
       
        [HttpPost]
        public IActionResult Register([FromBody]registerModel value)
        {
             if (value == null)
                {
                    return BadRequest("Recieved a Bad request");
                }
               return  Ok(value);
        }
    }
}
