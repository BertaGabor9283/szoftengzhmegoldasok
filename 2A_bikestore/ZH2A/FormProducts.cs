using Microsoft.EntityFrameworkCore;

namespace ZH2A
{
    public partial class FormProducts : Form
    {
        Models.SeBikestoreContext context;

        // a Form1 context-jét kapjuk meg, így közös a szerkesztés
        public FormProducts(Models.SeBikestoreContext context)
        {
            InitializeComponent();
            this.context = context;
        }

        // kényelmi konstruktor önálló megnyitáshoz (futáskor a context-et átvevő konstruktort használjuk)
        public FormProducts() : this(new Models.SeBikestoreContext())
        {
        }

        private void FormProducts_Load(object sender, EventArgs e)
        {
            // Ⓑ a legördülő oszlopok adatforrásai (márkák, kategóriák)
            brandBindingSource.DataSource = (from x in context.Brands
                                             orderby x.BrandName
                                             select x).ToList();

            categoryBindingSource.DataSource = (from x in context.Categories
                                                orderby x.CategoryName
                                                select x).ToList();

            // Ⓐ a termékek betöltése; a Local.ToBindingList() miatt a rácson végzett
            // hozzáadás / módosítás / törlés követve lesz a context-ben
            context.Products.Load();
            productBindingSource.DataSource = context.Products.Local.ToBindingList();
        }

        // Ⓐ mentés
        private void buttonSave_Click(object sender, EventArgs e)
        {
            dataGridViewProducts.EndEdit();
            productBindingSource.EndEdit();

            try
            {
                context.SaveChanges();
                MessageBox.Show("A mentés sikeres.");
            }
            catch (Exception ex)
            {
                ResetFailedChanges();
                productBindingSource.DataSource = context.Products.Local.ToBindingList();
                productBindingSource.ResetBindings(false);
                MessageBox.Show(ex.Message);
            }
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

        // az új sor üres (0 értékű) idegen kulcsa nincs a legördülő listában, ezért ne dobjon hibát
        private void dataGridViewProducts_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }
    }
}
