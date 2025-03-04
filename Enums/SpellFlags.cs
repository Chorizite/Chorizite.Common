﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Chorizite.Common.Enums {
    [Flags]
    public enum SpellFlags : uint {
        Resistable = 1,
        PKSensitive = 2,
        Beneficial = 4,
        SelfTargeted = 8,
        Reversed = 0x10,
        NotIndoor = 0x20,
        NotOutdoor = 0x40,
        NotResearchable = 0x80,
        Projectile = 0x100,
        CreatureSpell = 0x200,
        ExcludedFromItemDescriptions = 0x400,
        IgnoresManaConversion = 0x800,
        NonTrackingProjectile = 0x1000,
        FellowshipSpell = 0x2000,
        FastCast = 0x4000,
        IndoorLongRange = 0x8000,
        DamageOverTime = 0x10000,
        UNKNOWN = 0x20000
    }
}
