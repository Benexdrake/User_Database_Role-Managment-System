using System.Data;


namespace User_Managment_System.Classes
{
    internal partial class MySqlDB
    {
        public void WriteSql(string sql)
        {
            try
            {
                isLoggedIn = SQLLogin();
                if (isLoggedIn)
                {
                    cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
            
        }
    }
}
