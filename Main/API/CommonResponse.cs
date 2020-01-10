using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
namespace Main.API
{
    /// <summary>
    /// Base class for response message which contains only <see cref="ID"/> and <see cref="Text"/>
    /// </summary>
    public class CommonResponse
    {
        [JsonProperty(JSONProperties.ID)]
        public string ID { get; set; }
        [JsonProperty(JSONProperties.TEXT)]
        public string Text { get; set; }
    }
}
