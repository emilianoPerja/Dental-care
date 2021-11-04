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
            //List<string> patients = new List<string>();
            //patients.Add("Pedro");
            //patients.Add("Javier");
            //patients.Add("Erika");
            //patients.Add("Miguel");
            //patients.Add("Elizabeth");

            //cmbPatients.DataSource = patients;

            // #4 - DataSource - objects
            //List<Client> patients = new List<Client>();
            //patients.Add(new Client(689155, "Xavier", "Quintas"));
            //patients.Add(new Client(917169, "Jaume", "Alguacil"));
            //patients.Add(new Client(147222, "Jose", "Maldonado"));
            //patients.Add(new Client(387368, "Rafael", "Caballero"));
            //patients.Add(new Client(876855, "Maria", "Ramos"));
            //patients.Add(new Client(736932, "Francisca", "Jurado"));
            //patients.Add(new Client(502676, "Luis", "Ros"));
            //patients.Add(new Client(186080, "Antonio", "Vargas"));
            //patients.Add(new Client(832366, "Javier", "Esteban"));
            //patients.Add(new Client(379061, "Marc", "Arroyo"));
            //patients.Add(new Client(567213, "Jesus", "Bermudez"));
            //patients.Add(new Client(183757, "Ruben", "Escribano"));
            //patients.Add(new Client(676399, "Diego", "Cardona"));
            //patients.Add(new Client(376270, "Angela", "Iglesias"));
            //patients.Add(new Client(980040, "Francisco", "Montiel"));
            //patients.Add(new Client(873028, "Silvia", "Huerta"));
            //patients.Add(new Client(358176, "Ander", "Correa"));

            //cmbPatients.DisplayMember = "FullName";
            //cmbPatients.ValueMember = "Id";
            //cmbPatients.DataSource = patients;

            // #5 - DataSource - objects - binding
            BindingList<Client> patients = new BindingList<Client>();
            patients.Add(new Client(689155, "Xavier", "Quintas"));
            patients.Add(new Client(917169, "Jaume", "Alguacil"));
            patients.Add(new Client(147222, "Jose", "Maldonado"));
            patients.Add(new Client(387368, "Rafael", "Caballero"));
            patients.Add(new Client(876855, "Maria", "Ramos"));
            patients.Add(new Client(736932, "Francisca", "Jurado"));
            patients.Add(new Client(502676, "Luis", "Ros"));
            patients.Add(new Client(186080, "Antonio", "Vargas"));
            patients.Add(new Client(832366, "Javier", "Esteban"));
            patients.Add(new Client(379061, "Marc", "Arroyo"));
            patients.Add(new Client(567213, "Jesus", "Bermudez"));
            patients.Add(new Client(183757, "Ruben", "Escribano"));
            patients.Add(new Client(676399, "Diego", "Cardona"));
            patients.Add(new Client(376270, "Angela", "Iglesias"));
            patients.Add(new Client(980040, "Francisco", "Montiel"));
            patients.Add(new Client(873028, "Silvia", "Huerta"));
            patients.Add(new Client(358176, "Ander", "Correa"));
            
            cmbPatients.DisplayMember = "FullName";
            cmbPatients.ValueMember = "Id";
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
            //txtIndex.Text = $"{cmbPatients.SelectedIndex}"; // OK
            //txtItem.Text = $"{cmbPatients.SelectedItem}";   // OK
            //txtValue.Text = $"{cmbPatients.SelectedValue}"; // OK
            //btnRemove.Enabled = cmbPatients.SelectedIndex >= 0;

            // #4 - DataSource - objects
            if (cmbPatients.SelectedIndex >= 0)
            {
                txtIndex.Text = $"{cmbPatients.SelectedIndex}"; // OK
                Client client = cmbPatients.SelectedItem as Client; // casting
                txtItem.Text = $"{client.Id} - {client.FullName}";   // OK
                txtValue.Text = $"{cmbPatients.SelectedValue}"; // OK
            }
            else
            {
                txtIndex.Text = "";
                txtItem.Text = "";
                txtValue.Text = "";
            }

            btnRemove.Enabled = cmbPatients.SelectedIndex >= 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // #1 - strings - Items
            //cmbPatients.Items.Add("Ramiro");

            // #2 - Items - objects
            //cmbPatients.Items.Add(new Client(623971, "Ramiro", "Jimenez"));

            // #3 - DataSource - strings
            //List<string> patients = cmbPatients.DataSource as List<string>;
            //patients.Add("Ramiro");
            //cmbPatients.DataSource = null;
            //cmbPatients.DataSource = patients;

            // #4 - DataSource - objects
            //List<Client> patients = cmbPatients.DataSource as List<Client>;
            //patients.Add(new Client(623971, "Ramiro", "Jimenez"));
            //cmbPatients.DataSource = null;
            //cmbPatients.DisplayMember = "FullName";
            //cmbPatients.DataSource = patients;

            // #5 - DataSource - objects - binding
            BindingList<Client> patients = cmbPatients.DataSource as BindingList<Client>;
            patients.Add(new Client(623971, "Ramiro", "Jimenez"));
            patients.ResetBindings();
            cmbPatients_SelectedIndexChanged(null, null); // call function()
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
            //List<string> patients = cmbPatients.DataSource as List<string>;
            //patients.RemoveAt(cmbPatients.SelectedIndex);
            //cmbPatients.DataSource = null;
            //cmbPatients.DataSource = patients;

            //if (cmbPatients.SelectedIndex == -1 && patients.Count > 0)
            //{
            //    cmbPatients.SelectedIndex = patients.Count - 1;
            //}

            // #4 - DataSource - objects
            //List<Client> patients = cmbPatients.DataSource as List<Client>;
            //patients.RemoveAt(cmbPatients.SelectedIndex);
            //cmbPatients.DataSource = null;
            //cmbPatients.DataSource = patients;

            //if (cmbPatients.SelectedIndex == -1 && patients.Count > 0)
            //{
            //    cmbPatients.SelectedIndex = patients.Count - 1;
            //}

            //cmbPatients.DisplayMember = "FullName";

            // #5 - DataSource - objects - binding
            BindingList<Client> patients = cmbPatients.DataSource as BindingList<Client>;
            patients.RemoveAt(cmbPatients.SelectedIndex);
            patients.ResetBindings();
            cmbPatients_SelectedIndexChanged(null, null); // call function()
            //cmbPatients.SelectedIndex = patients.Count - 1;
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
