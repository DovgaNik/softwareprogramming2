namespace ImmigrationControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Login loginForm = new Login();
            loginForm.ShowDialog();

            InitializeComponent();
        }

    }
}
