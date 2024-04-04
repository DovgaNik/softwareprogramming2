using immigrationLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ImmigrationControl
{
    public partial class AddDocument : Form
    {
        public GenericDocument tempDoc;
        List<string> Pins;
        public AddDocument(List<string> PINs)
        {
            InitializeComponent();
            comboBox2.DataSource = PINs;
            comboBox1.DataSource = new BindingSource(Countries.countries, null);
            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Key";
            Pins = PINs;
        }
        private void makeEverythingEnabled()
        {
            textBox1.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            makeEverythingEnabled();
            textBox4.Enabled = false;
            textBox6.Enabled = false;
            textBox5.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            makeEverythingEnabled();
            textBox3.Enabled = false;
            textBox4.Enabled = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            makeEverythingEnabled();
            textBox3.Enabled = false;
            textBox6.Enabled = false;
            textBox5.Enabled = false;
        }

        private void button_add_immigrant_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                tempDoc = new Passport(textBox1.Text, dateTimePicker1.Value.Date, comboBox1.SelectedIndex, Pins[comboBox2.SelectedIndex], textBox3.Text, dateTimePicker2.Value.Date);
                this.Close();
            }

            if (radioButton2.Checked)
            {
                tempDoc = new Visa(textBox1.Text, dateTimePicker1.Value.Date, comboBox1.SelectedIndex, Pins[comboBox2.SelectedIndex], int.Parse(textBox6.Text), int.Parse(textBox5.Text), dateTimePicker2.Value.Date);
                this.Close();
            }

            if (radioButton3.Checked)
            {
                tempDoc = new ResidencyPermit(textBox1.Text, dateTimePicker1.Value.Date, comboBox1.SelectedIndex, Pins[comboBox2.SelectedIndex], dateTimePicker2.Value.Date, textBox4.Text);
                this.Close();
            }
        }
    }
}
