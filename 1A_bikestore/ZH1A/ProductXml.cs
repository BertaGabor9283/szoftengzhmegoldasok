namespace ZH1A
{
    // Egyszerű osztály az XML mentéshez (az entitás navigációs tulajdonságai miatt
    // a Models.Product közvetlenül nem szerializálható XmlSerializer-rel)
    public class ProductXml
    {
        public int ProductSk { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public int BrandId { get; set; }
        public int CategoryFk { get; set; }
        public short ModelYear { get; set; }
        public decimal ListPrice { get; set; }
    }
}
