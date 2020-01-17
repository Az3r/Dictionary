using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
namespace Main.API
{
    public class ResponseSearch
    {
        [JsonProperty(JSONProperties.METADATA)]
        public Metadata Metadata { get; set; }

        [JsonProperty(JSONProperties.RESULTS)]
        public List<SearchResult> Results { get; set; }
    }
}
