using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace moFaim
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new moFaim.Pages.LoginPage();
            //MainPage = new moFaim.Pages.RegistrationPage();
            MainPage = new moFaim.Pages.RestaurantView();
        }

        protected override void OnStart()
        {
           
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
