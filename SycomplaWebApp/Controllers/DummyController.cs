using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Modul.Final.Class;
using Newtonsoft.Json;

namespace SycomplaWebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DummyController : ControllerBase
    {
        [HttpPost]
        public Ac4yServiceResponse Post(DummyClass dummy)
        {
            DummyResponse dummyResponse =
                new DummyMethods().DummyTwice(new DummyRequest()
                {
                    Dummy = dummy
                });

            return dummyResponse;

        }

        [HttpGet]
        public Ac4yServiceResponse Get(DummyClass dummy)
        {
            //return dummy;

            
            DummyResponse dummyResponse =
                new DummyMethods().DummyTwice(new DummyRequest()
                {
                    Dummy = dummy
                });

            return dummyResponse;
            
        }

        [HttpGet]
        [Route("GetParameter")]
        public Ac4yServiceResponse GetParameter([FromQuery(Name = "dummy")] string dummy)
        {

            DummyResponse dummyResponse =
                new DummyMethods().DummyTwice(new DummyRequest()
                {
                    Dummy = new DummyClass() { Dummy = dummy }
                });

            return dummyResponse;

        }


    }
}
