using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Maps;
using EcoBlocApp_test.Services;
using EcoBlocApp_test.ViewModels;

namespace EcoBlocApp_test.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DumpsiteMap : ContentPage
    {

        GeolocateUser userLocation;
        double[] geoLocate;

        public DumpsiteMap()
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


            BindingContext = new DumpsiteMapViewModel(Navigation, geoLocate);




        }
        public async Task GetUserLocation()
        {
            userLocation = new GeolocateUser();
            geoLocate = await userLocation.GetCurrentLocation();

            ;
        }
    }
}