using FateAPI.Models.ExtraAssetsFolder.CharaGraphFolder;
using System.Collections.Generic;

namespace FateAPI.Models
{
    public class ExtraAssets
    {
        public CharaGraph charaGraph { get; set; }
        public Commands commands { get; set; }
    }

    public class Commands
    {
        public Dictionary<string, string> ascension { get; set; }
        public Dictionary<string, string> story { get; set; }
        public Dictionary<string, string> costume { get; set; }
        public Dictionary<string, string> equip { get; set; }
        public Dictionary<string, string> cc { get; set; }
    }
}
