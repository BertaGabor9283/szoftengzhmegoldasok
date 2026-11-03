namespace ZH4A
{
    // ⑥ a rács adatforrása
    public class DetailedOrderItem
    {
        public int OrderFk { get; set; }
        public int ProductFk { get; set; }
        public string ProductName { get; set; } = null!;
        public int Quantity { get; set; }
        public decimal? ListPrice { get; set; }
    }
}
