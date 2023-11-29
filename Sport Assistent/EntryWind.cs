using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sport_Assistent
{
    public partial class EntryWind : Form
    {
        private string profiledatabase;
        private MySqlConnection connection;
        public EntryWind()
        {
            InitializeComponent();
            profiledatabase = ConfigurationManager.ConnectionStrings["profile"].ConnectionString;
        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }

        private void loginLabel_Click(object sender, EventArgs e)
        {

        }

        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void beginButton_Click(object sender, EventArgs e)
        {
        }

        private void entryButton_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new MySqlConnection(profiledatabase);
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка подключения к базам данных: {ex}\nПовторите попытку или закройте программу!");
                return;

            }
            string login = loginTextBox.Text;
            string password = passwordTextBox.Text;
            var dataTable = new DataTable();
            var sqlDateAdapter = new MySqlDataAdapter();
            var command = new MySqlCommand("SELECT * FROM `startingdatabase` WHERE `login`=@ul AND `password`=@up", connection);
            command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@up", MySqlDbType.VarChar).Value = password;
            sqlDateAdapter.SelectCommand = command;
            sqlDateAdapter.Fill(dataTable);
            /*
            if (dataTable.Select().Length != 0)
            {
                foreach (var r in dataTable.Select())
                {
                    if (r[4].Equals(login) && r[5].Equals(password))
                    {
                        switch(r[6])
                        {
                            case 0:
                                VisualEffects.WindowChange(this, new AdminWind());
                                break;
                            case 1:
                                VisualEffects.WindowChange(this, new AccountantWind());
                                break;
                            case 2:
                                VisualEffects.WindowChange(this, new ClientWind());
                                break;
                            case 3:
                                VisualEffects.WindowChange(this, new TrainerWind());
                                break;
                        }
                        break;
                    }
                }
            }
            else MessageBox.Show("Данных нет");
            */
            if (dataTable.Select().Length != 0)
            {
                switch ((int)dataTable.Rows[0]["role"])
                {
                    case 0:
                        VisualEffects.WindowChange(this, new AdminWind());
                        break;
                    case 1:
                        VisualEffects.WindowChange(this, new AccountantWind());
                        break;
                    case 2:
                        VisualEffects.WindowChange(this, new ClientWind());
                        break;
                    case 3:
                        VisualEffects.WindowChange(this, new TrainerWind());
                        break;
                }
            }
            else MessageBox.Show("Профиль не найден!");
            connection.Close();

        }

        private void registrationButton_Click(object sender, EventArgs e)
        {

            VisualEffects.WindowChange(this, new RegistrationWind());
        }

        private void entryPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void accesRestorationButton_Click(object sender, EventArgs e)
        {
            VisualEffects.WindowChange(this, new AccesRestorationWind());
        }

        private void EntryWind_Load(object sender, EventArgs e)
        {
           
        }
    }
}
