using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
namespace Main.API
{
    /// <summary>
    /// An example shows how to use a specific word, usually by sentences
    /// </summary>
    public class Example
    {
        /// <summary>
        /// the sentence
        /// </summary>
        [JsonProperty(JSONProperties.TEXT)]
        public string Text { get; set; }
        /// <summary>
        /// <em>Optional</em>:
        /// A list of statements of the exact meaning of a word
        /// </summary>
        [JsonProperty(Filters.DEFINITIONS)]
        public List<string> Definitions { get; set; }

        /// <summary>
        /// <em>Optional</em>:
        ///  A subject, discipline, or branch of knowledge particular to the Sense 
        /// </summary>
        [JsonProperty(Filters.DOMAINS)]
        public List<ResponseModel> Domains { get; set; }

        /// <summary>
        /// <em>Optional</em>:
        /// Extra information on how to use a specific word, each property has the following meaning:
        /// <br><see cref="ResponseModel.ID"/>: the word's identifier</br>
        /// <br><see cref="ResponseModel.Text"/>: a note text</br>
        /// <br><see cref="ResponseModel.Type"/>: <see langword="null"/></br>
        /// </summary>
        public List<ResponseModel> Notes { get; set; }

        /// <summary>
        /// <em>Optional</em>:
        /// A particular area in which the pronunciation occurs, e.g. 'Great Britain' ,
        /// </summary>
        [JsonProperty(Filters.REGIONS)]
        public List<ResponseModel> Regions { get; set; }

        /// <summary>
        /// <em>Optional</em>:
        /// A particular area in which the pronunciation occurs, e.g. 'Great Britain' ,
        /// </summary>
        [JsonProperty(Filters.REGISTERS)]
        public List<ResponseModel> Registers { get; set; }

        /// <summary>
        /// <em>Optional</em>:
        /// The list of sense identifiers related to the example. Provided in the sentences endpoint only.
        /// </summary>
        [JsonProperty(JSONProperties.SENSE_IDS)]
        public List<string> SenseIds { get; set; }
    }
}
