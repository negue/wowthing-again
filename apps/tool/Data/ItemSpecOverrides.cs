﻿namespace Wowthing.Tool.Data;

public partial class Hardcoded
{
    private static readonly int[] DeathKnightBlood = [250];
    private static readonly int[] DeathKnightFrostUnholy = [251, 252];
    private static readonly int[] DruidFeralGuardian = [103, 104];
    private static readonly int[] PaladinHoly = [65];
    private static readonly int[] PaladinProtection = [66];
    private static readonly int[] PaladinRetribution = [70];
    private static readonly int[] PriestShadow = [258];
    private static readonly int[] ShamanElemental = [262];
    private static readonly int[] ShamanEnhancement = [263];
    private static readonly int[] ShamanRestoration = [264];
    private static readonly int[] WarriorArmsFury = [71, 72];
    private static readonly int[] WarriorProtection = [73];

    public static readonly Dictionary<int, int[]> ItemSpecOverrides = new()
    {
        // Death Knight T9
        { 48529, DeathKnightBlood }, // Alliance helm
        { 48535, DeathKnightBlood }, // Alliance shoulders
        { 48531, DeathKnightBlood }, // Alliance chest
        { 48537, DeathKnightBlood }, // Alliance hands
        { 48533, DeathKnightBlood }, // Alliance legs
        { 48560, DeathKnightBlood }, // Horde helm
        { 48562, DeathKnightBlood }, // Horde shoulders
        { 48558, DeathKnightBlood }, // Horde chest
        { 48559, DeathKnightBlood }, // Horde hands
        { 48561, DeathKnightBlood }, // Horde legs
        { 48472, DeathKnightFrostUnholy }, // Alliance helm
        { 48478, DeathKnightFrostUnholy }, // Alliance shoulders
        { 48474, DeathKnightFrostUnholy }, // Alliance chest
        { 48480, DeathKnightFrostUnholy }, // Alliance hands
        { 48476, DeathKnightFrostUnholy }, // Alliance legs
        { 48503, DeathKnightFrostUnholy }, // Horde helm
        { 48505, DeathKnightFrostUnholy }, // Horde shoulders
        { 48501, DeathKnightFrostUnholy }, // Horde chest
        { 48502, DeathKnightFrostUnholy }, // Horde hands
        { 48504, DeathKnightFrostUnholy }, // Horde legs

        // Death Knight T10
        { 50855, DeathKnightBlood }, // A helm
        { 50853, DeathKnightBlood }, // A shoulders
        { 50857, DeathKnightBlood }, // A chest
        { 50856, DeathKnightBlood }, // A hands
        { 50854, DeathKnightBlood }, // A legs
        { 51133, DeathKnightBlood }, // B helm
        { 51130, DeathKnightBlood }, // B shoulders
        { 51134, DeathKnightBlood }, // B chest
        { 51132, DeathKnightBlood }, // B hands
        { 51131, DeathKnightBlood }, // B legs
        { 51306, DeathKnightBlood }, // C helm
        { 51309, DeathKnightBlood }, // C shoulders
        { 51305, DeathKnightBlood }, // C chest
        { 51307, DeathKnightBlood }, // C hands
        { 51308, DeathKnightBlood }, // C legs
        { 50096, DeathKnightFrostUnholy }, // A helm
        { 50098, DeathKnightFrostUnholy }, // A shoulders
        { 50094, DeathKnightFrostUnholy }, // A chest
        { 50095, DeathKnightFrostUnholy }, // A hands
        { 50097, DeathKnightFrostUnholy }, // A legs
        { 51127, DeathKnightFrostUnholy }, // B helm
        { 51125, DeathKnightFrostUnholy }, // B shoulders
        { 51129, DeathKnightFrostUnholy }, // B chest
        { 51128, DeathKnightFrostUnholy }, // B hands
        { 51126, DeathKnightFrostUnholy }, // B legs
        { 51312, DeathKnightFrostUnholy }, // C helm
        { 51314, DeathKnightFrostUnholy }, // C shoulders
        { 51310, DeathKnightFrostUnholy }, // C chest
        { 51311, DeathKnightFrostUnholy }, // C hands
        { 51313, DeathKnightFrostUnholy }, // C legs

        // Druid T10
        { 50826, DruidFeralGuardian }, // A helm
        { 50824, DruidFeralGuardian }, // A shoulders
        { 50828, DruidFeralGuardian }, // A chest
        { 50827, DruidFeralGuardian }, // A hands
        { 50825, DruidFeralGuardian }, // A legs
        { 51143, DruidFeralGuardian }, // B helm
        { 51140, DruidFeralGuardian }, // B shoulders
        { 51141, DruidFeralGuardian }, // B chest
        { 51144, DruidFeralGuardian }, // B hands
        { 51142, DruidFeralGuardian }, // B legs
        { 51296, DruidFeralGuardian }, // C helm
        { 51299, DruidFeralGuardian }, // C shoulders
        { 51298, DruidFeralGuardian }, // C chest
        { 51295, DruidFeralGuardian }, // C hands
        { 51297, DruidFeralGuardian }, // C legs

        // Paladin T10
        { 50867, PaladinHoly }, // A helm
        { 50865, PaladinHoly }, // A shoulders
        { 50869, PaladinHoly }, // A chest
        { 50868, PaladinHoly }, // A hands
        { 50866, PaladinHoly }, // A legs
        { 51167, PaladinHoly }, // B helm
        { 51166, PaladinHoly }, // B shoulders
        { 51165, PaladinHoly }, // B chest
        { 51169, PaladinHoly }, // B hands
        { 51168, PaladinHoly }, // B legs
        { 51272, PaladinHoly }, // C helm
        { 51273, PaladinHoly }, // C shoulders
        { 51274, PaladinHoly }, // C chest
        { 51270, PaladinHoly }, // C hands
        { 51271, PaladinHoly }, // C legs
        { 50862, PaladinProtection }, // A helm
        { 50860, PaladinProtection }, // A shoulders
        { 50864, PaladinProtection }, // A chest
        { 50863, PaladinProtection }, // A hands
        { 50861, PaladinProtection }, // A legs
        { 51173, PaladinProtection }, // B helm
        { 51170, PaladinProtection }, // B shoulders
        { 51174, PaladinProtection }, // B chest
        { 51172, PaladinProtection }, // B hands
        { 51171, PaladinProtection }, // B legs
        { 51266, PaladinProtection }, // C helm
        { 51269, PaladinProtection }, // C shoulders
        { 51265, PaladinProtection }, // C chest
        { 51267, PaladinProtection }, // C hands
        { 51268, PaladinProtection }, // C legs
        { 50326, PaladinRetribution }, // A helm
        { 50324, PaladinRetribution }, // A shoulders
        { 50328, PaladinRetribution }, // A chest
        { 50327, PaladinRetribution }, // A hands
        { 50325, PaladinRetribution }, // A legs
        { 51162, PaladinRetribution }, // B helm
        { 51160, PaladinRetribution }, // B shoulders
        { 51164, PaladinRetribution }, // B chest
        { 51163, PaladinRetribution }, // B hands
        { 51161, PaladinRetribution }, // B legs
        { 51277, PaladinRetribution }, // C helm
        { 51279, PaladinRetribution }, // C shoulders
        { 51275, PaladinRetribution }, // C chest
        { 51276, PaladinRetribution }, // C hands
        { 51278, PaladinRetribution }, // C legs

        // Priest T9
        { 48073, PriestShadow }, // Alliance helm
        { 48072, PriestShadow }, // Alliance hands
        { 48074, PriestShadow }, // Alliance legs
        { 48098, PriestShadow }, // Horde helm
        { 48097, PriestShadow }, // Horde hands
        { 48099, PriestShadow }, // Horde legs

        // Priest T10
        { 50391, PriestShadow }, // A hands
        { 50393, PriestShadow }, // A legs
        { 51183, PriestShadow }, // B hands
        { 51181, PriestShadow }, // B legs
        { 51256, PriestShadow }, // C hands
        { 51258, PriestShadow }, // C legs

        // Shaman T10
        { 50843, ShamanElemental }, // A helm
        { 50845, ShamanElemental }, // A shoulders
        { 50841, ShamanElemental }, // A chest
        { 50842, ShamanElemental }, // A hands
        { 50844, ShamanElemental }, // A legs
        { 51202, ShamanElemental }, // B helm
        { 51204, ShamanElemental }, // B shoulders
        { 51200, ShamanElemental }, // B chest
        { 51201, ShamanElemental }, // B hands
        { 51203, ShamanElemental }, // B legs
        { 51237, ShamanElemental }, // C helm
        { 51235, ShamanElemental }, // C shoulders
        { 51239, ShamanElemental }, // C chest
        { 51238, ShamanElemental }, // C hands
        { 51236, ShamanElemental }, // C legs
        { 50832, ShamanEnhancement }, // A helm
        { 50834, ShamanEnhancement }, // A shoulders
        { 50830, ShamanEnhancement }, // A chest
        { 50831, ShamanEnhancement }, // A hands
        { 50833, ShamanEnhancement }, // A legs
        { 51197, ShamanEnhancement }, // B helm
        { 51199, ShamanEnhancement }, // B shoulders
        { 51195, ShamanEnhancement }, // B chest
        { 51196, ShamanEnhancement }, // B hands
        { 51198, ShamanEnhancement }, // B legs
        { 51242, ShamanEnhancement }, // C helm
        { 51240, ShamanEnhancement }, // C shoulders
        { 51244, ShamanEnhancement }, // C chest
        { 51243, ShamanEnhancement }, // C hands
        { 51241, ShamanEnhancement }, // C legs
        { 50837, ShamanRestoration }, // A helm
        { 50839, ShamanRestoration }, // A shoulders
        { 50835, ShamanRestoration }, // A chest
        { 50836, ShamanRestoration }, // A hands
        { 50838, ShamanRestoration }, // A legs
        { 51192, ShamanRestoration }, // B helm
        { 51194, ShamanRestoration }, // B shoulders
        { 51190, ShamanRestoration }, // B chest
        { 51191, ShamanRestoration }, // B hands
        { 51193, ShamanRestoration }, // B legs
        { 51247, ShamanRestoration }, // C helm
        { 51245, ShamanRestoration }, // C shoulders
        { 51249, ShamanRestoration }, // C chest
        { 51248, ShamanRestoration }, // C hands
        { 51246, ShamanRestoration }, // C legs

        // Warrior T9
        { 48371, WarriorArmsFury }, // Alliance helm
        { 48374, WarriorArmsFury }, // Alliance shoulders
        { 48372, WarriorArmsFury }, // Alliance chest
        { 48375, WarriorArmsFury }, // Alliance hands
        { 48373, WarriorArmsFury }, // Alliance legs
        { 48388, WarriorArmsFury }, // Horde helm
        { 48390, WarriorArmsFury }, // Horde shoulders
        { 48386, WarriorArmsFury }, // Horde chest
        { 48387, WarriorArmsFury }, // Horde hands
        { 48389, WarriorArmsFury }, // Horde legs
        { 48429, WarriorProtection }, // Alliance helm
        { 48448, WarriorProtection }, // Alliance shoulders
        { 48436, WarriorProtection }, // Alliance chest
        { 48449, WarriorProtection }, // Alliance hands
        { 48445, WarriorProtection }, // Alliance legs
        { 48458, WarriorProtection }, // Horde helm
        { 48460, WarriorProtection }, // Horde shoulders
        { 48456, WarriorProtection }, // Horde chest
        { 48457, WarriorProtection }, // Horde hands
        { 48459, WarriorProtection }, // Horde legs

        // Warrior T10
        { 50080, WarriorArmsFury }, // A helm
        { 50082, WarriorArmsFury }, // A shoulders
        { 50078, WarriorArmsFury }, // A chest
        { 50079, WarriorArmsFury }, // A hands
        { 50081, WarriorArmsFury }, // A legs
        { 51212, WarriorArmsFury }, // B helm
        { 51210, WarriorArmsFury }, // B shoulders
        { 51214, WarriorArmsFury }, // B chest
        { 51213, WarriorArmsFury }, // B hands
        { 51211, WarriorArmsFury }, // B legs
        { 51227, WarriorArmsFury }, // C helm
        { 51229, WarriorArmsFury }, // C shoulders
        { 51225, WarriorArmsFury }, // C chest
        { 51226, WarriorArmsFury }, // C hands
        { 51228, WarriorArmsFury }, // C legs
        { 50848, WarriorProtection }, // A helm
        { 50846, WarriorProtection }, // A shoulders
        { 50850, WarriorProtection }, // A chest
        { 50849, WarriorProtection }, // A hands
        { 50847, WarriorProtection }, // A legs
        { 51218, WarriorProtection }, // B helm
        { 51215, WarriorProtection }, // B shoulders
        { 51219, WarriorProtection }, // B chest
        { 51217, WarriorProtection }, // B hands
        { 51216, WarriorProtection }, // B legs
        { 51221, WarriorProtection }, // C helm
        { 51224, WarriorProtection }, // C shoulders
        { 51220, WarriorProtection }, // C chest
        { 51222, WarriorProtection }, // C hands
        { 51223, WarriorProtection }, // C legs
    };
}
