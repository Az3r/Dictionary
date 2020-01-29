using System.Collections.Generic;
using Newtonsoft.Json;
namespace Dictionary.API
{
    /// <summary>
    /// Use to contain information of a given word <br></br>
    /// </summary>
    public class LexicalEntry : InlineModel_1
    {
        [JsonProperty(Filters.GRAMMATICAL_FEATURES)]
        public List<InlineModel_1> GrammaticalFeatures { get; set; }

        [JsonProperty(Filters.LEXICAL_CATEGORY)]
        public InlineModel_1 LexicalCategory { get; set; }

        [JsonProperty(JSONProperties.ENTRIES)]
        public List<Entry> Entries { get; set; }

        /// <summary>
        /// Other words from which this one derives
        /// </summary>
        [JsonProperty(JSONProperties.DERIVATIVE_OF)]
        public List<InlineModel_1> DerivativeOf { get; set; }

        /// <summary>
        /// Other words from which their Sense derives
        /// </summary>
        [JsonProperty(JSONProperties.DERIVATIVES)]
        public List<InlineModel_1> Derivatives { get; set; }

        [JsonProperty(Filters.PRONUNCIATIONS)]
        public List<InlineModel_3> Pronunciations { get; set; }
    }
}
