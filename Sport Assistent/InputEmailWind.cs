using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sport_Assistent
{
    public partial class InputEmailWind : Form
    {
        public InputEmailWind()
        {
            InitializeComponent();
        }

        private void entryLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailTextBox_Click(object sender, EventArgs e)
        {
            if(emailTextBox.Text=="* Это действие необязательно") emailTextBox.Text = "";
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данные сохранены");
            VisualEffects.WindowChange(this, new EntryWind());
        }

        private void emailLabel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
