using EcoBlocApp_test.Services;
using EcoBlocApp_test.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EcoBlocApp_test.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LocateDumpsiteMap : ContentPage
    {
        GeolocateUser userLocation;
        double[] geoLocate;

        public LocateDumpsiteMap()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            indicator.IsRunning = true;
            indicator.IsEnabled = true;
            indicator.IsVisible = true;

            await GetUserLocation();

            indicator.IsRunning = false;
            indicator.IsEnabled = false;
            indicator.IsVisible = false;

            BindingContext = new LocateDumpsiteMapVM(Navigation, geoLocate);


            //need to change this


        }


        public async Task GetUserLocation()
        {
            userLocation = new GeolocateUser();
            geoLocate = await userLocation.GetCurrentLocation();

            ;
        }
    }
}