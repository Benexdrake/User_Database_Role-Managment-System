using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using User_Managment_System.Classes;

namespace User_Managment_System.Forms
{
    public partial class UserForm : Form
    {
        bool editMode;

        //MySqlDB mysql;
        List<Databases> dbList;
        List<List<Roles>> roles;
        Users user;

        OpenFileDialog ofd;

        ProcessStartInfo Process_Info;

        private string password;

        

        string folder = "Avatars";


        public UserForm(List<Databases> _dbList, List<List<Roles>> _roles)
        {
            InitializeComponent();
            dbList = _dbList;
            roles = _roles;
            pBox_Avatar.Image = new Bitmap(PicFolder("Avatar.PNG"));
            lbl_FilePath.Text = "Avatar.PNG";
            editMode = false;
            FillDatabases();
        }

        public UserForm(Users _user, List<Databases> _dbList, List<List<Roles>> _roles)
        {
            InitializeComponent();
            editMode = true;
            user = _user;
            dbList = _dbList;
            roles = _roles;
            FillElements();
        }

        private void FillElements()
        {
            tBox_Email.Text = user.Email;
            tBox_Firstname.Text = user.Firstname;
            tBox_Lastname.Text = user.Lastname;
            tBox_Information.Text = user.Information;
            dTime_DoB.Value = user.BirthDate;
            FillDatabases();
            cBox_Database.SelectedIndex = user.Server - 1;
            cBox_Role.SelectedIndex = user.Role - 1;
            pBox_Avatar.Image = new Bitmap(PicFolder(user.PicPath));
            lbl_FilePath.Text = user.PicPath;
        }

        private string PicFolder(string file)
        {
            if(!Directory.Exists(Application.StartupPath + folder))
            {
                Directory.CreateDirectory(Application.StartupPath + folder);
            }
            if (File.Exists(Application.StartupPath + $"{folder}\\" + file))
            {
                return Application.StartupPath + $"{folder}\\" + file;
            }
            else
            {
                return Application.StartupPath + "filenotfound.JPG";
            }
        }

        private void FillPrivileges(Roles role)
        {
            tBox_Permission_Info.Text = String.Empty;
            for (int i = 0; i < role.Role_Privileges.Length; i++)
            {
                tBox_Permission_Info.Text += role.Role_Privileges[i];
                if (i < role.Role_Privileges.Length - 1)
                {
                    tBox_Permission_Info.Text += ", ";
                }
            }
        }

        private void FillDatabases()
        {
            cBox_Database.Items.Clear();

            for (int i = 0; i < dbList.Count; i++)
            {
                cBox_Database.Items.Add(dbList[i].Database_Name);
            }
        }

        private void FillRoles()
        {
            cBox_Role.Items.Clear();
            for (int i = 0; i < roles[cBox_Database.SelectedIndex].Count; i++)
            {
                cBox_Role.Items.Add(roles[cBox_Database.SelectedIndex][i].Role_Name);
            }
            cBox_Role.SelectedIndex = 0;
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            if(tBox_Email.Text != string.Empty && tBox_Firstname.Text != string.Empty && tBox_Lastname.Text != string.Empty)
            {
                if(editMode)
                {
                    // Update
                }
                else
                {
                    
                    // Insert Into
                }
            }
            string s = System.IO.Path.GetFileName(pBox_Avatar.ImageLocation);
            MessageBox.Show(s);
        }

        private void cBox_Database_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillRoles();
        }

        private void cBox_Role_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillPrivileges(roles[cBox_Database.SelectedIndex][cBox_Role.SelectedIndex]);
        }
        
        private void btn_Pic_Click(object sender, EventArgs e)
        {
            ofd = new OpenFileDialog
            {
                Title = "Browse Picture File",
                DefaultExt = "png",
                Filter = "png files (*.png)|*.png",
                ReadOnlyChecked = true,
                ShowReadOnly = true
            };
            

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                lbl_FilePath.Text = ofd.SafeFileName;
                pBox_Avatar.Image = new Bitmap(ofd.FileName);
            }
            else
            {
                ofd = null;
            }
        }

        private void btn_Password_Click(object sender, EventArgs e)
        {
            // Generate a Password, Admin only sees SHA and the new Password will be Send as Email at the User Email
            password = IO.PasswordGenerator();
            tBox_Password.Text = IO.Compute256(password);
        }

        private void pBox_Avatar_Click(object sender, EventArgs e)
        {
            string s = string.Empty;
            if (ofd != null)
            {
                s = ofd.FileName;
            }
            else
            {
               s = PicFolder(lbl_FilePath.Text);
            }

            

            Process_Info = new ProcessStartInfo(s, @"%SystemRoot%\System32\rundll32.exe % ProgramFiles %\Windows Photo Viewer\PhotoViewer.dll, ImageView_Fullscreen")
            {
                UseShellExecute = true,
                WorkingDirectory = Path.GetDirectoryName(s),
                FileName = s,
                Verb = "OPEN"
            };
            Process.Start(Process_Info);

            

        }
    }
}
