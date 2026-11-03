namespace ZH4A
{
    // Egyszerű osztály az XML mentéshez (az entitás navigációs tulajdonságai miatt
    // a Models.Customer közvetlenül nem szerializálható XmlSerializer-rel)
    public class CustomerXml
    {
        public string Email { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
    }
}
