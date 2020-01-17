using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
namespace Main.API
{
    public class Headword
    {
        ///<summary>The identifier of a word</summary>
        [JsonProperty(JSONProperties.ID)]
        public string ID { get; set; }

        ///<summary>IANA language code</summary>
        [JsonProperty(JSONProperties.LANGUAGE)]
        public string Language { get; set; }

        ///<summary>The json object type. Could be 'headword', 'inflection' or 'phrase</summary>
        [JsonProperty(JSONProperties.TYPE)]
        public string Type { get; set; }
    }
}
