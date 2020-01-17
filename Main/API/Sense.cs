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
        public List<InlineModel_1> Constructions { get; set; }

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
        ///  A list of statements of the exact meaning of a word
        /// </summary>
        [JsonProperty(Filters.DEFINITIONS)]
        public List<string> Definitions { get; set; }

        /// <summary>
        /// A subject, discipline, or branch of knowledge particular to the Sense
        /// </summary>
        [JsonProperty(Filters.DOMAINS)]
        public List<InlineModel_1> Domains { get; set; }

        /// <summary>
        /// The origin of the word and the way in which its meaning has changed throughout history
        /// </summary>
        [JsonProperty(JSONProperties.ETYMOLOGIES)]
        public List<string> Etymologies { get; set; }

        [JsonProperty(Filters.EXAMPLES)]
        public List<Example> Examples { get; set; }

        /// <summary>
        /// <em>Optional</em>:
        /// Extra information on how to use a specific word, each property has the following meaning:
        /// <br><see cref="InlineModel_1.ID"/>: the word's identifier</br>
        /// <br><see cref="InlineModel_1.Text"/>: a note text</br>
        /// <br><see cref="InlineModel_1.Type"/>: <see langword="null"/></br>
        /// </summary>
        [JsonProperty(JSONProperties.NOTES)]
        public List<InlineModel_1> Notes { get; set; }

        /// <summary>
        /// A particular area in which the Sense occurs, e.g. 'Great Britain'
        /// </summary>
        [JsonProperty(Filters.REGIONS)]
        public List<InlineModel_1> Regions { get; set; }

        /// <summary>
        /// A level of language usage, typically with respect to formality. e.g. 'offensive', 'informal' 
        /// </summary>
        [JsonProperty(Filters.REGISTERS)]
        public List<InlineModel_1> Registers { get; set; }

        /// <summary>
        /// A list of short statements of the exact meaning of a word
        /// </summary>
        [JsonProperty(JSONProperties.SHORT_DEFINITIONS)]
        public List<string> ShortDefinitions { get; set; }

        /// <summary>
        /// Various words that are used interchangeably depending on the context, e.g 'duck' and 'duck boat'
        /// </summary>
        [JsonProperty(JSONProperties.VARIANT_FORMS)]
        public List<VariantForm> VariantForms { get; set; }

        /// <summary>
        /// Ordered list of subsenses of a sense ,
        /// </summary>
        [JsonProperty(JSONProperties.SUBSENSES)]
        public List<Sense> SubSenses { get; set; }
    }
}
