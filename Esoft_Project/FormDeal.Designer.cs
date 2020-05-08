namespace Esoft_Project
{
    partial class FormDeal
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
            this.comboBoxSupply = new System.Windows.Forms.ComboBox();
            this.comboBoxDemand = new System.Windows.Forms.ComboBox();
            this.labelSupply = new System.Windows.Forms.Label();
            this.labelDemand = new System.Windows.Forms.Label();
            this.labelSellerCompanyDeductions = new System.Windows.Forms.Label();
            this.labelAgentSellerDeductions = new System.Windows.Forms.Label();
            this.labelCustomerCompanyDeductions = new System.Windows.Forms.Label();
            this.labelAgentCustomerDeductions = new System.Windows.Forms.Label();
            this.textBoxSellerCompanyDeductions = new System.Windows.Forms.TextBox();
            this.textBoxAgentSellerDeductions = new System.Windows.Forms.TextBox();
            this.textCustomerCompanyDeductions = new System.Windows.Forms.TextBox();
            this.textBoxAgentCustomerDeductions = new System.Windows.Forms.TextBox();
            this.listViewDealSet = new System.Windows.Forms.ListView();
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
            // comboBoxSupply
            // 
            this.comboBoxSupply.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.comboBoxSupply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSupply.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxSupply.FormattingEnabled = true;
            this.comboBoxSupply.Location = new System.Drawing.Point(12, 100);
            this.comboBoxSupply.Name = "comboBoxSupply";
            this.comboBoxSupply.Size = new System.Drawing.Size(215, 21);
            this.comboBoxSupply.TabIndex = 0;
            this.comboBoxSupply.SelectedIndexChanged += new System.EventHandler(this.comboBoxSupply_SelectedIndexChanged);
            // 
            // comboBoxDemand
            // 
            this.comboBoxDemand.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.comboBoxDemand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxDemand.FormattingEnabled = true;
            this.comboBoxDemand.Location = new System.Drawing.Point(12, 140);
            this.comboBoxDemand.Name = "comboBoxDemand";
            this.comboBoxDemand.Size = new System.Drawing.Size(215, 21);
            this.comboBoxDemand.TabIndex = 1;
            this.comboBoxDemand.SelectedIndexChanged += new System.EventHandler(this.comboBoxDemand_SelectedIndexChanged);
            // 
            // labelSupply
            // 
            this.labelSupply.AutoSize = true;
            this.labelSupply.Location = new System.Drawing.Point(9, 84);
            this.labelSupply.Name = "labelSupply";
            this.labelSupply.Size = new System.Drawing.Size(77, 13);
            this.labelSupply.TabIndex = 2;
            this.labelSupply.Text = "Предложение";
            // 
            // labelDemand
            // 
            this.labelDemand.AutoSize = true;
            this.labelDemand.Location = new System.Drawing.Point(9, 124);
            this.labelDemand.Name = "labelDemand";
            this.labelDemand.Size = new System.Drawing.Size(73, 13);
            this.labelDemand.TabIndex = 3;
            this.labelDemand.Text = "Потребность";
            // 
            // labelSellerCompanyDeductions
            // 
            this.labelSellerCompanyDeductions.AutoSize = true;
            this.labelSellerCompanyDeductions.Location = new System.Drawing.Point(9, 166);
            this.labelSellerCompanyDeductions.Name = "labelSellerCompanyDeductions";
            this.labelSellerCompanyDeductions.Size = new System.Drawing.Size(208, 13);
            this.labelSellerCompanyDeductions.TabIndex = 4;
            this.labelSellerCompanyDeductions.Text = "Стоимость услуг для клиента-продавца";
            // 
            // labelAgentSellerDeductions
            // 
            this.labelAgentSellerDeductions.AutoSize = true;
            this.labelAgentSellerDeductions.Location = new System.Drawing.Point(9, 207);
            this.labelAgentSellerDeductions.Name = "labelAgentSellerDeductions";
            this.labelAgentSellerDeductions.Size = new System.Drawing.Size(208, 13);
            this.labelAgentSellerDeductions.TabIndex = 5;
            this.labelAgentSellerDeductions.Text = "Отчисления риелторуклиента-продавца";
            // 
            // labelCustomerCompanyDeductions
            // 
            this.labelCustomerCompanyDeductions.AutoSize = true;
            this.labelCustomerCompanyDeductions.Location = new System.Drawing.Point(9, 246);
            this.labelCustomerCompanyDeductions.Name = "labelCustomerCompanyDeductions";
            this.labelCustomerCompanyDeductions.Size = new System.Drawing.Size(218, 13);
            this.labelCustomerCompanyDeductions.TabIndex = 6;
            this.labelCustomerCompanyDeductions.Text = "Стоимость услуг для клиента-покупателя";
            // 
            // labelAgentCustomerDeductions
            // 
            this.labelAgentCustomerDeductions.AutoSize = true;
            this.labelAgentCustomerDeductions.Location = new System.Drawing.Point(9, 287);
            this.labelAgentCustomerDeductions.Name = "labelAgentCustomerDeductions";
            this.labelAgentCustomerDeductions.Size = new System.Drawing.Size(221, 13);
            this.labelAgentCustomerDeductions.TabIndex = 7;
            this.labelAgentCustomerDeductions.Text = "Отчисления риелтору клиента-покупателя";
            // 
            // textBoxSellerCompanyDeductions
            // 
            this.textBoxSellerCompanyDeductions.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxSellerCompanyDeductions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSellerCompanyDeductions.Location = new System.Drawing.Point(12, 182);
            this.textBoxSellerCompanyDeductions.Name = "textBoxSellerCompanyDeductions";
            this.textBoxSellerCompanyDeductions.Size = new System.Drawing.Size(215, 20);
            this.textBoxSellerCompanyDeductions.TabIndex = 8;
            // 
            // textBoxAgentSellerDeductions
            // 
            this.textBoxAgentSellerDeductions.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxAgentSellerDeductions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAgentSellerDeductions.Location = new System.Drawing.Point(12, 223);
            this.textBoxAgentSellerDeductions.Name = "textBoxAgentSellerDeductions";
            this.textBoxAgentSellerDeductions.Size = new System.Drawing.Size(215, 20);
            this.textBoxAgentSellerDeductions.TabIndex = 9;
            // 
            // textCustomerCompanyDeductions
            // 
            this.textCustomerCompanyDeductions.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textCustomerCompanyDeductions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textCustomerCompanyDeductions.Location = new System.Drawing.Point(12, 262);
            this.textCustomerCompanyDeductions.Name = "textCustomerCompanyDeductions";
            this.textCustomerCompanyDeductions.Size = new System.Drawing.Size(215, 20);
            this.textCustomerCompanyDeductions.TabIndex = 10;
            // 
            // textBoxAgentCustomerDeductions
            // 
            this.textBoxAgentCustomerDeductions.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxAgentCustomerDeductions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAgentCustomerDeductions.Location = new System.Drawing.Point(12, 303);
            this.textBoxAgentCustomerDeductions.Name = "textBoxAgentCustomerDeductions";
            this.textBoxAgentCustomerDeductions.Size = new System.Drawing.Size(215, 20);
            this.textBoxAgentCustomerDeductions.TabIndex = 11;
            // 
            // listViewDealSet
            // 
            this.listViewDealSet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewDealSet.FullRowSelect = true;
            this.listViewDealSet.GridLines = true;
            this.listViewDealSet.HideSelection = false;
            this.listViewDealSet.Location = new System.Drawing.Point(236, 101);
            this.listViewDealSet.MultiSelect = false;
            this.listViewDealSet.Name = "listViewDealSet";
            this.listViewDealSet.Size = new System.Drawing.Size(552, 267);
            this.listViewDealSet.TabIndex = 12;
            this.listViewDealSet.UseCompatibleStateImageBehavior = false;
            this.listViewDealSet.View = System.Windows.Forms.View.Details;
            this.listViewDealSet.SelectedIndexChanged += new System.EventHandler(this.listViewDealSet_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Клиент-продавец";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Риелтор клиента-продавца";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Клиент-покупатель";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Риелтор клиента-покупателя";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Адрес объекта недвижимости";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Стоимость";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Location = new System.Drawing.Point(526, 374);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(82, 36);
            this.buttonAdd.TabIndex = 13;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Location = new System.Drawing.Point(614, 374);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(82, 36);
            this.buttonEdit.TabIndex = 14;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDel.Location = new System.Drawing.Point(702, 374);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(82, 36);
            this.buttonDel.TabIndex = 15;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Esoft_Project.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(549, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 96);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // FormDeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 421);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewDealSet);
            this.Controls.Add(this.textBoxAgentCustomerDeductions);
            this.Controls.Add(this.textCustomerCompanyDeductions);
            this.Controls.Add(this.textBoxAgentSellerDeductions);
            this.Controls.Add(this.textBoxSellerCompanyDeductions);
            this.Controls.Add(this.labelAgentCustomerDeductions);
            this.Controls.Add(this.labelCustomerCompanyDeductions);
            this.Controls.Add(this.labelAgentSellerDeductions);
            this.Controls.Add(this.labelSellerCompanyDeductions);
            this.Controls.Add(this.labelDemand);
            this.Controls.Add(this.labelSupply);
            this.Controls.Add(this.comboBoxDemand);
            this.Controls.Add(this.comboBoxSupply);
            this.Name = "FormDeal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сделки";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSupply;
        private System.Windows.Forms.ComboBox comboBoxDemand;
        private System.Windows.Forms.Label labelSupply;
        private System.Windows.Forms.Label labelDemand;
        private System.Windows.Forms.Label labelSellerCompanyDeductions;
        private System.Windows.Forms.Label labelAgentSellerDeductions;
        private System.Windows.Forms.Label labelCustomerCompanyDeductions;
        private System.Windows.Forms.Label labelAgentCustomerDeductions;
        private System.Windows.Forms.TextBox textBoxSellerCompanyDeductions;
        private System.Windows.Forms.TextBox textBoxAgentSellerDeductions;
        private System.Windows.Forms.TextBox textCustomerCompanyDeductions;
        private System.Windows.Forms.TextBox textBoxAgentCustomerDeductions;
        private System.Windows.Forms.ListView listViewDealSet;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}