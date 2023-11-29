namespace Sport_Assistent
{
    partial class SPAdminWind
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataPanel = new System.Windows.Forms.Panel();
            this.timetableButton = new System.Windows.Forms.Button();
            this.clientDataButton = new System.Windows.Forms.Button();
            this.distributionButton = new System.Windows.Forms.Button();
            this.spAdminLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.dataPanel);
            this.panel1.Controls.Add(this.timetableButton);
            this.panel1.Controls.Add(this.clientDataButton);
            this.panel1.Controls.Add(this.distributionButton);
            this.panel1.Location = new System.Drawing.Point(40, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 524);
            this.panel1.TabIndex = 0;
            // 
            // dataPanel
            // 
            this.dataPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataPanel.Location = new System.Drawing.Point(28, 134);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.Size = new System.Drawing.Size(957, 368);
            this.dataPanel.TabIndex = 14;
            // 
            // timetableButton
            // 
            this.timetableButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timetableButton.BackColor = System.Drawing.Color.Yellow;
            this.timetableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timetableButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timetableButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.timetableButton.Location = new System.Drawing.Point(672, 0);
            this.timetableButton.Name = "timetableButton";
            this.timetableButton.Size = new System.Drawing.Size(338, 106);
            this.timetableButton.TabIndex = 13;
            this.timetableButton.Text = "Расписание тренировок";
            this.timetableButton.UseVisualStyleBackColor = false;
            this.timetableButton.Click += new System.EventHandler(this.timetableButton_Click);
            // 
            // clientDataButton
            // 
            this.clientDataButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clientDataButton.BackColor = System.Drawing.Color.Yellow;
            this.clientDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientDataButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.clientDataButton.Location = new System.Drawing.Point(335, 0);
            this.clientDataButton.Name = "clientDataButton";
            this.clientDataButton.Size = new System.Drawing.Size(338, 106);
            this.clientDataButton.TabIndex = 12;
            this.clientDataButton.Text = "Управление клиентскими данными";
            this.clientDataButton.UseVisualStyleBackColor = false;
            this.clientDataButton.Click += new System.EventHandler(this.clientDataButton_Click);
            // 
            // distributionButton
            // 
            this.distributionButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.distributionButton.BackColor = System.Drawing.Color.Orange;
            this.distributionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.distributionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.distributionButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.distributionButton.Location = new System.Drawing.Point(0, 0);
            this.distributionButton.Name = "distributionButton";
            this.distributionButton.Size = new System.Drawing.Size(338, 106);
            this.distributionButton.TabIndex = 11;
            this.distributionButton.Text = "Распределение тренеров";
            this.distributionButton.UseVisualStyleBackColor = false;
            this.distributionButton.Click += new System.EventHandler(this.distributionButton_Click);
            // 
            // spAdminLabel
            // 
            this.spAdminLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.spAdminLabel.AutoSize = true;
            this.spAdminLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spAdminLabel.Location = new System.Drawing.Point(335, 9);
            this.spAdminLabel.Name = "spAdminLabel";
            this.spAdminLabel.Size = new System.Drawing.Size(416, 29);
            this.spAdminLabel.TabIndex = 4;
            this.spAdminLabel.Text = "Администратор спорткомплекса";
            // 
            // SPAdminWind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1092, 599);
            this.Controls.Add(this.spAdminLabel);
            this.Controls.Add(this.panel1);
            this.Name = "SPAdminWind";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SPAdminWind_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel dataPanel;
        private System.Windows.Forms.Button timetableButton;
        private System.Windows.Forms.Button clientDataButton;
        private System.Windows.Forms.Button distributionButton;
        private System.Windows.Forms.Label spAdminLabel;
    }
}