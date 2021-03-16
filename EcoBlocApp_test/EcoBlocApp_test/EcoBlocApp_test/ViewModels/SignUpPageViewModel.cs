using EcoBlocApp_test.Models;
using EcoBlocApp_test.Services;
using EcoBlocApp_test.Views;
using Plugin.Media;
using Plugin.Media.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace EcoBlocApp_test.ViewModels
{
    public class SignUpPageViewModel : BaseViewModel
    {
        private INavigation _navigation;

        

        public ICommand SignUpCommand { get; private set; }

        public ICommand CancelCommand { get; private set; }


        private Participant _participant;

        public Participant Participant
        {
            get
            {

                return _participant;
            }
            set
            {
                _participant = value;
                NotifyPropertyChanged("Participant");
            }
        }

        private Event _event;

        public Event Event
        {
            get
            {

                return _event;
            }
            set
            {
                _event = value;
                NotifyPropertyChanged("Event");
            }
        }

        private string _reason;

        public string Reason
        {
            get
            {

                return _reason;
            }
            set
            {
                _reason = value;
                NotifyPropertyChanged("Reason");
            }
        }

        private string _eventName;

        public string EventName
        {
            get
            {

                return _eventName;
            }
            set
            {
                _eventName = value;
                NotifyPropertyChanged("EventName");
            }
        }

        private bool _waste;

        public bool Waste
        {
            get
            {

                return _waste;
            }
            set
            {
                _waste = value;
                NotifyPropertyChanged("Waste");
            }
        }

        private bool _wheelbarrow;

        public bool Wheelbarrow
        {
            get
            {

                return _wheelbarrow;
            }
            set
            {
                _wheelbarrow = value;
                NotifyPropertyChanged("Wheelbarrow");
            }
        }

        private bool _shovel;

        public bool Shovel
        {
            get
            {

                return _shovel;
            }
            set
            {
                _shovel = value;
                NotifyPropertyChanged("Shovel");
            }
        }

        private bool _transport;

        public bool Transport
        {
            get
            {

                return _transport;
            }
            set
            {
                _transport = value;
                NotifyPropertyChanged("Transport");
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

        public SignUpPageViewModel()
        {

        }

        public SignUpPageViewModel(INavigation navigation, Event @event)
        {
            
            LoginCheck();
            _navigation = navigation;
            SignUpCommand = new Command(() => SignUp());
            CancelCommand = new Command(() => Cancel());
            Event = new Event();
            Event = @event;
            EventName = @event.NameOfEvent;
        }

        private async void Cancel()
        {
            await _navigation.PopAsync();
        }

        private async void SignUp()
        {
            var _participant = new Participant();

            _participant.Name = _User.UserName;
            _participant.ReasonForJoining = Reason;

            App._sQLiteDatabase.AddParticipant(_User, Event, _participant);
            //add pop up page
            await _navigation.PopAsync();
        }

        public void LoginCheck()
        {
            var check = App._sQLiteDatabase.CheckIfUserIsLoggedIn();

            if (check == true)
            {
                var tempUser = App._sQLiteDatabase.GetUserDetails();
                _User = tempUser;
                
            }
            
        }

    }



}
