using EcoBlocApp_test.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using EcoBlocApp_test.Views;

namespace EcoBlocApp_test.ViewModels
{
    public class MapViewModel : BaseViewModel
    {

        private INavigation _navigation;

        double latitude;
        double longitude;
        

       
        private Map _myMap;

        public Map MyMap
        {   
            get
            {
                return _myMap;
            }
            set
            {
                _myMap = value;
                NotifyPropertyChanged("MyMap");
            }

        }


        private MapSpan _myMapSpan;

        public MapSpan MyMapSpan 
        {
            get
            {
                return _myMapSpan;
            }
            set
            {
                _myMapSpan = value;
                NotifyPropertyChanged("MyMapSpan");
            }
        }


        private Position _myPosition;

        public Position MyPosition
        {
            get
            {
                return _myPosition;
            }
            set
            {
                _myPosition = value;
                NotifyPropertyChanged("MyPosition");
            }
        }


        public ICommand ReportCommand { get; private set; }

        public ICommand EventManagerCommand { get; private set; }

        public ICommand CreateEventCommand { get; private set; }



        public MapViewModel()
        {
            
            
        }

        public MapViewModel(INavigation navigation, double[] location)
        {
            latitude = location[0];
            longitude = location[1];

            MyPosition = new Position(latitude, longitude);

            MyMapSpan = new MapSpan(MyPosition, 0.01, 0.01);

            MyMap = new Map(MyMapSpan);

            Pin pin = new Pin
            {
                Label = "Im here",
                Address = "My address",
                Type = PinType.Place,
                Position = new Position(latitude, longitude)
            };
            MyMap.Pins.Add(pin);

            _navigation = navigation;

            pin.InfoWindowClicked += async (s, args) =>
            {
                //string pinName = ((Pin)s).Label;
                await MarkerClickedButton();
            };

            ReportCommand = new Command(() => ReportButton());

            EventManagerCommand = new Command(() => EventManagerButton()); 

            CreateEventCommand = new Command(() => CreateEventButton());
        }

        public async Task MarkerClickedButton()
        {
            await _navigation.PushAsync(new Marker_detail_page()); ;
        }


        public async void ReportButton()
        {
            await _navigation.PushAsync(new DumpsiteReportPage()); ;
        }


        public async void EventManagerButton()
        {
            await _navigation.PushAsync(new EventTabbedPage()); ;
        }

        public async void CreateEventButton()
        {
            await _navigation.PushAsync(new EventCreationPage()); ;
        }

        //public async Task GetUserLocation()
        //{
        //   userLocation = new GeolocateUser();
        //   var temp = await userLocation.GetCurrentLocation();
        //  latitude = temp[0];
        //  longitude = temp[1];
        //   ;
        // }



        //public async void AddButton()
        // {
        //    await _navigation.PushAsync(new NewOrder()); ;
        //}


        //public async void SaveButton()
        //{
        //   await _navigation.PopAsync();
        //
        // }

    }
}
