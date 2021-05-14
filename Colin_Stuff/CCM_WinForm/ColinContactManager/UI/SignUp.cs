using ModernHttpClient;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace ColinContactManager
{
    public partial class SignUp : Form
    {
        // Necessary global variables for SignUp
        private User NewUser = new User();

        public string APILocation = "http://localhost:7071";

        public SignUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Cancel Button (Closes this window, opens Login)
            Login newLogin = new Login();
            this.Hide();
            newLogin.ShowDialog();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient(new NativeMessageHandler()))
            {
                // Sets up ExistingUser object for existing user signup check
                LoginUser ExistingUser = new LoginUser();
                ExistingUser.Username = NewUser.Username;
                ExistingUser.Password = "Not A Null Value :)";
                var JsonExistingUser = JsonConvert.SerializeObject(ExistingUser);

                // Client + API Setup Phrases
                client.BaseAddress = new Uri(APILocation);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Add("Login-User", JsonExistingUser);

                // Checks if user signup input is a duplicate of something on the database
                var response = await client.GetAsync($@"/api/Users/UserCheck");
                if (response.IsSuccessStatusCode)
                {
                    // Clears existing setup phrase
                    client.DefaultRequestHeaders.Accept.Clear();

                    // Takes user input, adds it to the Users database, new user created!
                    var JsonString = Newtonsoft.Json.JsonConvert.SerializeObject(NewUser);
                    response = await client.PostAsync($@"/api/Users/AddUser", new StringContent(JsonString, Encoding.UTF8, "application/json"));

                    if (response.IsSuccessStatusCode)
                    {
                        // After successful user creation, leads user back to login screen
                        DialogResult signUpSuccess = MessageBox.Show("User Creation Successful! You will now be redirected to the login screen.", "Sign Up Successful!", MessageBoxButtons.OK);
                        Login loginScreen = new Login();
                        this.Hide();
                        loginScreen.ShowDialog();
                    }
                    else
                    {
                        // Catches any error with user signup, let's the user know
                        DialogResult signUpError = MessageBox.Show("There was an error with your user creation. Please make sure you are connected to the server.", "Sign Up Error...", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    // User input was a duplicate of an already existing User on the database, try again?
                    DialogResult existingUserError = MessageBox.Show("That username already exists in our system. Please try a new one.", "User Already Exists...", MessageBoxButtons.OK);
                }
            }
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            // DATA BINDINGS: Binds user input in the textboxes with a new User object
            NewUser = new User();

            Username.DataBindings.Clear();
            FirstName.DataBindings.Clear();
            LastName.DataBindings.Clear();
            Password.DataBindings.Clear();

            Username.DataBindings.Add("Text", NewUser, "Username", true, DataSourceUpdateMode.OnPropertyChanged, string.Empty);
            FirstName.DataBindings.Add("Text", NewUser, "FirstName", true, DataSourceUpdateMode.OnPropertyChanged, string.Empty);
            LastName.DataBindings.Add("Text", NewUser, "LastName", true, DataSourceUpdateMode.OnPropertyChanged, string.Empty);
            Password.DataBindings.Add("Text", NewUser, "Password", true, DataSourceUpdateMode.OnPropertyChanged, string.Empty);
        }

        private void SignUp_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            // Exits the application upon user pressing close button
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}