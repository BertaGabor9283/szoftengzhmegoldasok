using System;
using System.Collections.Generic;

namespace ZH3A.Models;

public partial class Species
{
    public int SpeciesSk { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Animal> Animals { get; set; } = new List<Animal>();
}
