using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
namespace Main.API
{
    /// <summary>
    /// Contains information about how a word is pronounced, including its phonetic spelling, audio file
    /// </summary>
    public class Pronounciation
    {
        /// <summary>
        /// <em>Optional</em>:
        /// The URL of the sound file
        /// </summary>
        [JsonProperty(JSONProperties.AUDIO_FILE)]
        public string AudioFile { get; set; }

        /// <summary>
        /// <em>Optional</em>:
        /// A local or regional variation where the pronunciation occurs, e.g. 'British English'
        /// </summary>
        [JsonProperty(JSONProperties.DIALECTS)]
        public List<string> Dialects { get; set; }

        /// <summary>
        /// <em>Optional</em>:
        /// The alphabetic system used to display the phonetic spelling, usually API is used
        /// <br>see <see href="https://en.wikipedia.org/wiki/International_Phonetic_Alphabet"/> for more detail</br>
        /// </summary>
        [JsonProperty(JSONProperties.PHONETIC_NOTATION)]
        public string PhoneticNotation { get; set; }

        /// <summary>
        /// <em>Optional</em>:
        /// A system of spelling in which each letter represents invariably the same spoken sound
        /// <br>see <see href="https://www.ling.upenn.edu/courses/Fall_2014/ling115/phonetics.html"/> for more detail</br>
        /// </summary>
        [JsonProperty(JSONProperties.PHONETIC_SPELLING)]
        public string PhoneticSpelling { get; set; }

        /// <summary>
        /// <em>Optional</em>:
        /// A particular area in which the pronunciation occurs, e.g. 'Great Britain'
        /// </summary>
        [JsonProperty(Filters.REGIONS)]
        public List<ResponseModel> Regions { get; set; }
    }
}
