using System.Text.Json;

namespace immigrationLib
{
    public class UserList : List<User>
    {
        string filepath;
        public UserList (string filename)
        {
            filepath = filename;
            if (File.Exists(filename))
                Load();
        }

        private void SaveToJson()
        {
            File.WriteAllText(filepath, JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true}));
        }

        private void Load()
        {
            string json = File.ReadAllText(filepath);
            List<User> userList = JsonSerializer.Deserialize<List<User>>(json);
            foreach (User user in userList)
            {
                this.Add(user);
            }
        }

        public bool Login(string username, string password)
        {
            foreach (User user in this)
                if (user.Username.Equals(username))
                    if (user.verifyPassword(password))
                        return true;
                    else
                    {
                        throw new Exception("Invalid password");
                    }
                throw new Exception("User not found");
        }
        public void Register(string username, string password)
        {
            this.Add(new User(username, User.calculateHash(password)));
            SaveToJson();
        }
    }
}
