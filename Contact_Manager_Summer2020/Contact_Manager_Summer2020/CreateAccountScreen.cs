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
using System.IO;

namespace Contact_Manager_Summer2020
{
    public partial class CreateAccountScreen : Form
    {
        private static List<User> Accounts = new List<User>();
        public CreateAccountScreen()
        {
            InitializeComponent();
        }
        private void CreateAccountScreen_Load(object sender, EventArgs e)
        {
            // Read Saved Accounts from text file

            try
            {
                string file_name = @"FileSaveAccounts";
                string read = File.ReadAllText(file_name);
                if (read != "")
                {
                    Accounts = JsonConvert.DeserializeObject<List<User>>(read);
                }
            }
            catch (Exception)
            {

            }

            textUsername.DataBindings.Clear();
            textPassword.DataBindings.Clear();

            textUsername.DataBindings.Add("Text", NewUser, "Username", true, DataSourceUpdateMode.OnPropertyChanged, string.Empty);
            textPassword.DataBindings.Add("Text", NewUser, "Password", true, DataSourceUpdateMode.OnPropertyChanged, string.Empty);
        }
        public User NewUser = new User();
        private void buttonBack_Click(object sender, EventArgs e)
        {
            // goes to create account screen
            LoginScreen openForm = new LoginScreen();
            openForm.Show();
            this.Hide();
        }
        private void textUsername_Enter(object sender, EventArgs e)
        {
            if (textUsername.Text == "Username")
            {
                textUsername.Text = "";
                textUsername.ForeColor = Color.Black;
            }
        }
        private void textUsername_Leave(object sender, EventArgs e)
        {
            if (textUsername.Text == "")
            {
                textUsername.Text = "Username";
                textUsername.ForeColor = Color.Silver;
            }
        }
        private void textPassword_Enter(object sender, EventArgs e)
        {
            if (textPassword.Text == "Password")
            {
                textPassword.Text = "";
                textPassword.ForeColor = Color.Black;
            }
        }
        private void textPassword_Leave(object sender, EventArgs e)
        {
            if (textPassword.Text == "")
            {
                textPassword.Text = "Password";
                textPassword.ForeColor = Color.Silver;
            }
        }

        private void buttonAddAccount_Click(object sender, EventArgs e)
        {
            if ((textUsername.Text == "" || textUsername.Text == "Username"))
            {
                MessageBox.Show("Please enter in a username");
            }
            else if ((textPassword.Text == "" || textPassword.Text == "Password"))
            {
                MessageBox.Show("Please enter in a password");
            }
            else if (textPassword.Text.Length < 8 ) 
            {
                MessageBox.Show("Password must be at least 8 characters");
            } 
            else 
            { 
                for(int i = 0; i < Accounts.Count; i++)
                {
                    string user = Accounts.ElementAt(i).Username.ToString();
                    if (textUsername.Text == user)
                    {
                        MessageBox.Show("Username already taken");
                    }
                    else 
                    {
                        string pass = textPassword.Text;
                        int num = 0;
                        for (i = 0; i < pass.Length; i++)
                        {
                            // checks to see if there is a number in the password
                            if (Char.IsDigit(pass[i]))
                            {
                                num++;
                            }
                        }
                        if (num >= 2)
                        {
                            //Create a new Account 
                            Accounts.Add(NewUser);
                            // goes to create account screen
                            AddContactScreen openForm = new AddContactScreen();
                            openForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Password must include at least two numbers.");
                        }
                    }
                }
                
            }
        }
    }
}
public class User
{
    public string Username { get; set; }
    public string Password { get; set; }
    // User list for storing all entered contacts in an array of objects    
    public static List<Contact> UserContact { get; set; }
    public override string ToString()
    {
        return JsonConvert.SerializeObject(this);
    }
}

public static class Method
{
    public static List<User> Accounts;
}