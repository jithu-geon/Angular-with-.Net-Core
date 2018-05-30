using System;
using Microsoft.AspNetCore.Mvc;
using myAngularProj.Models;

namespace myAngularProj
{
    [Route("api/[Controller]")]
    public class RegisterController : Controller
    {
        RegisterRepo _repo=new RegisterRepo();
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
                _repo.AddUser(value);
               return  new ObjectResult(value);
        }
    }
}