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
    public partial class ClientWind : Form
    {
        // Коммит 2
        public ClientWind()
        {
            InitializeComponent();
        }

        private void trainerLabel_Click(object sender, EventArgs e)
        {

        }

        private void subscriptionButton_Click(object sender, EventArgs e)
        {
            subscriptionButton.BackColor=mainPanel.BackColor;
            VisualEffects.BackColorChange(new Control[] { timetableButton, notificationsButton }, Color.Yellow);
        }

        private void timetableButton_Click(object sender, EventArgs e)
        {
            timetableButton.BackColor = mainPanel.BackColor;
            VisualEffects.BackColorChange(new Control[] { subscriptionButton, notificationsButton }, Color.Yellow);
        }
        // Коммит 1
        private void notificationsButton_Click(object sender, EventArgs e)
        {
            notificationsButton.BackColor = mainPanel.BackColor;
            VisualEffects.BackColorChange(new Control[] { subscriptionButton, timetableButton }, Color.Yellow);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
