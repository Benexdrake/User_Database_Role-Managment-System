using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using User_Managment_System.Classes;

namespace User_Managment_System.Forms
{
    public partial class UserControlPanels : UserControl
    {
        //MySqlDB mysql;
        List<Databases> dbList;
        List<List<Roles>> roles;
        Users user;

        string folder = "Avatars";

        int choice;

        public UserControlPanels(Users _user, List<Databases> _dbList, List<List<Roles>> _roles, int n)
        {
            InitializeComponent();
            dbList = _dbList;
            roles = _roles;
            user = _user;
            Modus(n);
            LoadList();
            choice = n;
        }

        private void Modus(int n)
        {
            switch(n)
            {
                case 0:
                    btn_Bann.Visible = true;
                    btn_Bann.Text = "Bann";
                    break;
                case 1:
                    btn_Bann.Visible = true;
                    btn_Accept.Visible = false;
                    if(user.Available)
                    {
                        btn_Bann.Text = "Bann";
                    }
                    else
                    {
                        btn_Bann.Text = "UnBann";
                        btn_Bann.BackColor = Color.Green;
                    }
                    break;
                case 2:
                    btn_Bann.Visible = true;
                    btn_Bann.BackColor = Color.Green;
                    btn_Bann.Text = "UnBann";
                    break;
            }
        }

        public void LoadList()
        {
            tBox_Email.Text = user.Email;
            tBox_Firstname.Text = user.Firstname;
            tBox_Lastname.Text = user.Lastname;
            tBox_DoB.Text = user.BirthDate.ToString("dd.MM.yyyy");
            tBox_DB.Text = dbList[user.Server - 1].Database_Name;
            tBox_Role.Text = roles[user.Server - 1][user.Role - 1].Role_Name;
            pBox_Avatar.Image = new Bitmap(PicFolder(user.PicPath));
            FillPrivileges(roles[user.Server - 1][user.Role - 1]);
        }

        private void FillPrivileges(Roles role)
        {
            tBox_Permission_Info.Text = String.Empty;
            for (int i = 0; i < role.Role_Privileges.Length; i++)
            {
                tBox_Permission_Info.Text += role.Role_Privileges[i];
                if(i < role.Role_Privileges.Length-1)
                {
                    tBox_Permission_Info.Text += ", ";
                }
            }
        }

        private string PicFolder(string file)
        {
            if (!Directory.Exists(Application.StartupPath + folder))
            {
                Directory.CreateDirectory(Application.StartupPath + folder);
            }
            if(File.Exists(Application.StartupPath + $"{folder}\\" + file))
            {
                return Application.StartupPath + $"{folder}\\" + file;
            }
            else
            {
                return Application.StartupPath + "filenotfound.JPG";
            }

        }

        private void SendChoice()
        {
            CloseUserForm();
            switch (choice)
            {
                case 0:
                    // Send User to Blacklist
                    new MySqlDB().WriteSql($"call Update_Registration('{user.Email}', {true});");
                    this.Visible = false;
                    break;
                case 1:
                    // Lock or Unlock the User
                    if(user.Available)
                    {
                        new MySqlDB().WriteSql($"call Bann('{user.Email}',{false});");
                    }
                    else
                    {
                        new MySqlDB().WriteSql($"call Bann('{user.Email}',{true});");
                    }
                    
                    this.Visible = false;
                    break;
                case 2:
                    // Whitelist User
                    new MySqlDB().WriteSql($"call Update_Registration('{user.Email}', {false});");
                    //new MySqlDB().WriteSql($"call Insert_New_User('{user.Email}','{user.Password}', '{user.Firstname}', '{user.Lastname}' , '{user.Information}', '{user.PicPath}', '{user.BirthDate.ToString("yyyy-MM-dd")}',{user.Server},'{roles[0][1].Role_Name}');");
                    this.Visible = false;
                    break;
            }
        }

        void OpenUserForm()
        {
            CloseUserForm();
            new UserForm(user, dbList, roles).Show();
            //this.Visible = false;
        }
        void CloseUserForm()
        {
            var formCloseRequest = Application.OpenForms.OfType<UserForm>().FirstOrDefault();

            if (formCloseRequest != null)
            {
                formCloseRequest.Close();
            }
            formCloseRequest = Application.OpenForms.OfType<UserForm>().FirstOrDefault();
        }

        

        private void btn_Open_Click(object sender, EventArgs e)
        {
            OpenUserForm();
        }

        private void btn_Choice_Click(object sender, EventArgs e)
        {
            SendChoice();   
        }

        private void btn_Accept_Click(object sender, EventArgs e)
        {
            new MySqlDB().WriteSql($"call Insert_New_User('{user.Email}','{user.Password}', '{user.Firstname}', '{user.Lastname}' , '{user.Information}', '{user.PicPath}', '{user.BirthDate.ToString("yyyy-MM-dd")}',{user.Server},'{roles[0][1].Role_Name}');");
            this.Visible = false;
        }
    }
}
