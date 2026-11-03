using System.Xml.Serialization;
using Microsoft.EntityFrameworkCore;

namespace ZH4B
{
    public partial class Form1 : Form
    {
        Models.SeSzallashelyContext context = new Models.SeSzallashelyContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReadSzallashelyek();
            ReadVendegek();

            // Ⓑ a szálláshelyek száma
            labelCount.Text = $"Szálláshelyek száma: {context.Szallashely.Count()}";
        }

        // ③ bal lista: szálláshelyek, szűrhetően
        void ReadSzallashelyek()
        {
            var l = from x in context.Szallashely
                    where (x.SzallasNev ?? "").Contains(textBoxFilter.Text)
                    orderby x.SzallasNev
                    select x;

            szallashelyBindingSource.DataSource = l.ToList();
        }

        // ④ jobb lista: vendégek (itt nincs szűrés)
        void ReadVendegek()
        {
            var l = from x in context.Vendeg
                    orderby x.Nev
                    select x;

            vendegBindingSource.DataSource = l.ToList();
        }

        private void textBoxFilter_TextChanged(object sender, EventArgs e)
        {
            ReadSzallashelyek();
        }

        private void szallashelyBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            ReadSzobak();
        }

        // ⑤ a kiválasztott szálláshely szobái
        void ReadSzobak()
        {
            Models.Szallashely? szallashely = szallashelyBindingSource.Current as Models.Szallashely;
            if (szallashely == null)
            {
                szobaBindingSource.DataSource = new List<Models.Szoba>();
                return;
            }

            var l = from x in context.Szoba
                    where x.SzallasFk == szallashely.SzallasId
                    orderby x.SzobaSzama
                    select x;

            szobaBindingSource.DataSource = l.ToList();
        }

        // ⑦ a kiválasztott szoba foglalásai
        private void szobaBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            ReadFoglalasok();
        }

        // A rács a Models.Foglalas entitásokhoz kötődik (követett lekérdezés),
        // ezért a cellák szerkesztése a context-ben is megjelenik, a Save ment.
        void ReadFoglalasok()
        {
            Models.Szoba? szoba = szobaBindingSource.Current as Models.Szoba;
            if (szoba == null)
            {
                foglalasBindingSource.DataSource = new List<Models.Foglalas>();
                return;
            }

            var l = from x in context.Foglalas
                    where x.SzobaFk == szoba.SzobaId
                    orderby x.Mettol
                    select x;

            foglalasBindingSource.DataSource = l.ToList();
        }

        // ⑨ új foglalás felvétele (személyek száma: 1)
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Models.Szoba? szoba = szobaBindingSource.Current as Models.Szoba;
            Models.Vendeg? vendeg = vendegBindingSource.Current as Models.Vendeg;
            if (szoba == null || vendeg == null) return;

            Models.Foglalas newFoglalas = new Models.Foglalas();
            newFoglalas.SzobaFk = szoba.SzobaId;
            newFoglalas.UgyfelFk = vendeg.Usernev;
            newFoglalas.Mettol = DateOnly.FromDateTime(DateTime.Today);
            newFoglalas.Meddig = DateOnly.FromDateTime(DateTime.Today.AddDays(1));
            newFoglalas.FelnottSzam = 1;
            newFoglalas.GyermekSzam = 0;

            context.Foglalas.Add(newFoglalas);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                context.Entry(newFoglalas).State = EntityState.Detached;
                MessageBox.Show(ex.Message);
            }

            ReadFoglalasok();
        }

        // ⑩ a rácsban szerkesztett cellák mentése
        private void buttonSave_Click(object sender, EventArgs e)
        {
            dataGridViewFoglalas.EndEdit();
            foglalasBindingSource.EndEdit();

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ReadFoglalasok();
        }

        // ⑪ a kiválasztott foglalás törlése
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Models.Foglalas? foglalas = foglalasBindingSource.Current as Models.Foglalas;
            if (foglalas == null) return;

            context.Foglalas.Remove(foglalas);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ReadFoglalasok();
        }

        // érvénytelen cellaérték (pl. rossz dátum) ne dobjon kivételt
        private void dataGridViewFoglalas_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
            MessageBox.Show("Érvénytelen érték a cellában!");
        }

        // Ⓐ a szálláshelyek neveinek mentése XML-be
        private void buttonSaveXml_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XML fájl (*.xml)|*.xml";
            sfd.FileName = "szallashelyek.xml";
            if (sfd.ShowDialog() != DialogResult.OK) return;

            var szallashelyek = (from x in context.Szallashely
                                 orderby x.SzallasNev
                                 select new SzallashelyXml
                                 {
                                     SzallasId = x.SzallasId,
                                     SzallasNev = x.SzallasNev
                                 }).ToList();

            XmlSerializer serializer = new XmlSerializer(typeof(List<SzallashelyXml>));
            using (StreamWriter sw = new StreamWriter(sfd.FileName))
            {
                serializer.Serialize(sw, szallashelyek);
            }

            MessageBox.Show("A mentés sikeres.");
        }
    }
}
