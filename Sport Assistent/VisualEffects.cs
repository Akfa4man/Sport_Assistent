using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sport_Assistent
{
    public static class VisualEffects
    {
        public static void WindowChange(Form oldWind, Form newForm)
        {
            string alexConnection = ConfigurationManager.AppSettings.Get("Key0");
            oldWind.Hide();
            newForm.StartPosition=oldWind.StartPosition;
            newForm.Location= oldWind.Location;
            newForm.Text=oldWind.Text;
            newForm.WindowState=oldWind.WindowState;
            newForm.Size=oldWind.Size;
            newForm.ShowDialog();
            oldWind.Close();
        }

        public static void PanelChange(Panel oldPanel, Panel newPanel)
        {
            oldPanel.Hide();
            newPanel.Show();
        }

        public static void BackColorChange(Control[] windElements, Color newColor)
        {
            for(int i=0; i<windElements.Length; i++)
            {
                windElements[i].BackColor = newColor;
            }
        }
    }
}
