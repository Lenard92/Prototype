using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Prototype
{
    public partial class App : Application
    {
        static MetingDatabase database;
        static UserDatabase udatabase;
            
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MetingListPage());
        }

        public static MetingDatabase Database
        {
            get
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
            get
            {
                if (udatabase == null)
                {
                    udatabase = new UserDatabase(DependencyService.Get<ILocalFileHelper>().GetLocalFilePath("User.db3"));
                }
                return udatabase;
            }
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
