namespace ZH3B
{
    public partial class FormAddStore : Form
    {
        public Models.Store NewStore = new Models.Store();
        public FormAddStore()
        {
            InitializeComponent();
        }

        private void FormAddStore_Load(object sender, EventArgs e)
        {
            storeBindingSource.DataSource = NewStore;
        }

        // Ⓑ csak akkor záródik be OK-val, ha minden mező ki van töltve
        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
                string.IsNullOrWhiteSpace(textBoxPhone.Text) ||
                string.IsNullOrWhiteSpace(textBoxEmail.Text) ||
                string.IsNullOrWhiteSpace(textBoxStreet.Text) ||
                string.IsNullOrWhiteSpace(textBoxCity.Text) ||
                string.IsNullOrWhiteSpace(textBoxState.Text) ||
                string.IsNullOrWhiteSpace(textBoxZip.Text))
            {
                MessageBox.Show("Minden mezőt ki kell tölteni!");
                return;
            }

            DialogResult = DialogResult.OK;
        }
    }
}
