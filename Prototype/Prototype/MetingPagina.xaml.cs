using Android.Content.Res;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Prototype
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MetingPagina : ContentPage
    {
        public MetingPagina()
        {
            InitializeComponent();
            BackgroundColor = Constants.BackgroundColor;
            LogInIcon.HeightRequest = Constants.LoginIconHeight;
        }
      

        async void Opslaan_Clicked(object sender, System.EventArgs e)
        {
            var meetGegevens = (Meting)BindingContext;
            await App.Database.SaveMetingAsync(meetGegevens);
            await Navigation.PopAsync();

        }

        async void Annuleren_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PopAsync();
        }

    }
}
