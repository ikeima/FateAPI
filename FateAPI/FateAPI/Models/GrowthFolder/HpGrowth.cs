namespace FateAPI.Models.GrowthFolder
{
    public class HpGrowth
    {
        public int HP { get; set; }
        public int Level { get; set; }

        public HpGrowth(int hp, int level)
        {
            this.HP = hp;
            this.Level = level;
        }
    }
}
