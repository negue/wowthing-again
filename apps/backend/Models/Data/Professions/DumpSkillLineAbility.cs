﻿using CsvHelper.Configuration.Attributes;

// ReSharper disable InconsistentNaming
namespace Wowthing.Backend.Models.Data.Professions;

public class DumpSkillLineAbility
{
    public int ID { get; set; }
    public int MinSkillLineRank { get; set; }
    public int NumSkillUps { get; set; }
    public int SkillLine { get; set; }
    public int SkillupSkillLineID { get; set; }
    public int Spell { get; set; }
    public int TradeSkillCategoryID { get; set; }
    public int TrivialSkillLineRankHigh { get; set; }
    public int TrivialSkillLineRankLow { get; set; }
    public int UniqueBit { get; set; }
}
