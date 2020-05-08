namespace Esoft_Project
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonOpenClients = new System.Windows.Forms.Button();
            this.buttonOpenAgents = new System.Windows.Forms.Button();
            this.buttonRealEstates = new System.Windows.Forms.Button();
            this.buttonOpenSupplySet = new System.Windows.Forms.Button();
            this.buttonOpenSupplies = new System.Windows.Forms.Button();
            this.buttonOpenDeals = new System.Windows.Forms.Button();
            this.labelHello = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Esoft_Project.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(3, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 98);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonOpenClients
            // 
            this.buttonOpenClients.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonOpenClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenClients.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonOpenClients.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.buttonOpenClients.Location = new System.Drawing.Point(6, 149);
            this.buttonOpenClients.Name = "buttonOpenClients";
            this.buttonOpenClients.Size = new System.Drawing.Size(265, 48);
            this.buttonOpenClients.TabIndex = 1;
            this.buttonOpenClients.Text = "Клиенты";
            this.buttonOpenClients.UseVisualStyleBackColor = false;
            this.buttonOpenClients.Click += new System.EventHandler(this.buttonOpenClients_Click);
            // 
            // buttonOpenAgents
            // 
            this.buttonOpenAgents.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonOpenAgents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenAgents.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonOpenAgents.Location = new System.Drawing.Point(6, 203);
            this.buttonOpenAgents.Name = "buttonOpenAgents";
            this.buttonOpenAgents.Size = new System.Drawing.Size(265, 48);
            this.buttonOpenAgents.TabIndex = 2;
            this.buttonOpenAgents.Text = "Риелторы";
            this.buttonOpenAgents.UseVisualStyleBackColor = false;
            this.buttonOpenAgents.Click += new System.EventHandler(this.buttonOpenAgents_Click_1);
            // 
            // buttonRealEstates
            // 
            this.buttonRealEstates.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonRealEstates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRealEstates.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonRealEstates.Location = new System.Drawing.Point(6, 257);
            this.buttonRealEstates.Name = "buttonRealEstates";
            this.buttonRealEstates.Size = new System.Drawing.Size(265, 48);
            this.buttonRealEstates.TabIndex = 3;
            this.buttonRealEstates.Text = "Объекты недвижимости";
            this.buttonRealEstates.UseVisualStyleBackColor = false;
            this.buttonRealEstates.Click += new System.EventHandler(this.buttonRealEstates_Click);
            // 
            // buttonOpenSupplySet
            // 
            this.buttonOpenSupplySet.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonOpenSupplySet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenSupplySet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonOpenSupplySet.Location = new System.Drawing.Point(6, 311);
            this.buttonOpenSupplySet.Name = "buttonOpenSupplySet";
            this.buttonOpenSupplySet.Size = new System.Drawing.Size(265, 48);
            this.buttonOpenSupplySet.TabIndex = 4;
            this.buttonOpenSupplySet.Text = "Предложения";
            this.buttonOpenSupplySet.UseVisualStyleBackColor = false;
            this.buttonOpenSupplySet.Click += new System.EventHandler(this.buttonOpenSupplySet_Click_1);
            // 
            // buttonOpenSupplies
            // 
            this.buttonOpenSupplies.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonOpenSupplies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenSupplies.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonOpenSupplies.Location = new System.Drawing.Point(6, 365);
            this.buttonOpenSupplies.Name = "buttonOpenSupplies";
            this.buttonOpenSupplies.Size = new System.Drawing.Size(265, 48);
            this.buttonOpenSupplies.TabIndex = 5;
            this.buttonOpenSupplies.Text = "Потребности";
            this.buttonOpenSupplies.UseVisualStyleBackColor = false;
            this.buttonOpenSupplies.Click += new System.EventHandler(this.buttonOpenSupplies_Click);
            // 
            // buttonOpenDeals
            // 
            this.buttonOpenDeals.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonOpenDeals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenDeals.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonOpenDeals.Location = new System.Drawing.Point(6, 419);
            this.buttonOpenDeals.Name = "buttonOpenDeals";
            this.buttonOpenDeals.Size = new System.Drawing.Size(265, 48);
            this.buttonOpenDeals.TabIndex = 6;
            this.buttonOpenDeals.Text = "Сделки";
            this.buttonOpenDeals.UseVisualStyleBackColor = false;
            this.buttonOpenDeals.Click += new System.EventHandler(this.buttonOpenDeals_Click);
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.Location = new System.Drawing.Point(3, 3);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(44, 13);
            this.labelHello.TabIndex = 7;
            this.labelHello.Text = "Привет";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 561);
            this.Controls.Add(this.labelHello);
            this.Controls.Add(this.buttonOpenDeals);
            this.Controls.Add(this.buttonOpenSupplies);
            this.Controls.Add(this.buttonOpenSupplySet);
            this.Controls.Add(this.buttonRealEstates);
            this.Controls.Add(this.buttonOpenAgents);
            this.Controls.Add(this.buttonOpenClients);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Esoft";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonOpenClients;
        private System.Windows.Forms.Button buttonOpenAgents;
        private System.Windows.Forms.Button buttonRealEstates;
        private System.Windows.Forms.Button buttonOpenSupplySet;
        private System.Windows.Forms.Button buttonOpenSupplies;
        private System.Windows.Forms.Button buttonOpenDeals;
        private System.Windows.Forms.Label labelHello;
    }
}

