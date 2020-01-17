using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Main.API
{
    public class LemmasLexicalEntry
    {
        [JsonProperty(Filters.GRAMMATICAL_FEATURES)]
        public List<InlineModel_1> GrammaticalFeatures { get; set; }

        [JsonProperty(Filters.LEXICAL_CATEGORY)]
        public InlineModel_1 LexicalCategory { get; set; }

        ///<summary>he canonical form of words for which the entry is an inflection</summary>
        [JsonProperty(JSONProperties.INFLECTION_OF)]
        public List<InlineModel_1> InfectionList { get; set; }
    }
}
