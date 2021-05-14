using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Manager_Summer2020
{
    public partial class AddContactScreen : Form
    {
        List<Contact> Contacts = new List<Contact>();
        public AddContactScreen()
        {
            InitializeComponent();
        }

        private void OptionsScreen_Load(object sender, EventArgs e)
        {
            // Read Contacts Data from Accounts from text file

            try
            {
                string file_name = @"FileSaveContacts";
                string read = File.ReadAllText(file_name);
                if (read != "")
                {
                    Contacts = JsonConvert.DeserializeObject<List<Contact>>(read);
                }
            }
            catch (Exception)
            {

            }

            textFirstName.DataBindings.Clear();
            textLastName.DataBindings.Clear();
            textPhone.DataBindings.Clear();
            textEmail.DataBindings.Clear();
            textStreet.DataBindings.Clear();
            textCity.DataBindings.Clear();
            textState.DataBindings.Clear();
            textZip.DataBindings.Clear();
            textDescription.DataBindings.Clear();

            textFirstName.DataBindings.Add("Text", NewContact, "FirstName", true, DataSourceUpdateMode.OnPropertyChanged, string.Empty);
            textLastName.DataBindings.Add("Text", NewContact, "LastName", true, DataSourceUpdateMode.OnPropertyChanged, string.Empty);
            textPhone.DataBindings.Add("Text", NewContact, "Phone", true, DataSourceUpdateMode.OnPropertyChanged, string.Empty);
            textEmail.DataBindings.Add("Text", NewContact, "Email", true, DataSourceUpdateMode.OnPropertyChanged, string.Empty);
            textStreet.DataBindings.Add("Text", NewContact, "Street", true, DataSourceUpdateMode.OnPropertyChanged, string.Empty);
            textCity.DataBindings.Add("Text", NewContact, "City", true, DataSourceUpdateMode.OnPropertyChanged, string.Empty);
            textState.DataBindings.Add("Text", NewContact, "State", true, DataSourceUpdateMode.OnPropertyChanged, string.Empty);
            textZip.DataBindings.Add("Text", NewContact, "Zip", true, DataSourceUpdateMode.OnPropertyChanged, string.Empty);
            textDescription.DataBindings.Add("Text", NewContact, "Description", true, DataSourceUpdateMode.OnPropertyChanged, string.Empty);
        }

        public Contact NewContact = new Contact();

        private void buttonSaveAndExit_Click(object sender, EventArgs e)
        {
            Method.Contacts = Contacts;
            string Date = DateTime.Now.ToLongDateString();
            string Time = DateTime.Now.ToLongTimeString();
            MessageBox.Show($"Saved!\n{Date}\n{Time}");

            // Display Screen
            var newForm = new DisplayScreen();
            newForm.Show();

            // Save/Write Data to text file 
            string file_name = @"FileSave";
            string str = JsonConvert.SerializeObject(Contacts);
            File.WriteAllText(file_name, str);
        }
        public List<Contact> getContactList()
        {
            if ((textFirstName.Text == "First" || textFirstName.Text == "") || (textLastName.Text == "Last" || textLastName.Text == ""))
            {
                MessageBox.Show("Error: Please enter in a full name.");
            }
            else if (textPhone.Text == "###-###-####" || textPhone.Text == "")
            {
                MessageBox.Show("Error: Please enter in a phone number.");
            }
            else
            {
                Contacts.Add(NewContact);

                //Contacts.Add(new Contact()
                //{
                //    FirstName = textFirstName.Text,
                //    LastName = textLastName.Text,
                //    Phone = textPhone.Text,
                //    Email = textEmail.Text,
                //    Street = textStreet.Text,
                //    City = textCity.Text,
                //    State = textState.Text,
                //    Zip = textZip.Text,
                //    Description = textDescription.Text
                //}
                //);
            }
            return Contacts;
        }
        private void buttonNewContact_Click(object sender, EventArgs e)
        {
            // Clear Input Within Text Boxes
            textFirstName.Text = "First";
            textFirstName.ForeColor = Color.Silver;
            textLastName.Text = "Last";
            textLastName.ForeColor = Color.Silver;
            textPhone.Text = "###-###-####";
            textPhone.ForeColor = Color.Silver;
            textEmail.Text = "someone@example.com";
            textEmail.ForeColor = Color.Silver;
            textStreet.Text = "Street";
            textStreet.ForeColor = Color.Silver;
            textCity.Text = "City";
            textCity.ForeColor = Color.Silver;
            textState.Text = "State";
            textState.ForeColor = Color.Silver;
            textZip.Text = "Zip";
            textZip.ForeColor = Color.Silver;
            textDescription.Clear();
        }
        private void textFirstName_Enter(object sender, EventArgs e)
        {
            if (textFirstName.Text == "First")
            {
                textFirstName.Text = "";
                textFirstName.ForeColor = Color.White;
            }
        }
        private void textFirstName_Leave(object sender, EventArgs e)
        {
            if (textFirstName.Text == "")
            {
                textFirstName.Text = "First";
                textFirstName.ForeColor = Color.Silver;
            }
        }
        private void textLastName_Enter(object sender, EventArgs e)
        {
            if (textLastName.Text == "Last")
            {
                textLastName.Text = "";
                textLastName.ForeColor = Color.White;
            }
        }
        private void textLastName_Leave(object sender, EventArgs e)
        {
            if (textLastName.Text == "")
            {
                textLastName.Text = "Last";
                textLastName.ForeColor = Color.Silver;
            }
        }
        private void textPhone_Enter(object sender, EventArgs e)
        {
            if (textPhone.Text == "###-###-####")
            {
                textPhone.Text = "";
                textPhone.ForeColor = Color.White;
            }
        }
        private void textPhone_Leave(object sender, EventArgs e)
        {
            if (textPhone.Text == "")
            {
                textPhone.Text = "###-###-####";
                textPhone.ForeColor = Color.Silver;
            }
        }
        private void textEmail_Enter(object sender, EventArgs e)
        {
            if (textEmail.Text == "someone@example.com")
            {
                textEmail.Text = "";
                textEmail.ForeColor = Color.White;
            }
        }
        private void textEmail_Leave(object sender, EventArgs e)
        {
            if (textEmail.Text == "")
            {
                textEmail.Text = "someone@example.com";
                textEmail.ForeColor = Color.Silver;
            }
        }
        private void textStreet_Enter(object sender, EventArgs e)
        {
            if (textStreet.Text == "Street")
            {
                textStreet.Text = "";
                textStreet.ForeColor = Color.White;
            }
        }
        private void textStreet_Leave(object sender, EventArgs e)
        {
            if (textStreet.Text == "")
            {
                textStreet.Text = "Street";
                textStreet.ForeColor = Color.Silver;
            }
        }
        private void textCity_Enter(object sender, EventArgs e)
        {
            if (textCity.Text == "City")
            {
                textCity.Text = "";
                textCity.ForeColor = Color.White;
            }
        }
        private void textCity_Leave(object sender, EventArgs e)
        {
            if (textCity.Text == "")
            {
                textCity.Text = "City";
                textCity.ForeColor = Color.Silver;
            }
        }
        private void textState_Enter(object sender, EventArgs e)
        {
            if (textState.Text == "State")
            {
                textState.Text = "";
                textState.ForeColor = Color.White;
            }
        }
        private void textState_Leave(object sender, EventArgs e)
        {
            if (textState.Text == "")
            {
                textState.Text = "State";
                textState.ForeColor = Color.Silver;
            }
        }
        private void textZip_Enter(object sender, EventArgs e)
        {
            if (textZip.Text == "Zip")
            {
                textZip.Text = "";
                textZip.ForeColor = Color.White;
            }
        }
        private void textZip_Leave(object sender, EventArgs e)
        {
            if (textZip.Text == "")
            {
                textZip.Text = "Zip";
                textZip.ForeColor = Color.Silver;
            }
        }
        private void buttonAddContact_Click(object sender, EventArgs e)
        {
            getContactList();
            MessageBox.Show("Contact Added");

        }
        // Rest API Connection

        // ModernHttpClient
        using (var client = new HttpClient(new NativeMessageHandler()))
        {
            client.BaseAddress = new Uri(http://localhost:7071);
            client.DefaultRequestHeaders.Accept.Clear();
            //client.DefaultRequestHeaders.Add("x-functions-key", API.FunctionKey);

            var JsonString = Newtonsoft.Json.JsonConvert.SerializeObject(Contact);


            //var response = await client.GetAsync($@"/api/GetContacts");
            //if (response.IsSuccessStatusCode)
            //{
            //     var result = await response.Content.ReadAsStringAsync();
            //     var Contacts = JsonConvert.DeserializeObject<List<Contacts>>(result);
            //}
            //else
            //{ }

            var response = await client.PostAsync($@"/api/AddContact", new StringContent(JsonString, Encoding.UTF8, "application/json"));
            if (response.IsSuccessStatusCode)
            {
            
            }else{}
        }
    }
    // Object Contact Class
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Description { get; set; }
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
    public static class Method
    {
        public static List<Contact> Contacts;
    }
}
