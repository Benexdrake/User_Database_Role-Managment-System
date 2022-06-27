using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User_Managment_System.Forms;

namespace User_Managment_System.Classes
{
    public class Users
    {
        private int iD;
        private string email;
        private string password;
        private string firstname;
        private string lastname;
        private string picPath;
        private DateTime birthDate;
        private DateTime registerDate;
        private bool available;
        private int role;
        private int server;
        private string information;

        public int ID { get => iD; set => iD = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string Information { get => information; set => information = value; }
        public string PicPath { get => picPath; set => picPath = value; }
        public DateTime BirthDate { get => birthDate; set => birthDate = value; }
        public DateTime RegisterDate { get => registerDate; set => registerDate = value; }
        public bool Available { get => available; set => available = value; }
        public int Role { get => role; set => role = value; }
        public int Server { get => server; set => server = value; }
    }
}
