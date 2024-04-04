using System.Security.Cryptography;
using System.Text;
using System.Text.Json.Serialization;

namespace immigrationLib
{
    public class User
    {
        private string username;
        private string passwordHash;

        public User (string username)
        {
            this.username = username;
        }

        [JsonConstructor]
        public User(string username, string passwordHash)
        {
            this.username = username;
            this.passwordHash = passwordHash;
        }

        public string Username
        {
            get { return username; }
            set { username = value; }

        }

        public string PasswordHash
        {
            get { return passwordHash; }
        }

        public bool verifyPassword (string password)
        {
            return passwordHash == calculateHash(password);
        }

        public static string calculateHash (string text)
        {
            byte[] textBytes = Encoding.UTF8.GetBytes(text);
            using (SHA512 sha = new SHA512Managed())
            {
                byte[] hashBytes = sha.ComputeHash(textBytes);
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }

        public override string ToString()
        {
            return $"User {username}, password hash {passwordHash}";
        }
    }
}
