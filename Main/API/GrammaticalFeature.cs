using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
namespace Main.API
{
    public class GrammaticalFeature : BaseResponse
    {
        [JsonProperty("type")]
        public string Type { get; set; } = null;
    }
}
