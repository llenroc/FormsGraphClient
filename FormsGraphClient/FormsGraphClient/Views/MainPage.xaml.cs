using System;
using FormsGraphClient.Helper;
using Xamarin.Forms;

namespace FormsGraphClient.Views
{
    public partial class MainPage : ContentPage
    {
       
        public MainPage()
        {
            InitializeComponent();
        }

        private async void BtnLogin_OnClicked(object sender, EventArgs e)
        {
            var data = await DependencyService.Get<IAuthenticator>()
               .Authenticate(App.LoginAuthority, App.GraphResourceUri, App.ClientId, App.ReturnUri);
            App.AuthenticationResult = data;
            var userName = data.UserInfo.GivenName + " " + data.UserInfo.FamilyName;
            await DisplayAlert("Welcome", userName, "Ok", "Cancel");
            await Navigation.PushAsync(new HomePage());
        }
    }
}
