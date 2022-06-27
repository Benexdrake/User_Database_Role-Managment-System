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

        public UserControlPanels(Users _user, List<Databases> _dbList, List<List<Roles>> _roles)
        {
            InitializeComponent();
            dbList = _dbList;
            roles = _roles;
            user = _user;
            LoadList();
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

        private void btn_Open_Click(object sender, EventArgs e)
        {
            var formCloseRequest = Application.OpenForms.OfType<UserForm>().FirstOrDefault();

            if (formCloseRequest != null)
            {
                formCloseRequest.Close();
            }
            formCloseRequest = Application.OpenForms.OfType<UserForm>().FirstOrDefault();

            new UserForm(user,dbList,roles).Show();
        }
    }
}
