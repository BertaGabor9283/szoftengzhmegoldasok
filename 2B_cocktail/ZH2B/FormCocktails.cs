namespace ZH2B
{
    public partial class FormCocktails : Form
    {
        public Models.SeCocktailsContext context = new Models.SeCocktailsContext();

        public FormCocktails()
        {
            InitializeComponent();
        }

        private void FormCocktails_Load(object sender, EventArgs e)
        {
            // Ⓑ a legördülő doboz adatai előbb, mint a rács adatai
            typeBindingSource.DataSource = context.Types.ToList();

            cocktailBindingSource.DataSource = context.Cocktails.ToList();
        }

        // +
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (typeBindingSource.Current == null) return;

            Models.Type t = typeBindingSource.Current as Models.Type;

            Models.Cocktail newCocktail = new Models.Cocktail();
            newCocktail.Name = "Új koktél";
            newCocktail.TypeFk = t.TypeId;
            newCocktail.Price = 0;

            context.Cocktails.Add(newCocktail);

            context.SaveChanges();

            cocktailBindingSource.DataSource = context.Cocktails.ToList();
        }

        // -
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Models.Cocktail c = cocktailBindingSource.Current as Models.Cocktail;
            if (c == null) return;

            var törlendő = from x in context.Cocktails
                           where x.CocktailSk == c.CocktailSk
                           select x;

            context.Cocktails.RemoveRange(törlendő);

            context.SaveChanges();

            cocktailBindingSource.DataSource = context.Cocktails.ToList();
        }

        // Ⓐ mentés
        private void buttonSave_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
        }
    }
}
