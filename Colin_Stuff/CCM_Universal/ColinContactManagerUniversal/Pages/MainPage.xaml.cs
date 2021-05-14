using ModernHttpClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ColinContactManagerUniversal
{
    public sealed partial class MainPage : Page
    {

        // Necessary Global Variables for MainProgram
        private List<Contact> contactList = new List<Contact>();
        private Contact NewContact = new Contact();

        public string APILocation = "http://localhost:7071";

        public MainPage()
        {
            DataContext = NewContact;
            this.InitializeComponent();
        }
        
        private async void CreateContact_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
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
                    // Adds Users Typed-in Contact to DataGridView
                    contactList.Add(NewContact);
                    dataGrid.ItemsSource = null;
                    dataGrid.ItemsSource = contactList;
                }
                else
                {
                    // Catches Any Error With Contact Database POST, Lets The User Know

                    ContentDialog contentErrorDialog = new ContentDialog
                    {
                        Title = "Contact Creation Error.",
                        Content = "There was an error with your contact creation. Please make sure you are connected to the server.",
                        CloseButtonText = "OK"
                    };
                    await contentErrorDialog.ShowAsync();
                }
            }
        }

        private async void SaveContact_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            FileSavePicker fsp = new FileSavePicker();

            // FileSavePicker Properties
            fsp.SuggestedStartLocation = PickerLocationId.Desktop;
            fsp.FileTypeChoices.Add("Json", new List<string>() { ".json" });
            fsp.SuggestedFileName = "ContactList";

            StorageFile file = await fsp.PickSaveFileAsync();
            if (file != null)
            {
                using (var client = new HttpClient(new NativeMessageHandler()))
                {
                    // Client + API Setup Phrases
                    client.BaseAddress = new Uri(APILocation);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Add("User-Agent", Core.UserID);

                    // Retrieves specific user's contacts from database
                    var response = await client.GetAsync($@"/api/Contacts/GetContacts");
                    if (response.IsSuccessStatusCode)
                    {
                        // Takes contacts from database, writes it to a file
                        var result = await response.Content.ReadAsStringAsync();
                        var indent = JsonConvert.DeserializeObject(result);
                        result = JsonConvert.SerializeObject(indent, Formatting.Indented);
                        await FileIO.WriteTextAsync(file, result);
                    }
                    else
                    {
                        // Catches any error with contact retrieval, lets the user know

                        ContentDialog contentErrorDialog = new ContentDialog
                        {
                            Title = "Contact Retrieval Error.",
                            Content = "Client could not connect to our database. Please make sure you are connected to our server.",
                            CloseButtonText = "OK"
                        };
                        await contentErrorDialog.ShowAsync();
                    }
                }
            }
        }

        private async void OpenContact_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            var JsonCheck = new List<Contact>();
            string ContactReplace;

            FileOpenPicker fop = new FileOpenPicker();

            // FileOpenPicker Properties
            fop.ViewMode = PickerViewMode.List;
            fop.SuggestedStartLocation = PickerLocationId.Desktop;
            fop.FileTypeFilter.Add(".json");

            StorageFile file = await fop.PickSingleFileAsync();

            if (file != null)
            {
                ContactReplace = await FileIO.ReadTextAsync(file);

                try
                {
                    JsonCheck = JsonConvert.DeserializeObject<List<Contact>>(ContactReplace);
                }

                // Catch, If, and Else statements used to account for all error with user chosen file + cancelling OpenFileDialog
                catch (Exception)
                {
                    ContentDialog contentErrorDialog = new ContentDialog
                    {
                        Title = "Improper Contact List.",
                        Content = "The JSON file you entered is improper or has been tampered with. Consider using a different file.",
                        CloseButtonText = "OK"
                    };
                    await contentErrorDialog.ShowAsync();
                    return;
                }

                if (JsonCheck.Count() == 0)
                {
                    ContentDialog contentErrorDialog = new ContentDialog
                    {
                        Title = "Improper Contact List.",
                        Content = "The JSON file you entered is improper or has been tampered with. Consider using a different file.",
                        CloseButtonText = "OK"
                    };
                    await contentErrorDialog.ShowAsync();
                    return;
                }
            }
            else
            {
                return;
            }

            using (var client = new HttpClient(new NativeMessageHandler()))
            {
                // Client + API Setup Phrases
                client.BaseAddress = new Uri(APILocation);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Add("User-Agent", Core.UserID);

                // Deletes the current user's contacts, replaces them with all contacts from the JSON file
                var response = await client.PutAsync($@"/api/Contacts/ReplaceContacts", new StringContent(ContactReplace, Encoding.UTF8, "application/json"));
                if (response.IsSuccessStatusCode)
                {
                    // Replaces DataGridView data with new contact list from JSON file
                    var result = await response.Content.ReadAsStringAsync();
                    contactList = JsonConvert.DeserializeObject<List<Contact>>(result);
                    dataGrid.ItemsSource = null;
                    dataGrid.ItemsSource = contactList;
                }
                else
                {
                    // Catches any error with contact replacement, lets the user know
                    ContentDialog contentErrorDialog = new ContentDialog
                    {
                        Title = "Contact Retrieval Error.",
                        Content = "Client could not connect to our database. Please make sure you are connected to our server.",
                        CloseButtonText = "OK"
                    };
                    await contentErrorDialog.ShowAsync();
                }
            }
        }

        private async void Page_Load(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
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
                    dataGrid.ItemsSource = null;
                    dataGrid.ItemsSource = contactList;
                }
                else
                {
                    // Catches any error with contact retrieval, lets the user know
                    ContentDialog contentErrorDialog = new ContentDialog
                    {
                        Title = "Contact Retrieval Error.",
                        Content = "Client could not connect to our database. Please make sure you are connected to our server.",
                        CloseButtonText = "OK"
                    };
                    await contentErrorDialog.ShowAsync();
                }
            }
        }
    }
}