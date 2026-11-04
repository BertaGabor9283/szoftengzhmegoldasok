using System;
using System.Collections.Generic;

namespace ZH1B.Models;

public partial class Unit
{
    public int UnitId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Material> Materials { get; set; } = new List<Material>();
}
