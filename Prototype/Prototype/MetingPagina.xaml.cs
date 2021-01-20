//using Android.Content.Res;
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
        //genereer een blauwe MetingPagina met het GripOpGrasplaatje in een specifieke afmeting.
        public MetingPagina()
        {
            InitializeComponent();
            BackgroundColor = Constants.BackgroundColor;
            GripOpGras.HeightRequest = Constants.GripOpGrasHeight;                    
        }
        // De picker 
        async void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
           var lengte = (Meting)BindingContext;                        
           lengte.Eenheid = Picker.Items[Picker.SelectedIndex];                     
           await DisplayAlert("je hebt gekozen voor de meeteenheid", lengte.Eenheid,  "ok");
            

        }

        //Hier wordt de datepicker als alternatieve invoermethode van Meting.Dag aangesteld en wordt de gebruiker teruggebracht naar de meetlijst.
        async void DatePicker_OnDateSelected(object sender, DateChangedEventArgs e)
        {
            var kalenderDag = (Meting)BindingContext;
            kalenderDag.Dag = e.NewDate;
            await App.Database.SaveMetingAsync(kalenderDag);
            await Navigation.PopAsync();

        }

        // Hier wordt de save meting aangesproken zodat de laatst bewerkerkte of toegevoegde entry toegevoegd, of vervangen kan worden en wordt de gebruiker teruggebracacht naar de meetlijst.
        async void Opslaan_Clicked(object sender, System.EventArgs e)
        {
            var meetGegevens = (Meting)BindingContext;
            meetGegevens.Dag = DateTime.Now;
            await App.Database.SaveMetingAsync(meetGegevens);
            await Navigation.PopAsync();

        }
  
        //Hier wordt de delete meting van de database aangesproken zodat de laatst bewerkte of toegevoegde entry gedelete kan worden en wordt de gebruiker teruggebracht naar de meetlijst.
        async void Verwijderen_Clicked(object sender, System.EventArgs e)
        {
            var meetGegevens = (Meting)BindingContext;
            await App.Database.DeleteMetingAsync(meetGegevens);
            await Navigation.PopAsync();
        }

        // Ga terug naar de meetlijst bij het selecteren van de annuleerknop.
            async void Annuleren_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PopAsync();
        }

     
    }
}
