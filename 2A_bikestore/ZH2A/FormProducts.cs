namespace ZH2A
{
    public partial class FormProducts : Form
    {
        public Models.SeBikestoreContext context = new Models.SeBikestoreContext();

        public FormProducts()
        {
            InitializeComponent();
        }

        private void FormProducts_Load(object sender, EventArgs e)
        {
            // Ⓑ a legördülő dobozok adatai előbb, mint a rács adatai
            brandBindingSource.DataSource = context.Brands.ToList();
            categoryBindingSource.DataSource = context.Categories.ToList();

            productBindingSource.DataSource = context.Products.ToList();
        }

        // +
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (brandBindingSource.Current == null) return;
            if (categoryBindingSource.Current == null) return;

            Models.Brand b = brandBindingSource.Current as Models.Brand;
            Models.Category c = categoryBindingSource.Current as Models.Category;

            Models.Product newProduct = new Models.Product();
            newProduct.ProductName = "Új termék";
            newProduct.BrandId = b.BrandSk;
            newProduct.CategoryFk = c.CategorySk;
            newProduct.ModelYear = 2016;
            newProduct.ListPrice = 0;

            context.Products.Add(newProduct);

            context.SaveChanges();

            productBindingSource.DataSource = context.Products.ToList();
        }

        // -
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Models.Product p = productBindingSource.Current as Models.Product;
            if (p == null) return;

            var törlendő = from x in context.Products
                           where x.ProductSk == p.ProductSk
                           select x;

            context.Products.RemoveRange(törlendő);

            context.SaveChanges();

            productBindingSource.DataSource = context.Products.ToList();
        }

        // Ⓐ mentés
        private void buttonSave_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
        }
    }
}
