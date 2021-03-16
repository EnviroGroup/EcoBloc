using EcoBlocApp_test.Models;
using EcoBlocApp_test.Services;
using EcoBlocApp_test.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace EcoBlocApp_test.ViewModels
{
    public class MyEventsPageViewModel : BaseViewModel
    {
        private INavigation _navigation;

       


        List<Event> tempList;

        private ObservableCollection<Event> _myEvents;

        public ObservableCollection<Event> MyEvents
        {
            get
            {


                return _myEvents;
            }
            set
            {
                _myEvents = value;
                NotifyPropertyChanged("MyEvents");
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

        private User _user;
        public User _User
        {
            get { return _user; }
            set
            {
                _user = value;
                NotifyPropertyChanged("_User");
            }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                NotifyPropertyChanged("Name");
            }
        }

        public MyEventsPageViewModel()
        {

        }

        public MyEventsPageViewModel(INavigation navigation)
        {
            
            LoginCheck();
            Name = _User.UserName;

            //tempList = GetMyEvents();
            SelectedEvent = null;


            MyEvents = new ObservableCollection<Event>(tempList);

            _navigation = navigation;
        }


        public void LoginCheck()
        {
            var check = App._sQLiteDatabase.CheckIfUserIsLoggedIn();

            if (check == true)
            {
              var tempUser = App._sQLiteDatabase.GetUserDetails();
                _User = tempUser;
                tempList = _User.EventsCreated;
            }
            else
            {
                tempList.Clear();
            }
        }


        public List<Event> GetMyEvents()
        {
            return App._sQLiteDatabase.GetEvents(); // create id specific event id
        }

        public async void GoToEventDetails(Event @event)
        {

            SelectedEvent = null;
            await _navigation.PushAsync(new My_EventTemplate(@event, _navigation));
        }

    }
}
