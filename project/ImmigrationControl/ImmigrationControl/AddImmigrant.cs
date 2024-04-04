using immigrationLib;

namespace ImmigrationControl
{
    public partial class AddImmigrant : Form
    {
        public Immigrant newImmigrant;
        public AddImmigrant()
        {
            InitializeComponent();
            comboBox1.DataSource = new BindingSource(Countries.countries, null);
            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Key";
            comboBox2.DataSource = new BindingSource(Countries.countries, null);
            comboBox2.DisplayMember = "Value";
            comboBox2.ValueMember = "Key";
        }

        private void button_add_immigrant_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                if (textBox2.Text != "")
                    if(dateTimePicker1.Value.Date <= DateTime.Now.Date)
                        newImmigrant = new Immigrant(textBox1.Text, dateTimePicker1.Value.Date, comboBox1.SelectedIndex, comboBox2.SelectedIndex, textBox2.Text);
                    else
                        MessageBox.Show("Date of Birth must be today or before today!!!");
                else
                    MessageBox.Show("PIN is a required field!!!");
            else
                MessageBox.Show("Name is a required field!!!");
            this.Close();
        }
    }
}
