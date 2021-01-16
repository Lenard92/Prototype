using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Prototype;


namespace Prototype
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {


        public LoginPage()
        {
            InitializeComponent();
            Init();
        }
        void Init()
        {
            BackgroundColor = Constants.BackgroundColor;
            Lbl_Username.TextColor = Constants.MainTextColor;
            Lbl_Password.TextColor = Constants.MainTextColor;
            ActivitySpinner.IsVisible = false;
            LogInIcon.HeightRequest = Constants.LoginIconHeight;

        
        }
        async void SignInProcedure(object sender, EventArgs e)
        {
            

            User user = new User(Entry_Username.Text, Entry_Password.Text);
            if (user.CheckInformation())
            {
                await DisplayAlert("Login", "Login Succes", "Oke");
                
                await App.UDatabase.SaveUserAsync(user);
                await Navigation.PushAsync(new Welkom());
                //if (Device.OS == TargetPlatform.Android) ;





            }
            
            else
            {


                await DisplayAlert("Login", "Login not correct", "Oke");
            }

        }
    }
}


