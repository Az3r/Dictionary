using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
namespace Main.API
{
    /// <summary>
    /// Contains a list of <see cref="LexicalEntry"/>s and data related including:
    /// <br><see cref="ResponseModel.ID"/>: the identifier of word</br>
    /// <br><see cref="ResponseModel.Type"/>: The json object type. Could be 'headword', 'inflection' or 'phrase'</br>
    /// 
    /// </summary>
    public class ResponseResult : ResponseModel
    {
        /// <summary>
        /// IANA language code
        /// </summary>
        [JsonProperty(JSONProperties.LANGUAGE)]
        public string Language { get; set; }

        [JsonProperty(JSONProperties.LEXICAL_ENTRIES)]
        public List<LexicalEntry> LexicalEntries { get; set; }


    }
}
