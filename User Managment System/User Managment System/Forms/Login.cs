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
        }

        private bool TryLogin()
        {
            Settings.Username = tBox_Username.Text;
            //p = Classes.IO.Compute256(tBox_Password.Text);
            Settings.Password = tBox_Password.Text;
            Settings.DataSource = "localhost";
            Settings.Port = "3306";
            Settings.DBName = "UMS2";
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
        }
    }
}
