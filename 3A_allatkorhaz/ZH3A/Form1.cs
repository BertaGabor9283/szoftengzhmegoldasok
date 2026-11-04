using System.Xml.Linq;

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
            // ③ ④
            animalBindingSource.DataSource = context.Animals.ToList();
            procedureBindingSource.DataSource = context.Procedures.ToList();

            // Ⓑ állatok száma
            labelCount.Text = "Állatok száma: " + context.Animals.Count();
        }

        // ③ szűrés
        private void textBoxAnimalFilter_TextChanged(object sender, EventArgs e)
        {
            var l = from x in context.Animals
                    where x.Name.Contains(textBoxAnimalFilter.Text)
                    select x;

            animalBindingSource.DataSource = l.ToList();
        }

        // ⑤ bal listára kattintás
        private void animalBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            ReadTreatments();
        }

        void ReadTreatments()
        {
            if (animalBindingSource.Current == null) return;

            Models.Animal animal = animalBindingSource.Current as Models.Animal;

            var l = from x in context.Treatments
                    where x.AnimalFk == animal.AnimalSk
                    select x;

            treatmentBindingSource.DataSource = l.ToList();
        }

        // ⑧ második listára kattintás
        private void treatmentBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            ReadProcedureDones();
        }

        void ReadProcedureDones()
        {
            if (treatmentBindingSource.Current == null) return;

            Models.Treatment treatment = treatmentBindingSource.Current as Models.Treatment;

            var l = from x in context.ProcedureDones
                    where x.TreatmentFk == treatment.TreatmentSk
                    select new ProcedureDoneItem
                    {
                        ProcedureDoneSk = x.ProcedureDoneSk,
                        Name = x.ProcedureFkNavigation.Name,
                    };

            procedureDoneItemBindingSource.DataSource = l.ToList();
        }

        // ⑨ +
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (treatmentBindingSource.Current == null) return;
            if (procedureBindingSource.Current == null) return;

            Models.Treatment t = treatmentBindingSource.Current as Models.Treatment;
            Models.Procedure p = procedureBindingSource.Current as Models.Procedure;

            Models.ProcedureDone newProcedureDone = new Models.ProcedureDone();
            newProcedureDone.TreatmentFk = t.TreatmentSk;
            newProcedureDone.ProcedureFk = p.ProcedureSk;

            context.ProcedureDones.Add(newProcedureDone);

            context.SaveChanges();

            ReadProcedureDones();

            //ToDo: try-catch
        }

        // Ⓐ Animal tábla mentése XML-be
        private void buttonSaveXml_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XML|*.xml";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                var l = from x in context.Animals.ToList()
                        select new XElement("Animal",
                            new XElement("AnimalSk", x.AnimalSk),
                            new XElement("Name", x.Name),
                            new XElement("OwnerFk", x.OwnerFk),
                            new XElement("BirthYear", x.BirthYear),
                            new XElement("SpeciesFk", x.SpeciesFk));

                new XDocument(new XElement("Animals", l)).Save(sfd.FileName);
            }
        }
    }
}
