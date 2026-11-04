using System.Xml.Linq;

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
            // ③ ④
            customerBindingSource.DataSource = context.Customers.ToList();
            productBindingSource.DataSource = context.Products.ToList();
        }

        // ③ szűrés
        private void textBoxCustomerFilter_TextChanged(object sender, EventArgs e)
        {
            var l = from x in context.Customers
                    where x.Email.Contains(textBoxCustomerFilter.Text)
                    select x;

            customerBindingSource.DataSource = l.ToList();
        }

        // ⑤ bal listára kattintás
        private void customerBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            ReadOrders();
        }

        void ReadOrders()
        {
            if (customerBindingSource.Current == null) return;

            Models.Customer customer = customerBindingSource.Current as Models.Customer;

            var l = from x in context.Orders
                    where x.CustomerFk == customer.CustomerSk
                    select x;

            orderBindingSource.DataSource = l.ToList();
        }

        // ⑧ második listára kattintás
        private void orderBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            ReadItems();
        }

        void ReadItems()
        {
            if (orderBindingSource.Current == null) return;

            Models.Order order = orderBindingSource.Current as Models.Order;

            var l = from x in context.OrderItems
                    where x.OrderFk == order.OrderSk
                    select new DetailedOrderItem
                    {
                        OrderFk = x.OrderFk,
                        ProductFk = x.ProductFk,
                        ProductName = x.ProductFkNavigation.ProductName,
                        Quantity = x.Quantity,
                        ListPrice = x.ListPrice,
                    };

            detailedOrderItemBindingSource.DataSource = l.ToList();

            // Ⓑ a kiválasztott rendelés értéke
            var ertek = from x in context.OrderItems
                        where x.OrderFk == order.OrderSk
                        select x.Quantity * (x.ListPrice ?? 0) * (1 - (x.Discount ?? 0));

            labelValue.Text = "Rendelés értéke: " + ertek.Sum();
        }

        // ⑨ +
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (orderBindingSource.Current == null) return;
            if (productBindingSource.Current == null) return;

            Models.Order o = orderBindingSource.Current as Models.Order;
            Models.Product p = productBindingSource.Current as Models.Product;

            Models.OrderItem newItem = new Models.OrderItem();
            newItem.OrderFk = o.OrderSk;
            newItem.ProductFk = p.ProductSk;
            newItem.Quantity = 1;
            newItem.ListPrice = p.ListPrice;
            newItem.Discount = 0;

            context.OrderItems.Add(newItem);

            context.SaveChanges();

            ReadItems();

            //ToDo: try-catch
        }

        // -
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DetailedOrderItem di = detailedOrderItemBindingSource.Current as DetailedOrderItem;
            if (di == null) return;

            var törlendő = from x in context.OrderItems
                           where x.OrderFk == di.OrderFk
                           &&
                           x.ProductFk == di.ProductFk
                           select x;

            context.OrderItems.RemoveRange(törlendő);

            context.SaveChanges();

            ReadItems();
        }

        // Ⓐ Customers tábla e-mail címei és nevei XML-be
        private void buttonSaveXml_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XML|*.xml";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                var l = from x in context.Customers.ToList()
                        select new XElement("Customer",
                            new XElement("Email", x.Email),
                            new XElement("FirstName", x.FirstName),
                            new XElement("LastName", x.LastName));

                new XDocument(new XElement("Customers", l)).Save(sfd.FileName);
            }
        }
    }
}
