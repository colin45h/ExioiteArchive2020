using ModernHttpClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CCM_MobileXamarin.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreatePage : ContentPage
    {

        private List<Contact> contactList = new List<Contact>();
        private Contact NewContact = new Contact();

        public string APILocation = "http://localhost:7071";

        public CreatePage()
        {
            BindingContext = NewContact;
            InitializeComponent();
        }

        async void CreateContact(object sender, EventArgs e)
        {
            using (var client = new HttpClient(new NativeMessageHandler()))
            {
                // Client + API Setup Phrases
                client.BaseAddress = new Uri(APILocation);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Add("User-Agent", Core.UserID);

                // Converts Users Typed-in Contact to JSON Data, Adds it to Database
                var JsonString = JsonConvert.SerializeObject(NewContact);
                var response = await client.PostAsync($@"/api/Contacts/AddContact", new StringContent(JsonString, Encoding.UTF8, "application/json"));

                if (response.IsSuccessStatusCode)
                {
                    await Navigation.PopAsync();
                }
                else
                {
                    // Catches Any Error With Contact Database POST, Lets The User Know

                    await DisplayAlert("Contact Creation Error.", "There was an error with your contact creation. Please make sure you are connected to the server.", "OK");
                }
            }
        }

        async void CancelContact(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}