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
    public partial class CalenderPage : ContentPage
    {
        public CalenderPage()
        {
            InitializeComponent();
            BackgroundColor = Constants.BackgroundColor;
            LogInIcon.HeightRequest = Constants.LoginIconHeight;
        }
        async void DatePicker_OnDateSelected(object sender, DateChangedEventArgs e)
        {
            var kalenderDag = (Meting)BindingContext;
            kalenderDag.Dag = e.NewDate;
            await App.Database.SaveMetingAsync(kalenderDag);
            
        }

        async void Terug_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PopAsync();
        }
        async void VerderTerug_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new MetingListPage());
        }
    }
}
