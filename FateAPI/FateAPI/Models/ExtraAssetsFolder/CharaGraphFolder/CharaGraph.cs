using Newtonsoft.Json;
using System.Collections.Generic;

namespace FateAPI.Models.ExtraAssetsFolder.CharaGraphFolder
{
    public class CharaGraph
    {
        [JsonProperty("ascension")]
        public Dictionary<string,string> ascension { get; set; }
        [JsonProperty("costume")]
        public Dictionary<string, string> costume { get; set; }
    }
}
