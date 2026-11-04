namespace ZH3B
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
            textBoxStoreFilter = new TextBox();
            listBoxStores = new ListBox();
            storeBindingSource = new BindingSource(components);
            dataGridViewStocks = new DataGridView();
            storeIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            detailedStockItemBindingSource = new BindingSource(components);
            numericUpDownQuantity = new NumericUpDown();
            buttonAdd = new Button();
            buttonDelete = new Button();
            listBoxProducts = new ListBox();
            productBindingSource = new BindingSource(components);
            buttonAddStore = new Button();
            ((System.ComponentModel.ISupportInitialize)storeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStocks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)detailedStockItemBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            SuspendLayout();
            // 
            // textBoxStoreFilter
            // 
            textBoxStoreFilter.Location = new Point(24, 24);
            textBoxStoreFilter.Name = "textBoxStoreFilter";
            textBoxStoreFilter.Size = new Size(220, 27);
            textBoxStoreFilter.TabIndex = 0;
            textBoxStoreFilter.TextChanged += textBoxStoreFilter_TextChanged;
            // 
            // listBoxStores
            // 
            listBoxStores.DataSource = storeBindingSource;
            listBoxStores.DisplayMember = "StoreName";
            listBoxStores.FormattingEnabled = true;
            listBoxStores.Location = new Point(24, 64);
            listBoxStores.Name = "listBoxStores";
            listBoxStores.Size = new Size(220, 384);
            listBoxStores.TabIndex = 1;
            // 
            // storeBindingSource
            // 
            storeBindingSource.DataSource = typeof(Models.Store);
            storeBindingSource.CurrentChanged += storeBindingSource_CurrentChanged;
            // 
            // dataGridViewStocks
            // 
            dataGridViewStocks.AllowUserToAddRows = false;
            dataGridViewStocks.AllowUserToDeleteRows = false;
            dataGridViewStocks.AutoGenerateColumns = false;
            dataGridViewStocks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStocks.Columns.AddRange(new DataGridViewColumn[] { storeIdDataGridViewTextBoxColumn, productIdDataGridViewTextBoxColumn, productNameDataGridViewTextBoxColumn, quantityDataGridViewTextBoxColumn });
            dataGridViewStocks.DataSource = detailedStockItemBindingSource;
            dataGridViewStocks.Location = new Point(264, 64);
            dataGridViewStocks.Name = "dataGridViewStocks";
            dataGridViewStocks.ReadOnly = true;
            dataGridViewStocks.RowHeadersWidth = 51;
            dataGridViewStocks.Size = new Size(420, 384);
            dataGridViewStocks.TabIndex = 2;
            // 
            // storeIdDataGridViewTextBoxColumn
            // 
            storeIdDataGridViewTextBoxColumn.DataPropertyName = "StoreId";
            storeIdDataGridViewTextBoxColumn.HeaderText = "StoreId";
            storeIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            storeIdDataGridViewTextBoxColumn.Name = "storeIdDataGridViewTextBoxColumn";
            storeIdDataGridViewTextBoxColumn.Visible = false;
            storeIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            productIdDataGridViewTextBoxColumn.HeaderText = "ProductId";
            productIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            productIdDataGridViewTextBoxColumn.Visible = false;
            productIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            productNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            productNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            quantityDataGridViewTextBoxColumn.Width = 90;
            // 
            // detailedStockItemBindingSource
            // 
            detailedStockItemBindingSource.DataSource = typeof(DetailedStockItem);
            // 
            // numericUpDownQuantity
            // 
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
            // listBoxProducts
            // 
            listBoxProducts.DataSource = productBindingSource;
            listBoxProducts.DisplayMember = "ProductName";
            listBoxProducts.FormattingEnabled = true;
            listBoxProducts.Location = new Point(804, 64);
            listBoxProducts.Name = "listBoxProducts";
            listBoxProducts.Size = new Size(260, 384);
            listBoxProducts.TabIndex = 6;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Models.Product);
            // 
            // buttonAddStore
            // 
            buttonAddStore.Location = new Point(24, 458);
            buttonAddStore.Name = "buttonAddStore";
            buttonAddStore.Size = new Size(220, 32);
            buttonAddStore.TabIndex = 7;
            buttonAddStore.Text = "Új bolt";
            buttonAddStore.UseVisualStyleBackColor = true;
            buttonAddStore.Click += buttonAddStore_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1090, 510);
            Controls.Add(buttonAddStore);
            Controls.Add(listBoxProducts);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
            Controls.Add(numericUpDownQuantity);
            Controls.Add(dataGridViewStocks);
            Controls.Add(listBoxStores);
            Controls.Add(textBoxStoreFilter);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)storeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStocks).EndInit();
            ((System.ComponentModel.ISupportInitialize)detailedStockItemBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxStoreFilter;
        private ListBox listBoxStores;
        private BindingSource storeBindingSource;
        private DataGridView dataGridViewStocks;
        private DataGridViewTextBoxColumn storeIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private BindingSource detailedStockItemBindingSource;
        private NumericUpDown numericUpDownQuantity;
        private Button buttonAdd;
        private Button buttonDelete;
        private ListBox listBoxProducts;
        private BindingSource productBindingSource;
        private Button buttonAddStore;
    }
}
