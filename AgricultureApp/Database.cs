using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgricultureApp
{
    internal class Database
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;database=agriculture_database;username=root;password=root;");
        
        public void OpenConnection()
        { 
            if(connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }
        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
        public MySqlConnection GetConnection() 
        {
            try
            {
                return connection;
            }
            catch (Exception)
            {
                MessageBox.Show("Нет соединения с базой данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }   
        }
    }
}
