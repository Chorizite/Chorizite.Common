using System;

namespace Chorizite.Common.Enums {
    /// <summary>
    /// The objects type information
    /// </summary>
    [Flags]
    public enum ItemType : uint {
        MeleeWeapon = 0x00000001,

        Armor = 0x00000002,

        Clothing = 0x00000004,

        Jewelry = 0x00000008,

        Creature = 0x00000010,

        Food = 0x00000020,

        Money = 0x00000040,

        Misc = 0x00000080,

        MissileWeapon = 0x00000100,

        Container = 0x00000200,

        Useless = 0x00000400,

        Gem = 0x00000800,

        SpellComponents = 0x00001000,

        Writable = 0x00002000,

        Key = 0x00004000,

        Caster = 0x00008000,

        Portal = 0x00010000,

        Lockable = 0x00020000,

        PromissoryNote = 0x00040000,

        ManaStone = 0x00080000,

        Service = 0x00100000,

        MagicWieldable = 0x00200000,

        CraftCookingBase = 0x00400000,

        CraftAlchemyBase = 0x00800000,

        CraftFletchingBase = 0x02000000,

        CraftAlchemyIntermediate = 0x04000000,

        CraftFletchingIntermediate = 0x08000000,

        LifeStone = 0x10000000,

        TinkeringTool = 0x20000000,

        TinkeringMaterial = 0x40000000,

        Gameboard = 0x80000000,

    };
}
