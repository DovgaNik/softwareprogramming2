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
                if(users.Login(textBox1.Text, textBox2.Text))
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registration registrationForm = new Registration(users);
            if (registrationForm.ShowDialog() == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
