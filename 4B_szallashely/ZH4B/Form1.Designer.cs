namespace ZH4B
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
            textBoxFilter = new TextBox();
            listBoxSzallashely = new ListBox();
            szallashelyBindingSource = new BindingSource(components);
            listBoxSzoba = new ListBox();
            szobaBindingSource = new BindingSource(components);
            dataGridViewFoglalas = new DataGridView();
            foglalasPkDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ugyfelFkDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            szobaFkDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mettolDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            meddigDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            felnottSzamDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            gyermekSzamDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            foglalasBindingSource = new BindingSource(components);
            buttonAdd = new Button();
            buttonDelete = new Button();
            buttonSave = new Button();
            listBoxVendeg = new ListBox();
            vendegBindingSource = new BindingSource(components);
            labelCount = new Label();
            buttonSaveXml = new Button();
            ((System.ComponentModel.ISupportInitialize)szallashelyBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)szobaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFoglalas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)foglalasBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vendegBindingSource).BeginInit();
            SuspendLayout();
            // 
            // textBoxFilter
            // 
            textBoxFilter.Location = new Point(24, 24);
            textBoxFilter.Name = "textBoxFilter";
            textBoxFilter.Size = new Size(220, 27);
            textBoxFilter.TabIndex = 0;
            textBoxFilter.TextChanged += textBoxFilter_TextChanged;
            // 
            // listBoxSzallashely
            // 
            listBoxSzallashely.DataSource = szallashelyBindingSource;
            listBoxSzallashely.DisplayMember = "SzallasNev";
            listBoxSzallashely.FormattingEnabled = true;
            listBoxSzallashely.Location = new Point(24, 64);
            listBoxSzallashely.Name = "listBoxSzallashely";
            listBoxSzallashely.Size = new Size(220, 384);
            listBoxSzallashely.TabIndex = 1;
            // 
            // szallashelyBindingSource
            // 
            szallashelyBindingSource.DataSource = typeof(Models.Szallashely);
            szallashelyBindingSource.CurrentChanged += szallashelyBindingSource_CurrentChanged;
            // 
            // listBoxSzoba
            // 
            listBoxSzoba.DataSource = szobaBindingSource;
            listBoxSzoba.DisplayMember = "SzobaSzama";
            listBoxSzoba.FormattingEnabled = true;
            listBoxSzoba.Location = new Point(264, 64);
            listBoxSzoba.Name = "listBoxSzoba";
            listBoxSzoba.Size = new Size(70, 384);
            listBoxSzoba.TabIndex = 2;
            // 
            // szobaBindingSource
            // 
            szobaBindingSource.DataSource = typeof(Models.Szoba);
            szobaBindingSource.CurrentChanged += szobaBindingSource_CurrentChanged;
            // 
            // dataGridViewFoglalas
            // 
            dataGridViewFoglalas.AllowUserToAddRows = false;
            dataGridViewFoglalas.AllowUserToDeleteRows = false;
            dataGridViewFoglalas.AutoGenerateColumns = false;
            dataGridViewFoglalas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFoglalas.Columns.AddRange(new DataGridViewColumn[] { foglalasPkDataGridViewTextBoxColumn, ugyfelFkDataGridViewTextBoxColumn, szobaFkDataGridViewTextBoxColumn, mettolDataGridViewTextBoxColumn, meddigDataGridViewTextBoxColumn, felnottSzamDataGridViewTextBoxColumn, gyermekSzamDataGridViewTextBoxColumn });
            dataGridViewFoglalas.DataSource = foglalasBindingSource;
            dataGridViewFoglalas.Location = new Point(354, 64);
            dataGridViewFoglalas.Name = "dataGridViewFoglalas";
            dataGridViewFoglalas.RowHeadersWidth = 51;
            dataGridViewFoglalas.Size = new Size(560, 384);
            dataGridViewFoglalas.TabIndex = 3;
            // 
            // foglalasPkDataGridViewTextBoxColumn
            // 
            foglalasPkDataGridViewTextBoxColumn.DataPropertyName = "FoglalasPk";
            foglalasPkDataGridViewTextBoxColumn.HeaderText = "FoglalasPk";
            foglalasPkDataGridViewTextBoxColumn.MinimumWidth = 6;
            foglalasPkDataGridViewTextBoxColumn.Name = "foglalasPkDataGridViewTextBoxColumn";
            foglalasPkDataGridViewTextBoxColumn.Visible = false;
            foglalasPkDataGridViewTextBoxColumn.Width = 125;
            // 
            // ugyfelFkDataGridViewTextBoxColumn
            // 
            ugyfelFkDataGridViewTextBoxColumn.DataPropertyName = "UgyfelFk";
            ugyfelFkDataGridViewTextBoxColumn.HeaderText = "UgyfelFk";
            ugyfelFkDataGridViewTextBoxColumn.MinimumWidth = 6;
            ugyfelFkDataGridViewTextBoxColumn.Name = "ugyfelFkDataGridViewTextBoxColumn";
            ugyfelFkDataGridViewTextBoxColumn.Visible = false;
            ugyfelFkDataGridViewTextBoxColumn.Width = 125;
            // 
            // szobaFkDataGridViewTextBoxColumn
            // 
            szobaFkDataGridViewTextBoxColumn.DataPropertyName = "SzobaFk";
            szobaFkDataGridViewTextBoxColumn.HeaderText = "SzobaFk";
            szobaFkDataGridViewTextBoxColumn.MinimumWidth = 6;
            szobaFkDataGridViewTextBoxColumn.Name = "szobaFkDataGridViewTextBoxColumn";
            szobaFkDataGridViewTextBoxColumn.Visible = false;
            szobaFkDataGridViewTextBoxColumn.Width = 125;
            // 
            // mettolDataGridViewTextBoxColumn
            // 
            mettolDataGridViewTextBoxColumn.DataPropertyName = "Mettol";
            mettolDataGridViewTextBoxColumn.HeaderText = "Mettol";
            mettolDataGridViewTextBoxColumn.MinimumWidth = 6;
            mettolDataGridViewTextBoxColumn.Name = "mettolDataGridViewTextBoxColumn";
            mettolDataGridViewTextBoxColumn.Width = 130;
            // 
            // meddigDataGridViewTextBoxColumn
            // 
            meddigDataGridViewTextBoxColumn.DataPropertyName = "Meddig";
            meddigDataGridViewTextBoxColumn.HeaderText = "Meddig";
            meddigDataGridViewTextBoxColumn.MinimumWidth = 6;
            meddigDataGridViewTextBoxColumn.Name = "meddigDataGridViewTextBoxColumn";
            meddigDataGridViewTextBoxColumn.Width = 130;
            // 
            // felnottSzamDataGridViewTextBoxColumn
            // 
            felnottSzamDataGridViewTextBoxColumn.DataPropertyName = "FelnottSzam";
            felnottSzamDataGridViewTextBoxColumn.HeaderText = "FelnottSzam";
            felnottSzamDataGridViewTextBoxColumn.MinimumWidth = 6;
            felnottSzamDataGridViewTextBoxColumn.Name = "felnottSzamDataGridViewTextBoxColumn";
            felnottSzamDataGridViewTextBoxColumn.Width = 130;
            // 
            // gyermekSzamDataGridViewTextBoxColumn
            // 
            gyermekSzamDataGridViewTextBoxColumn.DataPropertyName = "GyermekSzam";
            gyermekSzamDataGridViewTextBoxColumn.HeaderText = "GyermekSzam";
            gyermekSzamDataGridViewTextBoxColumn.MinimumWidth = 6;
            gyermekSzamDataGridViewTextBoxColumn.Name = "gyermekSzamDataGridViewTextBoxColumn";
            gyermekSzamDataGridViewTextBoxColumn.Width = 130;
            // 
            // foglalasBindingSource
            // 
            foglalasBindingSource.DataSource = typeof(Models.Foglalas);
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(934, 160);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(80, 50);
            buttonAdd.TabIndex = 4;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(934, 220);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(80, 50);
            buttonDelete.TabIndex = 5;
            buttonDelete.Text = "-";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(834, 458);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(80, 32);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // listBoxVendeg
            // 
            listBoxVendeg.DataSource = vendegBindingSource;
            listBoxVendeg.DisplayMember = "Nev";
            listBoxVendeg.FormattingEnabled = true;
            listBoxVendeg.Location = new Point(1034, 64);
            listBoxVendeg.Name = "listBoxVendeg";
            listBoxVendeg.Size = new Size(190, 384);
            listBoxVendeg.TabIndex = 7;
            // 
            // vendegBindingSource
            // 
            vendegBindingSource.DataSource = typeof(Models.Vendeg);
            // 
            // labelCount
            // 
            labelCount.AutoSize = true;
            labelCount.Location = new Point(24, 462);
            labelCount.Name = "labelCount";
            labelCount.Size = new Size(100, 20);
            labelCount.TabIndex = 8;
            labelCount.Text = "Szálláshelyek száma: 0";
            // 
            // buttonSaveXml
            // 
            buttonSaveXml.Location = new Point(354, 458);
            buttonSaveXml.Name = "buttonSaveXml";
            buttonSaveXml.Size = new Size(220, 32);
            buttonSaveXml.TabIndex = 9;
            buttonSaveXml.Text = "Szálláshelyek mentése XML-be";
            buttonSaveXml.UseVisualStyleBackColor = true;
            buttonSaveXml.Click += buttonSaveXml_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1250, 510);
            Controls.Add(buttonSaveXml);
            Controls.Add(labelCount);
            Controls.Add(listBoxVendeg);
            Controls.Add(buttonSave);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridViewFoglalas);
            Controls.Add(listBoxSzoba);
            Controls.Add(listBoxSzallashely);
            Controls.Add(textBoxFilter);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)szallashelyBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)szobaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFoglalas).EndInit();
            ((System.ComponentModel.ISupportInitialize)foglalasBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)vendegBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxFilter;
        private ListBox listBoxSzallashely;
        private BindingSource szallashelyBindingSource;
        private ListBox listBoxSzoba;
        private BindingSource szobaBindingSource;
        private DataGridView dataGridViewFoglalas;
        private DataGridViewTextBoxColumn foglalasPkDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ugyfelFkDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn szobaFkDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mettolDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn meddigDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn felnottSzamDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gyermekSzamDataGridViewTextBoxColumn;
        private BindingSource foglalasBindingSource;
        private Button buttonAdd;
        private Button buttonDelete;
        private Button buttonSave;
        private ListBox listBoxVendeg;
        private BindingSource vendegBindingSource;
        private Label labelCount;
        private Button buttonSaveXml;
    }
}
