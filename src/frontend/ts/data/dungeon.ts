import {Dungeon, MythicPlusSeason} from '../types'
import type {Dictionary} from '../types'

const dungeonMap: Dictionary<Dungeon> = {
    // Battle for Azeroth
    244: new Dungeon(244, "Atal'Dazar", 'AD', 'dungeon_atal_dazar'),
    245: new Dungeon(245, 'Freehold', 'FH', 'dungeon_freehold'),
    246: new Dungeon(246, 'Tol Dagor', 'TD', 'dungeon_tol_dagor'),
    247: new Dungeon(247, 'The MOTHERLODE!!', 'ML', 'dungeon_the_motherlode'),
    248: new Dungeon(248, 'Waycrest Manor', 'WM', 'dungeon_waycrest_manor'),
    249: new Dungeon(249, "King's Rest", 'KR', 'dungeon_kings_rest'),
    250: new Dungeon(250, 'Temple of Sethraliss', 'ToS', 'dungeon_temple_of_sethraliss'),
    251: new Dungeon(251, 'The Underrot', 'UR', 'dungeon_the_underrot'),
    252: new Dungeon(252, 'Shrine of the Storm', 'SoS', 'dungeon_shrine_of_the_storm'),
    353: new Dungeon(353, 'Siege of Boralus', 'SoB', 'dungeon_siege_of_boralus'),
    369: new Dungeon(369, 'Operation: Mechagon - Junkyard', 'OMJ', 'dungeon_operation_mechagon_junkyard'),
    370: new Dungeon(370, 'Operation: Mechagon - Workshop', 'OMW', 'dungeon_operation_mechagon_workshop'),

    // Shadowlands
    375: new Dungeon(375, 'Mists of Tirna Scithe', 'MTS', 'dungeon_mists_of_tirna_scithe'),
    376: new Dungeon(376, 'The Necrotic Wake', 'NW', 'dungeon_the_necrotic_wake'),
    377: new Dungeon(377, 'De Other Side', 'DOS', 'dungeon_de_other_side'),
    378: new Dungeon(378, 'Halls of Atonement', 'HoA', 'dungeon_halls_of_atonement'),
    379: new Dungeon(379, 'Plaguefall', 'PF', 'dungeon_plaguefall'),
    380: new Dungeon(380, 'Sanguine Depths', 'SD', 'dungeon_sanguine_depths'),
    381: new Dungeon(381, 'Spires of Ascension', 'SoA', 'dungeon_spires_of_ascension'),
    382: new Dungeon(382, 'Theater of Pain', 'ToP', 'dungeon_theater_of_pain'),
}

const orderBattleForAzeroth: number[] = [
    244, // Atal'Dazar
    245, // Freehold
    249, // King's Rest
    247, // The MOTHERLODE!!
    252, // Shrine of the Storm
    353, // Siege of Boralus
    250, // Temple of Sethraliss
    246, // Tol Dagor
    251, // The Underrot
    248, // Waycrest Manor
]

// 8.3 dungeons
const orderBattleForAzeroth2: number[] = [
    369, // Operation: Mechagon - Junkyard
    370, // Operation: Mechagon - Workshop
]

const orderShadowlands: number[] = [
    377, // De Other Side
    378, // Halls of Atonement
    375, // Mists of Tirna Scithe
    376, // The Necrotic Wake
    379, // Plaguefall
    380, // Sanguine Depths
    381, // Spires of Ascension
    382, // Theater of Pain
]

const seasonMap: Dictionary<MythicPlusSeason> = {
    1: new MythicPlusSeason(1, 50, [orderBattleForAzeroth]),
    2: new MythicPlusSeason(2, 50, [orderBattleForAzeroth]),
    3: new MythicPlusSeason(3, 50, [orderBattleForAzeroth]),
    4: new MythicPlusSeason(4, 50, [orderBattleForAzeroth, orderBattleForAzeroth2]),
    5: new MythicPlusSeason(5, 60, [orderShadowlands]),
}

export {
    dungeonMap,
    seasonMap,
}
