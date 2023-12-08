using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TravelAgency
{
    // Подключение к БД
    internal class DBconnection
    {
        public static string connectionString = "server=localhost; user=test_user; password=root123; database=travel_agency";
        static public MySqlDataAdapter msDataAdapter;
        static MySqlConnection myConnection;
        static public MySqlCommand msCommand;

        public static bool Connect()
        {
            try
            {
                myConnection = new MySqlConnection(connectionString);
                myConnection.Open();
                msCommand = new MySqlCommand();
                msCommand.Connection = myConnection;
                msDataAdapter = new MySqlDataAdapter(msCommand);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static void Close()
        {
            myConnection.Close();
        }

        public MySqlConnection GetConnection()
        {
            return myConnection;
        }
    }
}
