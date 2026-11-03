using System;
using System.Collections.Generic;

namespace ZH3A.Models;

public partial class Animal
{
    public int AnimalSk { get; set; }

    public string Name { get; set; } = null!;

    public int? OwnerFk { get; set; }

    public int? BirthYear { get; set; }

    public int? SpeciesFk { get; set; }

    public virtual Owner? OwnerFkNavigation { get; set; }

    public virtual Species? SpeciesFkNavigation { get; set; }

    public virtual ICollection<Treatment> Treatments { get; set; } = new List<Treatment>();
}
