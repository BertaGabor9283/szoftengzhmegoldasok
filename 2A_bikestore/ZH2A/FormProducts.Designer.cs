namespace ZH2A
{
    partial class FormProducts
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
            dataGridViewProducts = new DataGridView();
            productSkDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            brandIdDataGridViewComboBoxColumn = new DataGridViewComboBoxColumn();
            brandBindingSource = new BindingSource(components);
            categoryFkDataGridViewComboBoxColumn = new DataGridViewComboBoxColumn();
            categoryBindingSource = new BindingSource(components);
            modelYearDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            listPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productBindingSource = new BindingSource(components);
            buttonSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)brandBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            SuspendLayout();
            //
            // dataGridViewProducts
            //
            dataGridViewProducts.AutoGenerateColumns = false;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Columns.AddRange(new DataGridViewColumn[] { productSkDataGridViewTextBoxColumn, productNameDataGridViewTextBoxColumn, brandIdDataGridViewComboBoxColumn, categoryFkDataGridViewComboBoxColumn, modelYearDataGridViewTextBoxColumn, listPriceDataGridViewTextBoxColumn });
            dataGridViewProducts.DataSource = productBindingSource;
            dataGridViewProducts.Location = new Point(24, 24);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.RowHeadersWidth = 51;
            dataGridViewProducts.Size = new Size(952, 384);
            dataGridViewProducts.TabIndex = 0;
            dataGridViewProducts.DataError += dataGridViewProducts_DataError;
            //
            // productSkDataGridViewTextBoxColumn
            //
            productSkDataGridViewTextBoxColumn.DataPropertyName = "ProductSk";
            productSkDataGridViewTextBoxColumn.HeaderText = "ProductSk";
            productSkDataGridViewTextBoxColumn.MinimumWidth = 6;
            productSkDataGridViewTextBoxColumn.Name = "productSkDataGridViewTextBoxColumn";
            productSkDataGridViewTextBoxColumn.ReadOnly = true;
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
            // brandIdDataGridViewComboBoxColumn
            //
            brandIdDataGridViewComboBoxColumn.DataPropertyName = "BrandId";
            brandIdDataGridViewComboBoxColumn.DataSource = brandBindingSource;
            brandIdDataGridViewComboBoxColumn.DisplayMember = "BrandName";
            brandIdDataGridViewComboBoxColumn.HeaderText = "Brand";
            brandIdDataGridViewComboBoxColumn.MinimumWidth = 6;
            brandIdDataGridViewComboBoxColumn.Name = "brandIdDataGridViewComboBoxColumn";
            brandIdDataGridViewComboBoxColumn.ValueMember = "BrandSk";
            brandIdDataGridViewComboBoxColumn.Width = 180;
            //
            // brandBindingSource
            //
            brandBindingSource.DataSource = typeof(Models.Brand);
            //
            // categoryFkDataGridViewComboBoxColumn
            //
            categoryFkDataGridViewComboBoxColumn.DataPropertyName = "CategoryFk";
            categoryFkDataGridViewComboBoxColumn.DataSource = categoryBindingSource;
            categoryFkDataGridViewComboBoxColumn.DisplayMember = "CategoryName";
            categoryFkDataGridViewComboBoxColumn.HeaderText = "Category";
            categoryFkDataGridViewComboBoxColumn.MinimumWidth = 6;
            categoryFkDataGridViewComboBoxColumn.Name = "categoryFkDataGridViewComboBoxColumn";
            categoryFkDataGridViewComboBoxColumn.ValueMember = "CategorySk";
            categoryFkDataGridViewComboBoxColumn.Width = 180;
            //
            // categoryBindingSource
            //
            categoryBindingSource.DataSource = typeof(Models.Category);
            //
            // modelYearDataGridViewTextBoxColumn
            //
            modelYearDataGridViewTextBoxColumn.DataPropertyName = "ModelYear";
            modelYearDataGridViewTextBoxColumn.HeaderText = "ModelYear";
            modelYearDataGridViewTextBoxColumn.MinimumWidth = 6;
            modelYearDataGridViewTextBoxColumn.Name = "modelYearDataGridViewTextBoxColumn";
            modelYearDataGridViewTextBoxColumn.Width = 100;
            //
            // listPriceDataGridViewTextBoxColumn
            //
            listPriceDataGridViewTextBoxColumn.DataPropertyName = "ListPrice";
            listPriceDataGridViewTextBoxColumn.HeaderText = "ListPrice";
            listPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            listPriceDataGridViewTextBoxColumn.Name = "listPriceDataGridViewTextBoxColumn";
            listPriceDataGridViewTextBoxColumn.Width = 110;
            //
            // productBindingSource
            //
            productBindingSource.DataSource = typeof(Models.Product);
            //
            // buttonSave
            //
            buttonSave.Location = new Point(856, 424);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(120, 40);
            buttonSave.TabIndex = 1;
            buttonSave.Text = "Mentés";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            //
            // FormProducts
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 480);
            Controls.Add(buttonSave);
            Controls.Add(dataGridViewProducts);
            Name = "FormProducts";
            Text = "Termékek";
            Load += FormProducts_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)brandBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewProducts;
        private DataGridViewTextBoxColumn productSkDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn brandIdDataGridViewComboBoxColumn;
        private DataGridViewComboBoxColumn categoryFkDataGridViewComboBoxColumn;
        private DataGridViewTextBoxColumn modelYearDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn listPriceDataGridViewTextBoxColumn;
        private BindingSource productBindingSource;
        private BindingSource brandBindingSource;
        private BindingSource categoryBindingSource;
        private Button buttonSave;
    }
}
