using System.Collections.Generic;
using Newtonsoft.Json;
namespace Main.API
{
    /// <summary>
    /// Use to contain information of a given word <br></br>
    /// </summary>
    public class LexicalEntry : InlineModel_1
    {
        [JsonProperty(Filters.GRAMMATICAL_FEATURES)]
        public List<InlineModel_1> GrammaticalFeatures { get; set; }

        [JsonProperty(JSONProperties.INFLECTION_OF)]
        public List<InlineModel_1> InfectionOf { get; set; }

        [JsonProperty(Filters.LEXICAL_CATEGORY)]
        public InlineModel_1 LexicalCategory { get; set; }

        /// <summary>
        /// Various words that are used interchangeably depending on the context, e.g 'duck' and 'duck boat'
        /// </summary>
        [JsonProperty(JSONProperties.VARIANT_FORMS)]
        public List<VariantForm> VariantForms { get; set; }

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
