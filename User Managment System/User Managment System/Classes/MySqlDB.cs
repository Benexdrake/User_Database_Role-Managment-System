using MySql.Data.MySqlClient;

namespace User_Managment_System.Classes
{
    internal partial class MySqlDB
    {
        private MySqlConnection con;
        private MySqlDataReader reader;
        private MySqlCommand cmd;
        private bool isLoggedIn;

        public bool IsLoggedIn { get => isLoggedIn; set => isLoggedIn = value; }

        public MySqlDB()
        {
        }

        public bool SQLLogin()
        {
            try
            {
                string username = Properties.Settings.Default.Username;
                string password = Properties.Settings.Default.SQLPassword;
                string dataSource = Properties.Settings.Default.DBSource;
                string port = Properties.Settings.Default.DBPort;
                string dbName = Properties.Settings.Default.DBName;


                string connection = (@$"Data Source = {dataSource}; Port = {port} ; Initial Catalog = {dbName}; User Id = {username}; Password = {password};");
                con = new MySqlConnection(connection);
                con.Open();
                isLoggedIn = true;
            }
            catch (Exception e)
            {
                isLoggedIn = false;
            }
            return isLoggedIn;
        }
    }
}
