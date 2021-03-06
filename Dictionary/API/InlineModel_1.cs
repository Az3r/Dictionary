﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
namespace Dictionary.API
{
    /// <summary>
    /// Basic model which contains only <see cref="ID"/>, <see cref="Type"/> and <see cref="Text"/>
    /// </summary>
    public class InlineModel_1
    {
        [JsonProperty(JSONProperties.ID)]
        public string ID { get; set; }
        [JsonProperty(JSONProperties.TEXT)]
        public string Text { get; set; }

        [JsonProperty(JSONProperties.TYPE)]
        public string Type { get; set; }

    }
}
