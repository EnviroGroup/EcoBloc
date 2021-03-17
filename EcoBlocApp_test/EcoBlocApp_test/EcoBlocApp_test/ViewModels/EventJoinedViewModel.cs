using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using EcoBlocApp_test.Models;
using System.Collections.ObjectModel;
using EcoBlocApp_test.Views;
using EcoBlocApp_test.Services;

namespace EcoBlocApp_test.ViewModels
{
    public class EventJoinedViewModel : BaseViewModel
    {

        private INavigation _navigation;

        SQLiteDatabase _sQLiteDatabase;


        List<Event> tempList;

        private ObservableCollection<Event> _events;

        public ObservableCollection<Event> Events
        {
            get
            {

                return _events;
            }
            set
            {
                _events = value;
                NotifyPropertyChanged("Events");
            }

        }


        private Event _selectedEvent;
        public Event SelectedEvent
        {
            get { return _selectedEvent; }
            set
            {
                _selectedEvent = value;
                NotifyPropertyChanged("SelectedEvent");




                if (_selectedEvent != null)
                {

                    ViewJoinedEvent(_selectedEvent);

                }




            }
        }

        private int _amountOfParticipates;
        public int AmountOfParticipates
        {
            get { return _amountOfParticipates; }
            set
            {
                _amountOfParticipates = value;
                NotifyPropertyChanged("AmountOfParticipates");
            }
        }

        public EventJoinedViewModel()
        {
        }

        public EventJoinedViewModel(INavigation navigation)
        {
            _sQLiteDatabase = new SQLiteDatabase();

            tempList = GetEvents();
            SelectedEvent = null;


            Events = new ObservableCollection<Event>(tempList);

            _navigation = navigation;
        }

        public List<Event> GetEvents()
        {
            return _sQLiteDatabase.GetEvents();
        }

        public int GetnumberOfParticipants()
        {
            return 1;
        }


        public async void ViewJoinedEvent(Event @event)
        {
            SelectedEvent = null;
            await _navigation.PushAsync(new JoinedEventTemplate()); ;
        }

        //public async void SaveButton()
        //{
        //   await _navigation.PopAsync();
        //
        // }

    }
}

