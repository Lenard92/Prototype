﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace Prototype
{
	//[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MetingListPage : ContentPage
	{
		public MetingListPage ()
		{
			InitializeComponent ();
            this.Title = "Lijst met metingen";
            BackgroundColor = Constants.BackgroundColor;
            var toolbarItem = new ToolbarItem
            {
                Text = "+"
            };
            toolbarItem.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new MetingPagina()
                {
                    BindingContext = new Meting()
                });
            };
            ToolbarItems.Add(toolbarItem);
		}
      
        protected async override void OnAppearing()
        {
            base.OnAppearing();

            MeetListView.ItemsSource = await App.Database.GetMetingAsync();
        }

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