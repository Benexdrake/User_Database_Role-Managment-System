using MySql.Data.MySqlClient;

namespace User_Managment_System.Classes
{
    internal partial class MySqlDB
    {
        private MySqlConnection con;
        private MySqlDataReader reader;
        private MySqlCommand cmd;

        string username, password, dataSource, port, databaseName;
        private bool isLoggedIn;

        public bool IsLoggedIn { get => isLoggedIn; set => isLoggedIn = value; }

        public MySqlDB(string _username, string _password, string _dataSource, string _port, string _databaseName)
        {
            username = _username;
            password = _password;
            dataSource = _dataSource;
            port = _port;
            databaseName = _databaseName;
        }

        public bool SQLLogin()
        {
            try
            {
                string connection = (@$"Data Source = {dataSource}; Port = {port} ; Initial Catalog = {databaseName}; User Id = {username}; Password = {password};");
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
