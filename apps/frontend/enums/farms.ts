export enum FarmType
{
    Kill = 1,
    KillBig,
    Puzzle,
    Treasure,
    Event,
    EventBig,
    Cloth,
    Leather,
    Mail,
    Plate,
    Weapon,
    Vendor,
    Group,
    Quest,
    Dungeon,
    Raid,
    Profession,
    Achievement,
}

export enum RewardReputation {
    Friendly = 1,
    Honored = 2,
    Revered = 3,
    Exalted = 4,
    Acquaintance = 10,
    Buddy = 11,
    Friend = 12,
    GoodFriend = 13,
    BestFriend = 14,
    Preferred = 20,
    Respected = 21,
    Valued = 22,
    Esteemed = 23,
    Low = 30,
    Medium = 31,
    High = 32,
    Maximum = 33,
    DragonAcquaintance = 40,
    DragonCohort = 41,
    DragonAlly = 42,
    DragonFang = 43,
    DragonFriend = 44,
    DragonTrueFriend = 45,
    Renown1 = 101,
    Renown2 = 102,
    Renown3 = 103,
    Renown4 = 104,
    Renown5 = 105,
    Renown6 = 106,
    Renown7 = 107,
    Renown8 = 108,
    Renown9 = 109,
    Renown10 = 110,
    Renown11 = 111,
    Renown12 = 112,
    Renown13 = 113,
    Renown14 = 114,
    Renown15 = 115,
    Renown16 = 116,
    Renown17 = 117,
    Renown18 = 118,
    Renown19 = 119,
    Renown20 = 120,
    Renown21 = 121,
    Renown22 = 122,
    Renown23 = 123,
    Renown24 = 124,
    Renown25 = 125,
    Renown26 = 126,
    Renown27 = 127,
    Renown28 = 128,
    Renown29 = 129,
    Renown30 = 130,
}

export enum RewardType {
    Pet = 1,
    Mount,
    Quest,
    Toy,
    Cosmetic,
    Armor,
    Weapon,
    Achievement,
    Item,
    Illusion,
    Currency,
    Reputation,
    XpQuest,
    Transmog = 100,
    InstanceSpecial = 1000,
    SetSpecial = 1001,
}

export enum FarmIdType
{
    Npc = 1,
    Object,
    Quest,
    Instance,
    Group,
}

export enum FarmResetType
{
    None,
    Daily,
    BiWeekly,
    Weekly,
    Never,
    Monthly,
}

export enum FarmAnchorPoint
{
    None,
    TopLeft,
    Top,
    TopRight,
    Left,
    Center,
    Right,
    BottomLeft,
    Bottom,
    BottomRight,
}
