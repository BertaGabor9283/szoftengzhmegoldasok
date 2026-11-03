namespace ZH2B
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
            textBoxQuantity = new TextBox();
            buttonAdd = new Button();
            buttonDelete = new Button();
            textBoxMaterialFilter = new TextBox();
            listBoxMaterials = new ListBox();
            materialBindingSource = new BindingSource(components);
            buttonCocktails = new Button();
            ((System.ComponentModel.ISupportInitialize)cocktailBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecipes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)detailedRecipeItemBindingSource).BeginInit();
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
            dataGridViewRecipes.MultiSelect = false;
            dataGridViewRecipes.Name = "dataGridViewRecipes";
            dataGridViewRecipes.ReadOnly = true;
            dataGridViewRecipes.RowHeadersWidth = 51;
            dataGridViewRecipes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewRecipes.Size = new Size(420, 384);
            dataGridViewRecipes.TabIndex = 2;
            //
            // recipeSkDataGridViewTextBoxColumn
            //
            recipeSkDataGridViewTextBoxColumn.DataPropertyName = "RecipeSk";
            recipeSkDataGridViewTextBoxColumn.HeaderText = "RecipeSk";
            recipeSkDataGridViewTextBoxColumn.MinimumWidth = 6;
            recipeSkDataGridViewTextBoxColumn.Name = "recipeSkDataGridViewTextBoxColumn";
            recipeSkDataGridViewTextBoxColumn.ReadOnly = true;
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
            materialNameDataGridViewTextBoxColumn.ReadOnly = true;
            //
            // materialTypeDataGridViewTextBoxColumn
            //
            materialTypeDataGridViewTextBoxColumn.DataPropertyName = "MaterialType";
            materialTypeDataGridViewTextBoxColumn.HeaderText = "MaterialType";
            materialTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            materialTypeDataGridViewTextBoxColumn.Name = "materialTypeDataGridViewTextBoxColumn";
            materialTypeDataGridViewTextBoxColumn.ReadOnly = true;
            materialTypeDataGridViewTextBoxColumn.Width = 110;
            //
            // quantityDataGridViewTextBoxColumn
            //
            quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            quantityDataGridViewTextBoxColumn.ReadOnly = true;
            quantityDataGridViewTextBoxColumn.Width = 80;
            //
            // unitNameDataGridViewTextBoxColumn
            //
            unitNameDataGridViewTextBoxColumn.DataPropertyName = "UnitName";
            unitNameDataGridViewTextBoxColumn.HeaderText = "UnitName";
            unitNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            unitNameDataGridViewTextBoxColumn.Name = "unitNameDataGridViewTextBoxColumn";
            unitNameDataGridViewTextBoxColumn.ReadOnly = true;
            unitNameDataGridViewTextBoxColumn.Width = 80;
            //
            // detailedRecipeItemBindingSource
            //
            detailedRecipeItemBindingSource.DataSource = typeof(DetailedRecipeItem);
            //
            // textBoxQuantity
            //
            textBoxQuantity.Location = new Point(704, 160);
            textBoxQuantity.Name = "textBoxQuantity";
            textBoxQuantity.Size = new Size(80, 27);
            textBoxQuantity.TabIndex = 3;
            textBoxQuantity.Text = "1";
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
            // textBoxMaterialFilter
            //
            textBoxMaterialFilter.Location = new Point(804, 24);
            textBoxMaterialFilter.Name = "textBoxMaterialFilter";
            textBoxMaterialFilter.Size = new Size(260, 27);
            textBoxMaterialFilter.TabIndex = 6;
            textBoxMaterialFilter.TextChanged += textBoxMaterialFilter_TextChanged;
            //
            // listBoxMaterials
            //
            listBoxMaterials.DataSource = materialBindingSource;
            listBoxMaterials.DisplayMember = "Name";
            listBoxMaterials.FormattingEnabled = true;
            listBoxMaterials.Location = new Point(804, 64);
            listBoxMaterials.Name = "listBoxMaterials";
            listBoxMaterials.Size = new Size(260, 384);
            listBoxMaterials.TabIndex = 7;
            //
            // materialBindingSource
            //
            materialBindingSource.DataSource = typeof(Models.Material);
            //
            // buttonCocktails
            //
            buttonCocktails.Location = new Point(804, 458);
            buttonCocktails.Name = "buttonCocktails";
            buttonCocktails.Size = new Size(260, 32);
            buttonCocktails.TabIndex = 8;
            buttonCocktails.Text = "Koktélok kezelése";
            buttonCocktails.UseVisualStyleBackColor = true;
            buttonCocktails.Click += buttonCocktails_Click;
            //
            // Form1
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1090, 510);
            Controls.Add(buttonCocktails);
            Controls.Add(listBoxMaterials);
            Controls.Add(textBoxMaterialFilter);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxQuantity);
            Controls.Add(dataGridViewRecipes);
            Controls.Add(listBoxCocktails);
            Controls.Add(textBoxCocktailFilter);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)cocktailBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecipes).EndInit();
            ((System.ComponentModel.ISupportInitialize)detailedRecipeItemBindingSource).EndInit();
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
        private TextBox textBoxQuantity;
        private Button buttonAdd;
        private Button buttonDelete;
        private TextBox textBoxMaterialFilter;
        private ListBox listBoxMaterials;
        private BindingSource materialBindingSource;
        private Button buttonCocktails;
    }
}
