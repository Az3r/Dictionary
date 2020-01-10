using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
namespace Main.API
{
    public class LemmasReponse : CommonResponse
    {
        [JsonProperty("language")]
        public string Language { get; set; }
        [JsonProperty("word")]
        public string Word { get; set; }
        public List<LexicalEntry> LexcicalEntries { get; set; }
    }
}
