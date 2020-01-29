using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
namespace Dictionary.API
{
    /// <summary>
    /// The response's content that is returned by Lemmas request
    /// </summary>
    public class LemmasReponse 
    {
        [JsonProperty(JSONProperties.METADATA)]
        public Metadata Metadata { get; set; }

        /// <summary>
        /// A list of entries and all the data related to them
        /// </summary>
        [JsonProperty(JSONProperties.RESULTS)]
        public List<HeadwordLemmas> Results { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
