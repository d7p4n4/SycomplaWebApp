using Modul.Final.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SycomplaWebApp
{
    public class GetByFBTokenRequest : Ac4yServiceRequest
    {
        public string FBToken { get; set; }
    }
}
