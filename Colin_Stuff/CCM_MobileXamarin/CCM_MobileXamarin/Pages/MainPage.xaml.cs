using CCM_MobileXamarin.Pages;
using ModernHttpClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Xamarin.Forms;

namespace CCM_MobileXamarin
{
    public sealed partial class MainPage : ContentPage
    {
        // Necessary Global Variables for MainProgram
        private List<Contact> contactList = new List<Contact>();

        private Contact NewContact = new Contact();

        public string APILocation = "http://localhost:7071";

        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            using (var client = new HttpClient(new NativeMessageHandler()))
            {
                // Client + API Setup Phrases
                client.BaseAddress = new Uri(APILocation);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Add("User-Agent", Core.UserID);

                // Retrieves specific user's contacts on startup
                var response = await client.GetAsync($@"/api/Contacts/GetContacts");
                if (response.IsSuccessStatusCode)
                {
                    // Takes contacts from database, outputs to DataGridView
                    var result = await response.Content.ReadAsStringAsync();
                    contactList = JsonConvert.DeserializeObject<List<Contact>>(result);
                    contactView.ItemsSource = contactList;
                }
                else
                {
                    // Catches any error with contact retrieval, lets the user know
                    await DisplayAlert("Contact Retrieval Error.", "Client could not connect to our database. Please make sure you are connected to our server.", "OK");
                }
            }
        }

        private void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(e.NewTextValue))
            {
                contactView.ItemsSource = contactList;
            }
            else
            {
                var tempData = (List<Contact>)contactList.Where(x => x.FirstName.StartsWith(e.NewTextValue));

                if (tempData.Count != 0)
                {
                    contactView.ItemsSource = tempData;
                }
                else if (((List<Contact>)contactList.Where(x => x.LastName.StartsWith(e.NewTextValue))).Count != 0)
                {
                    tempData = (List<Contact>)contactList.Where(x => x.LastName.StartsWith(e.NewTextValue));
                    contactView.ItemsSource = tempData;
                }
                else
                {
                    contactView.ItemsSource = contactList;
                }
            }
        }

        private void OnSearchButtonPressed(object sender, EventArgs e)
        {
            if (searchBar.Text.Length == 0)
            {
                contactView.ItemsSource = contactList;
            }
            else
            {
                var tempData = (List<Contact>)contactList.Where(x => x.FirstName.StartsWith(searchBar.Text));

                if (tempData.Count != 0)
                {
                    contactView.ItemsSource = tempData;
                }
                else if (((List<Contact>)contactList.Where(x => x.LastName.StartsWith(searchBar.Text))).Count != 0)
                {
                    tempData = (List<Contact>)contactList.Where(x => x.LastName.StartsWith(searchBar.Text));
                    contactView.ItemsSource = tempData;
                }
                else
                {
                    contactView.ItemsSource = contactList;
                }
            }
        }

        private async void GoContactPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CreatePage());
        }
    }
}