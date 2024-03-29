using System.Security.Cryptography;
using System.Text;

namespace users
{
    public class User
    {
        public User()
        {

        }
        public User(string username) //For existing users
        {
            this.username = username;

            List<string[]> userDB = new List<string[]>();

            StreamReader sr = new StreamReader("users.lst");
            string line = sr.ReadLine();
            while (line != null)
            {
                userDB.Add(line.Split(" "));
                Console.WriteLine(line);
                line = sr.ReadLine();
            }
            sr.Close();
            Console.ReadLine();
        }

        public User(string username, string password) // For new users
        {
            using (StreamWriter writer = new StreamWriter("users.lst"))
            {

                hashPassword = ComputeSha256Hash(password);
                writer.WriteLine(username + " " + hashPassword);

            }
        }


        private string username;
        private string hashPassword;


        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string HashPassword
        {
            set { hashPassword = ComputeSha256Hash(value); }
        }


        static string ComputeSha256Hash(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder hash = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                    hash.Append(bytes[i].ToString("x2"));
                return hash.ToString();
            }
        }

        public bool verifyPassword(string password)
        {
            return hashPassword == ComputeSha256Hash(password);
        }
    }
}
