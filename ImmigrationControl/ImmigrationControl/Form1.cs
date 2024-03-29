using users;

namespace ImmigrationControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            User loggedUser = new User();
            Login loginForm = new Login(loggedUser);
            loginForm.ShowDialog();

            InitializeComponent();

            label1.Text = loggedUser.Username;
        }

    }
}
