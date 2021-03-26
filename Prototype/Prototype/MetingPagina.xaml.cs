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
        private const bool V = true;

        //genereer een blauwe MetingPagina met het GripOpGrasplaatje in een specifieke afmeting.
        public MetingPagina()
        {
            InitializeComponent();
            BackgroundColor = Constants.BackgroundColor;
            GripOpGras.HeightRequest = Constants.GripOpGrasHeight;                    
        }
        // De picker geeft de geselecteerde waarde mee aan Meting.Eenheid, en geeft de user feedback
       


        //async void Picker_SelectedIndexChanged(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        //{
            //if (e.SelectedItem != null)
            //{
           // e = V

                //await App.Database.SaveUserAsync(kalenderDag);
               // await Navigation.PopAsync();
           //}
        //}
        

        //Hier wordt de datepicker als alternatieve invoermethode van Meting.Dag aangesteld en wordt de gebruiker teruggebracht naar de meetlijst.
        async void DatePicker_OnDateSelected5(object sender, DateChangedEventArgs e)
        {
            var kalenderDag = (User)BindingContext;
            kalenderDag.Dag = e.NewDate;
            //await App.Database.SaveUserAsync(kalenderDag);
            await Navigation.PopAsync();
            
        }

        // Hier wordt de save meting aangesproken zodat de laatst bewerkerkte of toegevoegde entry toegevoegd, of vervangen kan worden en wordt de gebruiker teruggebracacht naar de meetlijst.
        async void Opslaan_Clicked(object sender, System.EventArgs e)
        {

            var meetGegevens = (User)BindingContext;
            meetGegevens.Dag = DateTime.Now;
            //await App.Database.SaveUserAsync(meetGegevens);
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
