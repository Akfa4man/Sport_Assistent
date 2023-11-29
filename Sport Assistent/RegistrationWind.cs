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
    public partial class RegistrationWind : Form
    {
        public RegistrationWind()
        {
            InitializeComponent();
        }

        private void entryLabel_Click(object sender, EventArgs e)
        {

        }
        //Коммит 5
        //Надеюсь сработает
        //!!!
        private void RegistrationWind_Load(object sender, EventArgs e)
        {

        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            VisualEffects.WindowChange(this, new InputEmailWind());
        }
    }
}
