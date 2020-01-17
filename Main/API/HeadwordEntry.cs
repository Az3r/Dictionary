using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
namespace Main.API
{
    /// <summary>For entry request</summary>
    public class HeadwordEntry : Headword
    {
        ///<summary>A grouping of various senses in a specific language, and a lexical category that relates to a word</summary>
        [JsonProperty(JSONProperties.LEXICAL_ENTRIES)]
        public List<LexicalEntry> LexicalEntries { get; set; }
    }
}
