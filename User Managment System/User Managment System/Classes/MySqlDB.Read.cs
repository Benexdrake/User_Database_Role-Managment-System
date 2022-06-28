using System.Data;


namespace User_Managment_System.Classes
{
    internal partial class MySqlDB
    {
        public List<Users> ReadUsers(string sql)
        {
            List<Users> users = null;
            try
            {
                isLoggedIn = SQLLogin();
                if (isLoggedIn)
                {
                    cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        users = new List<Users>();
                        while (reader.Read())
                        {
                            users.Add(
                                new Users()
                                {
                                    ID = reader.GetInt32("ID"),
                                    Email = reader.GetString("Email"),
                                    Password = reader.GetString("Password"),
                                    Firstname = reader.GetString("Firstname"),
                                    Lastname = reader.GetString("Lastname"),
                                    Available = reader.GetBoolean("Available"),
                                    Information = reader.GetString("Information"),
                                    PicPath = reader.GetString("PicPath"),
                                    BirthDate = DateTime.Parse(reader.GetString("Birthdate")),
                                    RegisterDate = DateTime.Parse(reader.GetString("Register_Date")),
                                    Server = reader.GetInt32("Server_ID"),
                                    Role = reader.GetInt32("Roles_ID")
                                });
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
            
            con.Close();
            return users;
        }

        public List<Databases> ReadDatabases(string sql)
        {
            List<Databases> dbs = null;
            isLoggedIn = SQLLogin();
            if (isLoggedIn)
            {
                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    dbs = new List<Databases>();
                    while (reader.Read())
                    {
                        dbs.Add(
                            new Databases()
                            {
                                ID = reader.GetInt32("ID"),
                                Database_Name = reader.GetString("Database_Name"),
                                Database_Typ = reader.GetString("Database_Typ")
                            });
                    }
                }
            }
            con.Close();
            return dbs;
        }

        public List<Roles> ReadRoles(string sql)
        {
            List<Roles> roles = null;
            isLoggedIn = SQLLogin();
            if (isLoggedIn)
            {
                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    roles = new List<Roles>();
                    while (reader.Read())
                    {
                        roles.Add(
                            new Roles()
                            {
                                ID = reader.GetInt32("ID"),
                                Database_ID = reader.GetInt32("Database_ID"),
                                Role_Name = reader.GetString("Role_Name"),
                                Role_Privileges = reader.GetString("Role_Privileges").Split(','),
                            });
                    }
                }
            }
            con.Close();
            return roles;
        }
    }
}
