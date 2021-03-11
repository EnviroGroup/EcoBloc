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
using Rg.Plugins.Popup.Services;
using EcoBlocApp_test.PopUp;

namespace EcoBlocApp_test.ViewModels
{
    public class MapViewModel : BaseViewModel
    {

        SQLiteDatabase _sQLiteDatabase;

        private INavigation _navigation;

        double latitude;
        double longitude;

        private bool loggedIn;

        private List<SiteInformation> _siteInformationList;

        public List<SiteInformation> SiteInformationList
        {
            get
            {
                

                return _siteInformationList;
            }
            set
            {
                _siteInformationList = value;
                NotifyPropertyChanged("SiteInformationList");
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


        private List<OpenDumpsite> _openDumpsites; 

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


            pins = new List<Pin>();


            _openDumpsites = new List<OpenDumpsite>();
            _sQLiteDatabase = new SQLiteDatabase();


            loggedIn = _sQLiteDatabase.CheckIfUserIsLoggedIn();


            _siteInformationList = _sQLiteDatabase.GetSiteInformations();
            _openDumpsites = _sQLiteDatabase.GetOpenedDumpsites();




            MyPosition = new Position(latitude, longitude);

            MyMapSpan = new MapSpan(MyPosition, 0.01, 0.01);

            MyMap = new Map(MyMapSpan);


            AddPins(_siteInformationList, _openDumpsites);
            

            _navigation = navigation;

          

            ReportCommand = new Command(() => ReportButton());

            EventManagerCommand = new Command(() => EventManagerButton()); 

            CreateEventCommand = new Command(() => CreateEventButton());
        }

        public async Task MarkerClickedButton(SiteInformation site)
        {
           
            await _navigation.PushAsync(new Marker_detail_page(site)); ;
        }


        public async void ReportButton()
        {
            if (loggedIn == false)
            {
                var page = new Popview();

                await PopupNavigation.Instance.PushAsync(page);
            }
            else
            {
                await _navigation.PushAsync(new DumpsiteReportPage()); ;
            }
            
        }


        public async void EventManagerButton()
        {
            if (loggedIn == false)
            {
                var page = new Popview();

                await PopupNavigation.Instance.PushAsync(page);
            }
            else
            {
                await _navigation.PushAsync(new EventTabbedPage()); ;
            }

            
        }

        public async void CreateEventButton()
        {
            if (loggedIn == false)
            {
                var page = new Popview();

                await PopupNavigation.Instance.PushAsync(page);
            }
            else
            {
                await _navigation.PushAsync(new EventCreationPage(_sQLiteDatabase)); ;
            }

        }

        public void AddPins(List<SiteInformation> siteInformation, List<OpenDumpsite> openDumpsites)
        {
            Pin temp;

            foreach (var item in siteInformation)
            {


                temp = new Pin
                {
                    ClassId = item.SiteInformationId.ToString(),
                    Label = item.Name,
                    Address = item.Address,
                    Type = PinType.Place,
                    Position = new Position((double)item.Latitude, (double)item.Longitude),
                    
                };

                temp.InfoWindowClicked += async (s, args) =>
                {

                    await MarkerClickedButton(item);
                };

                MyMap.Pins.Add(temp);
                pins.Add(temp);
            }

            foreach (var item in openDumpsites)
            {


                temp = new Pin
                {
                    ClassId = item.OpenDumpsiteId.ToString(),
                    Label = item.Comment,
                    Address = item.DumpsiteMarker.PinAddress,
                    Type = PinType.Place,
                    
                    Position = new Position((double)item.DumpsiteMarker.Latitude, (double)item.DumpsiteMarker.Longitude),
                    
                };

                

                MyMap.Pins.Add(temp);
                pins.Add(temp);
            }





        }

    }
}
