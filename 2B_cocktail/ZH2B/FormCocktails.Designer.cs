namespace ZH2B
{
    partial class FormCocktails
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
            dataGridViewCocktails = new DataGridView();
            cocktailSkDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            typeDataGridViewComboBoxColumn = new DataGridViewComboBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cocktailBindingSource = new BindingSource(components);
            typeBindingSource = new BindingSource(components);
            buttonAdd = new Button();
            buttonDelete = new Button();
            buttonSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCocktails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cocktailBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)typeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCocktails
            // 
            dataGridViewCocktails.AllowUserToAddRows = false;
            dataGridViewCocktails.AllowUserToDeleteRows = false;
            dataGridViewCocktails.AutoGenerateColumns = false;
            dataGridViewCocktails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCocktails.Columns.AddRange(new DataGridViewColumn[] { cocktailSkDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, typeDataGridViewComboBoxColumn, priceDataGridViewTextBoxColumn });
            dataGridViewCocktails.DataSource = cocktailBindingSource;
            dataGridViewCocktails.Location = new Point(12, 12);
            dataGridViewCocktails.Name = "dataGridViewCocktails";
            dataGridViewCocktails.RowHeadersWidth = 51;
            dataGridViewCocktails.Size = new Size(736, 350);
            dataGridViewCocktails.TabIndex = 0;
            // 
            // cocktailSkDataGridViewTextBoxColumn
            // 
            cocktailSkDataGridViewTextBoxColumn.DataPropertyName = "CocktailSk";
            cocktailSkDataGridViewTextBoxColumn.HeaderText = "CocktailSk";
            cocktailSkDataGridViewTextBoxColumn.MinimumWidth = 6;
            cocktailSkDataGridViewTextBoxColumn.Name = "cocktailSkDataGridViewTextBoxColumn";
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
            // typeDataGridViewComboBoxColumn
            // 
            typeDataGridViewComboBoxColumn.DataPropertyName = "TypeFk";
            typeDataGridViewComboBoxColumn.DataSource = typeBindingSource;
            typeDataGridViewComboBoxColumn.DisplayMember = "Name";
            typeDataGridViewComboBoxColumn.HeaderText = "Type";
            typeDataGridViewComboBoxColumn.MinimumWidth = 6;
            typeDataGridViewComboBoxColumn.Name = "typeDataGridViewComboBoxColumn";
            typeDataGridViewComboBoxColumn.ValueMember = "TypeId";
            typeDataGridViewComboBoxColumn.Width = 160;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.Width = 90;
            // 
            // cocktailBindingSource
            // 
            cocktailBindingSource.DataSource = typeof(Models.Cocktail);
            // 
            // typeBindingSource
            // 
            typeBindingSource.DataSource = typeof(Models.Type);
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(12, 380);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(80, 32);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(102, 380);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(80, 32);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "-";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(648, 380);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(100, 32);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "Mentés";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // FormCocktails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 430);
            Controls.Add(buttonSave);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridViewCocktails);
            Name = "FormCocktails";
            Text = "FormCocktails";
            Load += FormCocktails_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCocktails).EndInit();
            ((System.ComponentModel.ISupportInitialize)cocktailBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)typeBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewCocktails;
        private DataGridViewTextBoxColumn cocktailSkDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn typeDataGridViewComboBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private BindingSource cocktailBindingSource;
        private BindingSource typeBindingSource;
        private Button buttonAdd;
        private Button buttonDelete;
        private Button buttonSave;
    }
}
