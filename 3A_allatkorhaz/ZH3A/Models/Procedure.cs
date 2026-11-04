using System;
using System.Collections.Generic;

namespace ZH3A.Models;

public partial class Procedure
{
    public int ProcedureSk { get; set; }

    public string Name { get; set; } = null!;

    public string? Unit { get; set; }

    public decimal? Price { get; set; }

    public virtual ICollection<ProcedureDone> ProcedureDones { get; set; } = new List<ProcedureDone>();
}
