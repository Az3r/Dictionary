using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
namespace Main.API
{
    /// <summary>
    /// Response message that provide extra information about a <see cref="LexicalCategories"/>
    /// </summary>
    public class GrammaticalFeature : APIReponse
    {
        [JsonProperty("type")]
        public string Type { get; set; } = null;
    }
}
