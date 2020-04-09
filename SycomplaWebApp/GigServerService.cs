using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SycomplaWebApp
{
    public class GigServerService
    {
        public bool IsUnknownOrInvalidToken(string fbToken)
        {
            return new EFMethodsCAP().IsExistByFBToken(fbToken);
        }
    }
}
