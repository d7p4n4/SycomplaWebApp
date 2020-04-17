using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSGIGServer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modul.Final.Class;

namespace SycomplaWebApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FireBaseController : ControllerBase
    {
        [HttpPost]
        [Route("FireBaseNotificationSend")]
        public Ac4yServiceResponse FireBaseNotificationSend(FireBaseRequest request)
        {
            return new FireBaseMethods().SendNotification(request);
        }
    }
}
