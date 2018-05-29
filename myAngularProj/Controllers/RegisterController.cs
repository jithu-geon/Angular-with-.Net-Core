using System;
using Microsoft.AspNetCore.Mvc;
using myAngularProj.Models;

namespace myAngularProj
{
    [Route("api/[Controller]")]
    public class RegisterController : Controller
    {
        [HttpGet]
        public IActionResult Greetings() {
            return Ok("Hello from ASP.NET Core Web API.");
        }
        [HttpPost]
         public IActionResult Post([FromBody]RegisterModel value)
        {
             if (value == null)
                {
                    return BadRequest("Recieved a Bad request");
                }
               return  Ok(value);
        }
    }
}