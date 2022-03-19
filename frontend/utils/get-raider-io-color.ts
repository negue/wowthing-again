import type { CharacterRaiderIoSeason } from '@/types'
import type { StaticDataRaiderIoScoreTiers } from '@/types/data/static'


export default function getRaiderIoColor(
    scores: CharacterRaiderIoSeason,
    tiers: StaticDataRaiderIoScoreTiers,
    score: number
): string {
    for (let i = 0; i < tiers.score.length; i++) {
        if (score >= tiers.score[i]) {
            return tiers.rgbHex[i]
        }
    }
    return null
}
