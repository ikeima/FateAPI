using Newtonsoft.Json;
using System.Collections.Generic;

namespace FateAPI.Models.ExtraAssetsFolder.CharaGraphFolder
{
    public class CharaGraph
    {
        public Dictionary<string,string> ascension { get; set; }
        public Dictionary<string, string> costume { get; set; }
    }
}
