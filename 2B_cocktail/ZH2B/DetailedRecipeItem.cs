namespace ZH2B
{
    // ⑤ a rács adatforrása
    public class DetailedRecipeItem
    {
        public int RecipeSk { get; set; }
        public string MaterialName { get; set; } = string.Empty;
        public string MaterialType { get; set; } = string.Empty;
        public decimal Quantity { get; set; }
        public string UnitName { get; set; } = string.Empty;
    }
}
