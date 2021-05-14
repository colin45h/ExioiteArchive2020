using ModernHttpClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;

namespace ColinContactManager
{
    public partial class Login : Form
    {
        // Necessary global variables for Login
        private LoginUser NewLoginUser = new LoginUser();

        public string APILocation = "http://localhost:7071";

        public Login()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient(new NativeMessageHandler()))
            {
                // Turns user login input into a NewLoginUser object
                var jsonLoginUser = JsonConvert.SerializeObject(NewLoginUser);

                // Client + API Setup Phrases
                client.BaseAddress = new Uri(APILocation);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Add("Login-User", jsonLoginUser);

                // Takes user login input, finds designated user in database, retrieves that User
                var response = await client.GetAsync($@"/api/Users/GetUser");
                if (response.IsSuccessStatusCode)
                {
                    // Turns JSON info from database into LoginUser object
                    var result = JsonConvert.DeserializeObject<List<LoginUser>>(await response.Content.ReadAsStringAsync());

                    // Accounts for multiple of the same user (just in case) + Retrieves UserID for successful login
                    LoginUser daUser = result.First();
                    Core.UserID = daUser.ID.ToString();

                    // Login screen gone, opens dashboard for designated user
                    this.Hide();
                    MainProgram dashboard = new MainProgram();
                    dashboard.Show();
                }
                else
                {
                    // Username or password incorrect, try again?
                    DialogResult loginError = MessageBox.Show("The Username or Password you entered isn't in our database, please try a different input.", "User Not Found...", MessageBoxButtons.OK);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Close login window, open signup window
            this.Hide();
            SignUp newSignUp = new SignUp();
            newSignUp.ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // DATA BINDINGS: Binds user input in the textboxes with a NewLoginUser object

            NewLoginUser = new LoginUser();

            Username.DataBindings.Clear();
            Password.DataBindings.Clear();

            Username.DataBindings.Add("Text", NewLoginUser, "Username", true, DataSourceUpdateMode.OnPropertyChanged, string.Empty);
            Password.DataBindings.Add("Text", NewLoginUser, "Password", true, DataSourceUpdateMode.OnPropertyChanged, string.Empty);
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Exits the application upon user pressing close button
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}