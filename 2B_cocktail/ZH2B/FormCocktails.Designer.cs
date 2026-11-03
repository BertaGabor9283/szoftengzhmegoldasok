namespace ZH2B
{
    partial class FormCocktails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridViewCocktails = new DataGridView();
            cocktailSkDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            typeFkDataGridViewComboBoxColumn = new DataGridViewComboBoxColumn();
            typeBindingSource = new BindingSource(components);
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cocktailBindingSource = new BindingSource(components);
            buttonSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCocktails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)typeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cocktailBindingSource).BeginInit();
            SuspendLayout();
            //
            // dataGridViewCocktails
            //
            dataGridViewCocktails.AutoGenerateColumns = false;
            dataGridViewCocktails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCocktails.Columns.AddRange(new DataGridViewColumn[] { cocktailSkDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, typeFkDataGridViewComboBoxColumn, priceDataGridViewTextBoxColumn });
            dataGridViewCocktails.DataSource = cocktailBindingSource;
            dataGridViewCocktails.Location = new Point(24, 24);
            dataGridViewCocktails.Name = "dataGridViewCocktails";
            dataGridViewCocktails.RowHeadersWidth = 51;
            dataGridViewCocktails.Size = new Size(752, 384);
            dataGridViewCocktails.TabIndex = 0;
            dataGridViewCocktails.DataError += dataGridViewCocktails_DataError;
            //
            // cocktailSkDataGridViewTextBoxColumn
            //
            cocktailSkDataGridViewTextBoxColumn.DataPropertyName = "CocktailSk";
            cocktailSkDataGridViewTextBoxColumn.HeaderText = "CocktailSk";
            cocktailSkDataGridViewTextBoxColumn.MinimumWidth = 6;
            cocktailSkDataGridViewTextBoxColumn.Name = "cocktailSkDataGridViewTextBoxColumn";
            cocktailSkDataGridViewTextBoxColumn.ReadOnly = true;
            cocktailSkDataGridViewTextBoxColumn.Visible = false;
            cocktailSkDataGridViewTextBoxColumn.Width = 125;
            //
            // nameDataGridViewTextBoxColumn
            //
            nameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            //
            // typeFkDataGridViewComboBoxColumn
            //
            typeFkDataGridViewComboBoxColumn.DataPropertyName = "TypeFk";
            typeFkDataGridViewComboBoxColumn.DataSource = typeBindingSource;
            typeFkDataGridViewComboBoxColumn.DisplayMember = "Name";
            typeFkDataGridViewComboBoxColumn.HeaderText = "Type";
            typeFkDataGridViewComboBoxColumn.MinimumWidth = 6;
            typeFkDataGridViewComboBoxColumn.Name = "typeFkDataGridViewComboBoxColumn";
            typeFkDataGridViewComboBoxColumn.ValueMember = "TypeId";
            typeFkDataGridViewComboBoxColumn.Width = 180;
            //
            // typeBindingSource
            //
            typeBindingSource.DataSource = typeof(Models.Type);
            //
            // priceDataGridViewTextBoxColumn
            //
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.Width = 110;
            //
            // cocktailBindingSource
            //
            cocktailBindingSource.DataSource = typeof(Models.Cocktail);
            //
            // buttonSave
            //
            buttonSave.Location = new Point(656, 424);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(120, 40);
            buttonSave.TabIndex = 1;
            buttonSave.Text = "Mentés";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            //
            // FormCocktails
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 480);
            Controls.Add(buttonSave);
            Controls.Add(dataGridViewCocktails);
            Name = "FormCocktails";
            Text = "Koktélok";
            Load += FormCocktails_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCocktails).EndInit();
            ((System.ComponentModel.ISupportInitialize)typeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)cocktailBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewCocktails;
        private DataGridViewTextBoxColumn cocktailSkDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn typeFkDataGridViewComboBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private BindingSource cocktailBindingSource;
        private BindingSource typeBindingSource;
        private Button buttonSave;
    }
}
