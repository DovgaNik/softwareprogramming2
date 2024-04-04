using immigrationLib;

namespace ImmigrationControl
{
    public partial class Registration : Form
    {
        UserList users;
        public Registration(UserList users)
        {
            this.users = users;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == textBox3.Text)
            {
                try
                {
                    users.Register(textBox1.Text, textBox2.Text);
                }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            } else
            {
                MessageBox.Show("The passwords don't match please retry");
            }
        }
    }
}
