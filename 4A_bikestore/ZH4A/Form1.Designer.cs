namespace ZH4A
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
            textBoxCustomerFilter = new TextBox();
            listBoxCustomers = new ListBox();
            customerBindingSource = new BindingSource(components);
            listBoxOrders = new ListBox();
            orderBindingSource = new BindingSource(components);
            dataGridViewItems = new DataGridView();
            orderFkDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productFkDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            listPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            detailedOrderItemBindingSource = new BindingSource(components);
            buttonAdd = new Button();
            buttonDelete = new Button();
            listBoxProducts = new ListBox();
            productBindingSource = new BindingSource(components);
            labelValue = new Label();
            buttonSaveXml = new Button();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)detailedOrderItemBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            SuspendLayout();
            //
            // textBoxCustomerFilter
            //
            textBoxCustomerFilter.Location = new Point(12, 12);
            textBoxCustomerFilter.Name = "textBoxCustomerFilter";
            textBoxCustomerFilter.Size = new Size(230, 27);
            textBoxCustomerFilter.TabIndex = 0;
            textBoxCustomerFilter.TextChanged += textBoxCustomerFilter_TextChanged;
            //
            // listBoxCustomers
            //
            listBoxCustomers.DataSource = customerBindingSource;
            listBoxCustomers.DisplayMember = "Email";
            listBoxCustomers.FormattingEnabled = true;
            listBoxCustomers.Location = new Point(12, 52);
            listBoxCustomers.Name = "listBoxCustomers";
            listBoxCustomers.Size = new Size(230, 384);
            listBoxCustomers.TabIndex = 1;
            //
            // customerBindingSource
            //
            customerBindingSource.DataSource = typeof(Models.Customer);
            customerBindingSource.CurrentChanged += customerBindingSource_CurrentChanged;
            //
            // listBoxOrders
            //
            listBoxOrders.DataSource = orderBindingSource;
            listBoxOrders.DisplayMember = "OrderDate";
            listBoxOrders.FormattingEnabled = true;
            listBoxOrders.Location = new Point(250, 52);
            listBoxOrders.Name = "listBoxOrders";
            listBoxOrders.Size = new Size(110, 384);
            listBoxOrders.TabIndex = 2;
            //
            // orderBindingSource
            //
            orderBindingSource.DataSource = typeof(Models.Order);
            orderBindingSource.CurrentChanged += orderBindingSource_CurrentChanged;
            //
            // dataGridViewItems
            //
            dataGridViewItems.AllowUserToAddRows = false;
            dataGridViewItems.AllowUserToDeleteRows = false;
            dataGridViewItems.AutoGenerateColumns = false;
            dataGridViewItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewItems.Columns.AddRange(new DataGridViewColumn[] { orderFkDataGridViewTextBoxColumn, productFkDataGridViewTextBoxColumn, productNameDataGridViewTextBoxColumn, quantityDataGridViewTextBoxColumn, listPriceDataGridViewTextBoxColumn });
            dataGridViewItems.DataSource = detailedOrderItemBindingSource;
            dataGridViewItems.Location = new Point(368, 52);
            dataGridViewItems.MultiSelect = false;
            dataGridViewItems.Name = "dataGridViewItems";
            dataGridViewItems.ReadOnly = true;
            dataGridViewItems.RowHeadersWidth = 51;
            dataGridViewItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewItems.Size = new Size(400, 384);
            dataGridViewItems.TabIndex = 3;
            //
            // orderFkDataGridViewTextBoxColumn
            //
            orderFkDataGridViewTextBoxColumn.DataPropertyName = "OrderFk";
            orderFkDataGridViewTextBoxColumn.HeaderText = "OrderFk";
            orderFkDataGridViewTextBoxColumn.MinimumWidth = 6;
            orderFkDataGridViewTextBoxColumn.Name = "orderFkDataGridViewTextBoxColumn";
            orderFkDataGridViewTextBoxColumn.ReadOnly = true;
            orderFkDataGridViewTextBoxColumn.Visible = false;
            orderFkDataGridViewTextBoxColumn.Width = 125;
            //
            // productFkDataGridViewTextBoxColumn
            //
            productFkDataGridViewTextBoxColumn.DataPropertyName = "ProductFk";
            productFkDataGridViewTextBoxColumn.HeaderText = "ProductFk";
            productFkDataGridViewTextBoxColumn.MinimumWidth = 6;
            productFkDataGridViewTextBoxColumn.Name = "productFkDataGridViewTextBoxColumn";
            productFkDataGridViewTextBoxColumn.ReadOnly = true;
            productFkDataGridViewTextBoxColumn.Visible = false;
            productFkDataGridViewTextBoxColumn.Width = 125;
            //
            // productNameDataGridViewTextBoxColumn
            //
            productNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            productNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            productNameDataGridViewTextBoxColumn.ReadOnly = true;
            //
            // quantityDataGridViewTextBoxColumn
            //
            quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            quantityDataGridViewTextBoxColumn.ReadOnly = true;
            quantityDataGridViewTextBoxColumn.Width = 90;
            //
            // listPriceDataGridViewTextBoxColumn
            //
            listPriceDataGridViewTextBoxColumn.DataPropertyName = "ListPrice";
            listPriceDataGridViewTextBoxColumn.HeaderText = "ListPrice";
            listPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            listPriceDataGridViewTextBoxColumn.Name = "listPriceDataGridViewTextBoxColumn";
            listPriceDataGridViewTextBoxColumn.ReadOnly = true;
            listPriceDataGridViewTextBoxColumn.Width = 100;
            //
            // detailedOrderItemBindingSource
            //
            detailedOrderItemBindingSource.DataSource = typeof(DetailedOrderItem);
            //
            // buttonAdd
            //
            buttonAdd.Location = new Point(780, 150);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(70, 50);
            buttonAdd.TabIndex = 4;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            //
            // buttonDelete
            //
            buttonDelete.Location = new Point(780, 210);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(70, 50);
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
            listBoxProducts.Location = new Point(860, 52);
            listBoxProducts.Name = "listBoxProducts";
            listBoxProducts.Size = new Size(230, 384);
            listBoxProducts.TabIndex = 6;
            //
            // productBindingSource
            //
            productBindingSource.DataSource = typeof(Models.Product);
            //
            // labelValue
            //
            labelValue.AutoSize = true;
            labelValue.Location = new Point(368, 458);
            labelValue.Name = "labelValue";
            labelValue.Size = new Size(117, 20);
            labelValue.TabIndex = 7;
            labelValue.Text = "Rendelés értéke:";
            //
            // buttonSaveXml
            //
            buttonSaveXml.Location = new Point(12, 452);
            buttonSaveXml.Name = "buttonSaveXml";
            buttonSaveXml.Size = new Size(230, 32);
            buttonSaveXml.TabIndex = 8;
            buttonSaveXml.Text = "Vásárlók mentése XML-be";
            buttonSaveXml.UseVisualStyleBackColor = true;
            buttonSaveXml.Click += buttonSaveXml_Click;
            //
            // Form1
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 500);
            Controls.Add(buttonSaveXml);
            Controls.Add(labelValue);
            Controls.Add(listBoxProducts);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridViewItems);
            Controls.Add(listBoxOrders);
            Controls.Add(listBoxCustomers);
            Controls.Add(textBoxCustomerFilter);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)detailedOrderItemBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxCustomerFilter;
        private ListBox listBoxCustomers;
        private BindingSource customerBindingSource;
        private ListBox listBoxOrders;
        private BindingSource orderBindingSource;
        private DataGridView dataGridViewItems;
        private DataGridViewTextBoxColumn orderFkDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productFkDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn listPriceDataGridViewTextBoxColumn;
        private BindingSource detailedOrderItemBindingSource;
        private Button buttonAdd;
        private Button buttonDelete;
        private ListBox listBoxProducts;
        private BindingSource productBindingSource;
        private Label labelValue;
        private Button buttonSaveXml;
    }
}
