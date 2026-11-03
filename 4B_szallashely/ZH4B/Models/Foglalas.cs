using System;
using System.Collections.Generic;

namespace ZH4B.Models;

public partial class Foglalas
{
    public int FoglalasPk { get; set; }

    public string? UgyfelFk { get; set; }

    public int? SzobaFk { get; set; }

    public DateOnly? Mettol { get; set; }

    public DateOnly? Meddig { get; set; }

    public int? FelnottSzam { get; set; }

    public int? GyermekSzam { get; set; }

    public virtual Szoba? SzobaFkNavigation { get; set; }

    public virtual Vendeg? UgyfelFkNavigation { get; set; }
}
