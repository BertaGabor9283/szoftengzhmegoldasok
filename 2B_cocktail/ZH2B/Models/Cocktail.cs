using System;
using System.Collections.Generic;

namespace ZH2B.Models;

public partial class Cocktail
{
    public int CocktailSk { get; set; }

    public string Name { get; set; } = null!;

    public int? TypeFk { get; set; }

    public decimal? Price { get; set; }

    public virtual ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();

    public virtual Type? TypeFkNavigation { get; set; }
}
