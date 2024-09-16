﻿using Wowthing.Tool.Converters.Manual;

namespace Wowthing.Tool.Models.Reputations;

[JsonConverter(typeof(ManualReputationCategoryConverter))]
public class ManualReputationCategory
{
    public int? MinimumLevel { get; set; }
    public string Name { get; set; }
    public List<List<ManualReputationCategorySet>> Reputations { get; set; }

    public string Slug => Name.Slugify();
}
