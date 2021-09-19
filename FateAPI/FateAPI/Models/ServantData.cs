using FateAPI.Models;
using FateAPI.Models.SkillsFolder;

namespace FateAPI.ViewModels
{
    public class ServantData
    {
        public int id { get; set; }
        public int collectionNo { get; set; }
        public string name { get; set; }
        public string className { get; set; }
        public string face { get; set; }
        public int rarity { get; set; }
        public ExtraAssets extraAssets { get; set; }
        public Skill[] skills { get; set; }

    }
}