using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
namespace Main.API
{
    public class InlineModel_2
    {
        [JsonProperty(Filters.DEFINITIONS)]
        public List<string> Definitions { get; set; }



        [JsonProperty(JSONProperties.SENSE_IDS)]
        public List<string> SenseIds { get; set; }
    }
}
