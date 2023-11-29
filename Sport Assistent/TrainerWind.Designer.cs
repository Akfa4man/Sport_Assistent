namespace Sport_Assistent
{
    partial class TrainerWind
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
            this.label2 = new System.Windows.Forms.Label();
            this.notificationsButton = new System.Windows.Forms.Button();
            this.timetableButton = new System.Windows.Forms.Button();
            this.dataPanel = new System.Windows.Forms.Panel();
            this.trainerLabel = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mainPanel.BackColor = System.Drawing.Color.Orange;
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.notificationsButton);
            this.mainPanel.Controls.Add(this.timetableButton);
            this.mainPanel.Controls.Add(this.dataPanel);
            this.mainPanel.Location = new System.Drawing.Point(41, 53);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1010, 524);
            this.mainPanel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(825, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 9;
            // 
            // notificationsButton
            // 
            this.notificationsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.notificationsButton.BackColor = System.Drawing.Color.Yellow;
            this.notificationsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notificationsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.notificationsButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.notificationsButton.Location = new System.Drawing.Point(672, 0);
            this.notificationsButton.Name = "notificationsButton";
            this.notificationsButton.Size = new System.Drawing.Size(338, 74);
            this.notificationsButton.TabIndex = 8;
            this.notificationsButton.Text = "Уведомления";
            this.notificationsButton.UseVisualStyleBackColor = false;
            this.notificationsButton.Click += new System.EventHandler(this.notificationsButton_Click);
            // 
            // timetableButton
            // 
            this.timetableButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timetableButton.BackColor = System.Drawing.Color.Orange;
            this.timetableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timetableButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timetableButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.timetableButton.Location = new System.Drawing.Point(0, 0);
            this.timetableButton.Name = "timetableButton";
            this.timetableButton.Size = new System.Drawing.Size(672, 74);
            this.timetableButton.TabIndex = 7;
            this.timetableButton.Text = "Расписание тренировок";
            this.timetableButton.UseVisualStyleBackColor = false;
            this.timetableButton.Click += new System.EventHandler(this.timetableButton_Click);
            // 
            // dataPanel
            // 
            this.dataPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dataPanel.Location = new System.Drawing.Point(31, 100);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.Size = new System.Drawing.Size(950, 403);
            this.dataPanel.TabIndex = 6;
            // 
            // trainerLabel
            // 
            this.trainerLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.trainerLabel.AutoSize = true;
            this.trainerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trainerLabel.Location = new System.Drawing.Point(515, 9);
            this.trainerLabel.Name = "trainerLabel";
            this.trainerLabel.Size = new System.Drawing.Size(104, 29);
            this.trainerLabel.TabIndex = 2;
            this.trainerLabel.Text = "Тренер";
            // 
            // TrainerWind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1092, 599);
            this.Controls.Add(this.trainerLabel);
            this.Controls.Add(this.mainPanel);
            this.Name = "TrainerWind";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.TrainerWind_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel dataPanel;
        private System.Windows.Forms.Label trainerLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button notificationsButton;
        private System.Windows.Forms.Button timetableButton;
    }
}