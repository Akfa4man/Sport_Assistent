namespace Sport_Assistent
{
    partial class InputEmailWind
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
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.continueButton = new System.Windows.Forms.Button();
            this.entryLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inputEmailPanel = new System.Windows.Forms.Panel();
            this.inputEmailPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // emailLabel
            // 
            this.emailLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailLabel.Location = new System.Drawing.Point(319, 221);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(80, 29);
            this.emailLabel.TabIndex = 5;
            this.emailLabel.Text = "Email:";
            this.emailLabel.Click += new System.EventHandler(this.emailLabel_Click);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.emailTextBox.Location = new System.Drawing.Point(405, 220);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(387, 30);
            this.emailTextBox.TabIndex = 6;
            this.emailTextBox.TabStop = false;
            this.emailTextBox.Text = "* Это действие необязательно";
            this.emailTextBox.Click += new System.EventHandler(this.emailTextBox_Click);
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(14, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(896, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "При востановлении доступа на него придёт письмо с паролем";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // continueButton
            // 
            this.continueButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.continueButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.continueButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.continueButton.FlatAppearance.BorderSize = 2;
            this.continueButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.continueButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.continueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.continueButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.continueButton.ForeColor = System.Drawing.Color.Orange;
            this.continueButton.Location = new System.Drawing.Point(490, 294);
            this.continueButton.Margin = new System.Windows.Forms.Padding(4);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(173, 50);
            this.continueButton.TabIndex = 15;
            this.continueButton.Text = "Продолжить\r\n";
            this.continueButton.UseVisualStyleBackColor = false;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // entryLabel
            // 
            this.entryLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.entryLabel.AutoSize = true;
            this.entryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.entryLabel.Location = new System.Drawing.Point(249, -22);
            this.entryLabel.Name = "entryLabel";
            this.entryLabel.Size = new System.Drawing.Size(0, 32);
            this.entryLabel.TabIndex = 4;
            this.entryLabel.Click += new System.EventHandler(this.entryLabel_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(227, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(504, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Введите адрес электронной почты";
            this.label1.Click += new System.EventHandler(this.label3_Click);
            // 
            // inputEmailPanel
            // 
            this.inputEmailPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputEmailPanel.Controls.Add(this.label2);
            this.inputEmailPanel.Controls.Add(this.label1);
            this.inputEmailPanel.Controls.Add(this.entryLabel);
            this.inputEmailPanel.Location = new System.Drawing.Point(103, 43);
            this.inputEmailPanel.Name = "inputEmailPanel";
            this.inputEmailPanel.Size = new System.Drawing.Size(927, 114);
            this.inputEmailPanel.TabIndex = 8;
            // 
            // InputEmailWind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1092, 599);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.inputEmailPanel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Name = "InputEmailWind";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.inputEmailPanel.ResumeLayout(false);
            this.inputEmailPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.Label entryLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel inputEmailPanel;
    }
}