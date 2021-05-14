using ModernHttpClient;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using Xamarin.Forms;

namespace CCM_MobileXamarin
{
	public sealed partial class SignupPage : ContentPage
	{
		// Necessary global variables for SignUp
		private User NewUser = new User();

		public string APILocation = "http://localhost:7071";

		public SignupPage()
		{
			BindingContext = NewUser;
			InitializeComponent();
		}

		private async void Cancel_Clicked(object sender, EventArgs e)
		{
			// Cancel Button (Closes this window, opens Login)
			await Navigation.PopAsync();
		}

		private async void Signup_Clicked(object sender, EventArgs e)
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

						await DisplayAlert("Sign Up Successful!", "User Creation Successful! You will now be redirected to the login screen.", "OK");
						await Navigation.PopAsync();
					}
					else
					{
						// Catches any error with user signup, let's the user know

						await DisplayAlert("Sign Up Error.", "There was an error with your user creaetion. Please make sure you are connected to the server.", "OK");
					}
				}
				else
				{
					// User input was a duplicate of an already existing User on the database, try again?

					await DisplayAlert("User Already Exists.", "That username already exists in our system. Please try a new one.", "OK");
				}
			}
		}
	}
}