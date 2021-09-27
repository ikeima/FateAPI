namespace FateAPI.Models
{
    public class NoblePhantasm
    {
        public int id { get; set; }
        public int num { get; set; }
        public string card { get; set; }
        public string name { get; set; }
        public string ruby { get; set; }
        public string icon { get; set; }
        public string rank { get; set; }
        public string type { get; set; }
        public string detail { get; set; }
        public Npgain npGain { get; set; }
        public int[] npDistribution { get; set; }
        public int strengthStatus { get; set; }
        public int priority { get; set; }
        public int condQuestId { get; set; }
        public int condQuestPhase { get; set; }
        public Individualuty[] individuality { get; set; }
        public Script script { get; set; }
        public Function[] functions { get; set; }
    }

    public class Npgain
    {
        public int[] buster { get; set; }
        public int[] arts { get; set; }
        public int[] quick { get; set; }
        public int[] extra { get; set; }
        public int[] defence { get; set; }
        public int[] np { get; set; }
    }

    public class Script
    {
        public int[] NP_HIGHER { get; set; }
        public int[] NP_LOWER { get; set; }
        public int[] STAR_HIGHER { get; set; }
        public int[] STAR_LOWER { get; set; }
        public int[] HP_VAL_HIGHER { get; set; }
        public int[] HP_VAL_LOWER { get; set; }
        public int[] HP_PER_HIGHER { get; set; }
        public int[] HP_PER_LOWER { get; set; }
    }

    public class Individualuty
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }


    }
    public class Function
    {
        public int funcId { get; set; }
        public string funcType { get; set; }

    }
}