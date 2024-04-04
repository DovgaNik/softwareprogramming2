using immigrationLib;
using System.Linq.Expressions;
namespace ImmigrationControl
{
    public partial class MainForm : Form
    {
        ImmigrantList immigrants;
        DocumentList documents;
        public MainForm()
        {
            //Login loginForm = new Login();

            //if (loginForm.ShowDialog() == DialogResult.Cancel)
            //{
            //    MessageBox.Show("To use the application you must be logged in!!!");
            //    System.Environment.Exit(1);
            //}
            //else
            //{
            InitializeComponent();
            immigrants = new ImmigrantList("immigrants.json");
            documents = new DocumentList("documents.json");
            reloadListBoxImmigrants();
            reloadListBoxDocuments();
            //}
        }

        private void reloadListBoxImmigrants()
        {
            listBox1.Items.Clear();
            foreach (Immigrant immigrant in immigrants)
                listBox1.Items.Add(immigrant.Name);
        }

        private void reloadListBoxDocuments()
        {
            listBox2.Items.Clear();
            foreach (GenericDocument document in documents)
                if (document != null)
                    listBox2.Items.Add((document.Name + " of " + document.PINofPerson));
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
            if (listBox1.SelectedIndex == -1)
                MessageBox.Show("Please select the item to delete");
            else
            {
                immigrants.RemoveAt(listBox1.SelectedIndex);
                reloadListBoxImmigrants();
                infoClear();
            }
        }

        private void infoClear()
        {

            label2.Text = "Name: ";
            label3.Text = "DOB: ";
            label4.Text = "POB: ";
            label5.Text = "Citizenship: ";
            label6.Text = "PIN: ";

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                label2.Text = "Name: " + immigrants[listBox1.SelectedIndex].Name;
                label3.Text = "DOB: " + immigrants[listBox1.SelectedIndex].DOB.ToString();
                label4.Text = "POB: " + Countries.countries[immigrants[listBox1.SelectedIndex].POB];
                label5.Text = "Citizenship: " + Countries.countries[immigrants[listBox1.SelectedIndex].Citizenship];
                label6.Text = "PIN: " + immigrants[listBox1.SelectedIndex].PIN;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> PINs = new List<string>();
            foreach (Immigrant immigrant in immigrants)
                PINs.Add(immigrant.PIN);
            AddDocument addDocument = new AddDocument(PINs);
            if (addDocument.ShowDialog() == DialogResult.OK)
            {
                documents.Add(addDocument.tempDoc);
                reloadListBoxDocuments();
            }
            
        }
    }
}
