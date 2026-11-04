namespace ZH3A
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            textBoxAnimalFilter = new TextBox();
            listBoxAnimals = new ListBox();
            animalBindingSource = new BindingSource(components);
            listBoxTreatments = new ListBox();
            treatmentBindingSource = new BindingSource(components);
            listBoxProcedureDones = new ListBox();
            procedureDoneItemBindingSource = new BindingSource(components);
            buttonAdd = new Button();
            listBoxProcedures = new ListBox();
            procedureBindingSource = new BindingSource(components);
            labelCount = new Label();
            buttonSaveXml = new Button();
            ((System.ComponentModel.ISupportInitialize)animalBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)treatmentBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)procedureDoneItemBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)procedureBindingSource).BeginInit();
            SuspendLayout();
            // 
            // textBoxAnimalFilter
            // 
            textBoxAnimalFilter.Location = new Point(24, 24);
            textBoxAnimalFilter.Name = "textBoxAnimalFilter";
            textBoxAnimalFilter.Size = new Size(220, 27);
            textBoxAnimalFilter.TabIndex = 0;
            textBoxAnimalFilter.TextChanged += textBoxAnimalFilter_TextChanged;
            // 
            // listBoxAnimals
            // 
            listBoxAnimals.DataSource = animalBindingSource;
            listBoxAnimals.DisplayMember = "Name";
            listBoxAnimals.FormattingEnabled = true;
            listBoxAnimals.Location = new Point(24, 64);
            listBoxAnimals.Name = "listBoxAnimals";
            listBoxAnimals.Size = new Size(220, 384);
            listBoxAnimals.TabIndex = 1;
            // 
            // animalBindingSource
            // 
            animalBindingSource.DataSource = typeof(Models.Animal);
            animalBindingSource.CurrentChanged += animalBindingSource_CurrentChanged;
            // 
            // listBoxTreatments
            // 
            listBoxTreatments.DataSource = treatmentBindingSource;
            listBoxTreatments.DisplayMember = "Date";
            listBoxTreatments.FormattingEnabled = true;
            listBoxTreatments.Location = new Point(264, 64);
            listBoxTreatments.Name = "listBoxTreatments";
            listBoxTreatments.Size = new Size(180, 384);
            listBoxTreatments.TabIndex = 2;
            // 
            // treatmentBindingSource
            // 
            treatmentBindingSource.DataSource = typeof(Models.Treatment);
            treatmentBindingSource.CurrentChanged += treatmentBindingSource_CurrentChanged;
            // 
            // listBoxProcedureDones
            // 
            listBoxProcedureDones.DataSource = procedureDoneItemBindingSource;
            listBoxProcedureDones.DisplayMember = "Name";
            listBoxProcedureDones.FormattingEnabled = true;
            listBoxProcedureDones.Location = new Point(464, 64);
            listBoxProcedureDones.Name = "listBoxProcedureDones";
            listBoxProcedureDones.Size = new Size(260, 384);
            listBoxProcedureDones.TabIndex = 3;
            // 
            // procedureDoneItemBindingSource
            // 
            procedureDoneItemBindingSource.DataSource = typeof(ProcedureDoneItem);
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(744, 200);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(60, 50);
            buttonAdd.TabIndex = 4;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // listBoxProcedures
            // 
            listBoxProcedures.DataSource = procedureBindingSource;
            listBoxProcedures.DisplayMember = "Name";
            listBoxProcedures.FormattingEnabled = true;
            listBoxProcedures.Location = new Point(824, 64);
            listBoxProcedures.Name = "listBoxProcedures";
            listBoxProcedures.Size = new Size(240, 384);
            listBoxProcedures.TabIndex = 5;
            // 
            // procedureBindingSource
            // 
            procedureBindingSource.DataSource = typeof(Models.Procedure);
            // 
            // labelCount
            // 
            labelCount.AutoSize = true;
            labelCount.Location = new Point(24, 462);
            labelCount.Name = "labelCount";
            labelCount.Size = new Size(100, 20);
            labelCount.TabIndex = 6;
            labelCount.Text = "Állatok száma: 0";
            // 
            // buttonSaveXml
            // 
            buttonSaveXml.Location = new Point(824, 458);
            buttonSaveXml.Name = "buttonSaveXml";
            buttonSaveXml.Size = new Size(240, 32);
            buttonSaveXml.TabIndex = 7;
            buttonSaveXml.Text = "Állatok mentése XML-be";
            buttonSaveXml.UseVisualStyleBackColor = true;
            buttonSaveXml.Click += buttonSaveXml_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1090, 510);
            Controls.Add(buttonSaveXml);
            Controls.Add(labelCount);
            Controls.Add(listBoxProcedures);
            Controls.Add(buttonAdd);
            Controls.Add(listBoxProcedureDones);
            Controls.Add(listBoxTreatments);
            Controls.Add(listBoxAnimals);
            Controls.Add(textBoxAnimalFilter);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)animalBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)treatmentBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)procedureDoneItemBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)procedureBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxAnimalFilter;
        private ListBox listBoxAnimals;
        private BindingSource animalBindingSource;
        private ListBox listBoxTreatments;
        private BindingSource treatmentBindingSource;
        private ListBox listBoxProcedureDones;
        private BindingSource procedureDoneItemBindingSource;
        private Button buttonAdd;
        private ListBox listBoxProcedures;
        private BindingSource procedureBindingSource;
        private Label labelCount;
        private Button buttonSaveXml;
    }
}
