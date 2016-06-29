using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using FormsGraphClient.Helper;
using FormsGraphClient.Model;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace FormsGraphClient.Views
{
    public partial class MailPage : ContentPage
    {
        public MailPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {  
            base.OnAppearing();
            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", App.AuthenticationResult.AccessToken);
            var response = await client.GetStringAsync("https://graph.microsoft.com/beta/me/messages");
            var result = JsonConvert.DeserializeObject<MailResponse>(response);
            MailList.ItemsSource = result.Value;
        }
    }
}
