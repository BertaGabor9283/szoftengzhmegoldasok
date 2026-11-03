namespace ZH3B
{
    public partial class FormAddStore : Form
    {
        // az űrlap ebbe az objektumba gyűjti az adatokat, Form1 innen veszi át
        public Models.Store NewStore = new Models.Store();

        public FormAddStore()
        {
            InitializeComponent();
        }

        private void FormAddStore_Load(object sender, EventArgs e)
        {
            storeBindingSource.DataSource = NewStore;
        }

        // Ⓑ OK-val csak akkor lehet bezárni, ha minden mező ki van töltve (a Cancel mindig zár)
        private void FormAddStore_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.OK) return;

            bool empty = string.IsNullOrWhiteSpace(textBoxStoreName.Text)
                      || string.IsNullOrWhiteSpace(textBoxPhone.Text)
                      || string.IsNullOrWhiteSpace(textBoxEmail.Text)
                      || string.IsNullOrWhiteSpace(textBoxStreet.Text)
                      || string.IsNullOrWhiteSpace(textBoxCity.Text)
                      || string.IsNullOrWhiteSpace(textBoxState.Text)
                      || string.IsNullOrWhiteSpace(textBoxZipCode.Text);

            if (empty)
            {
                e.Cancel = true;
                MessageBox.Show("Minden mező kitöltése kötelező!");
                return;
            }

            // az utolsó mező értéke is kerüljön vissza a NewStore-ba
            storeBindingSource.EndEdit();
        }
    }
}
