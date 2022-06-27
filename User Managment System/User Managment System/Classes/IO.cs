using System.Security.Cryptography;
using System.Text;


namespace User_Managment_System.Classes
{
    internal class IO
    {
        static char[] charArray = { (char)97, (char)98, (char)99, (char)100, (char)101, (char)102, (char)103, (char)104, (char)105, (char)106, (char)107, (char)108, (char)109, (char)110, (char)111, (char)112, (char)113, (char)114, (char)115, (char)116, (char)117, (char)118, (char)119, (char)120, (char)121, (char)122,
                                    (char)65 ,(char)66,(char)67,(char)68,(char)69,(char)70,(char)71,(char)72,(char)73,(char)74,(char)75,(char)76,(char)77,(char)78,(char)79,(char)80,(char)81,(char)82,(char)83,(char)84,(char)85,(char)86,(char)87,(char)88,(char)89,(char)90,
                                    (char)48, (char)49, (char)50, (char)51, (char)52, (char)53, (char)54, (char)55, (char)56, (char)57 };

        public static string Compute256(string rawdata)
        {
            using (SHA256 sHA256 = SHA256.Create())
            {
                byte[] bytes = sHA256.ComputeHash(Encoding.UTF8.GetBytes(rawdata));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        
        public static String PasswordGenerator()
        {
            Random rand = new Random();
            int a = 0;
            string newPW = string.Empty;
            int length = 12; ;
            for (int j = 0; j < length; j++)
            {
                a = rand.Next(0, charArray.Length - 1);
                newPW += charArray[a];
            }
            return newPW;
        }
    }
}
