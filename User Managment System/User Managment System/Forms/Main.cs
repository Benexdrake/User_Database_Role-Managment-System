using User_Managment_System.Classes;
using User_Managment_System.Forms;

namespace User_Managment_System
{
    public partial class Main : Form
    {
        private string username;
        private string password;

        private bool userMenu = true;
        private bool databaseMenu = true;
        private bool rolesMenu = true;

        Size openSize = new Size(225, 240);
        Size closedSize = new Size(225,60);
        UserForm uf;

        Users user;

        public Main(string _username, string _password)
        {
            InitializeComponent();
            username = _username;
            password = _password;
            
        }

        private void OpenCloseMenu(int n)
        {
            switch(n)
            {
                case 0:
                    if(userMenu)
                    {
                        panelUsers.Size = openSize;
                        panelDatabase.Size = closedSize;
                        panelRoles.Size = closedSize;
                        userMenu = false;
                        databaseMenu = true;
                        rolesMenu = true;
                    }
                    else
                    {
                        CloseAllMenus();
                    }    
                    break;
                case 1:
                    if(databaseMenu)
                    {
                        panelUsers.Size = closedSize;
                        panelDatabase.Size = openSize;
                        panelRoles.Size = closedSize;
                        userMenu=true;
                        databaseMenu = false;
                        rolesMenu=true;
                    }
                    else
                    {
                        CloseAllMenus();
                    }
                    break;
                case 2:
                    if(rolesMenu)
                    {
                        panelUsers.Size = closedSize;
                        panelDatabase.Size = closedSize;
                        panelRoles.Size = openSize;
                        userMenu = true;
                        databaseMenu=true;
                        rolesMenu = false;
                    }
                    else
                    {
                        CloseAllMenus();
                    }
                    break;
            }
        }
        

        private void CloseAllMenus()
        {
            panelUsers.Size = closedSize;
            panelDatabase.Size = closedSize;
            panelRoles.Size = closedSize;
            userMenu = true;
            databaseMenu = true;
            rolesMenu = true;
        }

        public List<Users> LoadUsers()
        {
            return new MySqlDB(username, password, "localhost", "3306", "ums2").ReadUsers("select * from registration_request order by id desc;");
        }

        public List<Databases> LoadDatabases()
        {
            return new MySqlDB(username, password, "localhost", "3306", "ums2").ReadDatabases("select * from UMS2.Servers order by id asc;");
        }

        public List<List<Roles>> LoadRoles(Databases[] db)
        {
            List<List<Roles>> roles = new List<List<Roles>>();
            for (int i = 0; i < db.Length; i++)
            {
                var r = new MySqlDB(username, password, "localhost", "3306", "ums2").ReadRoles($"select * from UMS2.Roles where Database_ID = {i+1} order by id asc;");
                roles.Add(r);
            }
            return roles;
        }

        private void btn_Users_Click(object sender, EventArgs e)
        {
            OpenCloseMenu(0);
        }

        private void btn_Database_Click(object sender, EventArgs e)
        {
            OpenCloseMenu(1);
        }

        private void btn_Role_Click(object sender, EventArgs e)
        {
            OpenCloseMenu(2);
        }

        

        private void CloseUsers()
        {
            var formCloseRequest = Application.OpenForms.OfType<UserForm>().FirstOrDefault();
            if (formCloseRequest != null)
            {
                formCloseRequest.Close();
            }
            formCloseRequest = Application.OpenForms.OfType<UserForm>().FirstOrDefault();
        }

        private void btn_New_User_Click(object sender, EventArgs e)
        {
            CloseUsers();
            var dbList = LoadDatabases();
            var roleList = LoadRoles(dbList.ToArray());
            uf = new UserForm(dbList, roleList);
            uf.Show();
        }

        private void btn_RegReq_User_Click(object sender, EventArgs e)
        {
            CloseUsers();
            panelChild.Controls.Clear();
            var userList = LoadUsers();
            var dbList = LoadDatabases();
            var roleList = LoadRoles(dbList.ToArray());
            if (userList != null && dbList != null && roleList != null)
            {
                for (int i = 0; i < userList.Count; i++)
                {
                    UserControlPanels uc = new UserControlPanels(userList[i], dbList, roleList);
                    panelChild.Controls.Add(uc);
                    uc.Dock = DockStyle.Top;
                    uc.Show();
                }
            }
        }

        private void btn_All_Users_Click(object sender, EventArgs e)
        {

        }
    }
}