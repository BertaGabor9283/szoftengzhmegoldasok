using System;
using System.Collections.Generic;

namespace ZH4B.Models;

public partial class Vendeg
{
    public string Usernev { get; set; } = null!;

    public string? Nev { get; set; }

    public string? Email { get; set; }

    public string? SzamlCim { get; set; }

    public DateOnly? SzulDat { get; set; }

    public virtual ICollection<Foglalas> Foglalas { get; set; } = new List<Foglalas>();
}
