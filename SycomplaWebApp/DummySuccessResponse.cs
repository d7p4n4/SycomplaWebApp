using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SycomplaWebApp
{
    public class DummySuccessResponse
    {
        [JsonProperty("dummy")]
        public DummyClass Dummy { get; set; }
    }
}
