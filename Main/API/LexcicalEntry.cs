using System.Collections.Generic;
using Newtonsoft.Json;
namespace Main.API
{
    /// <summary>
    /// Use to contain information of a given word <br></br>
    /// </summary>
    public class LexcicalEntry : APIReponse
    {
        [JsonProperty(Filters.GRAMMATICAL_FEATURES)]
        public List<GrammaticalFeature> GrammaticalFeatures { get; set; }
        [JsonProperty("inflectionOf")]
        public APIReponse InfectionOf { get; set; }
        [JsonProperty("lexicalCategory")]
        public APIReponse LexicalCategory { get; set; }
    }
}
