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
        public Individuality4[] individuality { get; set; }
        public Script script { get; set; }
        public Function7[] functions { get; set; }
        public Reverse reverse { get; set; }
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

    public class Reverse
    {
        public Nice nice { get; set; }
        public Basic basic { get; set; }
    }

    public class Nice
    {
        public Servant[] servant { get; set; }
        public MC[] MC { get; set; }
        public CC10[] CC { get; set; }
    }

    public class Servant
    {
        public int id { get; set; }
        public int collectionNo { get; set; }
        public string name { get; set; }
        public string ruby { get; set; }
        public string className { get; set; }
        public string type { get; set; }
        public string flag { get; set; }
        public int rarity { get; set; }
        public int cost { get; set; }
        public int lvMax { get; set; }
        public Extraassets extraAssets { get; set; }
        public string gender { get; set; }
        public string attribute { get; set; }
        public Trait[] traits { get; set; }
        public int starAbsorb { get; set; }
        public int starGen { get; set; }
        public int instantDeathChance { get; set; }
        public string[] cards { get; set; }
        public Hitsdistribution hitsDistribution { get; set; }
        public Carddetails cardDetails { get; set; }
        public int atkBase { get; set; }
        public int atkMax { get; set; }
        public int hpBase { get; set; }
        public int hpMax { get; set; }
        public int[] relateQuestIds { get; set; }
        public int growthCurve { get; set; }
        public int[] atkGrowth { get; set; }
        public int[] hpGrowth { get; set; }
        public int[] bondGrowth { get; set; }
        public int[] expGrowth { get; set; }
        public int[] expFeed { get; set; }
        public int bondEquip { get; set; }
        public int[] valentineEquip { get; set; }
        public Valentinescript[] valentineScript { get; set; }
        public int bondEquipOwner { get; set; }
        public int valentineEquipOwner { get; set; }
        public Ascensionadd ascensionAdd { get; set; }
        public Traitadd[] traitAdd { get; set; }
        public Svtchange[] svtChange { get; set; }
        public Ascensionmaterials ascensionMaterials { get; set; }
        public Skillmaterials skillMaterials { get; set; }
        public Appendskillmaterials appendSkillMaterials { get; set; }
        public Costumematerials costumeMaterials { get; set; }
        public Coin coin { get; set; }
        public Script1 script { get; set; }
        public Skill[] skills { get; set; }
        public Classpassive[] classPassive { get; set; }
        public Extrapassive2[] extraPassive { get; set; }
        public Appendpassive[] appendPassive { get; set; }
        public Noblephantasm[] noblePhantasms { get; set; }
        public Profile profile { get; set; }
    }

    public class Extraassets
    {
        public Charagraph charaGraph { get; set; }
        public Faces faces { get; set; }
        public Charagraphex charaGraphEx { get; set; }
        public Charagraphname charaGraphName { get; set; }
        public Narrowfigure narrowFigure { get; set; }
        public Charafigure charaFigure { get; set; }
        public Charafigureform charaFigureForm { get; set; }
        public Commands commands { get; set; }
        public Status status { get; set; }
        public Equipface equipFace { get; set; }
        public Image image { get; set; }
    }

    public class Charagraph
    {
        public Ascension ascension { get; set; }
        public Story story { get; set; }
        public Costume costume { get; set; }
        public Equip equip { get; set; }
        public Cc cc { get; set; }
    }

    public class Ascension
    {
    }

    public class Story
    {
    }

    public class Costume
    {
    }

    public class Equip
    {
    }

    public class Cc
    {
    }

    public class Faces
    {
        public Ascension1 ascension { get; set; }
        public Story1 story { get; set; }
        public Costume1 costume { get; set; }
        public Equip1 equip { get; set; }
        public Cc1 cc { get; set; }
    }

    public class Ascension1
    {
    }

    public class Story1
    {
    }

    public class Costume1
    {
    }

    public class Equip1
    {
    }

    public class Cc1
    {
    }

    public class Charagraphex
    {
        public Ascension2 ascension { get; set; }
        public Story2 story { get; set; }
        public Costume2 costume { get; set; }
        public Equip2 equip { get; set; }
        public Cc2 cc { get; set; }
    }

    public class Ascension2
    {
    }

    public class Story2
    {
    }

    public class Costume2
    {
    }

    public class Equip2
    {
    }

    public class Cc2
    {
    }

    public class Charagraphname
    {
        public Ascension3 ascension { get; set; }
        public Story3 story { get; set; }
        public Costume3 costume { get; set; }
        public Equip3 equip { get; set; }
        public Cc3 cc { get; set; }
    }

    public class Ascension3
    {
    }

    public class Story3
    {
    }

    public class Costume3
    {
    }

    public class Equip3
    {
    }

    public class Cc3
    {
    }

    public class Narrowfigure
    {
        public Ascension4 ascension { get; set; }
        public Story4 story { get; set; }
        public Costume4 costume { get; set; }
        public Equip4 equip { get; set; }
        public Cc4 cc { get; set; }
    }

    public class Ascension4
    {
    }

    public class Story4
    {
    }

    public class Costume4
    {
    }

    public class Equip4
    {
    }

    public class Cc4
    {
    }

    public class Charafigure
    {
        public Ascension5 ascension { get; set; }
        public Story5 story { get; set; }
        public Costume5 costume { get; set; }
        public Equip5 equip { get; set; }
        public Cc5 cc { get; set; }
    }

    public class Ascension5
    {
    }

    public class Story5
    {
    }

    public class Costume5
    {
    }

    public class Equip5
    {
    }

    public class Cc5
    {
    }

    public class Charafigureform
    {
    }

    public class Commands
    {
        public Ascension6 ascension { get; set; }
        public Story6 story { get; set; }
        public Costume6 costume { get; set; }
        public Equip6 equip { get; set; }
        public Cc6 cc { get; set; }
    }

    public class Ascension6
    {
    }

    public class Story6
    {
    }

    public class Costume6
    {
    }

    public class Equip6
    {
    }

    public class Cc6
    {
    }

    public class Status
    {
        public Ascension7 ascension { get; set; }
        public Story7 story { get; set; }
        public Costume7 costume { get; set; }
        public Equip7 equip { get; set; }
        public Cc7 cc { get; set; }
    }

    public class Ascension7
    {
    }

    public class Story7
    {
    }

    public class Costume7
    {
    }

    public class Equip7
    {
    }

    public class Cc7
    {
    }

    public class Equipface
    {
        public Ascension8 ascension { get; set; }
        public Story8 story { get; set; }
        public Costume8 costume { get; set; }
        public Equip8 equip { get; set; }
        public Cc8 cc { get; set; }
    }

    public class Ascension8
    {
    }

    public class Story8
    {
    }

    public class Costume8
    {
    }

    public class Equip8
    {
    }

    public class Cc8
    {
    }

    public class Image
    {
        public Ascension9 ascension { get; set; }
        public Story9 story { get; set; }
        public Costume9 costume { get; set; }
        public Equip9 equip { get; set; }
        public Cc9 cc { get; set; }
    }

    public class Ascension9
    {
    }

    public class Story9
    {
    }

    public class Costume9
    {
    }

    public class Equip9
    {
    }

    public class Cc9
    {
    }

    public class Hitsdistribution
    {
    }

    public class Carddetails
    {
    }

    public class Ascensionadd
    {
        public Individuality individuality { get; set; }
        public Voiceprefix voicePrefix { get; set; }
        public Overwriteservantname overWriteServantName { get; set; }
        public Overwriteservantbattlename overWriteServantBattleName { get; set; }
        public Overwritetdname overWriteTDName { get; set; }
        public Overwritetdruby overWriteTDRuby { get; set; }
        public Overwritetdfilename overWriteTDFileName { get; set; }
        public Overwritetdrank overWriteTDRank { get; set; }
        public Overwritetdtypetext overWriteTDTypeText { get; set; }
        public Lvmax lvMax { get; set; }
    }

    public class Individuality
    {
        public Ascension10 ascension { get; set; }
        public Costume10 costume { get; set; }
    }

    public class Ascension10
    {
    }

    public class Costume10
    {
    }

    public class Voiceprefix
    {
        public Ascension11 ascension { get; set; }
        public Costume11 costume { get; set; }
    }

    public class Ascension11
    {
    }

    public class Costume11
    {
    }

    public class Overwriteservantname
    {
        public Ascension12 ascension { get; set; }
        public Costume12 costume { get; set; }
    }

    public class Ascension12
    {
    }

    public class Costume12
    {
    }

    public class Overwriteservantbattlename
    {
        public Ascension13 ascension { get; set; }
        public Costume13 costume { get; set; }
    }

    public class Ascension13
    {
    }

    public class Costume13
    {
    }

    public class Overwritetdname
    {
        public Ascension14 ascension { get; set; }
        public Costume14 costume { get; set; }
    }

    public class Ascension14
    {
    }

    public class Costume14
    {
    }

    public class Overwritetdruby
    {
        public Ascension15 ascension { get; set; }
        public Costume15 costume { get; set; }
    }

    public class Ascension15
    {
    }

    public class Costume15
    {
    }

    public class Overwritetdfilename
    {
        public Ascension16 ascension { get; set; }
        public Costume16 costume { get; set; }
    }

    public class Ascension16
    {
    }

    public class Costume16
    {
    }

    public class Overwritetdrank
    {
        public Ascension17 ascension { get; set; }
        public Costume17 costume { get; set; }
    }

    public class Ascension17
    {
    }

    public class Costume17
    {
    }

    public class Overwritetdtypetext
    {
        public Ascension18 ascension { get; set; }
        public Costume18 costume { get; set; }
    }

    public class Ascension18
    {
    }

    public class Costume18
    {
    }

    public class Lvmax
    {
        public Ascension19 ascension { get; set; }
        public Costume19 costume { get; set; }
    }

    public class Ascension19
    {
    }

    public class Costume19
    {
    }

    public class Ascensionmaterials
    {
    }

    public class Skillmaterials
    {
    }

    public class Appendskillmaterials
    {
    }

    public class Costumematerials
    {
    }

    public class Coin
    {
        public int summonNum { get; set; }
        public Item item { get; set; }
    }

    public class Item
    {
        public int id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string[] uses { get; set; }
        public string detail { get; set; }
        public Individuality1[] individuality { get; set; }
        public string icon { get; set; }
        public string background { get; set; }
        public int priority { get; set; }
        public int dropPriority { get; set; }
    }

    public class Individuality1
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Script1
    {
        public Skillrankup SkillRankUp { get; set; }
    }

    public class Skillrankup
    {
    }

    public class Profile
    {
        public string cv { get; set; }
        public string illustrator { get; set; }
        public Stats stats { get; set; }
        public Costume20 costume { get; set; }
        public Comment[] comments { get; set; }
        public Voice[] voices { get; set; }
    }

    public class Stats
    {
        public string strength { get; set; }
        public string endurance { get; set; }
        public string agility { get; set; }
        public string magic { get; set; }
        public string luck { get; set; }
        public string np { get; set; }
    }

    public class Costume20
    {
    }

    public class Comment
    {
        public int id { get; set; }
        public int priority { get; set; }
        public string condMessage { get; set; }
        public string comment { get; set; }
        public string condType { get; set; }
        public int[] condValues { get; set; }
        public int condValue2 { get; set; }
    }

    public class Voice
    {
        public int svtId { get; set; }
        public int voicePrefix { get; set; }
        public string type { get; set; }
        public Voiceline[] voiceLines { get; set; }
    }

    public class Voiceline
    {
        public string name { get; set; }
        public string condType { get; set; }
        public int condValue { get; set; }
        public int priority { get; set; }
        public string svtVoiceType { get; set; }
        public string overwriteName { get; set; }
        public Summonscript summonScript { get; set; }
        public string[] id { get; set; }
        public string[] audioAssets { get; set; }
        public int[] delay { get; set; }
        public int[] face { get; set; }
        public int[] form { get; set; }
        public string[] text { get; set; }
        public string subtitle { get; set; }
        public Cond[] conds { get; set; }
        public Playcond[] playConds { get; set; }
    }

    public class Summonscript
    {
        public string scriptId { get; set; }
        public string script { get; set; }
    }

    public class Cond
    {
        public string condType { get; set; }
        public int value { get; set; }
        public int[] valueList { get; set; }
        public int eventId { get; set; }
    }

    public class Playcond
    {
        public int condGroup { get; set; }
        public string condType { get; set; }
        public int targetId { get; set; }
        public int condValue { get; set; }
        public int[] condValues { get; set; }
    }

    public class Trait
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Valentinescript
    {
        public string scriptId { get; set; }
        public string script { get; set; }
        public string scriptName { get; set; }
    }

    public class Traitadd
    {
        public int idx { get; set; }
        public Trait1[] trait { get; set; }
        public int limitCount { get; set; }
        public string condType { get; set; }
        public int condId { get; set; }
        public int condNum { get; set; }
    }

    public class Trait1
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Svtchange
    {
        public int[] beforeTreasureDeviceIds { get; set; }
        public int[] afterTreasureDeviceIds { get; set; }
        public int svtId { get; set; }
        public int priority { get; set; }
        public string condType { get; set; }
        public int condTargetId { get; set; }
        public int condValue { get; set; }
        public string name { get; set; }
        public int svtVoiceId { get; set; }
        public int limitCount { get; set; }
        public int flag { get; set; }
        public int battleSvtId { get; set; }
    }

    public class Skill
    {
        public int id { get; set; }
        public int num { get; set; }
        public string name { get; set; }
        public string ruby { get; set; }
        public string detail { get; set; }
        public string type { get; set; }
        public int strengthStatus { get; set; }
        public int priority { get; set; }
        public int condQuestId { get; set; }
        public int condQuestPhase { get; set; }
        public int condLv { get; set; }
        public int condLimitCount { get; set; }
        public string icon { get; set; }
        public int[] coolDown { get; set; }
        public Actindividuality[] actIndividuality { get; set; }
        public Script2 script { get; set; }
        public Extrapassive[] extraPassive { get; set; }
        public Skilladd[] skillAdd { get; set; }
        public Aiids aiIds { get; set; }
        public Function[] functions { get; set; }
    }

    public class Script2
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

    public class Aiids
    {
    }

    public class Actindividuality
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Extrapassive
    {
        public int num { get; set; }
        public int priority { get; set; }
        public int condQuestId { get; set; }
        public int condQuestPhase { get; set; }
        public int condLv { get; set; }
        public int condLimitCount { get; set; }
        public int condFriendshipRank { get; set; }
        public int eventId { get; set; }
        public int flag { get; set; }
        public int startedAt { get; set; }
        public int endedAt { get; set; }
    }

    public class Skilladd
    {
        public int priority { get; set; }
        public Releasecondition[] releaseConditions { get; set; }
        public string name { get; set; }
        public string ruby { get; set; }
    }

    public class Releasecondition
    {
        public int id { get; set; }
        public int priority { get; set; }
        public int condGroup { get; set; }
        public string condType { get; set; }
        public int condId { get; set; }
        public int condNum { get; set; }
    }

    public class Function
    {
        public int funcId { get; set; }
        public string funcType { get; set; }
        public string funcTargetType { get; set; }
        public string funcTargetTeam { get; set; }
        public string funcPopupText { get; set; }
        public string funcPopupIcon { get; set; }
        public Functval[] functvals { get; set; }
        public Funcquesttval[] funcquestTvals { get; set; }
        public Funcgroup[] funcGroup { get; set; }
        public Traitval[] traitVals { get; set; }
        public Buff[] buffs { get; set; }
        public Sval[] svals { get; set; }
        public Svals2[] svals2 { get; set; }
        public Svals3[] svals3 { get; set; }
        public Svals4[] svals4 { get; set; }
        public Svals5[] svals5 { get; set; }
        public Followerval[] followerVals { get; set; }
    }

    public class Functval
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Funcquesttval
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Funcgroup
    {
        public int eventId { get; set; }
        public int baseFuncId { get; set; }
        public string nameTotal { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public int priority { get; set; }
        public bool isDispValue { get; set; }
    }

    public class Traitval
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Buff
    {
        public int id { get; set; }
        public string name { get; set; }
        public string detail { get; set; }
        public string icon { get; set; }
        public string type { get; set; }
        public int buffGroup { get; set; }
        public Script3 script { get; set; }
        public Val[] vals { get; set; }
        public Tval[] tvals { get; set; }
        public Ckselfindv[] ckSelfIndv { get; set; }
        public Ckopindv[] ckOpIndv { get; set; }
        public int maxRate { get; set; }
    }

    public class Script3
    {
        public int checkIndvType { get; set; }
        public string[] CheckOpponentBuffTypes { get; set; }
        public Relationid relationId { get; set; }
        public string ReleaseText { get; set; }
        public int DamageRelease { get; set; }
        public INDIVIDUALITIE INDIVIDUALITIE { get; set; }
        public Upbuffratebuffindiv[] UpBuffRateBuffIndiv { get; set; }
        public int HP_LOWER { get; set; }
    }

    public class Relationid
    {
        public Atkside atkSide { get; set; }
        public Defside defSide { get; set; }
    }

    public class Atkside
    {
    }

    public class Defside
    {
    }

    public class INDIVIDUALITIE
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Upbuffratebuffindiv
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Val
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Tval
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Ckselfindv
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Ckopindv
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Sval
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
        public Dependfuncvals DependFuncVals { get; set; }
    }

    public class Dependfuncvals
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
    }

    public class Svals2
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
        public Dependfuncvals1 DependFuncVals { get; set; }
    }

    public class Dependfuncvals1
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
    }

    public class Svals3
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
        public Dependfuncvals2 DependFuncVals { get; set; }
    }

    public class Dependfuncvals2
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
    }

    public class Svals4
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
        public Dependfuncvals3 DependFuncVals { get; set; }
    }

    public class Dependfuncvals3
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
    }

    public class Svals5
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
        public Dependfuncvals4 DependFuncVals { get; set; }
    }

    public class Dependfuncvals4
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
    }

    public class Followerval
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
        public Dependfuncvals5 DependFuncVals { get; set; }
    }

    public class Dependfuncvals5
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
    }

    public class Classpassive
    {
        public int id { get; set; }
        public int num { get; set; }
        public string name { get; set; }
        public string ruby { get; set; }
        public string detail { get; set; }
        public string type { get; set; }
        public int strengthStatus { get; set; }
        public int priority { get; set; }
        public int condQuestId { get; set; }
        public int condQuestPhase { get; set; }
        public int condLv { get; set; }
        public int condLimitCount { get; set; }
        public string icon { get; set; }
        public int[] coolDown { get; set; }
        public Actindividuality1[] actIndividuality { get; set; }
        public Script4 script { get; set; }
        public Extrapassive1[] extraPassive { get; set; }
        public Skilladd1[] skillAdd { get; set; }
        public Aiids1 aiIds { get; set; }
        public Function1[] functions { get; set; }
    }

    public class Script4
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

    public class Aiids1
    {
    }

    public class Actindividuality1
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Extrapassive1
    {
        public int num { get; set; }
        public int priority { get; set; }
        public int condQuestId { get; set; }
        public int condQuestPhase { get; set; }
        public int condLv { get; set; }
        public int condLimitCount { get; set; }
        public int condFriendshipRank { get; set; }
        public int eventId { get; set; }
        public int flag { get; set; }
        public int startedAt { get; set; }
        public int endedAt { get; set; }
    }

    public class Skilladd1
    {
        public int priority { get; set; }
        public Releasecondition1[] releaseConditions { get; set; }
        public string name { get; set; }
        public string ruby { get; set; }
    }

    public class Releasecondition1
    {
        public int id { get; set; }
        public int priority { get; set; }
        public int condGroup { get; set; }
        public string condType { get; set; }
        public int condId { get; set; }
        public int condNum { get; set; }
    }

    public class Function1
    {
        public int funcId { get; set; }
        public string funcType { get; set; }
        public string funcTargetType { get; set; }
        public string funcTargetTeam { get; set; }
        public string funcPopupText { get; set; }
        public string funcPopupIcon { get; set; }
        public Functval1[] functvals { get; set; }
        public Funcquesttval1[] funcquestTvals { get; set; }
        public Funcgroup1[] funcGroup { get; set; }
        public Traitval1[] traitVals { get; set; }
        public Buff1[] buffs { get; set; }
        public Sval1[] svals { get; set; }
        public Svals21[] svals2 { get; set; }
        public Svals31[] svals3 { get; set; }
        public Svals41[] svals4 { get; set; }
        public Svals51[] svals5 { get; set; }
        public Followerval1[] followerVals { get; set; }
    }

    public class Functval1
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Funcquesttval1
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Funcgroup1
    {
        public int eventId { get; set; }
        public int baseFuncId { get; set; }
        public string nameTotal { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public int priority { get; set; }
        public bool isDispValue { get; set; }
    }

    public class Traitval1
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Buff1
    {
        public int id { get; set; }
        public string name { get; set; }
        public string detail { get; set; }
        public string icon { get; set; }
        public string type { get; set; }
        public int buffGroup { get; set; }
        public Script5 script { get; set; }
        public Val1[] vals { get; set; }
        public Tval1[] tvals { get; set; }
        public Ckselfindv1[] ckSelfIndv { get; set; }
        public Ckopindv1[] ckOpIndv { get; set; }
        public int maxRate { get; set; }
    }

    public class Script5
    {
        public int checkIndvType { get; set; }
        public string[] CheckOpponentBuffTypes { get; set; }
        public Relationid1 relationId { get; set; }
        public string ReleaseText { get; set; }
        public int DamageRelease { get; set; }
        public INDIVIDUALITIE1 INDIVIDUALITIE { get; set; }
        public Upbuffratebuffindiv1[] UpBuffRateBuffIndiv { get; set; }
        public int HP_LOWER { get; set; }
    }

    public class Relationid1
    {
        public Atkside1 atkSide { get; set; }
        public Defside1 defSide { get; set; }
    }

    public class Atkside1
    {
    }

    public class Defside1
    {
    }

    public class INDIVIDUALITIE1
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Upbuffratebuffindiv1
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Val1
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Tval1
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Ckselfindv1
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Ckopindv1
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Sval1
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
        public Dependfuncvals6 DependFuncVals { get; set; }
    }

    public class Dependfuncvals6
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
    }

    public class Svals21
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
        public Dependfuncvals7 DependFuncVals { get; set; }
    }

    public class Dependfuncvals7
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
    }

    public class Svals31
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
        public Dependfuncvals8 DependFuncVals { get; set; }
    }

    public class Dependfuncvals8
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
    }

    public class Svals41
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
        public Dependfuncvals9 DependFuncVals { get; set; }
    }

    public class Dependfuncvals9
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
    }

    public class Svals51
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
        public Dependfuncvals10 DependFuncVals { get; set; }
    }

    public class Dependfuncvals10
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
    }

    public class Followerval1
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
        public Dependfuncvals11 DependFuncVals { get; set; }
    }

    public class Dependfuncvals11
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
    }

    public class Extrapassive2
    {
        public int id { get; set; }
        public int num { get; set; }
        public string name { get; set; }
        public string ruby { get; set; }
        public string detail { get; set; }
        public string type { get; set; }
        public int strengthStatus { get; set; }
        public int priority { get; set; }
        public int condQuestId { get; set; }
        public int condQuestPhase { get; set; }
        public int condLv { get; set; }
        public int condLimitCount { get; set; }
        public string icon { get; set; }
        public int[] coolDown { get; set; }
        public Actindividuality2[] actIndividuality { get; set; }
        public Script6 script { get; set; }
        public Extrapassive3[] extraPassive { get; set; }
        public Skilladd2[] skillAdd { get; set; }
        public Aiids2 aiIds { get; set; }
        public Function2[] functions { get; set; }
    }

    public class Script6
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

    public class Aiids2
    {
    }

    public class Actindividuality2
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Extrapassive3
    {
        public int num { get; set; }
        public int priority { get; set; }
        public int condQuestId { get; set; }
        public int condQuestPhase { get; set; }
        public int condLv { get; set; }
        public int condLimitCount { get; set; }
        public int condFriendshipRank { get; set; }
        public int eventId { get; set; }
        public int flag { get; set; }
        public int startedAt { get; set; }
        public int endedAt { get; set; }
    }

    public class Skilladd2
    {
        public int priority { get; set; }
        public Releasecondition2[] releaseConditions { get; set; }
        public string name { get; set; }
        public string ruby { get; set; }
    }

    public class Releasecondition2
    {
        public int id { get; set; }
        public int priority { get; set; }
        public int condGroup { get; set; }
        public string condType { get; set; }
        public int condId { get; set; }
        public int condNum { get; set; }
    }

    public class Function2
    {
        public int funcId { get; set; }
        public string funcType { get; set; }
        public string funcTargetType { get; set; }
        public string funcTargetTeam { get; set; }
        public string funcPopupText { get; set; }
        public string funcPopupIcon { get; set; }
        public Functval2[] functvals { get; set; }
        public Funcquesttval2[] funcquestTvals { get; set; }
        public Funcgroup2[] funcGroup { get; set; }
        public Traitval2[] traitVals { get; set; }
        public Buff2[] buffs { get; set; }
        public Sval2[] svals { get; set; }
        public Svals22[] svals2 { get; set; }
        public Svals32[] svals3 { get; set; }
        public Svals42[] svals4 { get; set; }
        public Svals52[] svals5 { get; set; }
        public Followerval2[] followerVals { get; set; }
    }

    public class Functval2
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Funcquesttval2
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Funcgroup2
    {
        public int eventId { get; set; }
        public int baseFuncId { get; set; }
        public string nameTotal { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public int priority { get; set; }
        public bool isDispValue { get; set; }
    }

    public class Traitval2
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Buff2
    {
        public int id { get; set; }
        public string name { get; set; }
        public string detail { get; set; }
        public string icon { get; set; }
        public string type { get; set; }
        public int buffGroup { get; set; }
        public Script7 script { get; set; }
        public Val2[] vals { get; set; }
        public Tval2[] tvals { get; set; }
        public Ckselfindv2[] ckSelfIndv { get; set; }
        public Ckopindv2[] ckOpIndv { get; set; }
        public int maxRate { get; set; }
    }

    public class Script7
    {
        public int checkIndvType { get; set; }
        public string[] CheckOpponentBuffTypes { get; set; }
        public Relationid2 relationId { get; set; }
        public string ReleaseText { get; set; }
        public int DamageRelease { get; set; }
        public INDIVIDUALITIE2 INDIVIDUALITIE { get; set; }
        public Upbuffratebuffindiv2[] UpBuffRateBuffIndiv { get; set; }
        public int HP_LOWER { get; set; }
    }

    public class Relationid2
    {
        public Atkside2 atkSide { get; set; }
        public Defside2 defSide { get; set; }
    }

    public class Atkside2
    {
    }

    public class Defside2
    {
    }

    public class INDIVIDUALITIE2
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Upbuffratebuffindiv2
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Val2
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Tval2
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Ckselfindv2
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Ckopindv2
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Sval2
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
        public Dependfuncvals12 DependFuncVals { get; set; }
    }

    public class Dependfuncvals12
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
    }

    public class Svals22
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
        public Dependfuncvals13 DependFuncVals { get; set; }
    }

    public class Dependfuncvals13
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
    }

    public class Svals32
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
        public Dependfuncvals14 DependFuncVals { get; set; }
    }

    public class Dependfuncvals14
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
    }

    public class Svals42
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
        public Dependfuncvals15 DependFuncVals { get; set; }
    }

    public class Dependfuncvals15
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
    }

    public class Svals52
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
        public Dependfuncvals16 DependFuncVals { get; set; }
    }

    public class Dependfuncvals16
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
    }

    public class Followerval2
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
        public Dependfuncvals17 DependFuncVals { get; set; }
    }

    public class Dependfuncvals17
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
    }

    public class Appendpassive
    {
        public int num { get; set; }
        public int priority { get; set; }
        public Skill1 skill { get; set; }
        public Unlockmaterial[] unlockMaterials { get; set; }
    }

    public class Skill1
    {
        public int id { get; set; }
        public int num { get; set; }
        public string name { get; set; }
        public string ruby { get; set; }
        public string detail { get; set; }
        public string type { get; set; }
        public int strengthStatus { get; set; }
        public int priority { get; set; }
        public int condQuestId { get; set; }
        public int condQuestPhase { get; set; }
        public int condLv { get; set; }
        public int condLimitCount { get; set; }
        public string icon { get; set; }
        public int[] coolDown { get; set; }
        public Actindividuality3[] actIndividuality { get; set; }
        public Script8 script { get; set; }
        public Extrapassive4[] extraPassive { get; set; }
        public Skilladd3[] skillAdd { get; set; }
        public Aiids3 aiIds { get; set; }
        public Function3[] functions { get; set; }
    }

    public class Script8
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

    public class Aiids3
    {
    }

    public class Actindividuality3
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Extrapassive4
    {
        public int num { get; set; }
        public int priority { get; set; }
        public int condQuestId { get; set; }
        public int condQuestPhase { get; set; }
        public int condLv { get; set; }
        public int condLimitCount { get; set; }
        public int condFriendshipRank { get; set; }
        public int eventId { get; set; }
        public int flag { get; set; }
        public int startedAt { get; set; }
        public int endedAt { get; set; }
    }

    public class Skilladd3
    {
        public int priority { get; set; }
        public Releasecondition3[] releaseConditions { get; set; }
        public string name { get; set; }
        public string ruby { get; set; }
    }

    public class Releasecondition3
    {
        public int id { get; set; }
        public int priority { get; set; }
        public int condGroup { get; set; }
        public string condType { get; set; }
        public int condId { get; set; }
        public int condNum { get; set; }
    }

    public class Function3
    {
        public int funcId { get; set; }
        public string funcType { get; set; }
        public string funcTargetType { get; set; }
        public string funcTargetTeam { get; set; }
        public string funcPopupText { get; set; }
        public string funcPopupIcon { get; set; }
        public Functval3[] functvals { get; set; }
        public Funcquesttval3[] funcquestTvals { get; set; }
        public Funcgroup3[] funcGroup { get; set; }
        public Traitval3[] traitVals { get; set; }
        public Buff3[] buffs { get; set; }
        public Sval3[] svals { get; set; }
        public Svals23[] svals2 { get; set; }
        public Svals33[] svals3 { get; set; }
        public Svals43[] svals4 { get; set; }
        public Svals53[] svals5 { get; set; }
        public Followerval3[] followerVals { get; set; }
    }

    public class Functval3
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Funcquesttval3
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Funcgroup3
    {
        public int eventId { get; set; }
        public int baseFuncId { get; set; }
        public string nameTotal { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public int priority { get; set; }
        public bool isDispValue { get; set; }
    }

    public class Traitval3
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Buff3
    {
        public int id { get; set; }
        public string name { get; set; }
        public string detail { get; set; }
        public string icon { get; set; }
        public string type { get; set; }
        public int buffGroup { get; set; }
        public Script9 script { get; set; }
        public Val3[] vals { get; set; }
        public Tval3[] tvals { get; set; }
        public Ckselfindv3[] ckSelfIndv { get; set; }
        public Ckopindv3[] ckOpIndv { get; set; }
        public int maxRate { get; set; }
    }

    public class Script9
    {
        public int checkIndvType { get; set; }
        public string[] CheckOpponentBuffTypes { get; set; }
        public Relationid3 relationId { get; set; }
        public string ReleaseText { get; set; }
        public int DamageRelease { get; set; }
        public INDIVIDUALITIE3 INDIVIDUALITIE { get; set; }
        public Upbuffratebuffindiv3[] UpBuffRateBuffIndiv { get; set; }
        public int HP_LOWER { get; set; }
    }

    public class Relationid3
    {
        public Atkside3 atkSide { get; set; }
        public Defside3 defSide { get; set; }
    }

    public class Atkside3
    {
    }

    public class Defside3
    {
    }

    public class INDIVIDUALITIE3
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Upbuffratebuffindiv3
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Val3
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Tval3
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Ckselfindv3
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Ckopindv3
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Sval3
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
        public Dependfuncvals18 DependFuncVals { get; set; }
    }

    public class Dependfuncvals18
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
    }

    public class Svals23
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
        public Dependfuncvals19 DependFuncVals { get; set; }
    }

    public class Dependfuncvals19
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
    }

    public class Svals33
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
        public Dependfuncvals20 DependFuncVals { get; set; }
    }

    public class Dependfuncvals20
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
    }

    public class Svals43
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
        public Dependfuncvals21 DependFuncVals { get; set; }
    }

    public class Dependfuncvals21
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
    }

    public class Svals53
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
        public Dependfuncvals22 DependFuncVals { get; set; }
    }

    public class Dependfuncvals22
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
    }

    public class Followerval3
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
        public Dependfuncvals23 DependFuncVals { get; set; }
    }

    public class Dependfuncvals23
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
    }

    public class Unlockmaterial
    {
        public Item1 item { get; set; }
        public int amount { get; set; }
    }

    public class Item1
    {
        public int id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string[] uses { get; set; }
        public string detail { get; set; }
        public Individuality2[] individuality { get; set; }
        public string icon { get; set; }
        public string background { get; set; }
        public int priority { get; set; }
        public int dropPriority { get; set; }
    }

    public class Individuality2
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Noblephantasm
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
        public Npgain1 npGain { get; set; }
        public int[] npDistribution { get; set; }
        public int strengthStatus { get; set; }
        public int priority { get; set; }
        public int condQuestId { get; set; }
        public int condQuestPhase { get; set; }
        public Individuality3[] individuality { get; set; }
        public Script10 script { get; set; }
        public Function4[] functions { get; set; }
    }

    public class Npgain1
    {
        public int[] buster { get; set; }
        public int[] arts { get; set; }
        public int[] quick { get; set; }
        public int[] extra { get; set; }
        public int[] defence { get; set; }
        public int[] np { get; set; }
    }

    public class Script10
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

    public class Individuality3
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Function4
    {
        public int funcId { get; set; }
        public string funcType { get; set; }
        public string funcTargetType { get; set; }
        public string funcTargetTeam { get; set; }
        public string funcPopupText { get; set; }
        public string funcPopupIcon { get; set; }
        public Functval4[] functvals { get; set; }
        public Funcquesttval4[] funcquestTvals { get; set; }
        public Funcgroup4[] funcGroup { get; set; }
        public Traitval4[] traitVals { get; set; }
        public Buff4[] buffs { get; set; }
        public Sval4[] svals { get; set; }
        public Svals24[] svals2 { get; set; }
        public Svals34[] svals3 { get; set; }
        public Svals44[] svals4 { get; set; }
        public Svals54[] svals5 { get; set; }
        public Followerval4[] followerVals { get; set; }
    }

    public class Functval4
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Funcquesttval4
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Funcgroup4
    {
        public int eventId { get; set; }
        public int baseFuncId { get; set; }
        public string nameTotal { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public int priority { get; set; }
        public bool isDispValue { get; set; }
    }

    public class Traitval4
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Buff4
    {
        public int id { get; set; }
        public string name { get; set; }
        public string detail { get; set; }
        public string icon { get; set; }
        public string type { get; set; }
        public int buffGroup { get; set; }
        public Script11 script { get; set; }
        public Val4[] vals { get; set; }
        public Tval4[] tvals { get; set; }
        public Ckselfindv4[] ckSelfIndv { get; set; }
        public Ckopindv4[] ckOpIndv { get; set; }
        public int maxRate { get; set; }
    }

    public class Script11
    {
        public int checkIndvType { get; set; }
        public string[] CheckOpponentBuffTypes { get; set; }
        public Relationid4 relationId { get; set; }
        public string ReleaseText { get; set; }
        public int DamageRelease { get; set; }
        public INDIVIDUALITIE4 INDIVIDUALITIE { get; set; }
        public Upbuffratebuffindiv4[] UpBuffRateBuffIndiv { get; set; }
        public int HP_LOWER { get; set; }
    }

    public class Relationid4
    {
        public Atkside4 atkSide { get; set; }
        public Defside4 defSide { get; set; }
    }

    public class Atkside4
    {
    }

    public class Defside4
    {
    }

    public class INDIVIDUALITIE4
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Upbuffratebuffindiv4
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Val4
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Tval4
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Ckselfindv4
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Ckopindv4
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Sval4
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
        public Dependfuncvals24 DependFuncVals { get; set; }
    }

    public class Dependfuncvals24
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
    }

    public class Svals24
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
        public Dependfuncvals25 DependFuncVals { get; set; }
    }

    public class Dependfuncvals25
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
    }

    public class Svals34
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
        public Dependfuncvals26 DependFuncVals { get; set; }
    }

    public class Dependfuncvals26
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
    }

    public class Svals44
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
        public Dependfuncvals27 DependFuncVals { get; set; }
    }

    public class Dependfuncvals27
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
    }

    public class Svals54
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
        public Dependfuncvals28 DependFuncVals { get; set; }
    }

    public class Dependfuncvals28
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
    }

    public class Followerval4
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
        public Dependfuncvals29 DependFuncVals { get; set; }
    }

    public class Dependfuncvals29
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
    }

    public class MC
    {
        public int id { get; set; }
        public string name { get; set; }
        public string detail { get; set; }
        public int maxLv { get; set; }
        public Extraassets1 extraAssets { get; set; }
        public Skill2[] skills { get; set; }
        public int[] expRequired { get; set; }
    }

    public class Extraassets1
    {
        public Item2 item { get; set; }
        public Masterface masterFace { get; set; }
        public Masterfigure masterFigure { get; set; }
    }

    public class Item2
    {
        public string male { get; set; }
        public string female { get; set; }
    }

    public class Masterface
    {
        public string male { get; set; }
        public string female { get; set; }
    }

    public class Masterfigure
    {
        public string male { get; set; }
        public string female { get; set; }
    }

    public class Skill2
    {
        public int id { get; set; }
        public int num { get; set; }
        public string name { get; set; }
        public string ruby { get; set; }
        public string detail { get; set; }
        public string type { get; set; }
        public int strengthStatus { get; set; }
        public int priority { get; set; }
        public int condQuestId { get; set; }
        public int condQuestPhase { get; set; }
        public int condLv { get; set; }
        public int condLimitCount { get; set; }
        public string icon { get; set; }
        public int[] coolDown { get; set; }
        public Actindividuality4[] actIndividuality { get; set; }
        public Script12 script { get; set; }
        public Extrapassive5[] extraPassive { get; set; }
        public Skilladd4[] skillAdd { get; set; }
        public Aiids4 aiIds { get; set; }
        public Function5[] functions { get; set; }
    }

    public class Script12
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

    public class Aiids4
    {
    }

    public class Actindividuality4
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Extrapassive5
    {
        public int num { get; set; }
        public int priority { get; set; }
        public int condQuestId { get; set; }
        public int condQuestPhase { get; set; }
        public int condLv { get; set; }
        public int condLimitCount { get; set; }
        public int condFriendshipRank { get; set; }
        public int eventId { get; set; }
        public int flag { get; set; }
        public int startedAt { get; set; }
        public int endedAt { get; set; }
    }

    public class Skilladd4
    {
        public int priority { get; set; }
        public Releasecondition4[] releaseConditions { get; set; }
        public string name { get; set; }
        public string ruby { get; set; }
    }

    public class Releasecondition4
    {
        public int id { get; set; }
        public int priority { get; set; }
        public int condGroup { get; set; }
        public string condType { get; set; }
        public int condId { get; set; }
        public int condNum { get; set; }
    }

    public class Function5
    {
        public int funcId { get; set; }
        public string funcType { get; set; }
        public string funcTargetType { get; set; }
        public string funcTargetTeam { get; set; }
        public string funcPopupText { get; set; }
        public string funcPopupIcon { get; set; }
        public Functval5[] functvals { get; set; }
        public Funcquesttval5[] funcquestTvals { get; set; }
        public Funcgroup5[] funcGroup { get; set; }
        public Traitval5[] traitVals { get; set; }
        public Buff5[] buffs { get; set; }
        public Sval5[] svals { get; set; }
        public Svals25[] svals2 { get; set; }
        public Svals35[] svals3 { get; set; }
        public Svals45[] svals4 { get; set; }
        public Svals55[] svals5 { get; set; }
        public Followerval5[] followerVals { get; set; }
    }

    public class Functval5
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Funcquesttval5
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Funcgroup5
    {
        public int eventId { get; set; }
        public int baseFuncId { get; set; }
        public string nameTotal { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public int priority { get; set; }
        public bool isDispValue { get; set; }
    }

    public class Traitval5
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Buff5
    {
        public int id { get; set; }
        public string name { get; set; }
        public string detail { get; set; }
        public string icon { get; set; }
        public string type { get; set; }
        public int buffGroup { get; set; }
        public Script13 script { get; set; }
        public Val5[] vals { get; set; }
        public Tval5[] tvals { get; set; }
        public Ckselfindv5[] ckSelfIndv { get; set; }
        public Ckopindv5[] ckOpIndv { get; set; }
        public int maxRate { get; set; }
    }

    public class Script13
    {
        public int checkIndvType { get; set; }
        public string[] CheckOpponentBuffTypes { get; set; }
        public Relationid5 relationId { get; set; }
        public string ReleaseText { get; set; }
        public int DamageRelease { get; set; }
        public INDIVIDUALITIE5 INDIVIDUALITIE { get; set; }
        public Upbuffratebuffindiv5[] UpBuffRateBuffIndiv { get; set; }
        public int HP_LOWER { get; set; }
    }

    public class Relationid5
    {
        public Atkside5 atkSide { get; set; }
        public Defside5 defSide { get; set; }
    }

    public class Atkside5
    {
    }

    public class Defside5
    {
    }

    public class INDIVIDUALITIE5
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Upbuffratebuffindiv5
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Val5
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Tval5
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Ckselfindv5
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Ckopindv5
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Sval5
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
        public Dependfuncvals30 DependFuncVals { get; set; }
    }

    public class Dependfuncvals30
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
    }

    public class Svals25
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
        public Dependfuncvals31 DependFuncVals { get; set; }
    }

    public class Dependfuncvals31
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
    }

    public class Svals35
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
        public Dependfuncvals32 DependFuncVals { get; set; }
    }

    public class Dependfuncvals32
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
    }

    public class Svals45
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
        public Dependfuncvals33 DependFuncVals { get; set; }
    }

    public class Dependfuncvals33
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
    }

    public class Svals55
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
        public Dependfuncvals34 DependFuncVals { get; set; }
    }

    public class Dependfuncvals34
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
    }

    public class Followerval5
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
        public Dependfuncvals35 DependFuncVals { get; set; }
    }

    public class Dependfuncvals35
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
    }

    public class CC10
    {
        public int id { get; set; }
        public int collectionNo { get; set; }
        public string name { get; set; }
        public int rarity { get; set; }
        public Extraassets2 extraAssets { get; set; }
        public Skill3[] skills { get; set; }
        public string illustrator { get; set; }
        public string comment { get; set; }
    }

    public class Extraassets2
    {
        public Charagraph1 charaGraph { get; set; }
        public Faces1 faces { get; set; }
    }

    public class Charagraph1
    {
        public Ascension20 ascension { get; set; }
        public Story10 story { get; set; }
        public Costume21 costume { get; set; }
        public Equip10 equip { get; set; }
        public Cc11 cc { get; set; }
    }

    public class Ascension20
    {
    }

    public class Story10
    {
    }

    public class Costume21
    {
    }

    public class Equip10
    {
    }

    public class Cc11
    {
    }

    public class Faces1
    {
        public Ascension21 ascension { get; set; }
        public Story11 story { get; set; }
        public Costume22 costume { get; set; }
        public Equip11 equip { get; set; }
        public Cc12 cc { get; set; }
    }

    public class Ascension21
    {
    }

    public class Story11
    {
    }

    public class Costume22
    {
    }

    public class Equip11
    {
    }

    public class Cc12
    {
    }

    public class Skill3
    {
        public int id { get; set; }
        public int num { get; set; }
        public string name { get; set; }
        public string ruby { get; set; }
        public string detail { get; set; }
        public string type { get; set; }
        public int strengthStatus { get; set; }
        public int priority { get; set; }
        public int condQuestId { get; set; }
        public int condQuestPhase { get; set; }
        public int condLv { get; set; }
        public int condLimitCount { get; set; }
        public string icon { get; set; }
        public int[] coolDown { get; set; }
        public Actindividuality5[] actIndividuality { get; set; }
        public Script14 script { get; set; }
        public Extrapassive6[] extraPassive { get; set; }
        public Skilladd5[] skillAdd { get; set; }
        public Aiids5 aiIds { get; set; }
        public Function6[] functions { get; set; }
    }

    public class Script14
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

    public class Aiids5
    {
    }

    public class Actindividuality5
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Extrapassive6
    {
        public int num { get; set; }
        public int priority { get; set; }
        public int condQuestId { get; set; }
        public int condQuestPhase { get; set; }
        public int condLv { get; set; }
        public int condLimitCount { get; set; }
        public int condFriendshipRank { get; set; }
        public int eventId { get; set; }
        public int flag { get; set; }
        public int startedAt { get; set; }
        public int endedAt { get; set; }
    }

    public class Skilladd5
    {
        public int priority { get; set; }
        public Releasecondition5[] releaseConditions { get; set; }
        public string name { get; set; }
        public string ruby { get; set; }
    }

    public class Releasecondition5
    {
        public int id { get; set; }
        public int priority { get; set; }
        public int condGroup { get; set; }
        public string condType { get; set; }
        public int condId { get; set; }
        public int condNum { get; set; }
    }

    public class Function6
    {
        public int funcId { get; set; }
        public string funcType { get; set; }
        public string funcTargetType { get; set; }
        public string funcTargetTeam { get; set; }
        public string funcPopupText { get; set; }
        public string funcPopupIcon { get; set; }
        public Functval6[] functvals { get; set; }
        public Funcquesttval6[] funcquestTvals { get; set; }
        public Funcgroup6[] funcGroup { get; set; }
        public Traitval6[] traitVals { get; set; }
        public Buff6[] buffs { get; set; }
        public Sval6[] svals { get; set; }
        public Svals26[] svals2 { get; set; }
        public Svals36[] svals3 { get; set; }
        public Svals46[] svals4 { get; set; }
        public Svals56[] svals5 { get; set; }
        public Followerval6[] followerVals { get; set; }
    }

    public class Functval6
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Funcquesttval6
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Funcgroup6
    {
        public int eventId { get; set; }
        public int baseFuncId { get; set; }
        public string nameTotal { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public int priority { get; set; }
        public bool isDispValue { get; set; }
    }

    public class Traitval6
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Buff6
    {
        public int id { get; set; }
        public string name { get; set; }
        public string detail { get; set; }
        public string icon { get; set; }
        public string type { get; set; }
        public int buffGroup { get; set; }
        public Script15 script { get; set; }
        public Val6[] vals { get; set; }
        public Tval6[] tvals { get; set; }
        public Ckselfindv6[] ckSelfIndv { get; set; }
        public Ckopindv6[] ckOpIndv { get; set; }
        public int maxRate { get; set; }
    }

    public class Script15
    {
        public int checkIndvType { get; set; }
        public string[] CheckOpponentBuffTypes { get; set; }
        public Relationid6 relationId { get; set; }
        public string ReleaseText { get; set; }
        public int DamageRelease { get; set; }
        public INDIVIDUALITIE6 INDIVIDUALITIE { get; set; }
        public Upbuffratebuffindiv6[] UpBuffRateBuffIndiv { get; set; }
        public int HP_LOWER { get; set; }
    }

    public class Relationid6
    {
        public Atkside6 atkSide { get; set; }
        public Defside6 defSide { get; set; }
    }

    public class Atkside6
    {
    }

    public class Defside6
    {
    }

    public class INDIVIDUALITIE6
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Upbuffratebuffindiv6
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Val6
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Tval6
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Ckselfindv6
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Ckopindv6
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Sval6
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
        public Dependfuncvals36 DependFuncVals { get; set; }
    }

    public class Dependfuncvals36
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
    }

    public class Svals26
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
        public Dependfuncvals37 DependFuncVals { get; set; }
    }

    public class Dependfuncvals37
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
    }

    public class Svals36
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
        public Dependfuncvals38 DependFuncVals { get; set; }
    }

    public class Dependfuncvals38
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
    }

    public class Svals46
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
        public Dependfuncvals39 DependFuncVals { get; set; }
    }

    public class Dependfuncvals39
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
    }

    public class Svals56
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
        public Dependfuncvals40 DependFuncVals { get; set; }
    }

    public class Dependfuncvals40
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
    }

    public class Followerval6
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
        public Dependfuncvals41 DependFuncVals { get; set; }
    }

    public class Dependfuncvals41
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
    }

    public class Basic
    {
        public Servant1[] servant { get; set; }
        public MC1[] MC { get; set; }
        public CC13[] CC { get; set; }
    }

    public class Servant1
    {
        public int id { get; set; }
        public int collectionNo { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string flag { get; set; }
        public string className { get; set; }
        public string attribute { get; set; }
        public int rarity { get; set; }
        public int atkMax { get; set; }
        public int hpMax { get; set; }
        public string face { get; set; }
    }

    public class MC1
    {
        public int id { get; set; }
        public string name { get; set; }
        public Item3 item { get; set; }
    }

    public class Item3
    {
        public string male { get; set; }
        public string female { get; set; }
    }

    public class CC13
    {
        public int id { get; set; }
        public int collectionNo { get; set; }
        public string name { get; set; }
        public int rarity { get; set; }
        public string face { get; set; }
    }

    public class Individuality4
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Function7
    {
        public int funcId { get; set; }
        public string funcType { get; set; }
        public string funcTargetType { get; set; }
        public string funcTargetTeam { get; set; }
        public string funcPopupText { get; set; }
        public string funcPopupIcon { get; set; }
        public Functval7[] functvals { get; set; }
        public Funcquesttval7[] funcquestTvals { get; set; }
        public Funcgroup7[] funcGroup { get; set; }
        public Traitval7[] traitVals { get; set; }
        public Buff7[] buffs { get; set; }
        public Sval7[] svals { get; set; }
        public Svals27[] svals2 { get; set; }
        public Svals37[] svals3 { get; set; }
        public Svals47[] svals4 { get; set; }
        public Svals57[] svals5 { get; set; }
        public Followerval7[] followerVals { get; set; }
    }

    public class Functval7
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Funcquesttval7
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Funcgroup7
    {
        public int eventId { get; set; }
        public int baseFuncId { get; set; }
        public string nameTotal { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public int priority { get; set; }
        public bool isDispValue { get; set; }
    }

    public class Traitval7
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Buff7
    {
        public int id { get; set; }
        public string name { get; set; }
        public string detail { get; set; }
        public string icon { get; set; }
        public string type { get; set; }
        public int buffGroup { get; set; }
        public Script16 script { get; set; }
        public Val7[] vals { get; set; }
        public Tval7[] tvals { get; set; }
        public Ckselfindv7[] ckSelfIndv { get; set; }
        public Ckopindv7[] ckOpIndv { get; set; }
        public int maxRate { get; set; }
    }

    public class Script16
    {
        public int checkIndvType { get; set; }
        public string[] CheckOpponentBuffTypes { get; set; }
        public Relationid7 relationId { get; set; }
        public string ReleaseText { get; set; }
        public int DamageRelease { get; set; }
        public INDIVIDUALITIE7 INDIVIDUALITIE { get; set; }
        public Upbuffratebuffindiv7[] UpBuffRateBuffIndiv { get; set; }
        public int HP_LOWER { get; set; }
    }

    public class Relationid7
    {
        public Atkside7 atkSide { get; set; }
        public Defside7 defSide { get; set; }
    }

    public class Atkside7
    {
    }

    public class Defside7
    {
    }

    public class INDIVIDUALITIE7
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Upbuffratebuffindiv7
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Val7
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Tval7
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Ckselfindv7
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Ckopindv7
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool negative { get; set; }
    }

    public class Sval7
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
        public Dependfuncvals42 DependFuncVals { get; set; }
    }

    public class Dependfuncvals42
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
    }

    public class Svals27
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
        public Dependfuncvals43 DependFuncVals { get; set; }
    }

    public class Dependfuncvals43
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
    }

    public class Svals37
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
        public Dependfuncvals44 DependFuncVals { get; set; }
    }

    public class Dependfuncvals44
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
    }

    public class Svals47
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
        public Dependfuncvals45 DependFuncVals { get; set; }
    }

    public class Dependfuncvals45
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
    }

    public class Svals57
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
        public Dependfuncvals46 DependFuncVals { get; set; }
    }

    public class Dependfuncvals46
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
    }

    public class Followerval7
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
        public Dependfuncvals47 DependFuncVals { get; set; }
    }

    public class Dependfuncvals47
    {
        public int Rate { get; set; }
        public int Turn { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int UseRate { get; set; }
        public int Target { get; set; }
        public int Correction { get; set; }
        public int ParamAdd { get; set; }
        public int ParamMax { get; set; }
        public int HideMiss { get; set; }
        public int OnField { get; set; }
        public int HideNoEffect { get; set; }
        public int Unaffected { get; set; }
        public int ShowState { get; set; }
        public int AuraEffectId { get; set; }
        public int ActSet { get; set; }
        public int ActSetWeight { get; set; }
        public int ShowQuestNoEffect { get; set; }
        public int CheckDead { get; set; }
        public int RatioHPHigh { get; set; }
        public int RatioHPLow { get; set; }
        public int SetPassiveFrame { get; set; }
        public int ProcPassive { get; set; }
        public int ProcActive { get; set; }
        public int HideParam { get; set; }
        public int SkillID { get; set; }
        public int SkillLV { get; set; }
        public int ShowCardOnly { get; set; }
        public int EffectSummon { get; set; }
        public int RatioHPRangeHigh { get; set; }
        public int RatioHPRangeLow { get; set; }
        public int[] TargetList { get; set; }
        public int OpponentOnly { get; set; }
        public int StatusEffectId { get; set; }
        public int EndBattle { get; set; }
        public int LoseBattle { get; set; }
        public int AddIndividualty { get; set; }
        public int AddLinkageTargetIndividualty { get; set; }
        public int SameBuffLimitTargetIndividuality { get; set; }
        public int SameBuffLimitNum { get; set; }
        public int CheckDuplicate { get; set; }
        public int OnFieldCount { get; set; }
        public int[] TargetRarityList { get; set; }
        public int DependFuncId { get; set; }
        public int InvalidHide { get; set; }
        public int OutEnemyNpcId { get; set; }
        public int InEnemyNpcId { get; set; }
        public int OutEnemyPosition { get; set; }
        public int IgnoreIndividuality { get; set; }
        public int StarHigher { get; set; }
        public int ChangeTDCommandType { get; set; }
        public int ShiftNpcId { get; set; }
        public int DisplayLastFuncInvalidType { get; set; }
        public int[] AndCheckIndividualityList { get; set; }
        public int WinBattleNotRelatedSurvivalStatus { get; set; }
        public int ForceSelfInstantDeath { get; set; }
        public int ChangeMaxBreakGauge { get; set; }
        public int ParamAddMaxValue { get; set; }
        public int ParamAddMaxCount { get; set; }
        public int LossHpChangeDamage { get; set; }
        public int IncludePassiveIndividuality { get; set; }
        public int MotionChange { get; set; }
        public int PopLabelDelay { get; set; }
        public int NoTargetNoAct { get; set; }
        public int CardIndex { get; set; }
        public int CardIndividuality { get; set; }
        public int WarBoardTakeOverBuff { get; set; }
        public int[] ParamAddSelfIndividuality { get; set; }
        public int[] ParamAddOpIndividuality { get; set; }
        public int[] ParamAddFieldIndividuality { get; set; }
        public int ParamAddValue { get; set; }
        public int MultipleGainStar { get; set; }
        public int NoCheckIndividualityIfNotUnit { get; set; }
        public int ForcedEffectSpeedOne { get; set; }
        public int SetLimitCount { get; set; }
        public int CheckEnemyFieldSpace { get; set; }
        public int TriggeredFuncPosition { get; set; }
        public int DamageCount { get; set; }
        public int[] DamageRates { get; set; }
        public int[] OnPositions { get; set; }
        public int[] OffPositions { get; set; }
        public int TargetIndiv { get; set; }
        public int IncludeIgnoreIndividuality { get; set; }
        public int EvenIfWinDie { get; set; }
        public int ApplySupportSvt { get; set; }
        public int Individuality { get; set; }
        public int EventId { get; set; }
        public int AddCount { get; set; }
        public int RateCount { get; set; }
    }


}
