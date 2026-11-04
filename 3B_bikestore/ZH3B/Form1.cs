namespace ZH3B
{
    public partial class Form1 : Form
    {
        Models.SeBikestoreContext context = new Models.SeBikestoreContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ③ ④
            storeBindingSource.DataSource = context.Stores.ToList();
            productBindingSource.DataSource = context.Products.ToList();
        }

        // ③ szűrés
        private void textBoxStoreFilter_TextChanged(object sender, EventArgs e)
        {
            var l = from x in context.Stores
                    where x.StoreName.Contains(textBoxStoreFilter.Text)
                    select x;

            storeBindingSource.DataSource = l.ToList();
        }

        // ⑦ bal listára kattintás
        private void storeBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            ReadStocks();
        }

        void ReadStocks()
        {
            if (storeBindingSource.Current == null) return;

            Models.Store store = storeBindingSource.Current as Models.Store;

            var l = from x in context.Stocks
                    where x.StoreSk == store.StoreSk
                    select new DetailedStockItem
                    {
                        StoreId = x.StoreSk,
                        ProductId = x.ProductFk,
                        ProductName = x.ProductFkNavigation.ProductName,
                        Quantity = x.Quantity,
                    };

            detailedStockItemBindingSource.DataSource = l.ToList();
        }

        // ⑧ +
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (storeBindingSource.Current == null) return;
            if (productBindingSource.Current == null) return;

            Models.Store s = storeBindingSource.Current as Models.Store;
            Models.Product p = productBindingSource.Current as Models.Product;

            Models.Stock newStock = new Models.Stock();
            newStock.StoreSk = s.StoreSk;
            newStock.ProductFk = p.ProductSk;
            newStock.Quantity = (int)numericUpDownQuantity.Value;

            context.Stocks.Add(newStock);

            context.SaveChanges();

            ReadStocks();

            //ToDo: try-catch
        }

        // ⑨ -
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DetailedStockItem sd = detailedStockItemBindingSource.Current as DetailedStockItem;
            if (sd == null) return;

            var törlendő = from x in context.Stocks
                           where x.ProductFk == sd.ProductId
                           &&
                           x.StoreSk == sd.StoreId
                           select x;

            context.Stocks.RemoveRange(törlendő);

            context.SaveChanges();

            ReadStocks();
        }

        // Ⓐ Új bolt felvétele másik űrlapon
        private void buttonAddStore_Click(object sender, EventArgs e)
        {
            FormAddStore fas = new FormAddStore();
            if (fas.ShowDialog() == DialogResult.OK)
            {
                context.Stores.Add(fas.NewStore);
                context.SaveChanges();

                storeBindingSource.DataSource = context.Stores.ToList();
            }
        }
    }
}
