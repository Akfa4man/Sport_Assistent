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
    public partial class AdminWind : Form
    {
        public AdminWind()
        {
            InitializeComponent();
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void accesControlButton_Click(object sender, EventArgs e)
        {
            accessControlButton.BackColor = Color.DarkSlateGray;
            problemNotificationsButton.BackColor = Color.DarkCyan;
            VisualEffects.PanelChange(problemsNotificationPanel, accesControlPanel);
        }

        private void problemNotificationButton(object sender, EventArgs e)
        {
            problemNotificationsButton.BackColor = Color.Yellow;
            accessControlButton.BackColor = Color.Orange;
            VisualEffects.PanelChange(accesControlPanel, problemsNotificationPanel);
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminWind_Load(object sender, EventArgs e)
        {
            
        }
    }
}
