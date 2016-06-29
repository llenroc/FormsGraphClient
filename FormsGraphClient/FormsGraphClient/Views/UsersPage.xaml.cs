using System.Net.Http;
using System.Net.Http.Headers;
using FormsGraphClient.Model;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace FormsGraphClient.Views
{
    public partial class UsersPage : ContentPage
    {
        public UsersPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", App.AuthenticationResult.AccessToken);
            var response = await client.GetStringAsync("https://graph.microsoft.com/beta/users");
            var result = JsonConvert.DeserializeObject<UsersRequest>(response);
            UsersList.ItemsSource = result.Value;
        }
    }
}
