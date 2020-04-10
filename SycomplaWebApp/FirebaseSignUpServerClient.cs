using Modul.Final.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SycomplaWebApp
{
    public class FirebaseSignUpServerClient
    {
        public FirebaseSignUpResponse FirebaseSignUp(FirebaseSignUpRequest request)
        {
            FirebaseSignUpResponse response = new FirebaseSignUpResponse();

            try
            {
                if (new EFMethodsCAP().IsExistByFBToken(request.fbToken))
                    throw new Exception("Már létezik az adatbázisban ez a token");

                new EFMethodsCAP().Insert(new User() { FBToken = request.fbToken });

                response.Result = new Ac4yProcessResult() { Code = Ac4yProcessResult.SUCCESS };
            }
            catch (Exception exception)
            {
                response.Result = (new Ac4yProcessResult() { Code = Ac4yProcessResult.FAIL, Message = exception.Message, Description = exception.StackTrace });
            }
            return response;
        }
    }
}
