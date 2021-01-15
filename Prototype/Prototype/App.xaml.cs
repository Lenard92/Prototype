using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Prototype
{
    public partial class App : Application
    {
        static MetingDatabase database;

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
