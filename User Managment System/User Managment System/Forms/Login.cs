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
    public partial class Login : Form
    {
        
        Thread th;
        ThreadStart ts;

        string u;
        string p;

        public Login()
        {
            InitializeComponent();
            if(Properties.Settings.Default.Username != String.Empty)
            {
                tBox_Username.Text = Properties.Settings.Default.Username;
                cBox_Save_Username.Checked = Properties.Settings.Default.checkBox;
                Properties.Settings.Default.SQLPassword = string.Empty;
                Properties.Settings.Default.Save();
            }
        }

        private bool TryLogin()
        {
            Settings.Username = tBox_Username.Text;
            Properties.Settings.Default.SQLPassword = tBox_Password.Text;

            if (cBox_Save_Username.Checked)
            {
                Properties.Settings.Default.Username = tBox_Username.Text;
                Properties.Settings.Default.checkBox = cBox_Save_Username.Checked;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Username = string.Empty;
                Properties.Settings.Default.checkBox = cBox_Save_Username.Checked;
                Properties.Settings.Default.Save();
            }
            return new MySqlDB().SQLLogin();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {

            
            if(TryLogin())
            {
                
                Main mf = new Main();
                
                ts = new ThreadStart(delegate { mf.ShowDialog(); });
                th = new Thread(ts);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error, Username or Password False!!!");
            }
            MessageBox.Show(Properties.Settings.Default.SQLPassword);
        }

        private void cBox_See_Password_CheckedChanged(object sender, EventArgs e)
        {
            if(!cBox_See_Password.Checked)
            {
                tBox_Password.PasswordChar = '*';
            }
            else
            {
                tBox_Password.PasswordChar = '\0';
            }
        }

        private void cBox_Save_Username_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
