using ModernHttpClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace ColinContactManager
{
    public partial class MainProgram : System.Windows.Forms.Form
    {
        // Necessary Global Variables for MainProgram
        private List<Contact> contactList = new List<Contact>();

        private Contact NewContact = new Contact();
        public string APILocation = "http://localhost:7071";

        public MainProgram()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient(new NativeMessageHandler()))
            {
                // Client + API Setup Phrases
                client.BaseAddress = new Uri(APILocation);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Add("User-Agent", Core.UserID);

                // Converts Users Typed-in Contact to JSON Data, Adds it to Database
                var JsonString = Newtonsoft.Json.JsonConvert.SerializeObject(NewContact);
                var response = await client.PostAsync($@"/api/Contacts/AddContact", new StringContent(JsonString, Encoding.UTF8, "application/json"));

                if (response.IsSuccessStatusCode)
                {
                    // Adds Users Typed-in Contact to DataGridView
                    contactList.Add(NewContact);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = contactList;
                    dataGridView1.Refresh();
                }
                else
                {
                    // Catches Any Error With Contact Database POST, Lets The User Know
                    DialogResult contactError = MessageBox.Show("There was an error with your contact creation. Please make sure you are connected to the server.", "Contact Creation Error...", MessageBoxButtons.OK);
                }
            }
        }

        private async void button2_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            // SaveFileDialog properties
            sfd.FileName = "ContactList.json";
            sfd.Title = "Save Contact List";
            sfd.InitialDirectory = "C:\\";
            sfd.Filter = "Jason Files (*.json)|*.json";
            sfd.FilterIndex = 2;
            sfd.RestoreDirectory = true;

            if (sfd.ShowDialog() == DialogResult.OK || sfd.FileName != "")
            {
                using (var client = new HttpClient(new NativeMessageHandler()))
                {
                    // Client + API Setup Phrases
                    client.BaseAddress = new Uri(APILocation);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Add("User-Agent", Core.UserID);

                    // Retrieves specific user's contacts from database
                    var response = await client.GetAsync($@"/api/Contacts/GetContacts");
                    if (response.IsSuccessStatusCode)
                    {
                        // Takes contacts from database, writes it to a file
                        var result = await response.Content.ReadAsStringAsync();
                        var indent = JsonConvert.DeserializeObject(result);
                        result = JsonConvert.SerializeObject(indent, Formatting.Indented);
                        File.WriteAllText(sfd.FileName, result);
                    }
                    else
                    {
                        // Catches any error with contact retrieval, lets the user know
                        DialogResult databaseError = MessageBox.Show("Client could not connect to our database. Please make sure you are connected to our server.", "Contact Retrieval Error...", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            var JsonCheck = new List<Contact>();
            string ContactReplace;

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                // OpenFileDialog properties
                ofd.InitialDirectory = "C:\\";
                ofd.Filter = "Json Files (*.json)|*.json";
                ofd.Title = "Open Contact List";
                ofd.FilterIndex = 2;
                ofd.RestoreDirectory = true;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    ContactReplace = File.ReadAllText(ofd.FileName);

                    try
                    {
                        JsonCheck = JsonConvert.DeserializeObject<List<Contact>>(ContactReplace);
                    }

                    // Catch, If, and Else statements used to account for all error with user chosen file + cancelling OpenFileDialog
                    catch (Exception)
                    {
                        DialogResult badJsonFile = MessageBox.Show("The JSON file you entered is improper or has been tampered with. Consider using a different file.", "Improper Contact List", MessageBoxButtons.OK);
                        return;
                    }

                    if (JsonCheck.Count() == 0)
                    {
                        DialogResult badJsonFile = MessageBox.Show("The JSON file you entered is improper or has been tampered with. Consider using a different file.", "Improper Contact List", MessageBoxButtons.OK);
                        return;
                    }
                }
                else
                {
                    return;
                }
            }
            using (var client = new HttpClient(new NativeMessageHandler()))
            {
                // Client + API Setup Phrases
                client.BaseAddress = new Uri(APILocation);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Add("User-Agent", Core.UserID);

                // Deletes the current user's contacts, replaces them with all contacts from the JSON file
                var response = await client.PutAsync($@"/api/Contacts/ReplaceContacts", new StringContent(ContactReplace, Encoding.UTF8, "application/json"));
                if (response.IsSuccessStatusCode)
                {
                    // Replaces DataGridView data with new contact list from JSON file
                    var result = await response.Content.ReadAsStringAsync();
                    contactList = JsonConvert.DeserializeObject<List<Contact>>(result);
                    dataGridView1.DataSource = contactList;
                    dataGridView1.Refresh();
                }
                else
                {
                    // Catches any error with contact replacement, lets the user know
                    DialogResult databaseError = MessageBox.Show("Client could not connect to our database. Please make sure you are connected to our server.", "Contact Retrieval Error...", MessageBoxButtons.OK);
                }
            }
        }

        private async void Form_Load(object sender, EventArgs e)
        {
            using (var client = new HttpClient(new NativeMessageHandler()))
            {
                // Client + API Setup Phrases
                client.BaseAddress = new Uri(APILocation);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Add("User-Agent", Core.UserID);

                // Retrieves specific user's contacts on startup
                var response = await client.GetAsync($@"/api/Contacts/GetContacts");
                if (response.IsSuccessStatusCode)
                {
                    // Takes contacts from database, outputs to DataGridView
                    var result = await response.Content.ReadAsStringAsync();
                    contactList = JsonConvert.DeserializeObject<List<Contact>>(result);
                    dataGridView1.DataSource = contactList;
                    dataGridView1.Refresh();
                }
                else
                {
                    // Catches any error with contact retrieval, lets the user know
                    DialogResult databaseError = MessageBox.Show("Client could not connect to our database. Please make sure you are connected to our server.", "Contact Retrieval Error...", MessageBoxButtons.OK);
                }
            }

            // DATA BINDINGS: Binds user input in the textboxes with a new Contact object

            NewContact = new Contact();

            FirstName.DataBindings.Clear();
            LastName.DataBindings.Clear();
            Email.DataBindings.Clear();
            PhoneNumber.DataBindings.Clear();
            Address.DataBindings.Clear();
            City.DataBindings.Clear();
            State.DataBindings.Clear();
            Zip.DataBindings.Clear();

            FirstName.DataBindings.Add("Text", NewContact, "FirstName", true, DataSourceUpdateMode.OnPropertyChanged, string.Empty);
            LastName.DataBindings.Add("Text", NewContact, "LastName", true, DataSourceUpdateMode.OnPropertyChanged, string.Empty);
            Email.DataBindings.Add("Text", NewContact, "Email", true, DataSourceUpdateMode.OnPropertyChanged, string.Empty);
            PhoneNumber.DataBindings.Add("Text", NewContact, "PhoneNumber", true, DataSourceUpdateMode.OnPropertyChanged, string.Empty);
            Address.DataBindings.Add("Text", NewContact, "Address", true, DataSourceUpdateMode.OnPropertyChanged, string.Empty);
            City.DataBindings.Add("Text", NewContact, "City", true, DataSourceUpdateMode.OnPropertyChanged, string.Empty);
            State.DataBindings.Add("Text", NewContact, "State", true, DataSourceUpdateMode.OnPropertyChanged, string.Empty);
            Zip.DataBindings.Add("Text", NewContact, "Zip", true, DataSourceUpdateMode.OnPropertyChanged, string.Empty);
        }

        private void MainProgram_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Exits the application upon user pressing close button
            Application.Exit();
        }
    }
}