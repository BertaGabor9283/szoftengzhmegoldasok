using System;
using System.Collections.Generic;

namespace ZH4B.Models;

public partial class Szoba
{
    public int SzobaId { get; set; }

    public string? SzobaSzama { get; set; }

    public int? Ferohely { get; set; }

    public int? Potagy { get; set; }

    public string? Klimas { get; set; }

    public int? SzallasFk { get; set; }

    public virtual ICollection<Foglalas> Foglalas { get; set; } = new List<Foglalas>();

    public virtual Szallashely? SzallasFkNavigation { get; set; }
}
