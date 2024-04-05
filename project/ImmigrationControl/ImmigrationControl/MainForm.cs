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
            Login loginForm = new Login();

            if (loginForm.ShowDialog() == DialogResult.Cancel)
            {
                MessageBox.Show("To use the application you must be logged in!!!");
                System.Environment.Exit(1);
            }
            else
            {
                InitializeComponent();
            immigrants = new ImmigrantList("immigrants.json");
            documents = new DocumentList("documents.json");
            reloadListBoxImmigrants();
            reloadListBoxDocuments();
            }
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != -1)
            {
                documents.RemoveAt(listBox2.SelectedIndex);
                reloadListBoxDocuments();
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != -1)
            {
                if (documents[listBox2.SelectedIndex].GetType() == typeof(Passport))
                {
                    Passport passport = (Passport)documents[listBox2.SelectedIndex];
                    label7.Text = "Type: Passport";
                    label8.Text = "Number: " + passport.PassportNumber;
                    label9.Text = "Issue Date: " + passport.DateOfIssue.ToString("dd/MM/yyyy");
                    label10.Text = "Country: " + Countries.countries[passport.IssuingAuthority];
                    label11.Text = "PIN: " + passport.PINofPerson;
                    label12.Text = "Expiry Date: " + passport.DateOfExpiration.ToString("dd/MM/yyyy");
                    return;
                }
                else if (documents[listBox2.SelectedIndex].GetType() == typeof(Visa))
                {
                    Visa visa = (Visa)documents[listBox2.SelectedIndex];
                    label7.Text = "Type: Visa";
                    label9.Text = "Issue Date: " + visa.DateOfIssue.ToString("dd/MM/yyyy");
                    label10.Text = "Country: " + Countries.countries[visa.IssuingAuthority];
                    label11.Text = "PIN: " + visa.PINofPerson;
                    label12.Text = "Expiry Date: " + visa.DateOfExpiration.ToString("dd/MM/yyyy");
                    label8.Text = "Days remaining: " + visa.daysRemaining;
                    return;
                }

                else if (documents[listBox2.SelectedIndex].GetType() == typeof(ResidencyPermit))
                {
                    ResidencyPermit residencyPermit = (ResidencyPermit)documents[listBox2.SelectedIndex];
                    label7.Text = "Type: Residency Permit";
                    label9.Text = "Issue Date: " + residencyPermit.DateOfIssue.ToString("dd/MM/yyyy");
                    label10.Text = "Country: " + Countries.countries[residencyPermit.IssuingAuthority];
                    label11.Text = "PIN: " + residencyPermit.PINofPerson;
                    label12.Text = "Expiry Date: " + residencyPermit.DateOfExpiration.ToString("dd/MM/yyyy");
                    return;
                }
                else
                {
                    GenericDocument doc = documents[listBox2.SelectedIndex];
                    label8.Text = "Number: " + doc.Name;
                    label9.Text = "Issue Date: " + doc.DateOfIssue.ToString("dd/MM/yyyy");
                    label10.Text = "Country: " + Countries.countries[doc.IssuingAuthority];
                    label11.Text = "PIN: " + doc.PINofPerson;
                    label7.Text = "Expiry Date: " + doc.DateOfExpiration.ToString("dd/MM/yyyy");
                    label13.Text = $"{(doc.daysBeforeExpiry() < 0 ? "Expired" : "Not expired")}";
                }
            }
        }
    }
}
