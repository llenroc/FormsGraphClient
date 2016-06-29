using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Xamarin.Forms;

namespace FormsGraphClient
{
    public partial class App : Application
    {
        public static string ClientId = "<client-id>";
        public static string LoginAuthority = "https://login.microsoftonline.com/<tenant>";
        public static string ReturnUri = "<return url>";
        public static string GraphResourceUri = "https://graph.microsoft.com";
        public static AuthenticationResult AuthenticationResult = null;
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
