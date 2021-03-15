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
using Xamarin.Forms.GoogleMaps;
using EcoBlocApp_test.Views;
using EcoBlocApp_test.Models;
using Rg.Plugins.Popup.Services;
using EcoBlocApp_test.PopUp;

namespace EcoBlocApp_test.ViewModels
{
    public class LocateDumpsiteMapVM:BaseViewModel
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


        public LocateDumpsiteMapVM()
        {

        }

        public LocateDumpsiteMapVM(INavigation navigation, double[] location)
        {
            _navigation = navigation;

            latitude = location[0];
            longitude = location[1];

            MyPosition = new Position(latitude, longitude);

            MyMapSpan = new MapSpan(MyPosition, 0.01, 0.01);

            MyMap = new Map( );

            MyMap.MoveToRegion(MyMapSpan, true);

            Pin tempPin = new Pin()
            {
                Label = "mememe",
                Type = PinType.Place,
                Position =MyPosition,
                IsDraggable = true
            };

            MyMap.Pins.Add(tempPin);

           

        }

        
        
        
    }
}
