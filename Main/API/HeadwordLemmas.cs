using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Main.API
{
    /// <summary>For lemmas request</summary>
    public class HeadwordLemmas : Headword
    {
        [JsonProperty(JSONProperties.LEXICAL_ENTRIES)]
        public List<LemmasLexicalEntry> LexicalEntries { get; set; }
    }
}
