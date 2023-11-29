using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Collections.Specialized;
using System.Windows.Forms;

namespace Sport_Assistent
{
    class Connector: ApplicationSettingsBase
    {
        MySqlConnection connection=new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=users");
        public void OpenConnection()
        {
            connection.Open();
        }
        public void CloseConnection() { connection.Close(); }

        public MySqlConnection GetConnection() { return connection; }
    }
}
