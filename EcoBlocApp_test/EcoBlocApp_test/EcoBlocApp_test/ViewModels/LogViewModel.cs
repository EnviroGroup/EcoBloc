using EcoBlocApp_test.Models;
using EcoBlocApp_test.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using EcoBlocApp_test.Views;

namespace EcoBlocApp_test.ViewModels
{
    public class LogViewModel : BaseViewModel
    {
        private INavigation _navigation;

        


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
                   
                    GoToEventDetails(_selectedEvent);
                    
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

        public LogViewModel() 
        {
        }

        public LogViewModel(INavigation navigation)
        {
            

            tempList = GetEvents();
            SelectedEvent = null;


            Events = new ObservableCollection<Event>(tempList);
            
            _navigation = navigation;
        }

        public List<Event> GetEvents()
         {
           return App._sQLiteDatabase.GetEvents();
        }

        public int GetnumberOfParticipants()
        {
            return 1;
        }


        public async void GoToEventDetails(Event @event)
        {
            
            SelectedEvent = null;
            await _navigation.PushAsync(new EventTemplate(@event, _navigation));
        }

    }
}
