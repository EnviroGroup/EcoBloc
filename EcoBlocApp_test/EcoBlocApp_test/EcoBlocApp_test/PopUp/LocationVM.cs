using EcoBlocApp_test.Services;
using EcoBlocApp_test.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Essentials;
namespace EcoBlocApp_test.PopUp
{
    class LocationVM : BaseViewModel
    {
        
       

        private double latitude;

        public double Latitude
        {
            get
            {
                return latitude;
            }
            set
            {
                latitude = value;
                NotifyPropertyChanged("Latitude");
            }

        }

        private  double longitude;

        public double Longitude
        {
            get
            {
                return longitude;
            }
            set
            {
                longitude = value;
                NotifyPropertyChanged("Longitude");
            }

        }

        private string _streetName;

        public string StreetName
        {
            get
            {
                return _streetName;
            }
            set
            {
                _streetName = value;
                NotifyPropertyChanged("StreetName");
            }

        }

        public LocationVM(double lat,double longi)
        {
            latitude = lat;
            longitude = longi;
           // GetGecode();
        }

        public async void GetGecode()
        {
            var placemarks = await Geocoding.GetPlacemarksAsync(latitude, longitude);
            var placemark = placemarks?.FirstOrDefault();

            StreetName = placemark.Thoroughfare;
        }



    }
}
