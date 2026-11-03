using System;
using System.Collections.Generic;

namespace ZH3A.Models;

public partial class Owner
{
    public int OwnerSk { get; set; }

    public string Name { get; set; } = null!;

    public int? LocalityFk { get; set; }

    public virtual ICollection<Animal> Animals { get; set; } = new List<Animal>();

    public virtual Locality? LocalityFkNavigation { get; set; }
}
