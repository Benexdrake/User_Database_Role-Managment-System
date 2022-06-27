
namespace User_Managment_System.Classes
{
    public partial class MySqlDB
    {
        public void WriteSQL(string sql)
        {
            isLoggedIn = SQLLogin();
            if (isLoggedIn)
            {
                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
        }
    }
}
