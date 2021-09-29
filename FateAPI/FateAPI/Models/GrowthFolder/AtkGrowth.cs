namespace FateAPI.Models
{
    public class AtkGrowth
    {
        public int Attack { get; set; }
        public int Level { get; set; }

        public AtkGrowth(int attack, int level)
        {
            this.Attack = attack;
            this.Level = level;
        }
    }
}
