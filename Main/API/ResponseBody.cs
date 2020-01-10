using System;
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
        [JsonProperty(JSONProperties.RESULTS)]
        public List<ResponseResult> Results { get; set; }

        public override string ToString()
        {
            JsonSerializer serializer = new JsonSerializer();
            StringWriter stringWriter = new StringWriter();
            JsonWriter writer = new JsonTextWriter(stringWriter);
            serializer.Serialize(writer, this, typeof(ResponseBody));
            return stringWriter.ToString();
        }
    }
}
