namespace ImmigrationControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Login loginForm = new Login();

            if (loginForm.ShowDialog() == DialogResult.Cancel)
            {
                MessageBox.Show("To use the application you must be logged in!!!");
                System.Environment.Exit(1);
            }
            else
                InitializeComponent();
        
        }

    }
}
