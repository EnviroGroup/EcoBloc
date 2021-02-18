using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Maps;
using EcoBlocApp_test.Services;

namespace EcoBlocApp_test.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapView : ContentPage
    {
        Map MyMap;
        GeolocateUser userLocation;
        double latitude;
        double longitude;

        public MapView()
        {
            //Task.Run( GetUserLocation());

            
            
            InitializeComponent();

            Position position = new Position(-33.918861, 18.423300);

            MapSpan mapSpan = new MapSpan(position, 0.01, 0.01);

            Grid grid = new Grid
            {
                RowDefinitions =
            {
                new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                new RowDefinition(),
                new RowDefinition { Height = new GridLength(100) }
            },
                ColumnDefinitions =
            {
                new ColumnDefinition{ Width = new GridLength(1, GridUnitType.Star) },
                new ColumnDefinition{ Width = new GridLength(3, GridUnitType.Star) },
                new ColumnDefinition{ Width = new GridLength(6, GridUnitType.Star) }
            }
            };

            var pin = new Pin()
            {
                Position = new Position(-33.918861, 18.423300),
                Label = "Some Pin!"
            };

            MyMap = new Map(mapSpan);
            MyMap.Pins.Add(pin);
            Grid.SetRowSpan(MyMap, 3);
            Grid.SetColumnSpan(MyMap, 3);

            grid.Children.Add(MyMap);

            grid.Children.Add(new Button
            {
                Text = "me"
            });

            Content = grid;





        }

        public async Task GetUserLocation()
        {
            userLocation = new GeolocateUser();
            var temp = await userLocation.GetCurrentLocation();
            latitude = temp[0];
            longitude = temp[1];
            ;
        }
        public partial class HomeView : ContentPage
        {
            public HomeView(HomeViewModel homeViewModel)
            {
                InitializeComponent();

                homeViewModel.Navigation = Navigation;
                BindingContext = homeViewModel;

<<<<<<< Updated upstream
=======
                ResetCollectionViewSelection();
            }

            private void ResetCollectionViewSelection()
            {
                NoteCollectionView.SelectionChanged += (s, e)
                    => NoteCollectionView.SelectedItem = null;
            }
        }
>>>>>>> Stashed changes
    }

}


    

    }
