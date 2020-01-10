using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
namespace Main.API
{
    /// <summary>
    /// A word's sense
    /// </summary>
    public class Sense
    {
        /// <summary>
        /// Provides information about typical syntax used of this sense. Each construction may optionally have one or more examples
        /// </summary>
        [JsonProperty(JSONProperties.CONSTRUCTIONS)]
        public List<ResponseModel> Constructions { get; set; }

        /// <summary>
        /// A grouping of crossreference notes
        /// </summary>
        [JsonProperty(JSONProperties.CROSS_REFERENCE_MARKERS)]
        public List<string> CrossReferenceMarkers { get; set; }

        /// <summary>
        /// A array of words that have relations with word being search, with each property has the following meaning:
        /// <br><see cref="ResponseModel.ID"/>: The id of word which has relation</br>
        /// <br><see cref="ResponseModel.Text"/>: The word itself</br>
        /// <br><see cref="ResponseModel.Type"/>: The type of relation between the two words, see <see cref="API.RelationTypes"/></br>
        /// </summary>
        public List<ResponseModel> CrossReferences { get; set; }

        /// <summary>
        ///  A list of statements of the exact meaning of a word
        /// </summary>
        [JsonProperty(Filters.DEFINITIONS)]
        public List<string> Definitions { get; set; }

        /// <summary>
        /// A subject, discipline, or branch of knowledge particular to the Sense
        /// </summary>
        [JsonProperty(Filters.DOMAINS)]
        public List<ResponseModel> Domains { get; set; }

        /// <summary>
        /// The origin of the word and the way in which its meaning has changed throughout history
        /// </summary>
        [JsonProperty(JSONProperties.ETYMOLOGIES)]
        public List<string> Etymologies { get; set; }

        [JsonProperty(Filters.EXAMPLES)]
        public List<Example> Examples { get; set; }

        [JsonProperty(JSONProperties.NOTES)]
        public List<ResponseModel> Notes { get; set; }

        [JsonProperty(Filters.PRONUNCIATIONS)]
        public List<Pronounciation> Pronunciations { get; set; }

        /// <summary>
        /// A particular area in which the Sense occurs, e.g. 'Great Britain'
        /// </summary>
        [JsonProperty(Filters.REGIONS)]
        public List<ResponseModel> Regions { get; set; }

        /// <summary>
        /// A level of language usage, typically with respect to formality. e.g. 'offensive', 'informal' 
        /// </summary>
        [JsonProperty(Filters.REGISTERS)]
        public List<ResponseModel> Registers { get; set; }

        /// <summary>
        /// A list of short statements of the exact meaning of a word
        /// </summary>
        [JsonProperty(JSONProperties.SHORT_DEFINITIONS)]
        public List<string> ShortDefinitions { get; set; }

        /// <summary>
        /// Various words that are used interchangeably depending on the context, e.g 'duck' and 'duck boat'
        /// </summary>
        public List<ResponseModel> VariantForms { get; set; }
    }
}
