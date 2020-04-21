using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSGIGAuthenticationServer;
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
        public AuthenticationRequestResponse AuthenticationRequest(AuthenticationRequestRequest request)
        {
            return new AuthenticationServerObjectService()
            {
                Server = "https://fcm.googleapis.com/fcm/send",
                ServerKey = "AAAAMrfsOZQ:APA91bE_BRElbjcU7XZyAZn6Yw8C8bhOS1vd3gWGch9am14IepEIJleW_ZKGACIyGzz3gxuQpLwVUcZuZcsRWg7k0UbnJ3_SWL87tCT41I6ALga7lnANK-WlhV94mOn5b08mIVaVv1Dx"
            }.AuthenticationRequest(new AuthenticationRequestRequest() { fbToken = request.fbToken, CheckData = request.CheckData });

        }

        [HttpPost]
        [Route("signup")]
        public SignUpRequestResponse SignUp(SignUpRequestRequest request)
        {
            return new GigServerPersistentObjectService().SignUpRequest(new SignUpRequestRequest() { fbToken = request.fbToken });
        }

        [HttpPost]
        [Route("getuserfrombytoken")]
        public GetUserFromByTokenResponse GetUserFromByToken(GetUserFromByTokenReqest request)
        {
            return new GigServerPersistentObjectService().GetUserFromByToken(new GetUserFromByTokenReqest() { fbToken = request.fbToken });
        }

        [HttpPost]
        [Route("checkserialnumber")]
        public CheckSerialNumberObjectResponse CheckSerialNumber(CheckSerialNumberObjectRequest request)
        {
            return new GigServerPersistentObjectService().CheckSerialNumber(new CheckSerialNumberObjectRequest() { 
                SerialNumber = request.SerialNumber,
                fbToken = request.fbToken
            });
        }

        [HttpPost]
        [Route("acceptrequest")]
        public AcceptRequestResponse AcceptRequest(AcceptRequestRequest request)
        {
            return new GigServerPersistentObjectService().AcceptRequest(new AcceptRequestRequest() { UserToken = request.UserToken });
        }

        [HttpPost]
        [Route("attachnewdevice")]
        public AttachNewDeviceObjectResponse AttachNewDevice(AttachNewDeviceObjectRequest request)
        {
            return new GigServerPersistentObjectService().AttachNewDevice(new AttachNewDeviceObjectRequest() { UserToken = request.UserToken });
        }

        [HttpPost]
        [Route("acceptauthentication")]
        public AcceptAuthenticationResponse AttachNewDevice(AcceptAuthenticationRequest request)
        {
            return new GigServerPersistentObjectService().AcceptAuthentication(new AcceptAuthenticationRequest()
                {
                    RequestGuid = request.RequestGuid,
                    CheckData = request.CheckData
                });
        }

    }
}
