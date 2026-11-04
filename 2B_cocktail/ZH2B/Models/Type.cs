using System;
using System.Collections.Generic;

namespace ZH2B.Models;

public partial class Type
{
    public int TypeId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Cocktail> Cocktails { get; set; } = new List<Cocktail>();
}
