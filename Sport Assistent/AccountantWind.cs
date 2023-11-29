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
    public partial class AccountantWind : Form
    {
        public AccountantWind()
        {
            InitializeComponent();
        }
        //Коммит 1
        private void subscriptionButton_Click(object sender, EventArgs e)
        {
            subscriptionButton.BackColor = SystemColors.AppWorkspace;
            VisualEffects.BackColorChange(new Button[] { incomeButton, arrearsButton, reportButton }, Color.WhiteSmoke);
        }

        private void incomeButton_Click(object sender, EventArgs e)
        {
            incomeButton.BackColor = SystemColors.AppWorkspace;
            VisualEffects.BackColorChange(new Button[] { subscriptionButton, arrearsButton, reportButton }, Color.WhiteSmoke);
        }

        private void arrearsButton_Click(object sender, EventArgs e)
        {
            arrearsButton.BackColor = SystemColors.AppWorkspace;
            VisualEffects.BackColorChange(new Button[] { incomeButton, subscriptionButton, reportButton }, Color.WhiteSmoke);
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            reportButton.BackColor = SystemColors.AppWorkspace;
            VisualEffects.BackColorChange(new Button[] { incomeButton, arrearsButton, subscriptionButton }, Color.WhiteSmoke);
        }

        private void AccountantWind_Load(object sender, EventArgs e)
        {

        }
    }
}
