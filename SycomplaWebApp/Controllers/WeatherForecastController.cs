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
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<DummyController> _logger;

        public DummyController(ILogger<DummyController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get([FromQuery(Name = "dummy")] string dummy)
        {
            //return dummy;

            
            DummyResponse dummyResponse =
                DummyTwice(new DummyRequest()
                {
                    Dummy = dummy
                });

            if (dummyResponse.Result.Success())
            {
                return ("Minden szuper, dummy string: " + dummy);
            } 
            else
            {
                return dummyResponse.Result.Message;
            }
            
        }

        public DummyResponse DummyTwice(DummyRequest request)
        
        
        {
            DummyResult dummyResult = new DummyResult();
            DummyResponse dummyResponse = new DummyResponse(); 

            string dummyTwice = request.Dummy + " " + request.Dummy;

            if (request.Dummy != null)
            {
                DummySuccessResponse JSONObjSuccess = new DummySuccessResponse();
                JSONObjSuccess.Dummy = request.Dummy;

                dummyResult.SuccessResponse = JSONObjSuccess;

            } 
            else
            {

                DummyFailedResponse JSONObjFailed = new DummyFailedResponse();
                JSONObjFailed.StatusCode = 666665;

                dummyResult.FailedResponse = JSONObjFailed;
                
            }

            dummyResponse.DummyResult = dummyResult;


            if (dummyResponse.DummyResult.FailedResponse == null)
            {
                dummyResponse.Result = new Ac4yProcessResult() { Code = Ac4yProcessResult.SUCCESS };
            }
            else
            {
                dummyResponse.Result = new Ac4yProcessResult() { Code = Ac4yProcessResult.FAIL, Message = "Nincs paraméter!" };
            }
            return dummyResponse;
        }
    }
}
