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
            // Dit is een voorbeeld van hoe je de constants kunt aanroepen
            BackgroundColor = Constants.BackgroundColor;
            ActivitySpinner.IsVisible = false;
            GripOpGras.HeightRequest = Constants.GripOpGrasHeight;

            Btn_StartBerekening.TextColor = Constants.MainTextColor;
            Btn_Grondstonffen.TextColor = Constants.MainTextColor;
            Btn_AddData.TextColor = Constants.MainTextColor;


        }
        //// Deze functie gaat na of er gegevens zijn ingevoerd (zie User.cs) en navigeert indien true naar de welkompagina
        //async void SignInProcedure(object sender, EventArgs e)
        //{
            

        //    User user = new User(Entry_Username.Text, Entry_Password.Text);
        //    if (user.CheckInformation())
        //    {
        //        await DisplayAlert("Login", "Login Succes", "Oke");
                
        //        await App.UDatabase.SaveUserAsync(user);
        //        await Navigation.PushAsync(new WelkomDashboard());           
        //    }
            
        //    else
        //    {
        //        await DisplayAlert("Login", "Login is onjuist", "Oke");
        //        await Navigation.PopAsync();
        //        await DisplayAlert("Uw invoer is leeg","Probeer het nog eens", "Oke");
        //    }

        //}

        private void Btn_Grondstonffen_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException(); //TODO: linken naar de grondstoffen pagina
        }

        private void Btn_AddData_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException(); //TODO: linken naar de pagina om een cvs bestand te uploaden

        }

        private void Btn_StartBerekening_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException(); //TODO: linken naar de pagina om 

        }
    }
}


