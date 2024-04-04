using immigrationLib;

namespace ImmigrationControl
{
    public partial class Login : Form
    {
        UserList users;
        public Login()
        {
            users = new UserList("users.json");
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(users.Login(textBox1.Text, textBox2.Text).ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            users.Register(textBox1.Text, textBox2.Text);
        }
    }
}
