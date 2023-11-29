namespace Sport_Assistent
{
    partial class ClientWind
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
            this.clientLabel = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.notificationsButton = new System.Windows.Forms.Button();
            this.timetableButton = new System.Windows.Forms.Button();
            this.subscriptionButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clientLabel
            // 
            this.clientLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clientLabel.AutoSize = true;
            this.clientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientLabel.Location = new System.Drawing.Point(385, 7);
            this.clientLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(81, 24);
            this.clientLabel.TabIndex = 3;
            this.clientLabel.Text = "Клиент";
            this.clientLabel.Click += new System.EventHandler(this.trainerLabel_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Orange;
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Controls.Add(this.notificationsButton);
            this.mainPanel.Controls.Add(this.timetableButton);
            this.mainPanel.Controls.Add(this.subscriptionButton);
            this.mainPanel.Location = new System.Drawing.Point(32, 41);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(758, 426);
            this.mainPanel.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(24, 83);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 327);
            this.panel1.TabIndex = 12;
            // 
            // notificationsButton
            // 
            this.notificationsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.notificationsButton.BackColor = System.Drawing.Color.Yellow;
            this.notificationsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notificationsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.notificationsButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.notificationsButton.Location = new System.Drawing.Point(505, 0);
            this.notificationsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.notificationsButton.Name = "notificationsButton";
            this.notificationsButton.Size = new System.Drawing.Size(253, 60);
            this.notificationsButton.TabIndex = 11;
            this.notificationsButton.Text = "Уведомления";
            this.notificationsButton.UseVisualStyleBackColor = false;
            this.notificationsButton.Click += new System.EventHandler(this.notificationsButton_Click);
            // 
            // timetableButton
            // 
            this.timetableButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timetableButton.BackColor = System.Drawing.Color.Yellow;
            this.timetableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timetableButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timetableButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.timetableButton.Location = new System.Drawing.Point(251, 0);
            this.timetableButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.timetableButton.Name = "timetableButton";
            this.timetableButton.Size = new System.Drawing.Size(254, 60);
            this.timetableButton.TabIndex = 10;
            this.timetableButton.Text = "Расписание тренировок";
            this.timetableButton.UseVisualStyleBackColor = false;
            this.timetableButton.Click += new System.EventHandler(this.timetableButton_Click);
            // 
            // subscriptionButton
            // 
            this.subscriptionButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.subscriptionButton.BackColor = System.Drawing.Color.Orange;
            this.subscriptionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subscriptionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subscriptionButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.subscriptionButton.Location = new System.Drawing.Point(0, 0);
            this.subscriptionButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.subscriptionButton.Name = "subscriptionButton";
            this.subscriptionButton.Size = new System.Drawing.Size(254, 60);
            this.subscriptionButton.TabIndex = 9;
            this.subscriptionButton.Text = "Абонементы";
            this.subscriptionButton.UseVisualStyleBackColor = false;
            this.subscriptionButton.Click += new System.EventHandler(this.subscriptionButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(155, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ClientWind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(819, 487);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.clientLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ClientWind";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label clientLabel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button notificationsButton;
        private System.Windows.Forms.Button timetableButton;
        private System.Windows.Forms.Button subscriptionButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}