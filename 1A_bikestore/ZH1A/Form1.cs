using System.Xml.Linq;

namespace ZH1A
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

            // Ⓑ termékek száma
            labelCount.Text = "Termékek száma: " + detailedStockItemBindingSource.Count;
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

        // Ⓐ Products tábla mentése XML-be
        private void buttonSaveXml_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XML|*.xml";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                var l = from x in context.Products.ToList()
                        select new XElement("Product",
                            new XElement("ProductSk", x.ProductSk),
                            new XElement("ProductName", x.ProductName),
                            new XElement("BrandId", x.BrandId),
                            new XElement("CategoryFk", x.CategoryFk),
                            new XElement("ModelYear", x.ModelYear),
                            new XElement("ListPrice", x.ListPrice));

                new XDocument(new XElement("Products", l)).Save(sfd.FileName);
            }
        }
    }
}
