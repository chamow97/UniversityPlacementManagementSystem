using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University_Placement_Management_Systems
{
    class databaseConnection
    {
        public MySqlConnection newConnection;
        public string server;
        public string database;
        public string userName;
        public string passWord;

        public string MultipleActiveResultSets { get; private set; }

        public databaseConnection()
        {
            Initialize();
        }
        ~databaseConnection()
        {
           closeConnection();
        }
        public void Initialize()
        {
            server = "localhost";
            database = "universityDatabase";
            userName = "root";
            passWord = "msdhoni";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";"
                + "USERNAME=" + userName + ";" + "PASSWORD=" + passWord + ";" ;
             newConnection = new MySqlConnection(connectionString);
            //openConnection();
        }

        public bool openConnection()
        {
            try
            {
                newConnection.Open();
                return true;
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public bool closeConnection()
        {
            try
            {
                newConnection.Close();
                return true;
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
    }
}
