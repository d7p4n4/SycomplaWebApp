using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SycomplaWebApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GIGServerController : ControllerBase
    {
        // GET: api/GIGServer
        [HttpPost]
        [Route("loginRequest")]
        public LoginResponse LoginRequest(LoginRequest request)
        {
            return new LoginResponse() { Token = request.Token };
        }

        // POST: api/GIGServer
        [HttpPost]
        [Route("acceptAuthentication")]
        public AcceptAuthenticationResponse AcceptAuthentication(AcceptAuthenticationRequest request)
        {
            return new AcceptAuthenticationResponse() { Token = request.Token };
        }

        [HttpPost]
        [Route("insertuser")]
        public InsertResponse InsertUser(User request)
        {
            EFMethodsCAP eFMethods = new EFMethodsCAP();

            return new GigServerPersistentObjectService().Insert(new InsertRequest() { User = request });
        }

        [HttpPost]
        [Route("isunknownorinvalidtoken")]
        public IsUnknownOrInvalidTokenResponse IsUnkmnownOrInvalidToken(IsUnknownOrInvalidTokenRequest request)
        {

            return new GigServerPersistentObjectService().IsUnknownOrInvalidToken(request);
        }

    }
}
