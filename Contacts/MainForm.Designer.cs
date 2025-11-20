namespace Contacts
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            lblFullName = new Label();
            txtFullName = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            btnAdd = new Button();
            btnDelete = new Button();
            dgContacts = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgContacts).BeginInit();
            SuspendLayout();
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(12, 17);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(43, 15);
            lblFullName.TabIndex = 0;
            lblFullName.Text = "Ф.И.О:";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(61, 14);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(186, 23);
            txtFullName.TabIndex = 1;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(515, 18);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(560, 15);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(199, 23);
            txtEmail.TabIndex = 3;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(253, 17);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(59, 15);
            lblPhone.TabIndex = 4;
            lblPhone.Text = "Телефон:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(318, 14);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(186, 23);
            txtPhone.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(795, 14);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(897, 14);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgContacts
            // 
            dgContacts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgContacts.Location = new Point(12, 53);
            dgContacts.Name = "dgContacts";
            dgContacts.Size = new Size(960, 563);
            dgContacts.TabIndex = 8;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 628);
            Controls.Add(dgContacts);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(txtPhone);
            Controls.Add(lblPhone);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtFullName);
            Controls.Add(lblFullName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Контакты";
            ((System.ComponentModel.ISupportInitialize)dgContacts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFullName;
        private TextBox txtFullName;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblPhone;
        private TextBox txtPhone;
        private Button btnAdd;
        private Button btnDelete;
        private DataGridView dgContacts;
    }
}
