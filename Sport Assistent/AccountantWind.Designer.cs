namespace Sport_Assistent
{
    partial class AccountantWind
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.accountingLabel = new System.Windows.Forms.Label();
            this.dataPanel = new System.Windows.Forms.Panel();
            this.reportButton = new System.Windows.Forms.Button();
            this.arrearsButton = new System.Windows.Forms.Button();
            this.incomeButton = new System.Windows.Forms.Button();
            this.subscriptionButton = new System.Windows.Forms.Button();
            this.accountantLabel = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.dataPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mainPanel.BackColor = System.Drawing.Color.Gold;
            this.mainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mainPanel.Controls.Add(this.accountingLabel);
            this.mainPanel.Controls.Add(this.dataPanel);
            this.mainPanel.Location = new System.Drawing.Point(34, 47);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1010, 524);
            this.mainPanel.TabIndex = 0;
            // 
            // accountingLabel
            // 
            this.accountingLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.accountingLabel.AutoSize = true;
            this.accountingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.accountingLabel.Location = new System.Drawing.Point(381, 28);
            this.accountingLabel.Name = "accountingLabel";
            this.accountingLabel.Size = new System.Drawing.Size(263, 32);
            this.accountingLabel.TabIndex = 6;
            this.accountingLabel.Text = "Финансовый учёт";
            // 
            // dataPanel
            // 
            this.dataPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dataPanel.Controls.Add(this.reportButton);
            this.dataPanel.Controls.Add(this.arrearsButton);
            this.dataPanel.Controls.Add(this.incomeButton);
            this.dataPanel.Controls.Add(this.subscriptionButton);
            this.dataPanel.Location = new System.Drawing.Point(37, 85);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.Size = new System.Drawing.Size(941, 405);
            this.dataPanel.TabIndex = 5;
            // 
            // reportButton
            // 
            this.reportButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reportButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.reportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reportButton.Location = new System.Drawing.Point(710, 0);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(231, 117);
            this.reportButton.TabIndex = 3;
            this.reportButton.Text = "Генерация отчётов о финансовых показателях";
            this.reportButton.UseVisualStyleBackColor = false;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // arrearsButton
            // 
            this.arrearsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.arrearsButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.arrearsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.arrearsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arrearsButton.Location = new System.Drawing.Point(475, 0);
            this.arrearsButton.Name = "arrearsButton";
            this.arrearsButton.Size = new System.Drawing.Size(237, 117);
            this.arrearsButton.TabIndex = 2;
            this.arrearsButton.Text = "Контроль задолженностей клиентов";
            this.arrearsButton.UseVisualStyleBackColor = false;
            this.arrearsButton.Click += new System.EventHandler(this.arrearsButton_Click);
            // 
            // incomeButton
            // 
            this.incomeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.incomeButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.incomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.incomeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.incomeButton.Location = new System.Drawing.Point(232, 0);
            this.incomeButton.Name = "incomeButton";
            this.incomeButton.Size = new System.Drawing.Size(248, 117);
            this.incomeButton.TabIndex = 1;
            this.incomeButton.Text = "Расчёт доходов";
            this.incomeButton.UseVisualStyleBackColor = false;
            this.incomeButton.Click += new System.EventHandler(this.incomeButton_Click);
            // 
            // subscriptionButton
            // 
            this.subscriptionButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.subscriptionButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.subscriptionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subscriptionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subscriptionButton.Location = new System.Drawing.Point(0, 0);
            this.subscriptionButton.Name = "subscriptionButton";
            this.subscriptionButton.Size = new System.Drawing.Size(235, 117);
            this.subscriptionButton.TabIndex = 0;
            this.subscriptionButton.Text = "Учёт продаж абонементов";
            this.subscriptionButton.UseVisualStyleBackColor = false;
            this.subscriptionButton.Click += new System.EventHandler(this.subscriptionButton_Click);
            // 
            // accountantLabel
            // 
            this.accountantLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.accountantLabel.AutoSize = true;
            this.accountantLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.accountantLabel.Location = new System.Drawing.Point(473, 15);
            this.accountantLabel.Name = "accountantLabel";
            this.accountantLabel.Size = new System.Drawing.Size(137, 29);
            this.accountantLabel.TabIndex = 0;
            this.accountantLabel.Text = "Бухгалтер";
            // 
            // AccountantWind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1092, 599);
            this.Controls.Add(this.accountantLabel);
            this.Controls.Add(this.mainPanel);
            this.Name = "AccountantWind";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AccountantWind_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.dataPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel dataPanel;
        private System.Windows.Forms.Label accountantLabel;
        private System.Windows.Forms.Label accountingLabel;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.Button arrearsButton;
        private System.Windows.Forms.Button incomeButton;
        private System.Windows.Forms.Button subscriptionButton;
    }
}