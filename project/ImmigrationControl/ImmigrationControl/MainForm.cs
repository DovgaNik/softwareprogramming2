using immigrationLib;
namespace ImmigrationControl
{
    public partial class MainForm : Form
    {
        ImmigrantList immigrants;
        public MainForm()
        {
            //Login loginForm = new Login();

            //if (loginForm.ShowDialog() == DialogResult.Cancel)
            //{
            //    MessageBox.Show("To use the application you must be logged in!!!");
            //    System.Environment.Exit(1);
            //}
            //else
            InitializeComponent();
            immigrants = new ImmigrantList("immigrants.json");
            reloadListBoxImmigrants();

        }

        private void reloadListBoxImmigrants()
        {
            listBox1.Items.Clear();
            foreach (Immigrant immigrant in immigrants)
                listBox1.Items.Add(immigrant.Name);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddImmigrant addImmigrant = new AddImmigrant();
            if (addImmigrant.ShowDialog() == DialogResult.OK)
            {
                immigrants.Add(addImmigrant.newImmigrant);
                reloadListBoxImmigrants();
            }
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            immigrants.RemoveAt(listBox1.SelectedIndex);
            reloadListBoxImmigrants();
        }
    }
}
