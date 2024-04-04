using immigrationLib;
namespace ImmigrationControl
{
    public partial class Form1 : Form
    {
        ImmigrantList immigrants;
        public Form1()
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
            comboBox1.DataSource = new BindingSource(Countries.countries, null);
            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Key";
            comboBox2.DataSource = new BindingSource(Countries.countries, null);
            comboBox2.DisplayMember = "Value";
            comboBox2.ValueMember = "Key";

            reloadListBox(listBox1, immigrants);

        }

        private void reloadListBox(ListBox listbox, ImmigrantList list)
        {
            listbox.Items.Clear();
            foreach (Immigrant immigrant in list)
                listbox.Items.Add(immigrant);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Immigrant newImmigrant = new Immigrant(textBox1.Text, dateTimePicker1.Value.Date, comboBox1.TabIndex, comboBox2.TabIndex, textBox2.Text);
            immigrants.Add(newImmigrant);
            listBox1.Items.Add(newImmigrant.Name);
        }
    }
}
