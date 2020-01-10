using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
namespace Main.API
{
    public class Result : CommonResponse
    {
        [JsonProperty(JSONProperties.LANGUAGE)]
        public string Language { get; set; }
        [JsonProperty(JSONProperties.LEXICAL_ENTRIES)]
        public List<LexicalEntry> LexicalEntries { get; set; }
        [JsonProperty(JSONProperties.WORD)]
        public string Word { get; set; }
    }
}
