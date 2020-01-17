using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
namespace Main.API
{
    public class Sense : InlineModel_2
    {
        /// <summary>
        /// A grouping of crossreference notes
        /// </summary>
        [JsonProperty(JSONProperties.CROSS_REFERENCE_MARKERS)]
        public List<string> CrossReferenceMarkers { get; set; }

        /// <summary>
        /// A array of words that have relations with word being search, with each property has the following meaning:
        /// <br><see cref="InlineModel_1.ID"/>: The id of word which has relation</br>
        /// <br><see cref="InlineModel_1.Text"/>: The word itself</br>
        /// <br><see cref="InlineModel_1.Type"/>: The type of relation between the two words, see <see cref="API.RelationTypes"/></br>
        /// </summary>
        public List<InlineModel_1> CrossReferences { get; set; }

        /// <summary>
        /// The origin of the word and the way in which its meaning has changed throughout history
        /// </summary>
        [JsonProperty(JSONProperties.ETYMOLOGIES)]
        public List<string> Etymologies { get; set; }

        [JsonProperty(Filters.EXAMPLES)]
        public List<InlineModel_2> Examples { get; set; }

        /// <summary>
        /// A list of short statements of the exact meaning of a word
        /// </summary>
        [JsonProperty(JSONProperties.SHORT_DEFINITIONS)]
        public List<string> ShortDefinitions { get; set; }

        /// <summary>
        /// Various words that are used interchangeably depending on the context, e.g 'duck' and 'duck boat'
        /// </summary>
        [JsonProperty(JSONProperties.VARIANT_FORMS)]
        public List<InlineModel_2> VariantForms { get; set; }

        /// <summary>
        /// Ordered list of subsenses of a sense ,
        /// </summary>
        [JsonProperty(JSONProperties.SUBSENSES)]
        public List<Sense> SubSenses { get; set; }
    }
}
