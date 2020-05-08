namespace Esoft_Project
{
    partial class FormAgents
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.textBoxShare = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelMiddleName = new System.Windows.Forms.Label();
            this.labelShare = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.listViewRealtors = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Location = new System.Drawing.Point(414, 414);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(82, 36);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLastName.Location = new System.Drawing.Point(12, 102);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(110, 20);
            this.textBoxLastName.TabIndex = 1;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFirstName.Location = new System.Drawing.Point(12, 142);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(110, 20);
            this.textBoxFirstName.TabIndex = 2;
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxMiddleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMiddleName.Location = new System.Drawing.Point(12, 183);
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(110, 20);
            this.textBoxMiddleName.TabIndex = 3;
            // 
            // textBoxShare
            // 
            this.textBoxShare.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxShare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxShare.Location = new System.Drawing.Point(12, 222);
            this.textBoxShare.Name = "textBoxShare";
            this.textBoxShare.Size = new System.Drawing.Size(110, 20);
            this.textBoxShare.TabIndex = 4;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(9, 86);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(56, 13);
            this.labelLastName.TabIndex = 6;
            this.labelLastName.Text = "Фамилия";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(9, 125);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(29, 13);
            this.labelFirstName.TabIndex = 7;
            this.labelFirstName.Text = "Имя";
            // 
            // labelMiddleName
            // 
            this.labelMiddleName.AutoSize = true;
            this.labelMiddleName.Location = new System.Drawing.Point(9, 167);
            this.labelMiddleName.Name = "labelMiddleName";
            this.labelMiddleName.Size = new System.Drawing.Size(54, 13);
            this.labelMiddleName.TabIndex = 8;
            this.labelMiddleName.Text = "Отчество";
            // 
            // labelShare
            // 
            this.labelShare.AutoSize = true;
            this.labelShare.Location = new System.Drawing.Point(9, 206);
            this.labelShare.Name = "labelShare";
            this.labelShare.Size = new System.Drawing.Size(101, 13);
            this.labelShare.TabIndex = 9;
            this.labelShare.Text = "Доля от комиссии";
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Location = new System.Drawing.Point(502, 414);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(82, 36);
            this.buttonEdit.TabIndex = 10;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDel.Location = new System.Drawing.Point(590, 414);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(82, 36);
            this.buttonDel.TabIndex = 11;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // listViewRealtors
            // 
            this.listViewRealtors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewRealtors.FullRowSelect = true;
            this.listViewRealtors.GridLines = true;
            this.listViewRealtors.HideSelection = false;
            this.listViewRealtors.Location = new System.Drawing.Point(128, 102);
            this.listViewRealtors.MultiSelect = false;
            this.listViewRealtors.Name = "listViewRealtors";
            this.listViewRealtors.Size = new System.Drawing.Size(544, 306);
            this.listViewRealtors.TabIndex = 12;
            this.listViewRealtors.UseCompatibleStateImageBehavior = false;
            this.listViewRealtors.View = System.Windows.Forms.View.Details;
            this.listViewRealtors.SelectedIndexChanged += new System.EventHandler(this.listViewRealtors_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Фамилия";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Имя";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Отчество";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Доля";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Esoft_Project.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(434, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 95);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // FormAgents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listViewRealtors);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.labelShare);
            this.Controls.Add(this.labelMiddleName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.textBoxShare);
            this.Controls.Add(this.textBoxMiddleName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.buttonAdd);
            this.Name = "FormAgents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Риелтор";
            this.Load += new System.EventHandler(this.FormRealtors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxMiddleName;
        private System.Windows.Forms.TextBox textBoxShare;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelMiddleName;
        private System.Windows.Forms.Label labelShare;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.ListView listViewRealtors;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}