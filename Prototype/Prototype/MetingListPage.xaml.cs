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
	public partial class MetingListPage : ContentPage
	{
		public MetingListPage ()
		{
			InitializeComponent ();
            this.Title = "Calculated formulations; you can add one here ----->";
            this.BackgroundColor = Constants.BackgroundColor;
            
            

            BackgroundColor = Constants.BackgroundColor;
            var toolbarItem = new ToolbarItem
            {
                Text = "add"
                
            };
            
            // Deze toolbar maakt de items interactief, waardoor ze, indien geselcteerd, in dit geval navigeren naar de MetingPagina om daar bewerkt te worden
            toolbarItem.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new MetingPagina()
                {
                    BindingContext = new Meting()
                });
            };
            ToolbarItems.Add(toolbarItem);
		}
        
        // deze functie opdate de view steeds met een nieuwe entry door gebruik te maken van de getmeting uit de metingdatabase
        protected async override void OnAppearing()
        {
            base.OnAppearing();

            MeetListView.ItemsSource = await App.Database.GetMetingAsync();
        }
        
        // deze functie cast de bindingcontext naar het geselcteerde item, zodat deze bewerkt kan worden
        async void Meting_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null) {
                await Navigation.PushAsync(new MetingPagina()
                {
                    BindingContext = e.SelectedItem
                });
            }
        }
	}
}