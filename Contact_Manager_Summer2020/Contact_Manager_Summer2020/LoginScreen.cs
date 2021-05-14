using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Contact_Manager_Summer2020
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }
        private void NewUser_Button_Click(object sender, EventArgs e)
        {
            // goes to create account screen
            CreateAccountScreen openForm = new CreateAccountScreen();
            openForm.Show();
            this.Hide();
        }

        private void textUser_Enter(object sender, EventArgs e)
        {
            if (textUser.Text == "Username")
            {
                textUser.Text = "";
                textUser.ForeColor = Color.Black;
            }
        }
        private void textUser_Leave(object sender, EventArgs e)
        {
            if (textUser.Text == "")
            {
                textUser.Text = "Username";
                textUser.ForeColor = Color.Black;
            }
        }
        private void textPass_Enter(object sender, EventArgs e)
        {
            if (textPass.Text == "Password")
            {
                textPass.Text = "";
                textPass.ForeColor = Color.Black;
            }
        }
        private void textPass_Leave(object sender, EventArgs e)
        {
            if (textPass.Text == "")
            {
                textPass.Text = "Password";
                textPass.ForeColor = Color.Black;
            }
        }
        private void Login_Button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Accounts.size; i++) 
            {
                if (textUser.Text == Accounts.ElementAt(i).getUsername()) 
                {
                    AddContactScreen openForm = new AddContactScreen();
                    openForm.Show();
                    this.Hide();
                }
            }
        }
    }
}
