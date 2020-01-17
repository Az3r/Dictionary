using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
namespace Main.API
{
    public class InlineModel_2
    {
        /// <summary>A list of statements of the exact meaning of a word</summary>
        [JsonProperty(Filters.DEFINITIONS)]
        public List<string> Definitions { get; set; }

        /// <summary>A subject, discipline, or branch of knowledge particular to the Sense</summary>
        [JsonProperty(Filters.DOMAINS)]
        public List<InlineModel_1> Domains { get; set; }

        [JsonProperty(JSONProperties.NOTES)]
        public List<InlineModel_1> Notes { get; set; }

        /// <summary>A particular area in which the pronunciation occurs, e.g. 'Great Britain'</summary>
        [JsonProperty(Filters.REGIONS)]
        public List<InlineModel_1> Regions { get; set; }

        /// <summary>A level of language usage, typically with respect to formality. e.g. 'offensive', 'informal'</summary>
        [JsonProperty(Filters.REGISTERS)]
        public List<InlineModel_1> Registers { get; set; }

        /// <summary>The list of sense identifiers related to the example. Provided in the sentences endpoint only.</summary>
        [JsonProperty(JSONProperties.SENSE_IDS)]
        public List<string> SenseIds { get; set; }

        [JsonProperty(JSONProperties.TEXT)]
        public string Text { get; set; }
    }
}
