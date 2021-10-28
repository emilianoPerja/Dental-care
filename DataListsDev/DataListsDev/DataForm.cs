using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataListsDev
{
    public partial class DataForm : Form
    {
        public DataForm()
        {
            InitializeComponent();

            // #1 - Items - strings
            //cmbPatients.Items.Add("Pedro");
            //cmbPatients.Items.Add("Javier");
            //cmbPatients.Items.Add("Erika");
            //cmbPatients.Items.Add("Miguel");
            //cmbPatients.Items.Add("Elizabeth");

            // #2 - Items - objects
            //cmbPatients.Items.Add(new Client(689155, "Xavier", "Quintas"));
            //cmbPatients.Items.Add(new Client(917169, "Jaume", "Alguacil"));
            //cmbPatients.Items.Add(new Client(147222, "Jose", "Maldonado"));
            //cmbPatients.Items.Add(new Client(387368, "Rafael", "Caballero"));
            //cmbPatients.Items.Add(new Client(876855, "Maria", "Ramos"));
            //cmbPatients.Items.Add(new Client(736932, "Francisca", "Jurado"));
            //cmbPatients.Items.Add(new Client(502676, "Luis", "Ros"));
            //cmbPatients.Items.Add(new Client(186080, "Antonio", "Vargas"));
            //cmbPatients.Items.Add(new Client(832366, "Javier", "Esteban"));
            //cmbPatients.Items.Add(new Client(379061, "Marc", "Arroyo"));
            //cmbPatients.Items.Add(new Client(567213, "Jesus", "Bermudez"));
            //cmbPatients.Items.Add(new Client(183757, "Ruben", "Escribano"));
            //cmbPatients.Items.Add(new Client(676399, "Diego", "Cardona"));
            //cmbPatients.Items.Add(new Client(376270, "Angela", "Iglesias"));
            //cmbPatients.Items.Add(new Client(980040, "Francisco", "Montiel"));
            //cmbPatients.Items.Add(new Client(873028, "Silvia", "Huerta"));
            //cmbPatients.Items.Add(new Client(358176, "Ander", "Correa"));
            //cmbPatients.DisplayMember = "FullName";

            // #3 - DataSource - strings
            List<string> patients = new List<string>();
            patients.Add("Pedro");
            patients.Add("Javier");
            patients.Add("Erika");
            patients.Add("Miguel");
            patients.Add("Elizabeth");

            cmbPatients.DataSource = patients;
        }

        private void cmbPatients_SelectedIndexChanged(object sender, EventArgs e)
        {
            // #1 - strings - Items
            //txtIndex.Text = $"{cmbPatients.SelectedIndex}"; // OK
            //txtItem.Text = $"{cmbPatients.SelectedItem}";   // OK
            //txtValue.Text = $"{cmbPatients.SelectedValue}"; // N/A
            //btnRemove.Enabled = true;

            // #2 - Items - objects
            //txtIndex.Text = $"{cmbPatients.SelectedIndex}"; // OK
            //Client client = cmbPatients.SelectedItem as Client; // casting
            //txtItem.Text = $"{client.Id} - {client.FullName}";   // OK
            //txtValue.Text = $"{cmbPatients.SelectedValue}"; // N/A
            //btnRemove.Enabled = true;

            // #3 - DataSource - strings
            txtIndex.Text = $"{cmbPatients.SelectedIndex}"; // OK
            txtItem.Text = $"{cmbPatients.SelectedItem}";   // OK
            txtValue.Text = $"{cmbPatients.SelectedValue}"; // OK
            btnRemove.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // #1 - strings - Items
            //cmbPatients.Items.Add("Ramiro");

            // #2 - Items - objects
            //cmbPatients.Items.Add(new Client(623971, "Ramiro", "Jimenez"));

            // #3 - DataSource - strings
            List<string> patients = cmbPatients.DataSource as List<string>;
            patients.Add("Ramiro");
            cmbPatients.DataSource = null;
            cmbPatients.DataSource = patients;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // #1 - strings - Items
            // #2 - Items - objects
            //cmbPatients.Items.RemoveAt(cmbPatients.SelectedIndex);
            //txtIndex.Text = "";
            //txtItem.Text = "";
            //btnRemove.Enabled = false;

            // #3 - DataSource - strings
        }
    }

    class Client
    {
        public int Id { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public string FullName => $"{LastName}, {FirstName}";

        public Client(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
