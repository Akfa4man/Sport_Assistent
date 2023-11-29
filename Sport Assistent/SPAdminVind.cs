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
    public partial class SPAdminWind : Form
    {
        public SPAdminWind()
        {
            InitializeComponent();
        }

        private void distributionButton_Click(object sender, EventArgs e)
        {
            distributionButton.BackColor = Color.Orange;
            Control[] otherButtons = new Control[] { timetableButton, clientDataButton };
            VisualEffects.BackColorChange(otherButtons, Color.Yellow);
        }

        private void clientDataButton_Click(object sender, EventArgs e)
        {
            clientDataButton.BackColor = Color.Orange;
            Control[] otherButtons = new Control[] { timetableButton, distributionButton };
            VisualEffects.BackColorChange(otherButtons, Color.Yellow);
        }

        private void timetableButton_Click(object sender, EventArgs e)
        {
            timetableButton.BackColor = Color.Orange;
            Control[] otherButtons = new Control[] { distributionButton, distributionButton };
            VisualEffects.BackColorChange(otherButtons, Color.Yellow);
        }

        private void SPAdminWind_Load(object sender, EventArgs e)
        {

        }
    }
}
