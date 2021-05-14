using ModernHttpClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Windows.UI.Xaml.Controls;

namespace ColinContactManagerUniversal
{
    public sealed partial class LoginPage : Page
    {
        // Necessary global variables for Login
        private LoginUser NewLoginUser = new LoginUser();

        public string APILocation = "http://localhost:7071";

        public LoginPage()
        {
            DataContext = NewLoginUser;
            this.InitializeComponent();
        }

        private async void Login_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
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
                    this.Frame.Navigate(typeof(MainPage));
                }
                else
                {
                    // Username or password incorrect, try again?
                    ContentDialog contentErrorDialog = new ContentDialog
                    {
                        Title = "User Not Found.",
                        Content = "The Username or Password you entered isn't in our database, please try a different input.",
                        CloseButtonText = "OK"
                    };
                    await contentErrorDialog.ShowAsync();
                }
            }
        }

        private void Signup_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            // Close login window, open signup window

            this.Frame.Navigate(typeof(SignUpPage));
        }
    }
}