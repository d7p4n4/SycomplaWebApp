using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SycomplaWebApp
{
    public class DummyFailedResponse
    {
        [JsonProperty("statusCode")]
        public long StatusCode { get; set; }

        [JsonProperty("message")]
        public string Message = "Hiba";
    }
}
