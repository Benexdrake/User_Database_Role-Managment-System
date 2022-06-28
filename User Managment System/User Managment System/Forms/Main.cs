using User_Managment_System.Classes;
using User_Managment_System.Forms;

namespace User_Managment_System
{
    public partial class Main : Form
    {
        private bool userMenu = true;
        private bool databaseMenu = true;
        private bool rolesMenu = true;

        UserForm uf;

        Users user;

        int choice;

        public Main()
        {
            InitializeComponent();
        }

        private void OpenCloseMenu(int n)
        {
            
            switch(n)
            {
                case 0:
                    if(userMenu)
                    {
                        panelUsers.Size = panelUsers.MaximumSize;
                        panelDatabase.Size = panelDatabase.MinimumSize;
                        panelRoles.Size = panelRoles.MinimumSize;
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
                        panelUsers.Size = panelUsers.MinimumSize;
                        panelDatabase.Size = panelDatabase.MaximumSize;
                        panelRoles.Size = panelRoles.MinimumSize;
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
                        panelUsers.Size = panelUsers.MinimumSize;
                        panelDatabase.Size = panelDatabase.MinimumSize;
                        panelRoles.Size = panelRoles.MaximumSize;
                        userMenu = true;
                        databaseMenu = true;
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
            panelUsers.Size = panelUsers.MinimumSize;
            panelDatabase.Size = panelDatabase.MinimumSize;
            panelRoles.Size = panelRoles.MinimumSize;
            userMenu = true;
            databaseMenu = true;
            rolesMenu = true;
        }

        public List<Users> LoadUsers(int n)
        {
            choice = n;
            string sql = string.Empty;
            switch(n)
            {
                case 0:
                    sql = "select * from registration_request where available = false order by id desc;";
                    break;
                case 1:
                    sql = "select * from registered_users order by id desc;";
                    break;
                case 2:
                    sql = "select * from registration_request where Available = true order by id desc;";
                    break;
            }
            return new MySqlDB().ReadUsers(sql);
        }

        public List<Databases> LoadDatabases()
        {
            return new MySqlDB().ReadDatabases("select * from UMS2.Servers order by id asc;");
        }

        public List<List<Roles>> LoadRoles(Databases[] db)
        {
            List<List<Roles>> roles = new List<List<Roles>>();
            for (int i = 0; i < db.Length; i++)
            {
                var r = new MySqlDB().ReadRoles($"select * from UMS2.Roles where Database_ID = {i+1} order by id asc;");
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

        private void LoadUserPanels(int n)
        {
            CloseUsers();
            panelChild.Controls.Clear();
            var userList = LoadUsers(n);
            var dbList = LoadDatabases();
            var roleList = LoadRoles(dbList.ToArray());
            if (userList != null && dbList != null && roleList != null)
            {
                for (int i = 0; i < userList.Count; i++)
                {
                    UserControlPanels uc = new UserControlPanels(userList[i], dbList, roleList, n);
                    panelChild.Controls.Add(uc);
                    uc.Dock = DockStyle.Top;
                    uc.Show();
                }
            }
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
            LoadUserPanels(0);
        }

        private void btn_All_Users_Click(object sender, EventArgs e)
        {
            LoadUserPanels(1);
        }

        private void btn_BlackList_Click(object sender, EventArgs e)
        {
            LoadUserPanels(2);
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            switch(choice)
            {
                case 0:
                    btn_RegReq_User_Click(sender, e);
                    break;
                case 1:
                    btn_All_Users_Click(sender, e);
                    break;
                case 2:
                    btn_BlackList_Click(sender, e);
                    break;
            }
        }
    }
}