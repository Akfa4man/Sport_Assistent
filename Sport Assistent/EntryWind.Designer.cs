namespace Sport_Assistent
{
    partial class EntryWind
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
            this.entryLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.continueButton = new System.Windows.Forms.Button();
            this.registrationButton = new System.Windows.Forms.Button();
            this.accesRestorationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // entryLabel
            // 
            this.entryLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.entryLabel.AutoSize = true;
            this.entryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.entryLabel.Location = new System.Drawing.Point(149, 44);
            this.entryLabel.Name = "entryLabel";
            this.entryLabel.Size = new System.Drawing.Size(750, 32);
            this.entryLabel.TabIndex = 0;
            this.entryLabel.Text = "Чтобы войти в аккаунт, введите его логин и пароль.";
            // 
            // loginLabel
            // 
            this.loginLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.Location = new System.Drawing.Point(309, 155);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(88, 29);
            this.loginLabel.TabIndex = 1;
            this.loginLabel.Text = "Логин:";
            this.loginLabel.Click += new System.EventHandler(this.loginLabel_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel.Location = new System.Drawing.Point(295, 245);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(102, 29);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Пароль:";
            this.passwordLabel.Click += new System.EventHandler(this.passwordLabel_Click);
            // 
            // loginTextBox
            // 
            this.loginTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTextBox.Location = new System.Drawing.Point(403, 154);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(387, 30);
            this.loginTextBox.TabIndex = 3;
            this.loginTextBox.TextChanged += new System.EventHandler(this.loginTextBox_TextChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextBox.Location = new System.Drawing.Point(403, 244);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(387, 30);
            this.passwordTextBox.TabIndex = 4;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
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
            this.continueButton.ForeColor = System.Drawing.Color.DarkOrange;
            this.continueButton.Location = new System.Drawing.Point(457, 399);
            this.continueButton.Margin = new System.Windows.Forms.Padding(4);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(231, 50);
            this.continueButton.TabIndex = 5;
            this.continueButton.Text = "Войти";
            this.continueButton.UseVisualStyleBackColor = false;
            this.continueButton.Click += new System.EventHandler(this.entryButton_Click);
            // 
            // registrationButton
            // 
            this.registrationButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.registrationButton.BackColor = System.Drawing.Color.Transparent;
            this.registrationButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.registrationButton.FlatAppearance.BorderSize = 0;
            this.registrationButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.registrationButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.registrationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registrationButton.ForeColor = System.Drawing.Color.Teal;
            this.registrationButton.Location = new System.Drawing.Point(470, 457);
            this.registrationButton.Margin = new System.Windows.Forms.Padding(4);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(209, 32);
            this.registrationButton.TabIndex = 6;
            this.registrationButton.Text = "Зарегистрироваться";
            this.registrationButton.UseVisualStyleBackColor = false;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // accesRestorationButton
            // 
            this.accesRestorationButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.accesRestorationButton.BackColor = System.Drawing.Color.Transparent;
            this.accesRestorationButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.accesRestorationButton.FlatAppearance.BorderSize = 0;
            this.accesRestorationButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.accesRestorationButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.accesRestorationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accesRestorationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.accesRestorationButton.ForeColor = System.Drawing.Color.Teal;
            this.accesRestorationButton.Location = new System.Drawing.Point(470, 497);
            this.accesRestorationButton.Margin = new System.Windows.Forms.Padding(4);
            this.accesRestorationButton.Name = "accesRestorationButton";
            this.accesRestorationButton.Size = new System.Drawing.Size(209, 32);
            this.accesRestorationButton.TabIndex = 7;
            this.accesRestorationButton.Text = "Не можете войти?";
            this.accesRestorationButton.UseVisualStyleBackColor = false;
            this.accesRestorationButton.Click += new System.EventHandler(this.accesRestorationButton_Click);
            // 
            // EntryWind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1092, 599);
            this.Controls.Add(this.accesRestorationButton);
            this.Controls.Add(this.entryLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.registrationButton);
            this.Controls.Add(this.continueButton);
            this.Name = "EntryWind";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.EntryWind_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label entryLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.Button registrationButton;
        private System.Windows.Forms.Button accesRestorationButton;
    }
}