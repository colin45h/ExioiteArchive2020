using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Contact_Manager_Summer2020;

namespace Contact_Manager_Summer2020
{
    public partial class DisplayScreen : Form
    {
        public DisplayScreen()
        {
            InitializeComponent();
        }
        private void DisplayScreen_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = Method.Contacts;
            // obtain the 'getContactList' method from the other form
            // This Displays the List in the 'List View' UI control
            //var contact_list = Method.Contacts;
            ////dataGridView.DataSource = contact_list;
            //foreach(var contact in contact_list)
            //{
            //    dataGridView.Rows.Add(contact.FirstName, contact.LastName, contact.Phone, contact.Email, contact.Street, contact.City, contact.State, contact.Zip, contact.Description);
            //    var row = new string[] { contact.FirstName, contact.LastName, contact.Phone, contact.Email, contact.Street, contact.City, contact.State, contact.Zip, contact.Description };
            //    var View = new ListViewItem(row);
            //    View.Tag = contact;
            //    displayContacts.Items.Add(View);
            //}
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            // goes back to the main screen
            AddContactScreen openForm = new AddContactScreen();
            openForm.Show();
            this.Hide();
        }
    }
}
