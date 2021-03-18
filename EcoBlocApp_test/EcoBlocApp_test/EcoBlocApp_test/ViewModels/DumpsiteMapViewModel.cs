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
using EcoBlocApp_test.Models;


namespace EcoBlocApp_test.ViewModels
{
    public class DumpsiteMapViewModel :BaseViewModel
    {
      

        private INavigation _navigation;

        double latitude;
        double longitude;


        private List<OpenDumpsite> _openDumpsites; // change to dumpsites

        public List<OpenDumpsite> OpenDumpsites
        {
            get
            {


                return _openDumpsites;
            }
            set
            {
                _openDumpsites = value;
                NotifyPropertyChanged("OpenDumpsites");
            }

        }

        public List<Pin> pins;


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



        public DumpsiteMapViewModel()
        {


        }

        public DumpsiteMapViewModel(INavigation navigation, double[] location)
        {

            latitude = location[0];
            longitude = location[1];


            pins = new List<Pin>();



           

            _openDumpsites = new List<OpenDumpsite>();





            MyPosition = new Position(latitude, longitude);

            MyMapSpan = new MapSpan(MyPosition, 0.01, 0.01);

            MyMap = new Map(MyMapSpan);

            _openDumpsites = App._sQLiteDatabase.GetOpenedDumpsites();
            AddPins(_openDumpsites);
            

            _navigation = navigation;


        }

        public async Task MarkerClickedButton()
        {
            await _navigation.PopAsync(); 
        }


        
        

        public void AddPins(List<OpenDumpsite> OpenDumpsite)
        {
            Pin temp;

            foreach (var item in OpenDumpsite)
            {


                temp = new Pin
                {
                    ClassId = item.OpenDumpsiteId.ToString(),
                    Label = item.StreetName,
                    Address = item.DumpsiteMarker.PinAddress,
                    Type = PinType.Place,
                    Position = new Position((double)item.DumpsiteMarker.Latitude, (double)item.DumpsiteMarker.Longitude),
                    

                };

                temp.InfoWindowClicked += async (s, args) =>
                {
                    AddTempDumpsite(item);
                    await MarkerClickedButton();
                };

                MyMap.Pins.Add(temp);
                pins.Add(temp);

                
            }
        }

        public void AddTempDumpsite(OpenDumpsite openDumpsite)
        {
            var temp = new TempDumpsite();
            var tempmarker = new TempDumpsiteMarker();

            temp.StreetName = openDumpsite.StreetName;
            temp.ImageUrl = openDumpsite.ImageUrl;
            temp.Comment = openDumpsite.Comment;
            temp.TempDumpsiteId = openDumpsite.OpenDumpsiteId;
            temp.WasteTypes = openDumpsite.WasteTypes;


            tempmarker.Latitude = openDumpsite.DumpsiteMarker.Latitude;
            tempmarker.Longitude = openDumpsite.DumpsiteMarker.Longitude;
            tempmarker.PinAddress = openDumpsite.DumpsiteMarker.PinAddress;
            tempmarker.PinLabel = openDumpsite.DumpsiteMarker.PinLabel;
            tempmarker.TempDumpsiteMarkerId = openDumpsite.DumpsiteMarker.DumpsiteMarkerId;


            temp.TempDumpsiteMarker = tempmarker;


            App._sQLiteDatabase.AddTempDumpsite(temp);
            App._sQLiteDatabase.AddTempDumpsiteMarker(tempmarker);



        }

    }
}
