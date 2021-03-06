﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
namespace Dictionary.API
{
    /// <summary>
    /// Additional Information provided by Oxford University Press
    /// </summary>
    public class Metadata
    {
        [JsonProperty(JSONProperties.OPERATION)]
        public string Operation { get; set; }

        [JsonProperty(JSONProperties.PROVIDER)]
        public string Provider { get; set; }

        [JsonProperty(JSONProperties.SCHEMA)]
        public string Schema { get; set; }

        [JsonProperty(JSONProperties.TOTAL)]
        public int Total { get; set; }
    }
}
