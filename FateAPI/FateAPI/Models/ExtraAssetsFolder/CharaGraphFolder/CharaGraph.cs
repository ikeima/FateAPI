using Newtonsoft.Json;
using System.Collections.Generic;

namespace FateAPI.Models.ExtraAssetsFolder.CharaGraphFolder
{
    public class CharaGraph
    {
        public Ascension ascension { get; set; }
        [JsonProperty("costume")]
        public Dictionary<string, string> costume { get; set; }
    }
    public class Ascension
    {
        // TODO: Поменять атрибуты, т.к. нет гарантий, что атрибуты 1-4 обязательно будут
        [JsonProperty("1")]
        public string first { get; set; }
        [JsonProperty("2")]
        public string second { get; set; }
        [JsonProperty("3")]
        public string third { get; set; }
        [JsonProperty("4")]
        public string four { get; set; }
    }
}
