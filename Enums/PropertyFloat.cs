namespace Chorizite.Common.Enums {
    /// <summary>
    /// The PropertyFloat identifies a specific Character or Object float property.
    /// </summary>
    public enum PropertyFloat : uint {
        None = 0,

        HeartbeatInterval = 1,

        HeartbeatTimestamp = 2,

        HealthRate = 3,

        StaminaRate = 4,

        ManaRate = 5,

        HealthUponResurrection = 6,

        StaminaUponResurrection = 7,

        ManaUponResurrection = 8,

        StartTime = 9,

        StopTime = 10,

        ResetInterval = 11,

        Shade = 12,

        ArmorModVsSlash = 13,

        ArmorModVsPierce = 14,

        ArmorModVsBludgeon = 15,

        ArmorModVsCold = 16,

        ArmorModVsFire = 17,

        ArmorModVsAcid = 18,

        ArmorModVsElectric = 19,

        CombatSpeed = 20,

        WeaponLength = 21,

        DamageVariance = 22,

        CurrentPowerMod = 23,

        AccuracyMod = 24,

        StrengthMod = 25,

        MaximumVelocity = 26,

        RotationSpeed = 27,

        MotionTimestamp = 28,

        WeaponDefense = 29,

        WimpyLevel = 30,

        VisualAwarenessRange = 31,

        AuralAwarenessRange = 32,

        PerceptionLevel = 33,

        PowerupTime = 34,

        MaxChargeDistance = 35,

        ChargeSpeed = 36,

        BuyPrice = 37,

        SellPrice = 38,

        DefaultScale = 39,

        LockpickMod = 40,

        RegenerationInterval = 41,

        RegenerationTimestamp = 42,

        GeneratorRadius = 43,

        TimeToRot = 44,

        DeathTimestamp = 45,

        PkTimestamp = 46,

        VictimTimestamp = 47,

        LoginTimestamp = 48,

        CreationTimestamp = 49,

        MinimumTimeSincePk = 50,

        DeprecatedHousekeepingPriority = 51,

        AbuseLoggingTimestamp = 52,

        LastPortalTeleportTimestamp = 53,

        UseRadius = 54,

        HomeRadius = 55,

        ReleasedTimestamp = 56,

        MinHomeRadius = 57,

        Facing = 58,

        ResetTimestamp = 59,

        LogoffTimestamp = 60,

        EconRecoveryInterval = 61,

        WeaponOffense = 62,

        DamageMod = 63,

        ResistSlash = 64,

        ResistPierce = 65,

        ResistBludgeon = 66,

        ResistFire = 67,

        ResistCold = 68,

        ResistAcid = 69,

        ResistElectric = 70,

        ResistHealthBoost = 71,

        ResistStaminaDrain = 72,

        ResistStaminaBoost = 73,

        ResistManaDrain = 74,

        ResistManaBoost = 75,

        Translucency = 76,

        PhysicsScriptIntensity = 77,

        Friction = 78,

        Elasticity = 79,

        AiUseMagicDelay = 80,

        ItemMinSpellcraftMod = 81,

        ItemMaxSpellcraftMod = 82,

        ItemRankProbability = 83,

        Shade2 = 84,

        Shade3 = 85,

        Shade4 = 86,

        ItemEfficiency = 87,

        ItemManaUpdateTimestamp = 88,

        SpellGestureSpeedMod = 89,

        SpellStanceSpeedMod = 90,

        AllegianceAppraisalTimestamp = 91,

        PowerLevel = 92,

        AccuracyLevel = 93,

        AttackAngle = 94,

        AttackTimestamp = 95,

        CheckpointTimestamp = 96,

        SoldTimestamp = 97,

        UseTimestamp = 98,

        UseLockTimestamp = 99,

        HealkitMod = 100,

        FrozenTimestamp = 101,

        HealthRateMod = 102,

        AllegianceSwearTimestamp = 103,

        ObviousRadarRange = 104,

        HotspotCycleTime = 105,

        HotspotCycleTimeVariance = 106,

        SpamTimestamp = 107,

        SpamRate = 108,

        BondWieldedTreasure = 109,

        BulkMod = 110,

        SizeMod = 111,

        GagTimestamp = 112,

        GeneratorUpdateTimestamp = 113,

        DeathSpamTimestamp = 114,

        DeathSpamRate = 115,

        WildAttackProbability = 116,

        FocusedProbability = 117,

        CrashAndTurnProbability = 118,

        CrashAndTurnRadius = 119,

        CrashAndTurnBias = 120,

        GeneratorInitialDelay = 121,

        AiAcquireHealth = 122,

        AiAcquireStamina = 123,

        AiAcquireMana = 124,

        ResistHealthDrain = 125,

        LifestoneProtectionTimestamp = 126,

        AiCounteractEnchantment = 127,

        AiDispelEnchantment = 128,

        TradeTimestamp = 129,

        AiTargetedDetectionRadius = 130,

        EmotePriority = 131,

        LastTeleportStartTimestamp = 132,

        EventSpamTimestamp = 133,

        EventSpamRate = 134,

        InventoryOffset = 135,

        CriticalMultiplier = 136,

        ManaStoneDestroyChance = 137,

        SlayerDamageBonus = 138,

        AllegianceInfoSpamTimestamp = 139,

        AllegianceInfoSpamRate = 140,

        NextSpellcastTimestamp = 141,

        AppraisalRequestedTimestamp = 142,

        AppraisalHeartbeatDueTimestamp = 143,

        ManaConversionMod = 144,

        LastPkAttackTimestamp = 145,

        FellowshipUpdateTimestamp = 146,

        CriticalFrequency = 147,

        LimboStartTimestamp = 148,

        WeaponMissileDefense = 149,

        WeaponMagicDefense = 150,

        IgnoreShield = 151,

        ElementalDamageMod = 152,

        StartMissileAttackTimestamp = 153,

        LastRareUsedTimestamp = 154,

        IgnoreArmor = 155,

        ProcSpellRate = 156,

        ResistanceModifier = 157,

        AllegianceGagTimestamp = 158,

        AbsorbMagicDamage = 159,

        CachedMaxAbsorbMagicDamage = 160,

        GagDuration = 161,

        AllegianceGagDuration = 162,

        GlobalXpMod = 163,

        HealingModifier = 164,

        ArmorModVsNether = 165,

        ResistNether = 166,

        CooldownDuration = 167,

        WeaponAuraOffense = 168,

        WeaponAuraDefense = 169,

        WeaponAuraElemental = 170,

        WeaponAuraManaConv = 171,

    };
}
