using System;
using System.Collections.Generic;

namespace ZH3A.Models;

public partial class Locality
{
    public int LocalitySk { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Owner> Owners { get; set; } = new List<Owner>();
}
