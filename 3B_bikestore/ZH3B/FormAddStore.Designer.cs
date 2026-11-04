namespace ZH3B
{
    partial class FormAddStore
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
            storeBindingSource = new BindingSource(components);
            labelName = new Label();
            textBoxName = new TextBox();
            labelPhone = new Label();
            textBoxPhone = new TextBox();
            labelEmail = new Label();
            textBoxEmail = new TextBox();
            labelStreet = new Label();
            textBoxStreet = new TextBox();
            labelCity = new Label();
            textBoxCity = new TextBox();
            labelState = new Label();
            textBoxState = new TextBox();
            labelZip = new Label();
            textBoxZip = new TextBox();
            buttonOk = new Button();
            buttonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)storeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // storeBindingSource
            // 
            storeBindingSource.DataSource = typeof(Models.Store);
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(24, 16);
            labelName.Name = "labelName";
            labelName.Size = new Size(100, 20);
            labelName.TabIndex = 0;
            labelName.Text = "Bolt neve:";
            // 
            // textBoxName
            // 
            textBoxName.DataBindings.Add(new Binding("Text", storeBindingSource, "StoreName", true));
            textBoxName.Location = new Point(24, 40);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(344, 27);
            textBoxName.TabIndex = 1;
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(24, 72);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(100, 20);
            labelPhone.TabIndex = 2;
            labelPhone.Text = "Telefon:";
            // 
            // textBoxPhone
            // 
            textBoxPhone.DataBindings.Add(new Binding("Text", storeBindingSource, "Phone", true));
            textBoxPhone.Location = new Point(24, 96);
            textBoxPhone.MaxLength = 25;
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(344, 27);
            textBoxPhone.TabIndex = 3;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(24, 128);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(100, 20);
            labelEmail.TabIndex = 4;
            labelEmail.Text = "E-mail:";
            // 
            // textBoxEmail
            // 
            textBoxEmail.DataBindings.Add(new Binding("Text", storeBindingSource, "Email", true));
            textBoxEmail.Location = new Point(24, 152);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(344, 27);
            textBoxEmail.TabIndex = 5;
            // 
            // labelStreet
            // 
            labelStreet.AutoSize = true;
            labelStreet.Location = new Point(24, 184);
            labelStreet.Name = "labelStreet";
            labelStreet.Size = new Size(100, 20);
            labelStreet.TabIndex = 6;
            labelStreet.Text = "Utca:";
            // 
            // textBoxStreet
            // 
            textBoxStreet.DataBindings.Add(new Binding("Text", storeBindingSource, "Street", true));
            textBoxStreet.Location = new Point(24, 208);
            textBoxStreet.Name = "textBoxStreet";
            textBoxStreet.Size = new Size(344, 27);
            textBoxStreet.TabIndex = 7;
            // 
            // labelCity
            // 
            labelCity.AutoSize = true;
            labelCity.Location = new Point(24, 240);
            labelCity.Name = "labelCity";
            labelCity.Size = new Size(100, 20);
            labelCity.TabIndex = 8;
            labelCity.Text = "Város:";
            // 
            // textBoxCity
            // 
            textBoxCity.DataBindings.Add(new Binding("Text", storeBindingSource, "City", true));
            textBoxCity.Location = new Point(24, 264);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new Size(344, 27);
            textBoxCity.TabIndex = 9;
            // 
            // labelState
            // 
            labelState.AutoSize = true;
            labelState.Location = new Point(24, 296);
            labelState.Name = "labelState";
            labelState.Size = new Size(100, 20);
            labelState.TabIndex = 10;
            labelState.Text = "Állam:";
            // 
            // textBoxState
            // 
            textBoxState.DataBindings.Add(new Binding("Text", storeBindingSource, "State", true));
            textBoxState.Location = new Point(24, 320);
            textBoxState.MaxLength = 10;
            textBoxState.Name = "textBoxState";
            textBoxState.Size = new Size(344, 27);
            textBoxState.TabIndex = 11;
            // 
            // labelZip
            // 
            labelZip.AutoSize = true;
            labelZip.Location = new Point(24, 352);
            labelZip.Name = "labelZip";
            labelZip.Size = new Size(100, 20);
            labelZip.TabIndex = 12;
            labelZip.Text = "Irányítószám:";
            // 
            // textBoxZip
            // 
            textBoxZip.DataBindings.Add(new Binding("Text", storeBindingSource, "ZipCode", true));
            textBoxZip.Location = new Point(24, 376);
            textBoxZip.MaxLength = 5;
            textBoxZip.Name = "textBoxZip";
            textBoxZip.Size = new Size(344, 27);
            textBoxZip.TabIndex = 13;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(192, 420);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(85, 32);
            buttonOk.TabIndex = 20;
            buttonOk.Text = "&Ok";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(283, 420);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(85, 32);
            buttonCancel.TabIndex = 21;
            buttonCancel.Text = "&Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormAddStore
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 472);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOk);
            Controls.Add(textBoxZip);
            Controls.Add(labelZip);
            Controls.Add(textBoxState);
            Controls.Add(labelState);
            Controls.Add(textBoxCity);
            Controls.Add(labelCity);
            Controls.Add(textBoxStreet);
            Controls.Add(labelStreet);
            Controls.Add(textBoxEmail);
            Controls.Add(labelEmail);
            Controls.Add(textBoxPhone);
            Controls.Add(labelPhone);
            Controls.Add(textBoxName);
            Controls.Add(labelName);
            Name = "FormAddStore";
            Text = "FormAddStore";
            Load += FormAddStore_Load;
            ((System.ComponentModel.ISupportInitialize)storeBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource storeBindingSource;
        private Label labelName;
        private TextBox textBoxName;
        private Label labelPhone;
        private TextBox textBoxPhone;
        private Label labelEmail;
        private TextBox textBoxEmail;
        private Label labelStreet;
        private TextBox textBoxStreet;
        private Label labelCity;
        private TextBox textBoxCity;
        private Label labelState;
        private TextBox textBoxState;
        private Label labelZip;
        private TextBox textBoxZip;
        private Button buttonOk;
        private Button buttonCancel;
    }
}
