using ModernHttpClient;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using Windows.UI.Xaml.Controls;

namespace ColinContactManagerUniversal
{
    public sealed partial class SignUpPage : Page
    {
        // Necessary global variables for SignUp
        private User NewUser = new User();

        public string APILocation = "http://localhost:7071";

        public SignUpPage()
        {
            DataContext = NewUser;
            this.InitializeComponent();
        }

        private void Cancel_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            // Cancel Button (Closes this window, opens Login)
            this.Frame.Navigate(typeof(LoginPage));
        }

        private async void Signup_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            using (var client = new HttpClient(new NativeMessageHandler()))
            {
                // Sets up ExistingUser object for existing user signup check
                LoginUser ExistingUser = new LoginUser();
                ExistingUser.Username = NewUser.Username;
                ExistingUser.Password = "Not a null value :)";
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

                        ContentDialog contentNiceDialog = new ContentDialog
                        {
                            Title = "Sign Up Successful!",
                            Content = "User Creation Successful! You will now be redirected to the login screen.",
                            CloseButtonText = "OK"
                        };
                        await contentNiceDialog.ShowAsync();

                        this.Frame.Navigate(typeof(LoginPage));
                    }
                    else
                    {
                        // Catches any error with user signup, let's the user know

                        ContentDialog contentErrorDialog = new ContentDialog
                        {
                            Title = "Sign Up Error.",
                            Content = "There was an error with your user creation. Please make sure you are connected to the server.",
                            CloseButtonText = "OK"
                        };
                        await contentErrorDialog.ShowAsync();
                    }
                }
                else
                {
                    // User input was a duplicate of an already existing User on the database, try again?

                    ContentDialog contentErrorDialog = new ContentDialog
                    {
                        Title = "User Already Exists.",
                        Content = "That username already exists in our system. Please try a new one.",
                        CloseButtonText = "OK"
                    };
                    await contentErrorDialog.ShowAsync();
                }
            }
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            // DATA BINDINGS: Binds user input in the textboxes with a new User object
            NewUser = new User();
        }
    }
}