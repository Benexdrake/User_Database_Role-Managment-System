using MySql.Data.MySqlClient;

namespace User_Managment_System.Classes
{
    internal partial class MySqlDB
    {
        private MySqlConnection con;
        private MySqlDataReader reader;
        private MySqlCommand cmd;

        string dataSource, port, databaseName;
        private bool isLoggedIn;

        public bool IsLoggedIn { get => isLoggedIn; set => isLoggedIn = value; }

        public MySqlDB()
        {
        }

        public bool SQLLogin()
        {
            try
            {
                string connection = (@$"Data Source = {Settings.DataSource}; Port = {Settings.Port} ; Initial Catalog = {Settings.DBName}; User Id = {Settings.Username}; Password = {Settings.Password};");
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
