using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SycomplaWebApp
{
    public class DummyClass
    {
        public string Dummy { get; set; }
        public int ResponseCode { get; set; }

        public string ToString()
        {
           return "{ dummy:" + Dummy + ", responseCode:" + ResponseCode + " }";
        }

    }
}
