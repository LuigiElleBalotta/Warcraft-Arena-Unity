﻿namespace Core
{
    public enum AuraEffectType
    {
        None = 0,
        BindSight = 1,
        ModPossess = 2,
        PeriodicDamage = 3,
        Dummy = 4,
        ConfusionState = 5,
        ModCharm = 6,
        ModFear = 7,
        PeriodicHealing = 8,
        ModAttackspeed = 9,
        ModThreat = 10,
        ModTaunt = 11,
        StunState = 12,
        ModDamageDone = 13,
        ModDamageTaken = 14,
        DamageShield = 15,
        Stealth = 16,
        ModifyStealthDetect = 17,
        ModInvisibility = 18,
        ModInvisibilityDetect = 19,
        ObsModHealth = 20,
        ModifyMaxPower = 21,
        ModResistance = 22,
        PeriodicTriggerSpell = 23,
        PeriodicEnergize = 24,
        ReflectSpells = 25,
        RootState = 26,
        Silence = 27,
        Pacify = 28,
        SilencePacify = 29,
        ModSkill = 30,
        SpeedIncreaseModifier = 31,
        SpeedSupressSlowEffects = 32,
        SpeedDecreaseModifier = 33,
        ModIncreaseHealth = 34,
        ModIncreaseEnergy = 35,
        ShapeShift = 36,
        EffectImmunity = 37,
        StateImmunity = 38,
        SchoolImmunity = 39,
        DamageImmunity = 40,
        DispelImmunity = 41,
        TriggerSpellChance = 42,
        ProcTriggerDamage = 43,
        TrackCreatures = 44,
        TrackResources = 45,
        ModParryPercent = 47,
        ModDodgePercent = 49,
        ModCriticalHealingAmount = 50,
        ModBlockPercent = 51,
        ModWeaponCritPercent = 52,
        PeriodicLeech = 53,
        ModHitChance = 54,
        ModSpellHitChance = 55,
        ChangeDisplayModel = 56,
        ModSpellCritChance = 57,
        ModIncreaseSwimSpeed = 58,
        ModDamageDoneCreature = 59,
        ModPacifySilence = 60,
        ModStat = 61,
        PeriodicHealthFunnel = 62,
        PeriodicManaLeech = 64,
        ModCastingSpeedNotStack = 65,
        FeignDeath = 66,
        ModDisarm = 67,
        ModStalked = 68,
        AbsorbDamage = 69,
        ExtraAttacks = 70,
        ModPowerCostSchoolPct = 72,
        ModPowerCostSchool = 73,
        ReflectSpellsSchool = 74,
        ModLanguage = 75,
        FarSight = 76,
        MechanicImmunity = 77,
        Mounted = 78,
        ModDamagePercentDone = 79,
        ModPercentStat = 80,
        SplitDamagePct = 81,
        WaterBreathing = 82,
        ModBaseResistance = 83,
        ModRegen = 84,
        ModPowerRegen = 85,
        ModifyDamagePercentDone = 86,
        ModifyDamagePercentTaken = 87,
        ModHealthRegenPercent = 88,
        PeriodicDamagePercent = 89,
        ModDetectRange = 91,
        PreventsFleeing = 92,
        ModUnattackable = 93,
        InterruptRegen = 94,
        Ghost = 95,
        SpellMagnet = 96,
        ManaShield = 97,
        ModSkillTalent = 98,
        ModAttackPower = 99,
        AurasVisible = 100,
        ModResistancePct = 101,
        ModMeleeAttackPowerVersus = 102,
        ModTotalThreat = 103,
        WaterWalk = 104,
        FeatherFall = 105,
        Hover = 106,
        AddFlatModifier = 107,
        AddPctModifier = 108,
        AddTargetTrigger = 109,
        ModifyPowerRegenPercent = 110,
        AddCasterHitTrigger = 111,
        OverrideClassScripts = 112,
        ModRangedDamageTaken = 113,
        ModRangedDamageTakenPct = 114,
        ModHealing = 115,
        ModRegenDuringCombat = 116,
        ModMechanicResistance = 117,
        ModHealingPct = 118,
        Untrackable = 120,
        Empathy = 121,
        ModOffhandDamagePct = 122,
        ModTargetResistance = 123,
        ModRangedAttackPower = 124,
        ModMeleeDamageTaken = 125,
        ModMeleeDamageTakenPct = 126,
        RangedAttackPowerAttackerBonus = 127,
        ModPossessPet = 128,
        SpeedStackableMultiplier = 129,
        SpeedNonStackableModifier = 130,
        ModRangedAttackPowerVersus = 131,
        ModIncreaseEnergyPercent = 132,
        ModIncreaseHealthPercent = 133,
        ModManaRegenInterrupt = 134,
        ModHealingDone = 135,
        ModHealingDonePercent = 136,
        ModTotalStatPercentage = 137,
        ModMeleeHaste = 138,
        ForceReaction = 139,
        ModRangedHaste = 140,
        ModBaseResistancePct = 142,
        ModResistanceExclusive = 143,
        SafeFall = 144,
        ModPetTalentPoints = 145,
        AllowTamePetType = 146,
        MechanicImmunityMask = 147,
        RetainComboPoints = 148,
        ReducePushback = 149,
        ModShieldBlockvaluePct = 150,
        TrackStealthed = 151,
        ModDetectedRange = 152,
        ModStealthLevel = 154,
        ModWaterBreathing = 155,
        ModReputationGain = 156,
        PetDamageMulti = 157,
        ModShieldBlockvalue = 158,
        NoPvpCredit = 159,
        ModHealthRegenInCombat = 161,
        PowerBurn = 162,
        ModifyCritDamageBonus = 163,
        MeleeAttackPowerAttackerBonus = 165,
        ModAttackPowerPct = 166,
        ModRangedAttackPowerPct = 167,
        ModDamageDoneVersus = 168,
        DetectAmore = 170,
        ModSpeedNotStack = 171,
        ModMountedSpeedNotStack = 172,
        ModSpellDamageOfStatPercent = 174,
        ModSpellHealingOfStatPercent = 175,
        SpiritOfRedemption = 176,
        ModAttackerSpellCritChanceForCaster = 177,
        ModAttackerSpellCritChance = 179,
        ModFlatSpellDamageVersus = 180,
        ModResistanceOfStatPercent = 182,
        ModCriticalThreat = 183,
        ModAttackerMeleeHitChance = 184,
        ModAttackerRangedHitChance = 185,
        ModAttackerSpellHitChance = 186,
        ModAttackerMeleeCritChance = 187,
        ModAttackerRangedCritChance = 188,
        ModRating = 189,
        ModFactionReputationGain = 190,
        UseNormalMovementSpeed = 191,
        ModMeleeRangedHaste = 192,
        MeleeSlow = 193,
        ModTargetAbsorbSchool = 194,
        ModTargetAbilityAbsorbSchool = 195,
        ModCooldown = 196,
        ModAttackerSpellAndWeaponCritChance = 197,
        ModXpPct = 200,
        IgnoreCombatResult = 202,
        ModAttackerMeleeCritDamage = 203,
        ModAttackerRangedCritDamage = 204,
        ModSchoolCritDMGTaken = 205,
        ModIncreaseVehicleFlightSpeed = 206,
        ModIncreaseMountedFlightSpeed = 207,
        ModIncreaseFlightSpeed = 208,
        ModMountedFlightSpeedAlways = 209,
        ModVehicleSpeedAlways = 210,
        ModFlightSpeedNotStack = 211,
        ModRageFromDamageDealt = 213,
        ArenaPreparation = 215,
        HasteSpells = 216,
        ModMeleeHaste2 = 217,
        HasteRanged = 218,
        ModManaRegenFromStat = 219,
        ModRatingFromStat = 220,
        ModDetaunt = 221,
        RaidProcFromCharge = 223,
        RaidProcFromChargeWithValue = 225,
        PeriodicDummy = 226,
        PeriodicTriggerSpellWithValue = 227,
        DetectAllStealth = 228,
        ModAOEDamageAvoidance = 229,
        ModMaxHealth = 230,
        ProcTriggerSpellWithValue = 231,
        MechanicDurationMod = 232,
        MechanicDurationModNotStack = 234,
        ModDispelResist = 235,
        ControlVehicle = 236,
        ModSpellDamageOfAttackPower = 237,
        ModSpellHealingOfAttackPower = 238,
        ModScale2 = 239,
        ModExpertise = 240,
        ForceMoveForward = 241,
        ModSpellDamageFromHealing = 242,
        ModFaction = 243,
        ComprehendLanguage = 244,
        ModAuraDurationByDispel = 245,
        ModAuraDurationByDispelNotStack = 246,
        CloneCaster = 247,
        ModCombatResultChance = 248,
        ConvertRune = 249,
        ModIncreaseHealth2 = 250,
        ModEnemyDodge = 251,
        ModSpeedSlowAll = 252,
        ModBlockCritChance = 253,
        ModDisarmOffhand = 254,
        ModMechanicDamageTakenPercent = 255,
        NoReagentUse = 256,
        ModTargetResistBySpellClass = 257,
        ScreenEffect = 260,
        Phase = 261,
        IgnoreTargetAuraState = 262,
        AllowOnlyAbility = 263,
        ModImmuneAuraApplySchool = 267,
        ModIgnoreTargetResist = 269,
        ModSpellDamageFromCaster = 271,
        IgnoreMeleeReset = 272,
        XRay = 273,
        IgnoreShapeShift = 275,
        ModDamageDoneForMechanic = 276,
        ModDisarmRanged = 278,
        InitializeImages = 279,
        ModHonorGainPct = 281,
        ModBaseHealthPct = 282,
        ModHealingReceived = 283,
        Linked = 284,
        ModAttackPowerOfArmor = 285,
        AbilityPeriodicCrit = 286,
        DeflectSpells = 287,
        IgnoreHitDirection = 288,
        PreventDurabilityLoss = 289,
        ModCritPct = 290,
        ModXpQuestPct = 291,
        OpenStable = 292,
        OverrideSpells = 293,
        PreventRegeneratePower = 294,
        SetVehicleID = 296,
        BlockSpellFamily = 297,
        Strangulate = 298,
        ShareDamagePct = 300,
        AbsorbHeal = 301,
        ModDamageDoneVersusAurastate = 303,
        ModFakeInebriate = 304,
        ModMinimumSpeed = 305,
        HealAbsorbTest = 307,
        ModCritChanceForCaster = 308,
        ModCreatureAOEDamageAvoidance = 310,
        AnimReplacementSet = 312,
        PreventResurrection = 314,
        UnderwaterWalking = 315,
        ModSpellPowerPct = 317,
        Mastery = 318,
        ModMeleeHaste3 = 319,
        ModRangedHaste2 = 320,
        ModNoActions = 321,
        InterfereTargetting = 322,
        ProcOnPowerAmount = 328,
        CastWhileWalking = 330,
        OverrideSpellCritCalculation = 331,
        OverrideActionbarSpells = 332,
        OverrideActionbarSpellsTriggered = 333,
        ModVendorItemsPrices = 337,
        ModDurabilityLoss = 338,
        ModMeleeRangedHaste2 = 342,
        ModSpellCooldownByHaste = 347,
        DepositBonusMoneyInGuildBankOnLoot = 348,
        ModCurrencyGain = 349,
        ModNextSpell = 363,
        MaxFarClipPlane = 365,
        EnablePowerBarTimer = 369,
        SetFairFarClip = 370,
        ModGlobalCooldownByHaste = 380,
        OverrideSpellVisual = 403,
        CanTurnWhileFalling = 409,
        ModMaxCharges = 411,
        ModCooldownByHasteRegen = 416,
        ModGlobalCooldownByHasteRegen = 417,
        OverridePetSpecs = 451,
        ChargeRecoveryMod = 453,
        ChargeRecoveryMultiplier = 454,
        ChargeRecoveryAffectedByHaste = 456,
        ChargeRecoveryAffectedByHasteRegen = 457,
        ModBonusArmorPct = 466,
        ModifyStatPercent = 467,
        TriggerSpellOnHealthBelowPct = 468,
    }
}