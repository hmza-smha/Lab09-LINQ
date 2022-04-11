using Newtonsoft.Json;
using System.Collections.Generic;

namespace Lab09_LINQ
{
    public class Root
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("features")]
        public List<Feature> Features { get; set; }
    }
}
