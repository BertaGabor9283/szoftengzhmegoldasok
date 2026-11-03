namespace ZH4B
{
    // Egyszerű osztály az XML mentéshez (az entitás navigációs tulajdonságai miatt
    // a Models.Szallashely közvetlenül nem szerializálható XmlSerializer-rel)
    public class SzallashelyXml
    {
        public int SzallasId { get; set; }
        public string? SzallasNev { get; set; }
    }
}
