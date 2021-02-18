using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms.Maps;
<<<<<<< Updated upstream
=======
using XamNote.Models;
using XamNote.Views;
using EcoBlocApp_test.Views;
>>>>>>> Stashed changes

namespace EcoBlocApp_test.ViewModels
{
    class MapViewModel
    {
       

        public MapViewModel()
        {
<<<<<<< Updated upstream
            //dfsdfsdfsdfsdfsd
        } 
=======
            
            
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



namespace XamNote.ViewModels
    {
        public class HomeViewModel : ViewModelBase
        {
            private ObservableCollection<Note> notes;
            private readonly INoteRepository noteRepository;

            public HomeViewModel(INoteRepository noteRepository)
            {
                this.noteRepository = noteRepository;

                SubscribeToSaveOccuredMessage();

                InitializeAddNoteCommand();

                LoadNotes();
            }

            private void SubscribeToSaveOccuredMessage()
            {
                MessagingCenter.Subscribe<NoteViewModel>(this, "saveoccured", n => LoadNotes());
            }

            private void InitializeAddNoteCommand()
                => AddNoteCommand = new Command(async () => NavigateToNoteView(new Note()));

            private async void LoadNotes()
            {
                try
                {
                    var notes = await noteRepository.GetNotes()
                    ?? Enumerable.Empty<Note>();

                    Notes = new ObservableCollection<Note>(notes);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }

            private async void NavigateToNoteView(Note value)
            {
                var noteView = Locator.Resolve<NoteView>();
                var noteViewModel = noteView.BindingContext as NoteViewModel;
                noteViewModel.Note = value;

                await Navigation.PushAsync(noteView);
            }

            public ObservableCollection<Note> Notes
            {
                get => notes;
                set
                {
                    notes = value;
                    OnPropertyChanged();
                }
            }

            public Note SelectedNote
            {
                get => null;
                set
                {
                    if (value == null) return;
                    NavigateToNoteView(value);
                }
            }

>>>>>>> Stashed changes

            public ICommand AddNoteCommand { get; private set; }
        }
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
