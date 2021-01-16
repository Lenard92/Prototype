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
    public partial class WelkomDashboard : ContentPage
    {


        public WelkomDashboard()
        {
            InitializeComponent();
            Init();
        }
        void Init()
        {

            // Dit is een voorbeeld van hoe je de constants kunt aanroepen
            BackgroundColor = Constants.BackgroundColor;


        }
        // navigeer naar de meetlijst bij het indrukken van de knop
        async void NaarMeetLijst_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MetingListPage());
        }
        // navigeer naar terug naar de inlogpagina
        async void NaarInlogScherm_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }

}