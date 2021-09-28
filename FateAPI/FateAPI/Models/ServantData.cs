using FateAPI.Models;
using FateAPI.Models.SkillsFolder;
using System.Collections.Generic;

namespace FateAPI.ViewModels
{
    public class ServantData
    {
        public int id { get; set; }
        public int collectionNo { get; set; }
        public string name { get; set; }
        public string ruby { get; set; }
        public string className { get; set; }
        public string flag { get; set; }
        public string face { get; set; }
        public int rarity { get; set; }
        public ExtraAssets extraAssets { get; set; }
        public Models.SkillsFolder.Skill[] skills { get; set; }
        public NoblePhantasm[] noblePhantasms { get; set; }
        public string gender { get; set; }
        public string attribute { get; set; }
        public Trait[] traits { get; set; }
        public int starAbsorb { get; set; }
        public int starGen { get; set; }
        public int instantDeathChance { get; set; }
        public string[] cards { get; set; }
        public HitsDistribution hitsDistribution { get; set; }



    }
}