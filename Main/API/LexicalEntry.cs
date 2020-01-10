using System.Collections.Generic;
using Newtonsoft.Json;
namespace Main.API
{
    /// <summary>
    /// Use to contain information of a given word <br></br>
    /// </summary>
    public class LexicalEntry : CommonResponse
    {
        [JsonProperty(Filters.GRAMMATICAL_FEATURES)]
        public List<GrammaticalFeature> GrammaticalFeatures { get; set; }

        [JsonProperty(JSONProperties.INFLECTION_OF)]
        public List<CommonResponse> InfectionOf { get; set; }

        [JsonProperty(Filters.LEXICAL_CATEGORY)]
        public CommonResponse LexicalCategory { get; set; }
    }
}
