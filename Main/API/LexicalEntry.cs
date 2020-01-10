using System.Collections.Generic;
using Newtonsoft.Json;
namespace Main.API
{
    /// <summary>
    /// Use to contain information of a given word <br></br>
    /// </summary>
    public class LexicalEntry : ResponseModel
    {
        [JsonProperty(Filters.GRAMMATICAL_FEATURES)]
        public List<GrammaticalFeature> GrammaticalFeatures { get; set; }

        [JsonProperty(JSONProperties.INFLECTION_OF)]
        public List<ResponseModel> InfectionOf { get; set; }

        [JsonProperty(Filters.LEXICAL_CATEGORY)]
        public ResponseModel LexicalCategory { get; set; }
    }
}
