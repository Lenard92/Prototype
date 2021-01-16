using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Prototype
{
    public partial class App : Application
    {
        // In deze statements worden de databases via de controllers omgezet in fields
        static MetingDatabase database;
        static UserDatabase udatabase;
        
        // Hier wordt de beginpagina bepaald
        public App()
        {
            InitializeComponent();

            //MainPage = new NavigationPage(new LoginPage());
            MainPage = new NavigationPage(new LoginPage());
        }

        public static MetingDatabase Database
        {
            get  // de get functie haalt de database op, en indien de database nog niet bestaat maakt hij deze aan
            {
                if (database == null)
                {
                    database = new MetingDatabase(DependencyService.Get<ILocalFileHelper>().GetLocalFilePath("Meting.db3"));
                }
                return database;
            }
        }
        public static UserDatabase UDatabase
        {
            get   // de get functie haalt de database op, en indien de database nog niet bestaat maakt hij deze aan
            {
                if (udatabase == null)
                {
                    udatabase = new UserDatabase(DependencyService.Get<ILocalFileHelper>().GetLocalFilePath("User.db3"));
                }
                return udatabase;
            }
        }
        //onderstaande functies worden standaard gegenereerd, tijdens het ontwikkelen van het MVP was het nog niet noodzakelijk om hier iets mee te doen 

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
