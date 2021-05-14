using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Manager_Summer2020
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void OptionsScreen_Load(object sender, EventArgs e)
        {

        }

        private void buttonSaveAndExit_Click(object sender, EventArgs e)
        {
            string Date = DateTime.Now.ToLongDateString();
            string Time = DateTime.Now.ToLongTimeString();
            MessageBox.Show($"Saved!\n{Date}\n{Time}");
            // Display Screen
            var newForm = new DisplayScreen();
            newForm.Show();
        }

        private void buttonNewContact_Click(object sender, EventArgs e)
        {
            // Clear Input Within Text Boxes
            textName.Clear();
            textPhone.Clear();
            textEmail.Clear();
            textDescription.Clear();
        }
        private void textName_Enter(object sender, EventArgs e) 
        {
            if (textName.Text == "Full Name")
            {
                textName.Text = "";
                textName.ForeColor = Color.Black;
            }
        }
        private void textName_Leave(object sender, EventArgs e) 
        { 
            if(textName.Text == "")
            {
                textName.Text = "Full Name";
                textName.ForeColor = Color.Silver;
            }
        }
        private void textDescription_TextChanged(object sender, EventArgs e)
        {

        }
    }

    // Object Contact Class
    public class Contact
    {
        public string Name;
        public string Phone;
        public string Email;
        public string Description;
        // public static int totalContacts;
        public Contact(string Name, string Phone, string Email, string Description)
        {
            this.Name = Name;
            this.Phone = Phone;
            this.Email = Email;
            this.Description = Description;
            // totalContacts += contacts
        }
        
    }
}
