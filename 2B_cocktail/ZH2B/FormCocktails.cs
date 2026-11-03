using Microsoft.EntityFrameworkCore;

namespace ZH2B
{
    public partial class FormCocktails : Form
    {
        Models.SeCocktailsContext context;

        // a Form1 context-jét kapjuk meg, így közös a szerkesztés
        public FormCocktails(Models.SeCocktailsContext context)
        {
            InitializeComponent();
            this.context = context;
        }

        // csak a Visual Studio tervezőjének kell (futáskor a másik konstruktort használjuk)
        public FormCocktails() : this(new Models.SeCocktailsContext())
        {
        }

        private void FormCocktails_Load(object sender, EventArgs e)
        {
            // Ⓑ a legördülő oszlop adatforrása (koktél típusok)
            typeBindingSource.DataSource = (from x in context.Types
                                            orderby x.Name
                                            select x).ToList();

            // Ⓐ a koktélok betöltése; a Local.ToBindingList() miatt a rácson végzett
            // hozzáadás / módosítás / törlés követve lesz a context-ben
            context.Cocktails.Load();
            cocktailBindingSource.DataSource = context.Cocktails.Local.ToBindingList();
        }

        // Ⓐ mentés
        private void buttonSave_Click(object sender, EventArgs e)
        {
            dataGridViewCocktails.EndEdit();
            cocktailBindingSource.EndEdit();

            try
            {
                context.SaveChanges();
                MessageBox.Show("A mentés sikeres.");
            }
            catch (Exception ex)
            {
                ResetFailedChanges();
                cocktailBindingSource.DataSource = context.Cocktails.Local.ToBindingList();
                cocktailBindingSource.ResetBindings(false);
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

        // az új sor üres idegen kulcsa nincs a legördülő listában, ezért ne dobjon hibát
        private void dataGridViewCocktails_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }
    }
}
