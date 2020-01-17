using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Main.API
{
    public class SearchResult
    {
        [JsonProperty(JSONProperties.ID)]
        public string Id { get; set; }

        [JsonProperty(JSONProperties.MATCH_STRING)]
        public string MatchString { get; set; }

        [JsonProperty(JSONProperties.MATCH_TYPE)]
        public string MatchType { get; set; }

        [JsonProperty(Filters.REGIONS)]
        public string Region { get; set; }
    }
}
