using MyProjectAPI2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyProjectAPI2.Controllers
{
    public class SampleController : ApiController
    {
        reg[] registervalues = new reg[]
        {
            new reg {Name="jithu", email="jithu@jithu.com", password="sadf" }
        };
        
        public IEnumerable<reg> GetAllreg()
        {
            return registervalues;
        }
    }
}
