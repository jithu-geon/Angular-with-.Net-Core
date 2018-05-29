using System;
using Microsoft.AspNetCore.Mvc;

namespace myAngularProj
{
    [Route("api/[Controller]")]
    public class RegisterController : Controller
    {
        [HttpGet]
        public IActionResult Greetings() {
            return Ok("Hello from ASP.NET Core Web API.");
        }
    }
}