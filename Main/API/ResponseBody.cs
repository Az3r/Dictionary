﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;
namespace Main.API
{
    /// <summary>
    /// The response's content that is returned by server
    /// </summary>
    public class ResponseBody
    {
        [JsonProperty(JSONProperties.METADATA)]
        public Metadata Metadata { get; set; }

        /// <summary>
        /// A list of entries and all the data related to them
        /// </summary>
        [JsonProperty(JSONProperties.RESULTS)]
        public List<ResponseResult> Results { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
