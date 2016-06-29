using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using FormsGraphClient.Model;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace FormsGraphClient.Views
{
    public partial class FilesPage : ContentPage
    {
        public FilesPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", App.AuthenticationResult.AccessToken);
            var response = await client.GetStringAsync("https://graph.microsoft.com/beta/me/drive/root/children");
            var result = JsonConvert.DeserializeObject<FileResponse>(response);
            FilesList.ItemsSource = result.Value;
        }
    }
}
