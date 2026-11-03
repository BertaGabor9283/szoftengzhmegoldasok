using System.Xml.Serialization;
using Microsoft.EntityFrameworkCore;

namespace ZH4A
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
            ReadCustomers();
            ReadProducts();
        }

        // ③ bal lista: vásárlók, szűrhetően (e-mail alapján)
        void ReadCustomers()
        {
            var l = from x in context.Customers
                    where x.Email.Contains(textBoxCustomerFilter.Text)
                    orderby x.Email
                    select x;

            customerBindingSource.DataSource = l.ToList();
        }

        // ④ jobb lista: termékek (itt nincs szűrés)
        void ReadProducts()
        {
            var l = from x in context.Products
                    orderby x.ProductName
                    select x;

            productBindingSource.DataSource = l.ToList();
        }

        private void textBoxCustomerFilter_TextChanged(object sender, EventArgs e)
        {
            ReadCustomers();
        }

        // ⑤ a kiválasztott vásárló megrendelései
        private void customerBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            ReadOrders();
        }

        void ReadOrders()
        {
            Models.Customer? customer = customerBindingSource.Current as Models.Customer;
            if (customer == null)
            {
                orderBindingSource.DataSource = new List<Models.Order>();
                return;
            }

            var l = from x in context.Orders
                    where x.CustomerFk == customer.CustomerSk
                    orderby x.OrderDate
                    select x;

            orderBindingSource.DataSource = l.ToList();
        }

        // ⑧ a kiválasztott megrendelés elemei
        private void orderBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            ReadItems();
        }

        // ⑧ a kiválasztott megrendelés elemei DetailedOrderItem formában
        void ReadItems()
        {
            Models.Order? order = orderBindingSource.Current as Models.Order;
            if (order == null)
            {
                detailedOrderItemBindingSource.DataSource = new List<DetailedOrderItem>();
                labelValue.Text = "Rendelés értéke: " + 0m.ToString("N2");
                return;
            }

            var l = from x in context.OrderItems
                    where x.OrderFk == order.OrderSk
                    orderby x.ProductFkNavigation.ProductName
                    select new DetailedOrderItem
                    {
                        OrderFk = x.OrderFk,
                        ProductFk = x.ProductFk,
                        ProductName = x.ProductFkNavigation.ProductName,
                        Quantity = x.Quantity,
                        ListPrice = x.ListPrice
                    };

            detailedOrderItemBindingSource.DataSource = l.ToList();

            // Ⓑ a kiválasztott rendelés értéke: darab * listaár * (1 - kedvezmény)
            var values = from x in context.OrderItems
                         where x.OrderFk == order.OrderSk
                         select x.Quantity * (x.ListPrice ?? 0) * (1 - (x.Discount ?? 0));

            labelValue.Text = "Rendelés értéke: " + values.Sum().ToString("N2");
        }

        // ⑨ új rendelési tétel felvétele (a mennyiség mindig 1)
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Models.Order? order = orderBindingSource.Current as Models.Order;
            Models.Product? product = productBindingSource.Current as Models.Product;
            if (order == null || product == null) return;

            // összetett kulcs (order_FK, product_FK) -> ugyanaz a pár nem lehet kétszer
            bool exists = context.OrderItems.Any(x => x.OrderFk == order.OrderSk && x.ProductFk == product.ProductSk);
            if (exists)
            {
                MessageBox.Show("Ez a termék már szerepel a kiválasztott rendelésben!");
                return;
            }

            Models.OrderItem newItem = new Models.OrderItem();
            newItem.OrderFk = order.OrderSk;
            newItem.ProductFk = product.ProductSk;
            newItem.Quantity = 1;
            newItem.ListPrice = product.ListPrice;
            newItem.Discount = 0;

            context.OrderItems.Add(newItem);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                context.Entry(newItem).State = EntityState.Detached;
                MessageBox.Show(ex.Message);
            }

            ReadItems();
        }

        // törlés: a kiválasztott rendelési tétel
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DetailedOrderItem? item = detailedOrderItemBindingSource.Current as DetailedOrderItem;
            if (item == null) return;

            Models.OrderItem? toDelete = context.OrderItems.Find(item.OrderFk, item.ProductFk);
            if (toDelete == null) return;

            context.OrderItems.Remove(toDelete);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ReadItems();
        }

        // Ⓐ vásárlók (e-mail, név) mentése XML-be
        private void buttonSaveXml_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XML fájl (*.xml)|*.xml";
            sfd.FileName = "customers.xml";
            if (sfd.ShowDialog() != DialogResult.OK) return;

            var customers = (from x in context.Customers
                             orderby x.Email
                             select new CustomerXml
                             {
                                 Email = x.Email,
                                 FirstName = x.FirstName,
                                 LastName = x.LastName
                             }).ToList();

            XmlSerializer serializer = new XmlSerializer(typeof(List<CustomerXml>));
            using (StreamWriter sw = new StreamWriter(sfd.FileName))
            {
                serializer.Serialize(sw, customers);
            }

            MessageBox.Show("A mentés sikeres.");
        }
    }
}
