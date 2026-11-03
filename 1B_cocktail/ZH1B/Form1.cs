using System.Globalization;
using System.Xml.Serialization;
using Microsoft.EntityFrameworkCore;

namespace ZH1B
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
                labelCount.Text = "Hozzávalók száma: 0";
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

            var list = l.ToList();
            detailedRecipeItemBindingSource.DataSource = list;

            // Ⓑ a kiválasztott koktél hozzávalóinak száma
            labelCount.Text = $"Hozzávalók száma: {list.Count}";
        }

        // ⑧ új recept elem felvétele
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Models.Cocktail? cocktail = cocktailBindingSource.Current as Models.Cocktail;
            Models.Material? material = materialBindingSource.Current as Models.Material;
            if (cocktail == null || material == null) return;

            // a tizedesvessző és a tizedespont is elfogadott
            string text = textBoxQuantity.Text.Trim().Replace(',', '.');
            if (!decimal.TryParse(text, NumberStyles.Number, CultureInfo.InvariantCulture, out decimal quantity))
            {
                MessageBox.Show("A mennyiség nem érvényes szám!");
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
                MessageBox.Show(ex.Message);
            }

            ReadRecipes();
        }

        // Ⓐ Cocktail tábla mentése XML-be
        private void buttonSaveXml_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XML fájl (*.xml)|*.xml";
            sfd.FileName = "cocktails.xml";
            if (sfd.ShowDialog() != DialogResult.OK) return;

            var cocktails = (from x in context.Cocktails
                             orderby x.CocktailSk
                             select new CocktailXml
                             {
                                 CocktailSk = x.CocktailSk,
                                 Name = x.Name,
                                 TypeFk = x.TypeFk,
                                 Price = x.Price
                             }).ToList();

            XmlSerializer serializer = new XmlSerializer(typeof(List<CocktailXml>));
            using (StreamWriter sw = new StreamWriter(sfd.FileName))
            {
                serializer.Serialize(sw, cocktails);
            }

            MessageBox.Show("A mentés sikeres.");
        }
    }
}
