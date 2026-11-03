using System.Globalization;
using Microsoft.EntityFrameworkCore;

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
            ReadCocktails();
            ReadMaterials();
        }

        // ③ bal lista: koktélok, szűrhetően
        void ReadCocktails()
        {
            var l = from x in context.Cocktails
                    where x.Name.Contains(textBoxCocktailFilter.Text)
                    orderby x.Name
                    select x;

            cocktailBindingSource.DataSource = l.ToList();
        }

        // ④ jobb lista: alapanyagok (itt is lehet szűrni)
        void ReadMaterials()
        {
            var l = from x in context.Materials
                    where x.Name.Contains(textBoxMaterialFilter.Text)
                    orderby x.Name
                    select x;

            materialBindingSource.DataSource = l.ToList();
        }

        private void textBoxCocktailFilter_TextChanged(object sender, EventArgs e)
        {
            ReadCocktails();
        }

        private void textBoxMaterialFilter_TextChanged(object sender, EventArgs e)
        {
            ReadMaterials();
        }

        private void cocktailBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            ReadRecipes();
        }

        // ⑦ a kiválasztott koktél receptje DetailedRecipeItem formában
        void ReadRecipes()
        {
            Models.Cocktail? cocktail = cocktailBindingSource.Current as Models.Cocktail;
            if (cocktail == null)
            {
                detailedRecipeItemBindingSource.DataSource = new List<DetailedRecipeItem>();
                return;
            }

            var l = from x in context.Recipes
                    where x.CocktailFk == cocktail.CocktailSk
                    orderby x.RecipeSk
                    select new DetailedRecipeItem
                    {
                        RecipeSk = x.RecipeSk,
                        MaterialName = x.MaterialFkNavigation!.Name ?? "",
                        MaterialType = x.MaterialFkNavigation!.TypeFkNavigation!.Name ?? "",
                        Quantity = x.Quantity ?? 0,
                        UnitName = x.MaterialFkNavigation!.UnitFkNavigation!.Name ?? ""
                    };

            detailedRecipeItemBindingSource.DataSource = l.ToList();
        }

        // ⑧ új recept elem felvétele
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Models.Cocktail? cocktail = cocktailBindingSource.Current as Models.Cocktail;
            Models.Material? material = materialBindingSource.Current as Models.Material;
            if (cocktail == null || material == null) return;

            // a tizedesvessző és a tizedespont is elfogadott
            string text = textBoxQuantity.Text.Trim().Replace(',', '.');
            if (!decimal.TryParse(text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out decimal quantity) || quantity <= 0)
            {
                MessageBox.Show("A mennyiség nem érvényes, pozitív szám!");
                return;
            }

            Models.Recipe newRecipe = new Models.Recipe();
            newRecipe.CocktailFk = cocktail.CocktailSk;
            newRecipe.MaterialFk = material.MaterialId;
            newRecipe.Quantity = quantity;

            context.Recipes.Add(newRecipe);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                context.Entry(newRecipe).State = EntityState.Detached;
                MessageBox.Show(ex.Message);
            }

            ReadRecipes();
        }

        // sikertelen mentés után a context-ben maradt hibás változások visszaállítása,
        // különben minden további SaveChanges() újra ugyanazt a hibát dobná
        void ResetFailedChanges()
        {
            foreach (var entry in context.ChangeTracker.Entries().ToList())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                    case EntityState.Deleted:
                        entry.State = EntityState.Unchanged;
                        break;
                    case EntityState.Modified:
                        entry.CurrentValues.SetValues(entry.OriginalValues);
                        entry.State = EntityState.Unchanged;
                        break;
                }
            }
        }

        // ⑨ törlés
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DetailedRecipeItem? item = detailedRecipeItemBindingSource.Current as DetailedRecipeItem;
            if (item == null) return;

            Models.Recipe? recipe = context.Recipes.Find(item.RecipeSk);
            if (recipe == null) return;

            context.Recipes.Remove(recipe);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                ResetFailedChanges();
                MessageBox.Show(ex.Message);
            }

            ReadRecipes();
        }

        // Ⓐ koktélok kezelése külön űrlapon (a context-et átadjuk, hogy közös legyen a szerkesztés)
        private void buttonCocktails_Click(object sender, EventArgs e)
        {
            using (FormCocktails form = new FormCocktails(context))
            {
                form.ShowDialog();

                // Mentés nélküli bezárás: a mentetlen változtatások elvesznek (nem maradnak a közös context-ben)
                ResetFailedChanges();
            }

            // a koktélok újraolvasása a lista frissítéséhez
            ReadCocktails();
            ReadRecipes();
        }
    }
}
