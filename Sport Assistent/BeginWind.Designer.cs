﻿namespace Sport_Assistent
{
    partial class BeginWind
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.beginButton = new System.Windows.Forms.Button();
            this.beginPanel = new System.Windows.Forms.Panel();
            this.beginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.ForeColor = System.Drawing.Color.Black;
            this.nameLabel.Location = new System.Drawing.Point(23, 23);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(284, 42);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Sport Assistent";
            // 
            // beginButton
            // 
            this.beginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.beginButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.beginButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.beginButton.FlatAppearance.BorderSize = 2;
            this.beginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.beginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.beginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.beginButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.beginButton.ForeColor = System.Drawing.Color.Orange;
            this.beginButton.Location = new System.Drawing.Point(48, 96);
            this.beginButton.Margin = new System.Windows.Forms.Padding(4);
            this.beginButton.Name = "beginButton";
            this.beginButton.Size = new System.Drawing.Size(231, 50);
            this.beginButton.TabIndex = 2;
            this.beginButton.Text = "Начать работу";
            this.beginButton.UseVisualStyleBackColor = false;
            this.beginButton.Click += new System.EventHandler(this.beginButton_Click);
            // 
            // beginPanel
            // 
            this.beginPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.beginPanel.BackColor = System.Drawing.Color.Transparent;
            this.beginPanel.Controls.Add(this.beginButton);
            this.beginPanel.Controls.Add(this.nameLabel);
            this.beginPanel.Location = new System.Drawing.Point(394, 195);
            this.beginPanel.Name = "beginPanel";
            this.beginPanel.Size = new System.Drawing.Size(320, 163);
            this.beginPanel.TabIndex = 3;
            this.beginPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.beginPanel_Paint);
            // 
            // BeginWind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1063, 599);
            this.Controls.Add(this.beginPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BeginWind";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Sport assistent";
            this.Load += new System.EventHandler(this.BeginWind_Load);
            this.beginPanel.ResumeLayout(false);
            this.beginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button beginButton;
        private System.Windows.Forms.Panel beginPanel;
    }
}

