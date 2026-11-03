namespace ZH3B
{
    partial class FormAddStore
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
            storeBindingSource = new BindingSource(components);
            labelStoreName = new Label();
            textBoxStoreName = new TextBox();
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
            labelZipCode = new Label();
            textBoxZipCode = new TextBox();
            buttonOk = new Button();
            buttonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)storeBindingSource).BeginInit();
            SuspendLayout();
            //
            // storeBindingSource
            //
            storeBindingSource.DataSource = typeof(Models.Store);
            //
            // labelStoreName
            //
            labelStoreName.AutoSize = true;
            labelStoreName.Location = new Point(24, 27);
            labelStoreName.Name = "labelStoreName";
            labelStoreName.TabIndex = 20;
            labelStoreName.Text = "Név:";
            //
            // textBoxStoreName
            //
            textBoxStoreName.DataBindings.Add(new Binding("Text", storeBindingSource, "StoreName", true));
            textBoxStoreName.Location = new Point(150, 24);
            textBoxStoreName.Name = "textBoxStoreName";
            textBoxStoreName.Size = new Size(300, 27);
            textBoxStoreName.TabIndex = 0;
            //
            // labelPhone
            //
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(24, 71);
            labelPhone.Name = "labelPhone";
            labelPhone.TabIndex = 21;
            labelPhone.Text = "Telefon:";
            //
            // textBoxPhone
            //
            textBoxPhone.DataBindings.Add(new Binding("Text", storeBindingSource, "Phone", true));
            textBoxPhone.Location = new Point(150, 68);
            textBoxPhone.MaxLength = 25;
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(300, 27);
            textBoxPhone.TabIndex = 1;
            //
            // labelEmail
            //
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(24, 115);
            labelEmail.Name = "labelEmail";
            labelEmail.TabIndex = 22;
            labelEmail.Text = "E-mail:";
            //
            // textBoxEmail
            //
            textBoxEmail.DataBindings.Add(new Binding("Text", storeBindingSource, "Email", true));
            textBoxEmail.Location = new Point(150, 112);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(300, 27);
            textBoxEmail.TabIndex = 2;
            //
            // labelStreet
            //
            labelStreet.AutoSize = true;
            labelStreet.Location = new Point(24, 159);
            labelStreet.Name = "labelStreet";
            labelStreet.TabIndex = 23;
            labelStreet.Text = "Utca:";
            //
            // textBoxStreet
            //
            textBoxStreet.DataBindings.Add(new Binding("Text", storeBindingSource, "Street", true));
            textBoxStreet.Location = new Point(150, 156);
            textBoxStreet.Name = "textBoxStreet";
            textBoxStreet.Size = new Size(300, 27);
            textBoxStreet.TabIndex = 3;
            //
            // labelCity
            //
            labelCity.AutoSize = true;
            labelCity.Location = new Point(24, 203);
            labelCity.Name = "labelCity";
            labelCity.TabIndex = 24;
            labelCity.Text = "Város:";
            //
            // textBoxCity
            //
            textBoxCity.DataBindings.Add(new Binding("Text", storeBindingSource, "City", true));
            textBoxCity.Location = new Point(150, 200);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new Size(300, 27);
            textBoxCity.TabIndex = 4;
            //
            // labelState
            //
            labelState.AutoSize = true;
            labelState.Location = new Point(24, 247);
            labelState.Name = "labelState";
            labelState.TabIndex = 25;
            labelState.Text = "Állam:";
            //
            // textBoxState
            //
            textBoxState.DataBindings.Add(new Binding("Text", storeBindingSource, "State", true));
            textBoxState.Location = new Point(150, 244);
            textBoxState.MaxLength = 10;
            textBoxState.Name = "textBoxState";
            textBoxState.Size = new Size(300, 27);
            textBoxState.TabIndex = 5;
            //
            // labelZipCode
            //
            labelZipCode.AutoSize = true;
            labelZipCode.Location = new Point(24, 291);
            labelZipCode.Name = "labelZipCode";
            labelZipCode.TabIndex = 26;
            labelZipCode.Text = "Irányítószám:";
            //
            // textBoxZipCode
            //
            textBoxZipCode.DataBindings.Add(new Binding("Text", storeBindingSource, "ZipCode", true));
            textBoxZipCode.Location = new Point(150, 288);
            textBoxZipCode.MaxLength = 5;
            textBoxZipCode.Name = "textBoxZipCode";
            textBoxZipCode.Size = new Size(300, 27);
            textBoxZipCode.TabIndex = 6;
            //
            // buttonOk
            //
            buttonOk.DialogResult = DialogResult.OK;
            buttonOk.Location = new Point(250, 352);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(94, 29);
            buttonOk.TabIndex = 7;
            buttonOk.Text = "&Ok";
            buttonOk.UseVisualStyleBackColor = true;
            //
            // buttonCancel
            //
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(356, 352);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 8;
            buttonCancel.Text = "&Mégse";
            buttonCancel.UseVisualStyleBackColor = true;
            //
            // FormAddStore
            //
            AcceptButton = buttonOk;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancel;
            ClientSize = new Size(480, 405);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOk);
            Controls.Add(textBoxZipCode);
            Controls.Add(labelZipCode);
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
            Controls.Add(textBoxStoreName);
            Controls.Add(labelStoreName);
            Name = "FormAddStore";
            Text = "Új bolt";
            FormClosing += FormAddStore_FormClosing;
            Load += FormAddStore_Load;
            ((System.ComponentModel.ISupportInitialize)storeBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource storeBindingSource;
        private Label labelStoreName;
        private TextBox textBoxStoreName;
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
        private Label labelZipCode;
        private TextBox textBoxZipCode;
        private Button buttonOk;
        private Button buttonCancel;
    }
}
