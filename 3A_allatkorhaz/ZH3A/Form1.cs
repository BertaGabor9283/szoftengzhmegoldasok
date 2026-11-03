using System.Xml.Serialization;
using Microsoft.EntityFrameworkCore;

namespace ZH3A
{
    public partial class Form1 : Form
    {
        Models.SePetsContext context = new Models.SePetsContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReadAnimals();
            ReadProcedures();

            // Ⓑ az adatbázisban lévő összes állat száma
            labelCount.Text = $"Állatok száma: {context.Animals.Count()}";
        }

        // ③ bal lista: állatok, szűrhetően
        void ReadAnimals()
        {
            var l = from x in context.Animals
                    where x.Name.Contains(textBoxAnimalFilter.Text)
                    orderby x.Name
                    select x;

            animalBindingSource.DataSource = l.ToList();
        }

        // ④ jobb lista: eljárások (nincs szűrés)
        void ReadProcedures()
        {
            var l = from x in context.Procedures
                    orderby x.Name
                    select x;

            procedureBindingSource.DataSource = l.ToList();
        }

        private void textBoxAnimalFilter_TextChanged(object sender, EventArgs e)
        {
            ReadAnimals();
        }

        private void animalBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            ReadTreatments();
        }

        // ⑤ a kiválasztott állat kezelései (a megjelenített mező a dátum)
        void ReadTreatments()
        {
            Models.Animal? animal = animalBindingSource.Current as Models.Animal;
            if (animal == null)
            {
                treatmentBindingSource.DataSource = new List<Models.Treatment>();
                return;
            }

            var l = from x in context.Treatments
                    where x.AnimalFk == animal.AnimalSk
                    orderby x.Date
                    select x;

            treatmentBindingSource.DataSource = l.ToList();
        }

        // ⑧ a második listára kattintva (kiválasztott kezelés)
        private void treatmentBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            ReadProcedureDones();
        }

        // ⑧ a kiválasztott kezeléshez tartozó elvégzett eljárások ProcedureDoneItem formában
        void ReadProcedureDones()
        {
            Models.Treatment? treatment = treatmentBindingSource.Current as Models.Treatment;
            if (treatment == null)
            {
                procedureDoneItemBindingSource.DataSource = new List<ProcedureDoneItem>();
                return;
            }

            var l = from x in context.ProcedureDones
                    where x.TreatmentFk == treatment.TreatmentSk
                    orderby x.ProcedureDoneSk
                    select new ProcedureDoneItem
                    {
                        ProcedureDoneSk = x.ProcedureDoneSk,
                        Name = x.ProcedureFkNavigation!.Name ?? ""
                    };

            procedureDoneItemBindingSource.DataSource = l.ToList();
        }

        // ⑨ új elvégzett eljárás felvétele
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Models.Treatment? treatment = treatmentBindingSource.Current as Models.Treatment;
            Models.Procedure? procedure = procedureBindingSource.Current as Models.Procedure;
            if (treatment == null || procedure == null) return;

            Models.ProcedureDone newItem = new Models.ProcedureDone();
            newItem.TreatmentFk = treatment.TreatmentSk;
            newItem.ProcedureFk = procedure.ProcedureSk;

            context.ProcedureDones.Add(newItem);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                context.Entry(newItem).State = EntityState.Detached;
                MessageBox.Show(ex.Message);
            }

            ReadProcedureDones();
        }

        // Ⓐ Animal tábla mentése XML-be
        private void buttonSaveXml_Click(object sender, EventArgs e)
        {
            using SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XML fájl (*.xml)|*.xml";
            sfd.FileName = "animals.xml";
            if (sfd.ShowDialog() != DialogResult.OK) return;

            try
            {
                var animals = (from x in context.Animals
                               orderby x.AnimalSk
                               select new AnimalXml
                               {
                                   AnimalSk = x.AnimalSk,
                                   Name = x.Name,
                                   OwnerFk = x.OwnerFk,
                                   BirthYear = x.BirthYear,
                                   SpeciesFk = x.SpeciesFk
                               }).ToList();

                XmlSerializer serializer = new XmlSerializer(typeof(List<AnimalXml>));
                using (StreamWriter sw = new StreamWriter(sfd.FileName))
                {
                    serializer.Serialize(sw, animals);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            MessageBox.Show("A mentés sikeres.");
        }
    }
}
