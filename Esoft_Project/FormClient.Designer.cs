namespace Esoft_Project
{
    partial class FormClient
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
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelMiddleName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.listViewClient = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFirstName.Location = new System.Drawing.Point(12, 103);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(110, 20);
            this.textBoxFirstName.TabIndex = 0;
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxMiddleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMiddleName.Location = new System.Drawing.Point(12, 142);
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(110, 20);
            this.textBoxMiddleName.TabIndex = 1;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLastName.Location = new System.Drawing.Point(12, 184);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(110, 20);
            this.textBoxLastName.TabIndex = 2;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPhone.Location = new System.Drawing.Point(12, 224);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(110, 20);
            this.textBoxPhone.TabIndex = 3;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEmail.Location = new System.Drawing.Point(12, 265);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(110, 20);
            this.textBoxEmail.TabIndex = 4;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(9, 87);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(29, 13);
            this.labelFirstName.TabIndex = 5;
            this.labelFirstName.Text = "Имя";
            // 
            // labelMiddleName
            // 
            this.labelMiddleName.AutoSize = true;
            this.labelMiddleName.Location = new System.Drawing.Point(9, 126);
            this.labelMiddleName.Name = "labelMiddleName";
            this.labelMiddleName.Size = new System.Drawing.Size(54, 13);
            this.labelMiddleName.TabIndex = 6;
            this.labelMiddleName.Text = "Отчество";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(9, 168);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(56, 13);
            this.labelLastName.TabIndex = 7;
            this.labelLastName.Text = "Фамилия";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(9, 208);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(52, 13);
            this.labelPhone.TabIndex = 8;
            this.labelPhone.Text = "Телефон";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(9, 249);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(37, 13);
            this.labelEmail.TabIndex = 9;
            this.labelEmail.Text = "Почта";
            // 
            // listViewClient
            // 
            this.listViewClient.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewClient.FullRowSelect = true;
            this.listViewClient.GridLines = true;
            this.listViewClient.HideSelection = false;
            this.listViewClient.Location = new System.Drawing.Point(128, 103);
            this.listViewClient.MultiSelect = false;
            this.listViewClient.Name = "listViewClient";
            this.listViewClient.Size = new System.Drawing.Size(544, 306);
            this.listViewClient.TabIndex = 10;
            this.listViewClient.UseCompatibleStateImageBehavior = false;
            this.listViewClient.View = System.Windows.Forms.View.Details;
            this.listViewClient.SelectedIndexChanged += new System.EventHandler(this.listViewClient_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Имя";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Отчество";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Фамилия";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Телефон";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Email";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Location = new System.Drawing.Point(414, 413);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(82, 36);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Location = new System.Drawing.Point(502, 413);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(82, 36);
            this.buttonEdit.TabIndex = 12;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDel.Location = new System.Drawing.Point(590, 413);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(82, 36);
            this.buttonDel.TabIndex = 13;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Esoft_Project.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(435, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 98);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewClient);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelMiddleName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxMiddleName);
            this.Controls.Add(this.textBoxFirstName);
            this.Name = "FormClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Клиент";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxMiddleName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelMiddleName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.ListView listViewClient;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}