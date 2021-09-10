using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FateAPI.Models
{
    class ExtraAssets
    {
        public CharaGraph charaGraph { get; set; }
    }
    class CharaGraph
    {
        public Ascension ascension { get; set; }
    }
    class Ascension
    {
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
