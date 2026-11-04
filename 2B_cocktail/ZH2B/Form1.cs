namespace ZH2B
{
    public partial class Form1 : Form
    {
        Models.SeCocktailsContext context = new Models.SeCocktailsContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ③ ④
            cocktailBindingSource.DataSource = context.Cocktails.ToList();
            materialBindingSource.DataSource = context.Materials.ToList();
        }

        // ③ szűrés
        private void textBoxCocktailFilter_TextChanged(object sender, EventArgs e)
        {
            var l = from x in context.Cocktails
                    where x.Name.Contains(textBoxCocktailFilter.Text)
                    select x;

            cocktailBindingSource.DataSource = l.ToList();
        }

        // ⑦ bal listára kattintás
        private void cocktailBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            ReadRecipes();
        }

        void ReadRecipes()
        {
            if (cocktailBindingSource.Current == null) return;

            Models.Cocktail cocktail = cocktailBindingSource.Current as Models.Cocktail;

            var l = from x in context.Recipes
                    where x.CocktailFk == cocktail.CocktailSk
                    select new DetailedRecipeItem
                    {
                        RecipeSk = x.RecipeSk,
                        MaterialName = x.MaterialFkNavigation.Name,
                        MaterialType = x.MaterialFkNavigation.TypeFkNavigation.Name,
                        Quantity = x.Quantity ?? 0,
                        UnitName = x.MaterialFkNavigation.UnitFkNavigation.Name,
                    };

            detailedRecipeItemBindingSource.DataSource = l.ToList();
        }

        // ⑧ +
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (cocktailBindingSource.Current == null) return;
            if (materialBindingSource.Current == null) return;

            Models.Cocktail c = cocktailBindingSource.Current as Models.Cocktail;
            Models.Material m = materialBindingSource.Current as Models.Material;

            Models.Recipe newRecipe = new Models.Recipe();
            newRecipe.CocktailFk = c.CocktailSk;
            newRecipe.MaterialFk = m.MaterialId;
            newRecipe.Quantity = numericUpDownQuantity.Value;

            context.Recipes.Add(newRecipe);

            context.SaveChanges();

            ReadRecipes();

            //ToDo: try-catch
        }

        // ⑨ -
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DetailedRecipeItem ri = detailedRecipeItemBindingSource.Current as DetailedRecipeItem;
            if (ri == null) return;

            var törlendő = from x in context.Recipes
                           where x.RecipeSk == ri.RecipeSk
                           select x;

            context.Recipes.RemoveRange(törlendő);

            context.SaveChanges();

            ReadRecipes();
        }

        // Ⓐ Koktélok kezelése másik űrlapon
        private void buttonCocktails_Click(object sender, EventArgs e)
        {
            FormCocktails fc = new FormCocktails();
            fc.context = context;
            fc.ShowDialog();

            cocktailBindingSource.DataSource = context.Cocktails.ToList();
        }
    }
}
