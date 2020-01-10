using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
namespace Main.API
{
    /// <summary>
    /// Information about API's provider, schema and operation
    /// </summary>
    public class ResponseMetadata
    {
        [JsonProperty(JSONProperties.OPERATION)]
        public string Operation { get; set; }

        [JsonProperty(JSONProperties.PROVIDER)]
        public string Provider { get; set; }

        [JsonProperty(JSONProperties.SCHEMA)]
        public string Schema { get; set; }
    }
}
