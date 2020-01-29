using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Dictionary.API
{
    /// <summary>For pronounciation response</summary>
    public class InlineModel_3
    {
        ///<summary>The URL of the sound file</summary>
        [JsonProperty(JSONProperties.AUDIO_FILE)]
        public string AudioFile { get; set; }

        ///<summary>A local or regional variation where the pronunciation occurs, e.g. 'British English'</summary>
        [JsonProperty(JSONProperties.DIALECTS)]
        public List<string> Dialects { get; set; }

        ///<summary>The alphabetic system used to display the phonetic spelling</summary>
        [JsonProperty(JSONProperties.PHONETIC_NOTATION)]
        public string PhoneticNotation { get; set; }

        ///<summary> Phonetic spelling is the representation of vocal sounds which express pronunciations of words. 
        ///It is a system of spelling in which each letter represents invariably the same spoken sound </summary>
        [JsonProperty(JSONProperties.PHONETIC_SPELLING)]
        public string PhoneticSpelling { get; set; }

        ///<summary>A particular area in which the pronunciation occurs, e.g. 'Great Britain'</summary>
        [JsonProperty(Filters.REGIONS)]
        public List<InlineModel_1> Regions { get; set; }

        ///<summary>A level of language usage, typically with respect to formality. e.g. 'offensive', 'informal'</summary>
        [JsonProperty(Filters.REGISTERS)]
        public List<InlineModel_1> Registers { get; set; }

    }
}
