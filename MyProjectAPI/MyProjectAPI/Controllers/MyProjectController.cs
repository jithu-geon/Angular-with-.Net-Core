using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyProjectAPI.Models;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net.Http.Headers;


namespace MyProjectAPI.Controllers
{
    [Route("api/[controller]")]

    public class MyProjectController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public IActionResult Get(Register reg )
        {
            List<Register> regInfo = new List<Register>();
            HttpClient client=new HttpClient();
            client.BaseAddress = new Uri("http://localhost:29490/");
            
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("api/widgets/InventorySummary").Result;
           
                var regResponse = response.Content.ReadAsStringAsync().Result;

                //  regInfo = JsonConvert.DeserializeObject<List<Register>>(regResponse);
            
            return Ok(regResponse);
        }

        [HttpPost]
         public IActionResult Post([FromBody]Register value)
        {
             if (value == null)
                {
                    return BadRequest("Recieved a Bad request");
                }
                
               return  new ObjectResult(value);
        }

    
    }
}
