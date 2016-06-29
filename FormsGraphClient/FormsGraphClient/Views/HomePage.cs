using Xamarin.Forms;

namespace FormsGraphClient.Views
{
    public class HomePage : TabbedPage 
    {
        public HomePage()
        {
            this.Children.Add(new UsersPage());
            this.Children.Add(new MailPage());
            this.Children.Add(new FilesPage());
            NavigationPage.SetHasBackButton(this, false);
            NavigationPage.SetHasNavigationBar(this, false);

        }
    }
}
