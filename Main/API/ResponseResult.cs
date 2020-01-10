using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
namespace Main.API
{
    /// <summary>
    /// The result that is returned by server when calling one of the server's methods
    /// </summary>
    public class ResponseResult : CommonResponse
    {   
        [JsonProperty(JSONProperties.LANGUAGE)]
        public string Language { get; set; }

        [JsonProperty(JSONProperties.LEXICAL_ENTRIES)]
        public List<LexicalEntry> LexicalEntries { get; set; }

        [JsonProperty(JSONProperties.WORD)]
        public string Word { get; set; }

        [JsonProperty(JSONProperties.TYPE)]
        public string Type { get; set; }
    }
}
