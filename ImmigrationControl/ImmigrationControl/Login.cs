using users;

namespace ImmigrationControl
{
    public partial class Login : Form
    {
        User loggedUser;
        public Login(User loggedUser)
        {
            this.loggedUser = loggedUser;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User tempUser = new User(textBox1.Text);
            if (tempUser.verifyPassword(textBox2.Text))
            {
                loggedUser = tempUser;
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid password");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            loggedUser = new User(textBox1.Text, textBox2.Text);
            this.Close();
        }
    }
}
