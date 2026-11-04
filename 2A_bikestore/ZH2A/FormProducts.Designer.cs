namespace ZH2A
{
    partial class FormProducts
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
            dataGridViewProducts = new DataGridView();
            productSkDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            brandDataGridViewComboBoxColumn = new DataGridViewComboBoxColumn();
            categoryDataGridViewComboBoxColumn = new DataGridViewComboBoxColumn();
            modelYearDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            listPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productBindingSource = new BindingSource(components);
            brandBindingSource = new BindingSource(components);
            categoryBindingSource = new BindingSource(components);
            buttonAdd = new Button();
            buttonDelete = new Button();
            buttonSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)brandBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.AllowUserToAddRows = false;
            dataGridViewProducts.AllowUserToDeleteRows = false;
            dataGridViewProducts.AutoGenerateColumns = false;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Columns.AddRange(new DataGridViewColumn[] { productSkDataGridViewTextBoxColumn, productNameDataGridViewTextBoxColumn, brandDataGridViewComboBoxColumn, categoryDataGridViewComboBoxColumn, modelYearDataGridViewTextBoxColumn, listPriceDataGridViewTextBoxColumn });
            dataGridViewProducts.DataSource = productBindingSource;
            dataGridViewProducts.Location = new Point(12, 12);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.RowHeadersWidth = 51;
            dataGridViewProducts.Size = new Size(836, 350);
            dataGridViewProducts.TabIndex = 0;
            // 
            // productSkDataGridViewTextBoxColumn
            // 
            productSkDataGridViewTextBoxColumn.DataPropertyName = "ProductSk";
            productSkDataGridViewTextBoxColumn.HeaderText = "ProductSk";
            productSkDataGridViewTextBoxColumn.MinimumWidth = 6;
            productSkDataGridViewTextBoxColumn.Name = "productSkDataGridViewTextBoxColumn";
            productSkDataGridViewTextBoxColumn.Visible = false;
            productSkDataGridViewTextBoxColumn.Width = 125;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            productNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            productNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // brandDataGridViewComboBoxColumn
            // 
            brandDataGridViewComboBoxColumn.DataPropertyName = "BrandId";
            brandDataGridViewComboBoxColumn.DataSource = brandBindingSource;
            brandDataGridViewComboBoxColumn.DisplayMember = "BrandName";
            brandDataGridViewComboBoxColumn.HeaderText = "Brand";
            brandDataGridViewComboBoxColumn.MinimumWidth = 6;
            brandDataGridViewComboBoxColumn.Name = "brandDataGridViewComboBoxColumn";
            brandDataGridViewComboBoxColumn.ValueMember = "BrandSk";
            brandDataGridViewComboBoxColumn.Width = 160;
            // 
            // categoryDataGridViewComboBoxColumn
            // 
            categoryDataGridViewComboBoxColumn.DataPropertyName = "CategoryFk";
            categoryDataGridViewComboBoxColumn.DataSource = categoryBindingSource;
            categoryDataGridViewComboBoxColumn.DisplayMember = "CategoryName";
            categoryDataGridViewComboBoxColumn.HeaderText = "Category";
            categoryDataGridViewComboBoxColumn.MinimumWidth = 6;
            categoryDataGridViewComboBoxColumn.Name = "categoryDataGridViewComboBoxColumn";
            categoryDataGridViewComboBoxColumn.ValueMember = "CategorySk";
            categoryDataGridViewComboBoxColumn.Width = 160;
            // 
            // modelYearDataGridViewTextBoxColumn
            // 
            modelYearDataGridViewTextBoxColumn.DataPropertyName = "ModelYear";
            modelYearDataGridViewTextBoxColumn.HeaderText = "ModelYear";
            modelYearDataGridViewTextBoxColumn.MinimumWidth = 6;
            modelYearDataGridViewTextBoxColumn.Name = "modelYearDataGridViewTextBoxColumn";
            modelYearDataGridViewTextBoxColumn.Width = 90;
            // 
            // listPriceDataGridViewTextBoxColumn
            // 
            listPriceDataGridViewTextBoxColumn.DataPropertyName = "ListPrice";
            listPriceDataGridViewTextBoxColumn.HeaderText = "ListPrice";
            listPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            listPriceDataGridViewTextBoxColumn.Name = "listPriceDataGridViewTextBoxColumn";
            listPriceDataGridViewTextBoxColumn.Width = 90;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Models.Product);
            // 
            // brandBindingSource
            // 
            brandBindingSource.DataSource = typeof(Models.Brand);
            // 
            // categoryBindingSource
            // 
            categoryBindingSource.DataSource = typeof(Models.Category);
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
            buttonSave.Location = new Point(748, 380);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(100, 32);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "Mentés";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // FormProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 430);
            Controls.Add(buttonSave);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridViewProducts);
            Name = "FormProducts";
            Text = "FormProducts";
            Load += FormProducts_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)brandBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewProducts;
        private DataGridViewTextBoxColumn productSkDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn brandDataGridViewComboBoxColumn;
        private DataGridViewComboBoxColumn categoryDataGridViewComboBoxColumn;
        private DataGridViewTextBoxColumn modelYearDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn listPriceDataGridViewTextBoxColumn;
        private BindingSource productBindingSource;
        private BindingSource brandBindingSource;
        private BindingSource categoryBindingSource;
        private Button buttonAdd;
        private Button buttonDelete;
        private Button buttonSave;
    }
}
