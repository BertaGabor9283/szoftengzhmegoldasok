namespace ZH3A
{
    // Egyszerű osztály az XML mentéshez (az entitás navigációs tulajdonságai miatt
    // a Models.Animal közvetlenül nem szerializálható XmlSerializer-rel)
    public class AnimalXml
    {
        public int AnimalSk { get; set; }
        public string Name { get; set; } = string.Empty;
        public int? OwnerFk { get; set; }
        public int? BirthYear { get; set; }
        public int? SpeciesFk { get; set; }
    }
}
