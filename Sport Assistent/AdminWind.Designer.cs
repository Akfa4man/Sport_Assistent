namespace Sport_Assistent
{
    partial class AdminWind
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
            this.accesControlPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.problemNotificationsButton = new System.Windows.Forms.Button();
            this.problemsNotificationPanel = new System.Windows.Forms.Panel();
            this.accessControlButton = new System.Windows.Forms.Button();
            this.adminLabel = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.accesControlPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Orange;
            this.mainPanel.Controls.Add(this.accesControlPanel);
            this.mainPanel.Controls.Add(this.problemNotificationsButton);
            this.mainPanel.Controls.Add(this.problemsNotificationPanel);
            this.mainPanel.Controls.Add(this.accessControlButton);
            this.mainPanel.Location = new System.Drawing.Point(111, 46);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(870, 507);
            this.mainPanel.TabIndex = 1;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // accesControlPanel
            // 
            this.accesControlPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.accesControlPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.accesControlPanel.Controls.Add(this.tableLayoutPanel1);
            this.accesControlPanel.Location = new System.Drawing.Point(35, 101);
            this.accesControlPanel.Name = "accesControlPanel";
            this.accesControlPanel.Size = new System.Drawing.Size(803, 379);
            this.accesControlPanel.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(803, 62);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(59, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Клиент";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(661, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Доступ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(360, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Секция";
            // 
            // problemNotificationsButton
            // 
            this.problemNotificationsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.problemNotificationsButton.BackColor = System.Drawing.Color.Yellow;
            this.problemNotificationsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.problemNotificationsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.problemNotificationsButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.problemNotificationsButton.Location = new System.Drawing.Point(434, 0);
            this.problemNotificationsButton.Name = "problemNotificationsButton";
            this.problemNotificationsButton.Size = new System.Drawing.Size(436, 74);
            this.problemNotificationsButton.TabIndex = 1;
            this.problemNotificationsButton.Text = "Уведомления о неполадках";
            this.problemNotificationsButton.UseVisualStyleBackColor = false;
            this.problemNotificationsButton.Click += new System.EventHandler(this.problemNotificationButton);
            // 
            // problemsNotificationPanel
            // 
            this.problemsNotificationPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.problemsNotificationPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.problemsNotificationPanel.Location = new System.Drawing.Point(35, 101);
            this.problemsNotificationPanel.Name = "problemsNotificationPanel";
            this.problemsNotificationPanel.Size = new System.Drawing.Size(803, 379);
            this.problemsNotificationPanel.TabIndex = 4;
            // 
            // accessControlButton
            // 
            this.accessControlButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.accessControlButton.BackColor = System.Drawing.Color.Orange;
            this.accessControlButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accessControlButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.accessControlButton.Location = new System.Drawing.Point(1, 0);
            this.accessControlButton.Name = "accessControlButton";
            this.accessControlButton.Size = new System.Drawing.Size(436, 74);
            this.accessControlButton.TabIndex = 0;
            this.accessControlButton.Text = "Контроль доступа";
            this.accessControlButton.UseVisualStyleBackColor = false;
            this.accessControlButton.Click += new System.EventHandler(this.accesControlButton_Click);
            // 
            // adminLabel
            // 
            this.adminLabel.AutoSize = true;
            this.adminLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adminLabel.Location = new System.Drawing.Point(443, 9);
            this.adminLabel.Name = "adminLabel";
            this.adminLabel.Size = new System.Drawing.Size(207, 29);
            this.adminLabel.TabIndex = 2;
            this.adminLabel.Text = "Администратор";
            // 
            // AdminWind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1092, 599);
            this.Controls.Add(this.adminLabel);
            this.Controls.Add(this.mainPanel);
            this.Name = "AdminWind";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AdminWind_Load);
            this.mainPanel.ResumeLayout(false);
            this.accesControlPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button problemNotificationsButton;
        private System.Windows.Forms.Button accessControlButton;
        private System.Windows.Forms.Panel accesControlPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel problemsNotificationPanel;
        private System.Windows.Forms.Label adminLabel;
    }
}