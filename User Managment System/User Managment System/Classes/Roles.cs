using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Managment_System.Classes
{
    public class Roles
    {
        public int ID { get; set; }
        public int Database_ID { get; set; }
        public string Role_Name { get; set; }
        public string[] Role_Privileges { get; set; }
    }
}
