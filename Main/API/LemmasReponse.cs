﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
namespace Main.API
{
    public class LemmasReponse : APIReponse
    {
        [JsonProperty("language")]
        public string Language { get; set; }
        [JsonProperty("word")]
        public string Word { get; set; }
        public List<LexcicalEntry> LexcicalEntries { get; set; }
    }
}
