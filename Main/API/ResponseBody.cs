using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
namespace Main.API
{
    public class ResponseBody
    {
        [JsonProperty(JSONProperties.RESULTS)]
        public List<Result> Results { get; set; }
    }
}
