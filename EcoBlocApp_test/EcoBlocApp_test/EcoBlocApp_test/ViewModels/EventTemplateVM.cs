using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using EcoBlocApp_test.Models;
using System.Windows.Input;
using EcoBlocApp_test.Views;

namespace EcoBlocApp_test.ViewModels
{
    class EventTemplateVM : BaseViewModel
    {
        private INavigation _navigation;

        Event selectedEvent;

        private string _name;

        public string Name
        {
            get
            {

                return _name;
            }
            set
            {
                _name = value;
                NotifyPropertyChanged("Name");
            }
        }

        private DateTime _creationDate;

        public DateTime CreationDate
        {
            get
            {

                return _creationDate;
            }
            set
            {
                _creationDate = value;
                NotifyPropertyChanged("CreationDate");
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

        private string _dumpsiteName;

        public string DumpsiteName
        {
            get
            {

                return _dumpsiteName;
            }
            set
            {
                _dumpsiteName = value;
                NotifyPropertyChanged("DumpsiteName");
            }
        }

        private string _dumpsiteImage;

        public string DumpsiteImage
        {
            get
            {

                return _dumpsiteImage;
            }
            set
            {
                _dumpsiteImage = value;
                NotifyPropertyChanged("DumpsiteImage");
            }
        }

        private string _address;

        public string Address
        {
            get
            {

                return _address;
            }
            set
            {
                _address = value;
                NotifyPropertyChanged("Address");
            }
        }

        private int _numberOfParticipants;

        public int NumberOfParticipants
        {
            get
            {

                return _numberOfParticipants;
            }
            set
            {
                _numberOfParticipants = value;
                NotifyPropertyChanged("NumberOfParticipants");
            }
        }

        
        public ICommand JoinCommand { get; private set; }


        public EventTemplateVM()
        {
        }

        public EventTemplateVM(INavigation navigation, Event @event)
        {
            _navigation = navigation;
            selectedEvent = new Event();

            selectedEvent = @event;

            Name = selectedEvent.NameOfEvent;
            CreationDate = selectedEvent.EventCreationDate;
            NumberOfParticipants = selectedEvent.NumberOfParticipants;
            Reason = selectedEvent.ReasonForCreation;
            DumpsiteName = selectedEvent.EventDumpsite.StreetName;
            DumpsiteImage = selectedEvent.EventDumpsite.ImageUrl;
            Address = selectedEvent.EventDumpsite.EventMarker.PinAddress;

            JoinCommand = new Command(() => JoinButton());
        }

        public async void JoinButton()
        {
            await _navigation.PushAsync(new ParticipantsSignUpPage()); // need to push async to the participant sign up page
        }

    }
}
