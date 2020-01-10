using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
namespace Main.API
{
    /// <summary>
    /// Base class for response message which contains only <see cref="ID"/> and <see cref="Text"/>
    /// </summary>
    public abstract class CommonResponse
    {
        [JsonProperty("id")]
        public string ID { get; set; } = null;
        [JsonProperty("text")]
        public string Text { get; set; } = null;
    }
}
