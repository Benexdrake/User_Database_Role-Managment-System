using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            u = tBox_Username.Text;
            //p = Classes.IO.Compute256(tBox_Password.Text);
            p = tBox_Password.Text;
            return new Classes.MySqlDB(u, tBox_Password.Text, "localhost", "3306", "UMS2").SQLLogin();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if(TryLogin())
            {
                
                Main mf = new Main(u, p);
                u = String.Empty;
                p = String.Empty;
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
