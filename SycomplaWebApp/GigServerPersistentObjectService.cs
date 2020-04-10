using Modul.Final.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SycomplaWebApp
{
    public class GigServerPersistentObjectService
    {
        public InsertResponse Insert(InsertRequest request)
        {
            InsertResponse response = new InsertResponse();

            try
            {
                response.User = new EFMethodsCAP().Insert(request.User);

                response.Result = new Ac4yProcessResult() { Code = Ac4yProcessResult.SUCCESS };
            }
            catch (Exception exception)
            {
                response.Result = (new Ac4yProcessResult() { Code = Ac4yProcessResult.FAIL, Message = exception.Message, Description = exception.StackTrace });
            }
            return response;

        }

        public IsExistByFBTokenResponse isExistByFBToken(IsExistByFBTokenRequest request)
        {
            IsExistByFBTokenResponse response = new IsExistByFBTokenResponse();

            try { 
                if (new EFMethodsCAP().IsExistByFBToken(request.FBToken))
                    response.Result = new Ac4yProcessResult() { Code = Ac4yProcessResult.SUCCESS, Message = "létezik" };
                else
                    response.Result = new Ac4yProcessResult() { Code = Ac4yProcessResult.INEFFECTIVE, Message = "nem létezik" };
            }
            catch (Exception exception)
            {
                response.Result = (new Ac4yProcessResult() { Code = Ac4yProcessResult.FAIL, Message = exception.Message, Description = exception.StackTrace });
            }
            return response;
        }

        public GetByFBTokenResponse GetByFBToken(GetByFBTokenRequest request)
        {
            GetByFBTokenResponse response = new GetByFBTokenResponse();

            try
            {
                response.User = new EFMethodsCAP().GetByFBToken(request.FBToken);

                response.Result = new Ac4yProcessResult() { Code = Ac4yProcessResult.SUCCESS };
            }
            catch (Exception exception)
            {
                response.Result = (new Ac4yProcessResult() { Code = Ac4yProcessResult.FAIL, Message = exception.Message, Description = exception.StackTrace });
            }
            return response;
        }

        public isExistByIdResponse isExistById(isExistByIdRequest request)
        {
            isExistByIdResponse response = new isExistByIdResponse();

            try
            {
                if (new EFMethodsCAP().IsExistById(request.id))
                    response.Result = new Ac4yProcessResult() { Code = Ac4yProcessResult.SUCCESS, Message = "létezik" };
                else
                    response.Result = new Ac4yProcessResult() { Code = Ac4yProcessResult.INEFFECTIVE, Message = "nem létezik" };
            }
            catch (Exception exception)
            {
                response.Result = (new Ac4yProcessResult() { Code = Ac4yProcessResult.FAIL, Message = exception.Message, Description = exception.StackTrace });
            }
            return response;
        }
        
        public GetByIdResponse GetById(GetByIdRequest request)
        {
            GetByIdResponse response = new GetByIdResponse();

            try
            {
                response.User = new EFMethodsCAP().GetByFBToken(request.id);

                response.Result = new Ac4yProcessResult() { Code = Ac4yProcessResult.SUCCESS };
            }
            catch (Exception exception)
            {
                response.Result = (new Ac4yProcessResult() { Code = Ac4yProcessResult.FAIL, Message = exception.Message, Description = exception.StackTrace });
            }
            return response;
        }
        
        public isExistByGuidResponse isExistByGuid(isExistByGuidRequest request)
        {
            isExistByGuidResponse response = new isExistByGuidResponse();

            try
            {
                if (new EFMethodsCAP().IsExistByGuid(request.Guid))
                    response.Result = new Ac4yProcessResult() { Code = Ac4yProcessResult.SUCCESS, Message = "létezik" };
                else
                    response.Result = new Ac4yProcessResult() { Code = Ac4yProcessResult.INEFFECTIVE, Message = "nem létezik" };
            }
            catch (Exception exception)
            {
                response.Result = (new Ac4yProcessResult() { Code = Ac4yProcessResult.FAIL, Message = exception.Message, Description = exception.StackTrace });
            }
            return response;
        }

        public GetByGuidResponse GetByGuid(GetByGuidRequest request)
        {
            GetByGuidResponse response = new GetByGuidResponse();

            try
            {
                response.User = new EFMethodsCAP().GetByGuid(request.Guid);

                response.Result = new Ac4yProcessResult() { Code = Ac4yProcessResult.SUCCESS };
            }
            catch (Exception exception)
            {
                response.Result = (new Ac4yProcessResult() { Code = Ac4yProcessResult.FAIL, Message = exception.Message, Description = exception.StackTrace });
            }
            return response;
        }

        public IsUnknownOrInvalidTokenResponse IsUnknownOrInvalidToken(IsUnknownOrInvalidTokenRequest request)
        {
            IsUnknownOrInvalidTokenResponse response = new IsUnknownOrInvalidTokenResponse();

            try
            {
                if (new GigServerService().IsUnknownOrInvalidToken(request.FBToken))
                    response.Result = new Ac4yProcessResult() { Code = Ac4yProcessResult.SUCCESS, Message = "létezik" };
                else
                    response.Result = new Ac4yProcessResult() { Code = Ac4yProcessResult.INEFFECTIVE, Message = "nem létezik" };
            }
            catch (Exception exception)
            {
                response.Result = (new Ac4yProcessResult() { Code = Ac4yProcessResult.FAIL, Message = exception.Message, Description = exception.StackTrace });
            }
            return response;
        }
        
        public LoginRequestResponse LoginRequest(LoginRequestRequest request)
        {
            LoginRequestResponse response = new LoginRequestResponse();

            try
            {
                if (new GigServerService().LoginRequest(request.FBToken))
                        response.Result = new Ac4yProcessResult() { Code = Ac4yProcessResult.SUCCESS, Message = "Mehet a login, a token rendben" };

                //További kódok megfelelő token esetén
            }
            catch (Exception exception)
            {
                response.Result = (new Ac4yProcessResult() { Code = Ac4yProcessResult.FAIL, Message = exception.Message, Description = exception.StackTrace });
            }
            return response;
        }
        
    }
}
