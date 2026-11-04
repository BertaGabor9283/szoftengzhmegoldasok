namespace ZH1B
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
            textBoxCocktailFilter = new TextBox();
            listBoxCocktails = new ListBox();
            cocktailBindingSource = new BindingSource(components);
            dataGridViewRecipes = new DataGridView();
            recipeSkDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            materialNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            materialTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            unitNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            detailedRecipeItemBindingSource = new BindingSource(components);
            numericUpDownQuantity = new NumericUpDown();
            buttonAdd = new Button();
            buttonDelete = new Button();
            listBoxMaterials = new ListBox();
            materialBindingSource = new BindingSource(components);
            labelCount = new Label();
            buttonSaveXml = new Button();
            ((System.ComponentModel.ISupportInitialize)cocktailBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecipes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)detailedRecipeItemBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)materialBindingSource).BeginInit();
            SuspendLayout();
            // 
            // textBoxCocktailFilter
            // 
            textBoxCocktailFilter.Location = new Point(24, 24);
            textBoxCocktailFilter.Name = "textBoxCocktailFilter";
            textBoxCocktailFilter.Size = new Size(220, 27);
            textBoxCocktailFilter.TabIndex = 0;
            textBoxCocktailFilter.TextChanged += textBoxCocktailFilter_TextChanged;
            // 
            // listBoxCocktails
            // 
            listBoxCocktails.DataSource = cocktailBindingSource;
            listBoxCocktails.DisplayMember = "Name";
            listBoxCocktails.FormattingEnabled = true;
            listBoxCocktails.Location = new Point(24, 64);
            listBoxCocktails.Name = "listBoxCocktails";
            listBoxCocktails.Size = new Size(220, 384);
            listBoxCocktails.TabIndex = 1;
            // 
            // cocktailBindingSource
            // 
            cocktailBindingSource.DataSource = typeof(Models.Cocktail);
            cocktailBindingSource.CurrentChanged += cocktailBindingSource_CurrentChanged;
            // 
            // dataGridViewRecipes
            // 
            dataGridViewRecipes.AllowUserToAddRows = false;
            dataGridViewRecipes.AllowUserToDeleteRows = false;
            dataGridViewRecipes.AutoGenerateColumns = false;
            dataGridViewRecipes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRecipes.Columns.AddRange(new DataGridViewColumn[] { recipeSkDataGridViewTextBoxColumn, materialNameDataGridViewTextBoxColumn, materialTypeDataGridViewTextBoxColumn, quantityDataGridViewTextBoxColumn, unitNameDataGridViewTextBoxColumn });
            dataGridViewRecipes.DataSource = detailedRecipeItemBindingSource;
            dataGridViewRecipes.Location = new Point(264, 64);
            dataGridViewRecipes.Name = "dataGridViewRecipes";
            dataGridViewRecipes.ReadOnly = true;
            dataGridViewRecipes.RowHeadersWidth = 51;
            dataGridViewRecipes.Size = new Size(420, 384);
            dataGridViewRecipes.TabIndex = 2;
            // 
            // recipeSkDataGridViewTextBoxColumn
            // 
            recipeSkDataGridViewTextBoxColumn.DataPropertyName = "RecipeSk";
            recipeSkDataGridViewTextBoxColumn.HeaderText = "RecipeSk";
            recipeSkDataGridViewTextBoxColumn.MinimumWidth = 6;
            recipeSkDataGridViewTextBoxColumn.Name = "recipeSkDataGridViewTextBoxColumn";
            recipeSkDataGridViewTextBoxColumn.Visible = false;
            recipeSkDataGridViewTextBoxColumn.Width = 125;
            // 
            // materialNameDataGridViewTextBoxColumn
            // 
            materialNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            materialNameDataGridViewTextBoxColumn.DataPropertyName = "MaterialName";
            materialNameDataGridViewTextBoxColumn.HeaderText = "MaterialName";
            materialNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            materialNameDataGridViewTextBoxColumn.Name = "materialNameDataGridViewTextBoxColumn";
            // 
            // materialTypeDataGridViewTextBoxColumn
            // 
            materialTypeDataGridViewTextBoxColumn.DataPropertyName = "MaterialType";
            materialTypeDataGridViewTextBoxColumn.HeaderText = "MaterialType";
            materialTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            materialTypeDataGridViewTextBoxColumn.Name = "materialTypeDataGridViewTextBoxColumn";
            materialTypeDataGridViewTextBoxColumn.Width = 130;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            quantityDataGridViewTextBoxColumn.Width = 80;
            // 
            // unitNameDataGridViewTextBoxColumn
            // 
            unitNameDataGridViewTextBoxColumn.DataPropertyName = "UnitName";
            unitNameDataGridViewTextBoxColumn.HeaderText = "UnitName";
            unitNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            unitNameDataGridViewTextBoxColumn.Name = "unitNameDataGridViewTextBoxColumn";
            unitNameDataGridViewTextBoxColumn.Width = 80;
            // 
            // detailedRecipeItemBindingSource
            // 
            detailedRecipeItemBindingSource.DataSource = typeof(DetailedRecipeItem);
            // 
            // numericUpDownQuantity
            // 
            numericUpDownQuantity.DecimalPlaces = 2;
            numericUpDownQuantity.Location = new Point(704, 160);
            numericUpDownQuantity.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownQuantity.Name = "numericUpDownQuantity";
            numericUpDownQuantity.Size = new Size(80, 27);
            numericUpDownQuantity.TabIndex = 3;
            numericUpDownQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(704, 200);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(80, 50);
            buttonAdd.TabIndex = 4;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(704, 260);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(80, 50);
            buttonDelete.TabIndex = 5;
            buttonDelete.Text = "-";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // listBoxMaterials
            // 
            listBoxMaterials.DataSource = materialBindingSource;
            listBoxMaterials.DisplayMember = "Name";
            listBoxMaterials.FormattingEnabled = true;
            listBoxMaterials.Location = new Point(804, 64);
            listBoxMaterials.Name = "listBoxMaterials";
            listBoxMaterials.Size = new Size(260, 384);
            listBoxMaterials.TabIndex = 6;
            // 
            // materialBindingSource
            // 
            materialBindingSource.DataSource = typeof(Models.Material);
            // 
            // labelCount
            // 
            labelCount.AutoSize = true;
            labelCount.Location = new Point(264, 462);
            labelCount.Name = "labelCount";
            labelCount.Size = new Size(100, 20);
            labelCount.TabIndex = 7;
            labelCount.Text = "Hozzávalók száma: 0";
            // 
            // buttonSaveXml
            // 
            buttonSaveXml.Location = new Point(804, 458);
            buttonSaveXml.Name = "buttonSaveXml";
            buttonSaveXml.Size = new Size(260, 32);
            buttonSaveXml.TabIndex = 8;
            buttonSaveXml.Text = "Koktélok mentése XML-be";
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
            Controls.Add(listBoxMaterials);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
            Controls.Add(numericUpDownQuantity);
            Controls.Add(dataGridViewRecipes);
            Controls.Add(listBoxCocktails);
            Controls.Add(textBoxCocktailFilter);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)cocktailBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecipes).EndInit();
            ((System.ComponentModel.ISupportInitialize)detailedRecipeItemBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)materialBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxCocktailFilter;
        private ListBox listBoxCocktails;
        private BindingSource cocktailBindingSource;
        private DataGridView dataGridViewRecipes;
        private DataGridViewTextBoxColumn recipeSkDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn materialNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn materialTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitNameDataGridViewTextBoxColumn;
        private BindingSource detailedRecipeItemBindingSource;
        private NumericUpDown numericUpDownQuantity;
        private Button buttonAdd;
        private Button buttonDelete;
        private ListBox listBoxMaterials;
        private BindingSource materialBindingSource;
        private Label labelCount;
        private Button buttonSaveXml;
    }
}
