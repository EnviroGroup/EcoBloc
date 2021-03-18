using EcoBlocApp_test.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace EcoBlocApp_test.ViewModels
{
    public class Class1 : BaseViewModel
    {
        private bool _running;
        private GeolocateUser userLocation;
        private double[] geoLocate;

        public bool Running
        {
            get
            {

                return _running;
            }
            set
            {
                _running = value;
                NotifyPropertyChanged("Running");
            }
        }

        public Class1()
        {


            pm();
            

        }

        public async void pm()
        {

            userLocation = new GeolocateUser();
            geoLocate = await userLocation.GetCurrentLocation();

            Device.BeginInvokeOnMainThread(() =>
            {

                Running = true;
            });
        }
    }
}
