using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
namespace Dictionary.API
{
    public class Entry
    {
        ///<summary>The origin of the word and the way in which its meaning has changed throughout history </summary>
        [JsonProperty(JSONProperties.ETYMOLOGIES)]
        public List<string> Etymologies { get; set; }

        [JsonProperty(Filters.GRAMMATICAL_FEATURES)]
        public List<InlineModel_1> GrammaticalFeatures { get; set; }

        ///<summary>Identifies the homograph grouping. The last two digits identify different entries of the same homograph. The first one/two digits identify the homograph number.</summary>
        [JsonProperty(JSONProperties.HOMOGRAPH_NUMBER)]
        public string HomographNumber { get; set; }

        ///<summary>Complete list of senses</summary>
        [JsonProperty(JSONProperties.SENSES)]
        public List<Sense> Senses { get; set; }

        ///<summary>Various words that are used interchangeably depending on the context, e.g 'a' and 'an'</summary>
        [JsonProperty(JSONProperties.VARIANT_FORMS)]
        public List<InlineModel_2> VariantForms { get; set; }
    }
}
