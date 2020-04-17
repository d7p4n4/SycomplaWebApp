using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSGIGServer;
using CSGIGUserServer;
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
        [Route("loginRequestDepecrated")]
        public LoginResponse LoginRequest(LoginRequest request)
        {
            return new LoginResponse() { fbToken = request.fbToken };
        }

        [HttpGet]
        [Route("getvixapikey")]
        public string GetVixApiKey()
        {
            return "81c38db80f488127b6a75b34b447efa3";
        }

        // POST: api/GIGServer
        [HttpPost]
        [Route("acceptAuthentication")]
        public AcceptAuthenticationResponse AcceptAuthentication(AcceptAuthenticationRequest request)
        {
            return new AcceptAuthenticationResponse() { fbToken = request.fbToken };
        }

        [HttpPost]
        [Route("insertuser")]
        public InsertResponse InsertUser(User request)
        {
            EFUserMethodsCAP eFMethods = new EFUserMethodsCAP();

            return new GigServerPersistentObjectService().Insert(new InsertRequest() { User = request });
        }

        [HttpPost]
        [Route("isunknownorinvalidtoken")]
        public IsUnknownOrInvalidTokenResponse IsUnkmnownOrInvalidToken(IsUnknownOrInvalidTokenRequest request)
        {

            return new GigServerPersistentObjectService().IsUnknownOrInvalidToken(request);
        }

        [HttpPost]
        [Route("loginrequest")]
        public LoginRequestResponse LoginRequest(LoginRequestRequest request)
        {

            return new GigServerPersistentObjectService().LoginRequest(request);
        }

        [HttpPost]
        [Route("authenticationrequest")]
        public AuthenticatioRequestResponse AuthenticationRequest(AuthenticatioRequestRequest request)
        {

            return new AuthenticationServerClient("https://fcm.googleapis.com/fcm/send", "AAAAMrfsOZQ:APA91bE_BRElbjcU7XZyAZn6Yw8C8bhOS1vd3gWGch9am14IepEIJleW_ZKGACIyGzz3gxuQpLwVUcZuZcsRWg7k0UbnJ3_SWL87tCT41I6ALga7lnANK-WlhV94mOn5b08mIVaVv1Dx").AuthenticatioRequest(request);
        }

        [HttpPost]
        [Route("signup")]
        public FirebaseSignUpResponse SignUp(FirebaseSignUpRequest request)
        {
            return new FirebaseSignUpServerClient().FirebaseSignUp(new FirebaseSignUpRequest() { fbToken = request.fbToken });
        }

    }
}
