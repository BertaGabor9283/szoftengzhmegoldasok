using System;
using System.Collections.Generic;

namespace ZH1B.Models;

public partial class Recipe
{
    public int RecipeSk { get; set; }

    public int? CocktailFk { get; set; }

    public int? MaterialFk { get; set; }

    public decimal? Quantity { get; set; }

    public virtual Cocktail? CocktailFkNavigation { get; set; }

    public virtual Material? MaterialFkNavigation { get; set; }
}
