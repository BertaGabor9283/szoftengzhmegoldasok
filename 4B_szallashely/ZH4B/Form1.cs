using System.Xml.Linq;

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
            // ③ ④
            szallashelyBindingSource.DataSource = context.Szallashely.ToList();
            vendegBindingSource.DataSource = context.Vendeg.ToList();

            // Ⓑ szálláshelyek száma
            labelCount.Text = "Szálláshelyek száma: " + context.Szallashely.Count();
        }

        // ③ szűrés
        private void textBoxFilter_TextChanged(object sender, EventArgs e)
        {
            var l = from x in context.Szallashely
                    where x.SzallasNev.Contains(textBoxFilter.Text)
                    select x;

            szallashelyBindingSource.DataSource = l.ToList();
        }

        // ⑤ bal listára kattintás
        private void szallashelyBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            ReadSzobak();
        }

        void ReadSzobak()
        {
            if (szallashelyBindingSource.Current == null) return;

            Models.Szallashely szallashely = szallashelyBindingSource.Current as Models.Szallashely;

            var l = from x in context.Szoba
                    where x.SzallasFk == szallashely.SzallasId
                    select x;

            szobaBindingSource.DataSource = l.ToList();
        }

        // ⑦ második listára kattintás
        private void szobaBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            ReadFoglalasok();
        }

        void ReadFoglalasok()
        {
            if (szobaBindingSource.Current == null) return;

            Models.Szoba szoba = szobaBindingSource.Current as Models.Szoba;

            var l = from x in context.Foglalas
                    where x.SzobaFk == szoba.SzobaId
                    select x;

            foglalasBindingSource.DataSource = l.ToList();
        }

        // ⑨ +
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (szobaBindingSource.Current == null) return;
            if (vendegBindingSource.Current == null) return;

            Models.Szoba s = szobaBindingSource.Current as Models.Szoba;
            Models.Vendeg v = vendegBindingSource.Current as Models.Vendeg;

            Models.Foglalas newFoglalas = new Models.Foglalas();
            newFoglalas.SzobaFk = s.SzobaId;
            newFoglalas.UgyfelFk = v.Usernev;
            newFoglalas.Mettol = DateOnly.FromDateTime(DateTime.Today);
            newFoglalas.Meddig = DateOnly.FromDateTime(DateTime.Today.AddDays(1));
            newFoglalas.FelnottSzam = 1;
            newFoglalas.GyermekSzam = 0;

            context.Foglalas.Add(newFoglalas);

            context.SaveChanges();

            ReadFoglalasok();

            //ToDo: try-catch
        }

        // ⑩ Save: a rácsban átírt cellák mentése
        private void buttonSave_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
        }

        // ⑪ -
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Models.Foglalas f = foglalasBindingSource.Current as Models.Foglalas;
            if (f == null) return;

            var törlendő = from x in context.Foglalas
                           where x.FoglalasPk == f.FoglalasPk
                           select x;

            context.Foglalas.RemoveRange(törlendő);

            context.SaveChanges();

            ReadFoglalasok();
        }

        // Ⓐ szálláshelyek nevei XML-be
        private void buttonSaveXml_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XML|*.xml";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                var l = from x in context.Szallashely.ToList()
                        select new XElement("Szallashely",
                            new XElement("SzallasNev", x.SzallasNev));

                new XDocument(new XElement("Szallashelyek", l)).Save(sfd.FileName);
            }
        }
    }
}
