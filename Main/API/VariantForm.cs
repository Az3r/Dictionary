using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
namespace Main.API
{
    /// <summary>
    /// Used to retrieve word's variant form
    /// </summary>
    public class VariantForm
    {
        [JsonProperty(JSONProperties.TEXT)]
        public string Text { get; set; }

        /// <summary>
        /// A particular area in which the variant form occurs, e.g. 'Great Britain'
        /// </summary>
        [JsonProperty(Filters.REGIONS)]
        public List<ResponseModel> Regions { get; set; }
    }
}
