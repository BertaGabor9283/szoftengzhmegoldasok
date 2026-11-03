namespace ZH1B
{
    // Egyszerű osztály az XML mentéshez (az entitás navigációs tulajdonságai miatt
    // a Models.Cocktail közvetlenül nem szerializálható XmlSerializer-rel)
    public class CocktailXml
    {
        public int CocktailSk { get; set; }
        public string Name { get; set; } = string.Empty;
        public int? TypeFk { get; set; }
        public decimal? Price { get; set; }
    }
}
