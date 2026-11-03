using System.Xml.Serialization;
using Microsoft.EntityFrameworkCore;

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
            ReadStores();
            ReadProducts();
        }

        // ③ bal lista: boltok, szűrhetően
        void ReadStores()
        {
            var l = from x in context.Stores
                    where x.StoreName.Contains(textBoxStoreFilter.Text)
                    orderby x.StoreName
                    select x;

            storeBindingSource.DataSource = l.ToList();
        }

        // ④ jobb lista: termékek (itt is lehet szűrni)
        void ReadProducts()
        {
            var l = from x in context.Products
                    where x.ProductName.Contains(textBoxProductFilter.Text)
                    orderby x.ProductName
                    select x;

            productBindingSource.DataSource = l.ToList();
        }

        private void textBoxStoreFilter_TextChanged(object sender, EventArgs e)
        {
            ReadStores();
        }

        private void textBoxProductFilter_TextChanged(object sender, EventArgs e)
        {
            ReadProducts();
        }

        private void storeBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            ReadStocks();
        }

        // ⑦ a kiválasztott bolt készlete DetailedStockItem formában
        void ReadStocks()
        {
            Models.Store? store = storeBindingSource.Current as Models.Store;
            if (store == null)
            {
                detailedStockItemBindingSource.DataSource = new List<DetailedStockItem>();
                labelCount.Text = "Termékek száma: 0";
                return;
            }

            var l = from x in context.Stocks
                    where x.StoreSk == store.StoreSk
                    orderby x.ProductFkNavigation.ProductName
                    select new DetailedStockItem
                    {
                        StoreId = x.StoreSk,
                        ProductId = x.ProductFk,
                        ProductName = x.ProductFkNavigation.ProductName,
                        Quantity = x.Quantity
                    };

            var list = l.ToList();
            detailedStockItemBindingSource.DataSource = list;

            // Ⓑ a kiválasztott boltban lévő termékek száma
            labelCount.Text = $"Termékek száma: {list.Count}";
        }

        // ⑧ új készlet elem felvétele
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Models.Store? store = storeBindingSource.Current as Models.Store;
            Models.Product? product = productBindingSource.Current as Models.Product;
            if (store == null || product == null) return;

            if (!int.TryParse(textBoxQuantity.Text, out int quantity))
            {
                MessageBox.Show("A mennyiség nem érvényes egész szám!");
                return;
            }

            // összetett kulcs (store_SK, product_FK) -> ugyanaz a pár nem lehet kétszer
            bool exists = context.Stocks.Any(x => x.StoreSk == store.StoreSk && x.ProductFk == product.ProductSk);
            if (exists)
            {
                MessageBox.Show("Ez a termék már szerepel a kiválasztott bolt készletében!");
                return;
            }

            Models.Stock newStock = new Models.Stock();
            newStock.StoreSk = store.StoreSk;
            newStock.ProductFk = product.ProductSk;
            newStock.Quantity = quantity;

            context.Stocks.Add(newStock);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                context.Entry(newStock).State = EntityState.Detached;
                MessageBox.Show(ex.Message);
            }

            ReadStocks();
        }

        // ⑨ törlés
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DetailedStockItem? item = detailedStockItemBindingSource.Current as DetailedStockItem;
            if (item == null) return;

            var törlendő = from x in context.Stocks
                           where x.StoreSk == item.StoreId && x.ProductFk == item.ProductId
                           select x;

            context.Stocks.RemoveRange(törlendő);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ReadStocks();
        }

        // Ⓐ Products tábla mentése XML-be
        private void buttonSaveXml_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XML fájl (*.xml)|*.xml";
            sfd.FileName = "products.xml";
            if (sfd.ShowDialog() != DialogResult.OK) return;

            var products = (from x in context.Products
                            orderby x.ProductSk
                            select new ProductXml
                            {
                                ProductSk = x.ProductSk,
                                ProductName = x.ProductName,
                                BrandId = x.BrandId,
                                CategoryFk = x.CategoryFk,
                                ModelYear = x.ModelYear,
                                ListPrice = x.ListPrice
                            }).ToList();

            XmlSerializer serializer = new XmlSerializer(typeof(List<ProductXml>));
            using (StreamWriter sw = new StreamWriter(sfd.FileName))
            {
                serializer.Serialize(sw, products);
            }

            MessageBox.Show("A mentés sikeres.");
        }
    }
}
