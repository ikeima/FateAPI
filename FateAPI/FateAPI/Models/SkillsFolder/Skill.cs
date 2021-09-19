using System.Collections.Generic;

namespace FateAPI.Models.SkillsFolder
{
    public class Skill
    {
        public int id { get; set; }
        public int num { get; set; }
        public string name { get; set; }
        public string ruby { get; set; }
        public string detail { get; set; }
        public string type { get; set; }
        public int strengthStatus { get; set; }
        public string priority { get; set; }
        public int condQuestId { get; set; }
        public int condQuestPhase { get; set; }
        public int condLv { get; set; }
        public int condLimitCount { get; set; }
        public string icon { get; set; }
        public int[] coolDown { get; set; }
        public ActIndividuality[] actIndividuality { get; set; }
        public Script script { get; set; }
        public ExtraPassive[] extraPassive { get; set; }
        public SkillAdd[] skillAdd { get; set; }
        public Dictionary<int, int> aiIds { get; set; }
        public Functions[] functions { get; set; }
    }

    public class ActIndividuality
    {
        public int id { get; set; }
        public enum Name
        {
            unknown, genderMale, genderFemale, genderUnknown, classSaber, classLancer, classArcher, classRider, classCaster, classAssassin, classBerserker, classShielder, classRuler, classAlterEgo, classAvenger, classDemonGodPillar, classGrandCaster, classBeastI, classBeastII, classMoonCancer, classBeastIIIR, classForeigner, classBeastIIIL, classBeastUnknown, classPretender, attributeSky, attributeEarth, attributeHuman, attributeStar, attributeBeast, alignmentLawful, alignmentChaotic, alignmentNeutral, alignmentGood, alignmentEvil, alignmentBalanced, alignmentMadness, alignmentSummer, basedOnServant, human, undead, artificialDemon, demonBeast, daemon, soldier, amazoness, skeleton, zombie, ghost, automata, golem, spellBook, homunculus, lamia, centaur, werebeast, chimera, wyvern, dragonType, gazer, handOrDoor, demonGodPillar, oni, hand, door, threatToHumanity, divine, humanoid, dragon, dragonSlayer, roman, wildbeast, atalante, saberface, weakToEnumaElish, riding, arthur, skyOrEarth, brynhildsBeloved, undeadOrDaemon, demonic, skyOrEarthExceptPseudoAndDemi, divineOrDaemonOrUndead, saberClassServant, superGiant, king, greekMythologyMales, illya, feminineLookingServant, argonaut, genderCaenisServant, hominidaeServant, blessedByKur, demonicBeastServant, canBeInBattle, notBasedOnServant, livingHuman, cardArts, cardBuster, cardQuick, cardExtra, buffPositiveEffect, buffNegativeEffect, buffIncreaseDamage, buffIncreaseDefence, buffDecreaseDamage, buffDecreaseDefence, buffMentalEffect, buffPoison, buffCharm, buffPetrify, buffStun, buffBurn, buffSpecialResistUp, buffSpecialResistDown, buffEvadeAndInvincible, buffSureHit, buffNpSeal, buffEvade, buffInvincible, buffTargetFocus, buffGuts, skillSeal, buffCurse, buffAtkUp, buffPowerModStrUp, buffDamagePlus, buffNpDamageUp, buffCritDamageUp, buffCritRateUp, buffAtkDown, buffPowerModStrDown, buffDamageMinus, buffNpDamageDown, buffCritDamageDown, buffCritRateDown, buffDeathResistDown, buffDefenceUp, buffMaxHpUpPercent, buffMaxHpDownPercent, buffMaxHpUp, buffMaxHpDown, buffImmobilize, buffIncreasePoisonEffectiveness, buffPigify, buffCurseEffectUp, buffTerrorStunChanceAfterTurn, buffConfusion, buffOffensiveMode, buffDefensiveMode, buffLockCardsDeck, buffDisableColorCard, buffChangeField, buffIncreaseDefenceAgainstIndividuality, buffInvinciblePierce, buffHpRecoveryPerTurn, buffNegativeEffectImmunity, buffNegativeEffectAtTurnEnd, attackPhysical, attackProjectile, attackMagical, criticalHit, faceCard, cardNP, kingproteaGrowth, kingproteaProliferation, kingproteaProliferationNPDefense, fieldSunlight, fieldShore, fieldForest, fieldBurning, fieldCity, shadowServant, aoeNP, giant, childServant, buffSpecialInvincible, buffSkillRankUp, buffSleep, nobunaga, fieldImaginarySpace, existenceOutsideTheDomain, curse, fieldShoreOrImaginarySpace, shutenOnField, shuten, genji, vengeance, enemyGardenOfSinnersLivingCorpse, enemyGardenOfSinnersApartmentGhostAndSkeleton, enemyGardenOfSinnersBaseModel, enemyGardenOfSinnersVengefulSpiritOfSevenPeople, enemySaberEliWerebeastAndHomunculusAndKnight, enemySaberEliSkeletonAndGhostAndLamia, enemySaberEliBugAndGolem, enemySeraphEater, enemySeraphShapeshifter, enemySeraphTypeI, enemySeraphTypeSakura, enemyHimejiCastleKnightAndGazerAndMassProduction, enemyHimejiCastleDronesAndHomunculusAndAutomata, enemyHimejiCastleSkeletonAndScarecrow, enemyGuda3MiniNobu, enemyDavinciTrueEnemy, enemyDavinciFalseEnemy, enemyCaseFilesRareEnemy, enemyLasVegasBonusEnemy, enemySummerCampRareEnemy, enemyLittleBigTenguTsuwamonoEnemy, eventSaberWars, eventRashomon, eventOnigashima, eventOnigashimaRaid, eventPrisma, eventPrismaWorldEndMatch, eventNeroFest2, eventGuda2, eventNeroFest3, eventSetsubun, eventApocrypha, eventBattleInNewYork1, eventOniland, eventOoku, eventGuda4, eventLasVegas, eventBattleInNewYork2, eventSaberWarsII, eventSummerCamp, eventGuda5, cursedBook, buffCharmFemale, mechanical, fae, hasCostume, weakPointsRevealed, chenGongNpBlock, knightsOfTheRound, divineSpirit, buffNullifyBuff, enemyGudaMiniNobu, burningLove
        };
        public bool negative { get; set; }
    }
    public class Script
    {
        public int NP_HIGHER { get; set; }
        public int NP_LOWER { get; set; }
        public int STAR_HIGHER { get; set; }
        public int STAR_LOWER { get; set; }
        public int HP_VAL_HIGHER { get; set; }
        public int HP_VAL_LOWER { get; set; }
        public int HP_PER_HIGHER { get; set; }
        public int HP_PER_LOWER { get; set; }
    }
    public class ExtraPassive
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
    public class SkillAdd
    {
        public int priority { get; set; }
        public ReleaseConditions[] releaseConditions { get; set; }
        public string name { get; set; }
        public string ruby { get; set; }

    }
    public class ReleaseConditions
    {
        public int id { get; set; }
        public int priority { get; set; }
        public int condGroup { get; set; }
        public enum condType
        {
            none, questClear, itemGet, useItemEternity, useItemTime, useItemCount, svtLevel, svtLimit, svtGet, svtFriendship, svtGroup, @event, date, weekday, purchaseQpShop, purchaseStoneShop, warClear, flag, svtCountStop, birthDay, eventEnd, svtEventJoin, missionConditionDetail, eventMissionClear, eventMissionAchieve, questClearNum, notQuestGroupClear, raidAlive, raidDead, raidDamage, questChallengeNum, masterMission, questGroupClear, superBossDamage, superBossDamageAll, purchaseShop, questNotClear, notShopPurchase, notSvtGet, notEventShopPurchase, svtHaving, notSvtHaving, questChallengeNumEqual, questChallengeNumBelow, questClearNumEqual, questClearNumBelow, questClearPhase, notQuestClearPhase, eventPointGroupWin, eventNormaPointClear, questAvailable, questGroupAvailableNum, eventNormaPointNotClear, notItemGet, costumeGet, questResetAvailable, svtGetBeforeEventEnd, questClearRaw, questGroupClearRaw, eventGroupPointRatioInTerm, eventGroupRankInTerm, notEventRaceQuestOrNotAllGroupGoal, eventGroupTotalWinEachPlayer, eventScriptPlay, svtCostumeReleased, questNotClearAnd, svtRecoverd, shopReleased, eventPoint, eventRewardDispCount, equipWithTargetCostume, raidGroupDead, notSvtGroup, notQuestResetAvailable, notQuestClearRaw, notQuestGroupClearRaw, notEventMissionClear, notEventMissionAchieve, notCostumeGet, notSvtCostumeReleased, notEventRaceQuestOrNotTargetRankGoal, playerGenderType, shopGroupLimitNum, eventGroupPoint, eventGroupPointBelow, eventTotalPoint, eventTotalPointBelow, eventValue, eventValueBelow, eventFlag, eventStatus, notEventStatus, forceFalse, svtHavingLimitMax, eventPointBelow, svtEquipFriendshipHaving, movieNotDownload, multipleDate, svtFriendshipAbove, svtFriendshipBelow, movieDownloaded, routeSelect, notRouteSelect, limitCount, limitCountAbove, limitCountBelow, badEndPlay, commandCodeGet, notCommandCodeGet, allUsersBoxGachaCount, totalTdLevel, totalTdLevelAbove, totalTdLevelBelow, commonRelease, battleResultWin, battleResultLose, eventValueEqual, boardGameTokenHaving, boardGameTokenGroupHaving, eventFlagOn, eventFlagOff, questStatusFlagOn, questStatusFlagOff, eventValueNotEqual, limitCountMaxEqual, limitCountMaxAbove, limitCountMaxBelow, boardGameTokenGetNum, battleLineWinAbove, battleLineLoseAbove, battleLineContinueWin, battleLineContinueLose, battleLineContinueWinBelow, battleLineContinueLoseBelow, battleGroupWinAvove, battleGroupLoseAvove, svtLimitClassNum, overTimeLimitRaidAlive, onTimeLimitRaidDead, onTimeLimitRaidDeadNum, raidBattleProgressAbove, svtEquipRarityLevelNum, latestMainScenarioWarClear, eventMapValueContains, resetBirthDay, shopFlagOn, shopFlagOff, purchaseValidShopGroup, svtLevelClassNum, svtLevelIdNum, limitCountImageEqual, limitCountImageAbove, limitCountImageBelow, eventTypeStartTimeToEndDate, existBoxGachaScriptReplaceGiftId, notExistBoxGachaScriptReplaceGiftId
        };
        public int condId { get; set; }
        public int condNum { get; set; }


    }
    //class Functions
    //{
    //    public int funcId { get; set; }
    //    public enum funcType
    //    {
    //        none, addState, subState, damage, damageNp, gainStar, gainHp, gainNp, lossNp, shortenSkill, extendSkill, releaseState, lossHp, instantDeath, damageNpPierce, damageNpIndividual, addStateShort, gainHpPer, damageNpStateIndividual, hastenNpturn, delayNpturn, damageNpHpratioHigh, damageNpHpratioLow, cardReset, replaceMember, lossHpSafe, damageNpCounter, damageNpStateIndividualFix, damageNpSafe, callServant, ptShuffle, lossStar, changeServant, changeBg, damageValue, withdraw, fixCommandcard, shortenBuffturn, extendBuffturn, shortenBuffcount, extendBuffcount, changeBgm, displayBuffstring, resurrection, gainNpBuffIndividualSum, setSystemAliveFlag, forceInstantDeath, damageNpRare, gainNpFromTargets, gainHpFromTargets, lossHpPer, lossHpPerSafe, shortenUserEquipSkill, quickChangeBg, shiftServant, damageNpAndCheckIndividuality, absorbNpturn, overwriteDeadType, forceAllBuffNoact, breakGaugeUp, breakGaugeDown, moveToLastSubmember, expUp, qpUp, dropUp, friendPointUp, eventDropUp, eventDropRateUp, eventPointUp, eventPointRateUp, transformServant, qpDropUp, servantFriendshipUp, userEquipExpUp, classDropUp, enemyEncountCopyRateUp, enemyEncountRateUp, enemyProbDown, getRewardGift, sendSupportFriendPoint, movePosition, revival, damageNpIndividualSum, damageValueSafe, friendPointUpDuplicate, moveState, changeBgmCostume, func126, func127, updateEntryPositions
    //    }
    //    public enum funcTargetType
    //    {
    //        self, ptOne, ptAnother, ptAll, enemy, enemyAnother, enemyAll, ptFull, enemyFull, ptOther, ptOneOther, ptRandom, enemyOther, enemyRandom, ptOtherFull, enemyOtherFull, ptselectOneSub, ptselectSub, ptOneAnotherRandom, ptSelfAnotherRandom, enemyOneAnotherRandom, ptSelfAnotherFirst, ptSelfBefore, ptSelfAfter, ptSelfAnotherLast, commandTypeSelfTreasureDevice, fieldOther, enemyOneNoTargetNoAction, ptOneHpLowestValue, ptOneHpLowestRate
    //    }
    //    public enum funcTargetTeam
    //    {
    //        player, enemy, playerAndEnemy
    //    }
    //}


    public class Functions
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
        public BuffScript script { get; set; }
        public Val[] vals { get; set; }
        public Tval[] tvals { get; set; }
        public Ckselfindv[] ckSelfIndv { get; set; }
        public Ckopindv[] ckOpIndv { get; set; }
        public int maxRate { get; set; }
    }

    public class BuffScript
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

}
