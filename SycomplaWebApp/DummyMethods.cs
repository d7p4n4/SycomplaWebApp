using Modul.Final.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SycomplaWebApp
{
    public class DummyMethods
    {
        public DummyResponse DummyTwice(DummyRequest request)


        {
            DummyResult dummyResult = new DummyResult();
            DummyResponse dummyResponse = new DummyResponse();

            string dummyTwice = request.Dummy + " " + request.Dummy;

            if (request.Dummy.Dummy != null)
            {
                request.Dummy.ResponseCode = 200;
                DummySuccessResponse JSONObjSuccess = new DummySuccessResponse();
                JSONObjSuccess.Dummy = request.Dummy;

                dummyResult.SuccessResponse = JSONObjSuccess;

            }
            else
            {

                DummyFailedResponse JSONObjFailed = new DummyFailedResponse();
                JSONObjFailed.StatusCode = 66666;


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
