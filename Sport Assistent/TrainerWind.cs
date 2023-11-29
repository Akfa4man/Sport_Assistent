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
    public partial class TrainerWind : Form
    {
        public TrainerWind()
        {
            InitializeComponent();
        }

        private void timetableButton_Click(object sender, EventArgs e)
        {
            timetableButton.BackColor = Color.Orange;
            notificationsButton.BackColor = Color.Yellow;
        }

        private void notificationsButton_Click(object sender, EventArgs e)
        {
            notificationsButton.BackColor = Color.Orange;
            timetableButton.BackColor= Color.DarkCyan;
        }

        private void TrainerWind_Load(object sender, EventArgs e)
        {

        }
    }
}
