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
    public class EntryReponse
    {
        [JsonProperty(JSONProperties.METADATA)]
        public Metadata Metadata { get; set; }

        /// <summary>
        /// A list of entries and all the data related to them
        /// </summary>
        [JsonProperty(JSONProperties.RESULTS)]
        public List<HeadwordEntry> Results { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}